using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
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
                //AGUARDA 1 SEGUNDO PARA DIRECIONAR A TELA LOGADA
                Thread.Sleep(1000);

                TelaContaLogada(pessoa);
            }


        private static void TelaLogin()
            {
                Console.Clear();

                Console.WriteLine("                                                                 ");
                Console.WriteLine("                 1 - Digite o CPF:                               ");
                string cpf = Console.ReadLine()!;
                Console.WriteLine("                 ==========================                      ");
                Console.WriteLine("                 2 - Digite sua Senha:                           ");
                string senha = Console.ReadLine()!;

                //Logar no sistema

                Pessoa pessoa = pessoas.FirstOrDefault(p => p.CPF == cpf && p.Senha == senha)!; //busca o primeiro ou unico registro dentro da lista

                if (pessoa != null)
                {
                    //TELA DE BOAS VINDAS
                    TelaBoasVindas(pessoa);
                    //TELA CONTA LOGADA
                    TelaContaLogada(pessoa);
                }        
                else
                {
                    Console.Clear();

                    Console.WriteLine("                 Pessoa não Cadastrada!                 ");
                    Console.WriteLine("                ===============================         ");

                    Console.WriteLine();
                    Console.WriteLine();
                }
            }
        private static void TelaBoasVindas(Pessoa pessoa)
        {
            string msgTeladeBemVindo =
                $@"{pessoa.Nome} | Banco : {pessoa?.Conta?.GetCodigoDoBanco()} | Agência : {pessoa?.Conta?.GetNumeroAgencia()} | Conta : {pessoa?.Conta?.GetNumeroDaConta()}";
            Console.WriteLine($@"");
            Console.WriteLine($@"                      Seja bem vindo, {msgTeladeBemVindo} !         ");
            Console.WriteLine("");
        }

        private static void TelaContaLogada(Pessoa pessoa)
        {
            Console.Clear();

            TelaBoasVindas(pessoa);
            
            
            Console.WriteLine("             Digite a Opção Desejada:                           ");
            Console.WriteLine("           =================================                    ");

            Console.WriteLine("             1 - Realizar um Depósito :                           ");
            Console.WriteLine("             =============================                        ");
            Console.WriteLine("             2 - Realizar um Saque :                              ");
            Console.WriteLine("             =============================                        ");
            Console.WriteLine("             3 - Consultar Saldo :                                ");
            Console.WriteLine("             =============================                        ");
            Console.WriteLine("             4 - Extrato :                                        ");
            Console.WriteLine("             =============================                        ");
            Console.WriteLine("             5 - Sair :                                           ");

            opcao = int.Parse(Console.ReadLine()!);
            switch(opcao)
            {
                case 1:
                    break;

                case 2:
                    break;

                case 3:
                    break;

                case 4:
                    break;

                case 5:
                    TelaPrincipal();
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("             Opção Inválida!                 ");
                    Console.WriteLine("       ===============================       ");
                    break;

            }
        }
    }
}