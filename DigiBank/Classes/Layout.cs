using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigiBank.Classes
{
    public class Layout
    {
        private static List<Pessoa> pessoas = new List<Pessoa>(); // ira armazenar as pessoas dentro dessa variavel (criar banco de dados)
        private static int opcao = 0;
        public static void TelaPrincipal()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;

            Console.Clear();

            Console.WriteLine("                                                               ");
            Console.WriteLine("                 Digite a Opção Desejada                       ");
            Console.WriteLine("                 ==========================                    ");
            Console.WriteLine("                 1 - Criar Conta                               ");
            Console.WriteLine("                 ==========================                    ");
            Console.WriteLine("                 2 - Entrar com CPF e Senha                    ");
            Console.WriteLine("                 ==========================                    ");

            opcao = int.Parse(Console.ReadLine()!);

            switch (opcao)
            {
                case 1:
                    TelaCriarConta();
                    break;
                case 2:
                    TelaLogin();
                    break;
                default:
                    Console.WriteLine("Opção Inválida");
                    break;
            }
        }
        private static void TelaCriarConta()
            {
                Console.Clear();

                Console.WriteLine("                                                               ");
                Console.WriteLine("                 Digite seu Nome:                              ");
                string nome = Console.ReadLine()!;
                Console.WriteLine("                 ==========================                    ");
                Console.WriteLine("                 1 - Digite seu CPF:                           ");
                string cpf = Console.ReadLine()!;
                Console.WriteLine("                 ==========================                    ");
                Console.WriteLine("                 2 - Digite sua Senha:                         ");
                string senha = Console.ReadLine()!;
                Console.WriteLine("                 ==========================                    ");

                Console.WriteLine($@"{nome}");

            
            // Criar uma conta

                ContaCorrente contaCorrente = new ContaCorrente();
                Pessoa pessoa= new Pessoa();

                pessoa.SetNome(nome);
                pessoa.SetCPF(cpf);
                pessoa.SetSenha(senha);
                pessoa.Conta = contaCorrente;

                pessoas.Add(pessoa);

                Console.Clear();

                
                Console.WriteLine("                 Conta Cadastrada com Sucesso!                 ");
                Console.WriteLine("                ===============================                ");
            }

        


            // Logar no sistema

        private static void TelaLogin()
            {
                Console.Clear();

                Console.WriteLine("                                                                 ");
                Console.WriteLine("                 1 - Digite o CPF:                               ");
                string cpf = Console.ReadLine()!;
                Console.WriteLine("                 ==========================                      ");
                Console.WriteLine("                 2 - Digite sua Senha:                           ");
                string senha = Console.ReadLine()!;
        
            }
        
    }
}