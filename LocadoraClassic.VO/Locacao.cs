using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraClassic.VO
{
    public class Locacao
    {
        public int Id { get; set; }
        public List<Dictionary<string, string>> FilmesLocados { get; set; }
        public DateTime DataLocacao { get; set; }
        public DateTime DataDevolucao { get; set; }
        public decimal ValorTotal { get; set; }
        public Locacao() { }
    }
}
