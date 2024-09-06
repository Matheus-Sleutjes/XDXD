using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stefanini.Domain.Dto
{
    public class ProdutoDto
    {
        public string Nome { get; set; }
        public double Valor { get; set; }
        public int Estoque { get; set; }
    }
}
