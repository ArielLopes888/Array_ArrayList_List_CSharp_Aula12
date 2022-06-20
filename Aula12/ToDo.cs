using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula12
{
    public class ToDo
    {
        public int selecionarTarefa()
        {
            Console.WriteLine("O que você deseja fazer?");
            Console.WriteLine("Encerrar programa. - 0");
            Console.WriteLine("Adicionar tarefa. - 1");
            Console.WriteLine("Remover tarefa. - 2");
            Console.WriteLine("Atualizar tarefa. - 3");
            Console.WriteLine("Listar todas as tarefas. - 4");
            Console.WriteLine("Apresentar uma tarefa a partir do índice. - 5");
            int tarefa = int.Parse(Console.ReadLine());
            return tarefa;
        }
        public void Inicio()
        {
            int tarefa = selecionarTarefa();
            while (tarefa != 0)
            {
                if (tarefa == 1)
                {
                    adicionarTarefa();
                }
                else if (tarefa == 2)
                {
                    removerTarefa();
                }
                else if (tarefa == 3)
                {
                    atualizarTarefa();
                }
                else if (tarefa == 4)
                {
                    listarTodasAsTarefas();
                }
                else if (tarefa == 5)
                {
                    apresentarUmaTarefaAPartirDoIndice();
                }
                else
                {
                    selecionarTarefa();
                }
                tarefa = selecionarTarefa();
            }
            
            public void adicionarTarefa()
            {

            }

            public void removerTarefa()
            {

            }

            public void atualizarTarefa()
            {

            }

            public void listarTodasAsTarefas()
            {

            }

            public void apresentarUmaTarefaAPartirDoIndice()
            {

            }


        }
    }
}
/*
Adicionar tarefa.
Remover tarefa.
Atualizar tarefa.
Listar todas as tarefas.
Apresentar uma tarefa a partir do índice
*/