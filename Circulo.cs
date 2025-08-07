﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_O_O
{
    public class Circulo : Forma
    {
        public double Raio { get; set; }
        public Circulo(double raio)
        {
            Raio = raio;
        }
        public override double CalcularArea()
        {
            return Math.PI * Raio * Raio;

        }
    }
}
