using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula12
{
    public class ToDo
    {
        List<string> ListaTarefas = new List<string>();
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
                Console.WriteLine("Qual tarefa você deseja adicionar?");
                ListaTarefas.Add(Console.ReadLine());
            }

            public void removerTarefa()
            {

                Console.WriteLine("Qual tarefa você deseja remover?");
                string tarefa = Console.ReadLine();
                if (ListaTarefas.Contains(tarefa))
                    {
                    ListaTarefas.Remove(tarefa);
                    }
                else
                {
                    Console.WriteLine("Essa tarefa não está na lista.");
                }
                
            }

            public void atualizarTarefa()
            {
                Console.WriteLine("Qual o índice da tarefa que você deseja atualizar?");
                int indice = int.Parse(Console.ReadLine());
                Console.WriteLine("Qual a nova tarefa?");
                ListaTarefas[indice] = Console.ReadLine();
            }

            public void listarTodasAsTarefas()
            {
                for (int i = 0; i < ListaTarefas.Count; i++)
                {
                    Console.WriteLine(ListaTarefas[i]);
                }
            }

            public void apresentarUmaTarefaAPartirDoIndice()
            {
                Console.WriteLine("Qual índice da tarefa que você deseja procurar?");
                int indice = int.Parse(Console.ReadLine());
                Console.WriteLine(ListaTarefas[indice]);
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