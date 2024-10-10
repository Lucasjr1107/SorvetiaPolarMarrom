using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorveteria_PolarMarrom.Classe
{
    public class Produto
    {

        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }

        public Produto(string nome, string descricao, decimal valor)
        {
            Nome = nome;
            Descricao = descricao;
            Valor = valor;
        }

        public override string ToString()
        {
            return $"{Nome} - {Valor.ToString("C")}";
        }
    }
}
    
