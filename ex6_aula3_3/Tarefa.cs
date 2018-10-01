using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace F1Ex6c
{
    enum TipoPrioridade { baixa, normal, alta } 
    enum TipoCategoria { pessoal, trabalho };
    enum TipoEstado { executar, execucao, concluida };

    enum TipoOrdem { titulo, prioridade, categoria, estado, data };

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

        public Tarefa(string titulo = null,
            TipoPrioridade prioridade = TipoPrioridade.alta,
            TipoCategoria categoria = TipoCategoria.trabalho,
            TipoEstado estado = TipoEstado.executar,
            string datalimite = null)
        {
            if (string.IsNullOrEmpty(titulo) || string.IsNullOrWhiteSpace(titulo))
                titulo = "Tarefa";

            if (!DateTime.TryParse(datalimite, out DateTime data)) data = DateTime.Now.AddHours(24);

            IdTarefa = ++NumDeTarefas;
            Prioridade = prioridade;
            Categoria = categoria;
            Estado = estado;
            Titulo = titulo;
            DataLimite = data;
            }
    }
}
