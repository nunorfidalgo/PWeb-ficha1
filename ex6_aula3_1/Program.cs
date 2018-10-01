using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace F1Ex6a
{
    class Program
    {
        static void Main(string[] args)
        {
            Utilizador u = new Utilizador("Bananas", new List<Tarefa>());

            //Mock Data
            u.AdicionarTarefa();
            u.AdicionarTarefa("lavar", categoria: TipoCategoria.pessoal);
            u.AdicionarTarefa("comer", TipoPrioridade.normal, datalimite: "6/10/2017 09:30");
            u.AdicionarTarefa("correr", TipoPrioridade.normal);
            u.AdicionarTarefa(datalimite: "6/10/2017 10:30", prioridade: TipoPrioridade.alta, titulo: "acordar");
            u.AdicionarTarefa(datalimite: "7/10/2017 15:30", estado: TipoEstado.concluida);

            //Mock Teste
            u.MostrarTarefas("\nLista Inicial\n", u.Tarefas);

            u.MostrarTarefas("\nTarefas Atrasadas\n", u.TarefasAtrasadas(DateTime.Now));
            u.MostrarTarefas("\nTarefas Realizadas\n", u.ListaDeTarefas(TipoEstado.concluida));

            u.MostrarTarefas("\nTarefas Prioritárias\n", u.ListaDeTarefas(TipoPrioridade.alta));
            u.MostrarTarefas("\nTarefas Pessoais\n", u.ListaDeTarefas(TipoCategoria.pessoal));

        }
    }
}
