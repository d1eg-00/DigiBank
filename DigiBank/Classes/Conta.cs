using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DigiBank.Contratos;

namespace DigiBank.Classes
{
    public abstract class Conta : Banco , IConta
    {
        //Construtor da classe
        public Conta()
        {
            this.NumeroAgencia = "0001";
            Conta.NumeroDaContaSequencial ++;
            this.Movimentacoes = new List<Extrato>();

        }

        //Atributos da Classe
        public double Saldo { get; protected set; } //protected >> somente as classes que herderem ou a propria classe pode alterar
        public string? NumeroAgencia { get; private set; }
        public string? NumeroConta { get; protected set; }
        public static int NumeroDaContaSequencial { get; private set; }
        private List<Extrato> Movimentacoes;

        public double ConsultaSaldo()
        {
            return this.Saldo;
        }

        public void Deposita(double valor)
        {
            DateTime dataAtual = DateTime.Now;
            this.Movimentacoes.Add(new Extrato(dataAtual, "Deposito", valor));
            this.Saldo += valor;
        }

        public bool Saca(double valor)
        {
            if(valor > this.ConsultaSaldo())
                return false;

            DateTime dataAtual = DateTime.Now;
            this.Movimentacoes.Add(new Extrato(dataAtual, "Saque", valor));

            this.Saldo -= valor;
                return true;
            
        }

        public string GetCodigoDoBanco()
        {
            return this.CodigoDoBanco;
        }

        public string GetNumeroAgencia()
        {
            return this.NumeroAgencia!;
        }

        public string GetNumeroDaConta()
        {
            return this.NumeroConta!;
        }

        public List<Extrato> Extrato()
        {
            return this.Movimentacoes;
        }
    }
}