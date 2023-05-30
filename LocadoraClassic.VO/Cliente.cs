using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraClassic.VO
{
    public class Cliente
    {
        public int Id {  get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; } 
        public string Tel { get; set; }

        public string Endereco { get; set; }

        public Cliente() { }
        public Cliente(int id, string nome, string cPF, string rG, string tel, string endereco)
        {
            Id = id;
            Nome = nome;
            CPF = cPF;
            RG = rG;
            Tel = tel;
            Endereco = endereco;
        }
        public override string ToString()
        {
            return this.Nome;
        }
    }
    
}
