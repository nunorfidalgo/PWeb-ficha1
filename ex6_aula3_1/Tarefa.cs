using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace F1Ex6a
{
    enum TipoPrioridade { baixa, normal, alta } 
    enum TipoCategoria { pessoal, trabalho };
    enum TipoEstado { executar, execucao, concluida };

    class Tarefa
    {
        public int IdTarefa { get; set; }
        public TipoPrioridade Prioridade { get; set; }
        public TipoCategoria Categoria { get; set; }
        public TipoEstado Estado { get; set; }
        public string Titulo { get; set; }
        public DateTime DataLimite { get; set; }

        //Gerador de indices
        static int NumDeTarefas = 0; 

        public Tarefa(string titulo, 
                        TipoPrioridade prioridade, TipoCategoria categoria, 
                        TipoEstado estado, DateTime datalimite)
        {
            IdTarefa = ++NumDeTarefas;

            Prioridade = prioridade;
            Categoria = categoria;
            Estado = estado;
            Titulo = titulo;
            DataLimite = datalimite;
            }
    }
}
