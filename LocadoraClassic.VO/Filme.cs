using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraClassic.VO
{
    public class Filme
    {
        public int Id { get; set; }
        public Genero Genero { get; set; }
        public Categoria Categoria { get; set; }
        public string Nome { get; set; }
        public string Sinopse { get; set; }
        public bool Locado { get; set; }
        public int Duracao { get; set; }
        public Filme() { }

        public Filme(int id, Genero genero, Categoria categoria, string nome, string sinopse, bool locado, int duracao)
        {
            Id = id;
            Genero = genero;
            Categoria = categoria;
            Nome = nome;
            Sinopse = sinopse;
            Locado = locado;
            Duracao = duracao;
        }
    }
}
