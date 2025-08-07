using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_O_O
{
    public class ContaGenerica
    {
        public string? Banco { get; set; }
        public string? Agencia { get; set; }
        public string? Conta { get; set; }
        public decimal? Saldo { get; set; }

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

    public class ContaCorrente : ContaGenerica
    {
        public decimal Limite { get; set; }

        public override bool Sacar(decimal valor)
        {
            if (valor > 0 && Saldo + this.Limite >= valor)
            {
                Saldo -= valor;
                return true;
            }
            return false;
        }
    }
}
