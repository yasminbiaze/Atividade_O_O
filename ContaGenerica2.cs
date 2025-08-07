using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_O_O
{
    public class ContaGenerica2
    {
        public ContaGenerica2(string banco, string agencia, string conta, decimal saldo)
        {
            this.Banco = banco;
            this.Agencia = agencia;
            this.Conta = conta;
            this.Saldo = saldo;
        }

        private string? Banco { get; set; }
        private string? Agencia { get; set; }
        private string? Conta { get; set; }
        private decimal? Saldo { get; set; }

        public virtual void Depositar(decimal valor)
        {
            if (valor > 0)
                Saldo += valor;
        }

        public virtual bool Sacar(decimal valor)
        {
            if (valor > 0 && Saldo >= valor)
            {
                Saldo -= valor;
                return true;
            }
            return false;
        }
    }
}
