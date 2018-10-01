using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace F1Ex6c
{
    class Utilizador
    {
        public string Nome { get; private set; }
        public List<Tarefa> Tarefas { get; private set; }

        public Utilizador(string nome)
        {
            Nome= nome;
            Tarefas = new List<Tarefa>();
            }


        public void AdicionarTarefa(Tarefa tarefa= null)
        {
            if (tarefa == null) tarefa = new Tarefa();
            Tarefas.Add(tarefa);

            }


        //Cria uma nova lista com as tarefas por ordem (decrescente) de ...
        //Recorre a expressoes lambda.

        public List<Tarefa> OrganizarAsTarefas(TipoOrdem tipordem)
        {
            List<Tarefa> lista = null;

            switch (tipordem)
            {
                case TipoOrdem.titulo:
                    lista = Tarefas.OrderByDescending(p => p.Titulo).ToList(); break;
                case TipoOrdem.prioridade:
                    lista = Tarefas.OrderByDescending(p => p.Prioridade).ToList(); break;
                case TipoOrdem.categoria:
                    lista = Tarefas.OrderByDescending(p => p.Categoria).ToList(); break;
                case TipoOrdem.estado:
                    lista = Tarefas.OrderByDescending(p => p.Estado).ToList(); break;

                default: lista = Tarefas.OrderByDescending(p => p.DataLimite).ToList(); break;
                }

            return lista;
            }

        
        //Cria uma nova lista com as tarefas por ordem crescente da data e, para cada data, organiza as tarefas por prioridade.
        //Recorre ao Linq.

        public List<Tarefa> OrganizarAsTarefas()
        {
            List<Tarefa> listadetarefas = new List<Tarefa>();

            var TarefasByData = from p in Tarefas orderby p.DataLimite ascending group p by p.DataLimite;

            foreach (var data in TarefasByData)
            {
                var TarefasByPrioridade = from q in data orderby q.Prioridade descending select q;
                foreach (var q in TarefasByPrioridade) listadetarefas.Add(q);
                }

            return listadetarefas;
            }


        public List<Tarefa> TarefasAtrasadas(DateTime data)
        {
            List<Tarefa> listadetarefas = new List<Tarefa>();

            foreach (Tarefa p in Tarefas)
                if (p.DataLimite < data && p.Estado != TipoEstado.concluida) listadetarefas.Add(p);

            return listadetarefas;
            }


        public List<Tarefa> ListaDeTarefas(TipoEstado tipo)
        {
            List<Tarefa> listadetarefas = new List<Tarefa>();

            foreach (Tarefa p in Tarefas)
                if (p.Estado == tipo) listadetarefas.Add(p);

            return listadetarefas;
            }

        public List<Tarefa> ListaDeTarefas(TipoPrioridade tipo)
        {
            List<Tarefa> listadetarefas = new List<Tarefa>();

            foreach (Tarefa p in Tarefas)
                if (p.Prioridade == tipo) listadetarefas.Add(p);

            return listadetarefas;
            }

        public List<Tarefa> ListaDeTarefas(TipoCategoria tipo)
        {
            List<Tarefa> listadetarefas = new List<Tarefa>();

            foreach (Tarefa p in Tarefas)
                if (p.Categoria == tipo) listadetarefas.Add(p);

            return listadetarefas;
            }


        // USAR ESTE PROCESSO:
        //
        // public List<Tarefa> RemoverTarefas(TipoEstado tipo)
        // {
        //    foreach (Tarefa p in ListaDeTarefas(tipo)) Tarefas.Remove(p);
        //    return Tarefas;
        //    }
        //
        // OU USAR ESTE PROCESSO:
        //
        // NOTE: Use of TarefasRealizadas().ToList() instead of TarefasRealizadas().
        // In general .NET collections do not support being enumerated and modified at the same time. 
        // If we try to modifies the collection list while we are in the middle of enumerating it, it will raise an exception.

        public List<Tarefa> RemoverTarefas(TipoEstado tipo)
        {
            foreach (Tarefa p in Tarefas.ToList())
                if (p.Estado == tipo) Tarefas.Remove(p);

            return Tarefas;
            }


        public List<Tarefa> RemoverTarefas(TipoPrioridade tipo)
        {
            foreach (Tarefa p in ListaDeTarefas(tipo)) Tarefas.Remove(p);
            return Tarefas;
            }

        public List<Tarefa> RemoverTarefas(TipoCategoria tipo)
        {
            foreach (Tarefa p in ListaDeTarefas(tipo)) Tarefas.Remove(p);
            return Tarefas;
            }


        public void MostrarTarefas(string titulo = null, List<Tarefa> listadetarefas = null)
        {
            if(titulo != null) Console.WriteLine(titulo);

            foreach (Tarefa p in listadetarefas)
                Console.WriteLine("{0} | {1} | {2} | {3} | {4} | {5}", 
                    p.IdTarefa, p.Titulo, p.Prioridade, 
                    p.Categoria, p.Estado, p.DataLimite);
            }
    } 
} 

