using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace F1Ex6c
{
    class Program
    {
        static void Main(string[] args)
        {
            Utilizador u = new Utilizador("Bananas");

            Console.WriteLine("F1Ex6c {0}", u.Nome);

            //Mock Data
            u.AdicionarTarefa();


            u.AdicionarTarefa(new Tarefa("aula", TipoPrioridade.baixa, TipoCategoria.pessoal, TipoEstado.executar, "11/10/2017"));
            u.AdicionarTarefa(new Tarefa("almoçar", TipoPrioridade.normal, TipoCategoria.pessoal, TipoEstado.executar, "11/10/2017"));
            u.AdicionarTarefa(new Tarefa("dormir", TipoPrioridade.alta, TipoCategoria.pessoal, TipoEstado.executar, "11/10/2017"));

            u.AdicionarTarefa(new Tarefa("acordar", TipoPrioridade.baixa, datalimite: "12/10/2017"));
            u.AdicionarTarefa(new Tarefa("lavar", TipoPrioridade.normal, datalimite: "12/10/2017"));
            u.AdicionarTarefa(new Tarefa("correr", TipoPrioridade.alta, datalimite: "12/10/2017"));

            u.AdicionarTarefa(new Tarefa(datalimite: "6/10/2017 10:30", estado: TipoEstado.executar));
            u.AdicionarTarefa(new Tarefa(datalimite: "37/10/2017 15:30", estado: TipoEstado.concluida));


            //Mock Teste
            u.MostrarTarefas("\nLista Inicial\n", u.Tarefas);


            u.MostrarTarefas("\nLista Ordenada\n", u.OrganizarAsTarefas(TipoOrdem.titulo));
            u.MostrarTarefas("\nLista Agrupada/Ordenada\n", u.OrganizarAsTarefas());

            u.MostrarTarefas("\nTarefas Atrasadas\n", u.TarefasAtrasadas(DateTime.Now));

            u.MostrarTarefas("\nTarefas Realizadas\n", u.ListaDeTarefas(TipoEstado.concluida));
            u.MostrarTarefas("\nTarefas Prioritárias\n", u.ListaDeTarefas(TipoPrioridade.alta));
            u.MostrarTarefas("\nTarefas Pessoais\n", u.ListaDeTarefas(TipoCategoria.pessoal));

            u.MostrarTarefas("\nSem as Tarefas Realizadas\n", u.RemoverTarefas(TipoEstado.concluida));
            u.MostrarTarefas("\nSem as Tarefas Pessoais\n", u.RemoverTarefas(TipoCategoria.pessoal));
        }
    }
}
