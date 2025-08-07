using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_O_O
{
    public class Personagem
    {
        public string? Nome { get; set; }
        public string? Categoria { get; set; }
        public int? Nivel { get; set; }
        public int? Forca { get; set; }
        public int? Agilidade { get; set; }
        public int? Inteligencia { get; set; }
        public int? Vida { get; set; }

        public Personagem(string? nome, string? categoria, int? nivel, int? forca, int? agilidade, int? inteligencia, int? vida)
        {
            Nome = nome;
            Categoria = categoria;
            Nivel = nivel;
            Forca = forca;
            Agilidade = agilidade;
            Inteligencia = inteligencia;
            Vida = vida;
        }
    }
}
