using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteDesenvolvedor.Models
{ 
    
    public class Imovel
    {
        public int Id { get; set; }
        public string TipoNegocio { get; set; }
        public string Cliente { get; set; }
        public double ValorImovel { get; set; }
        public string DataPublicacao { get; set; }
        public string Descricao { get; set; }
        public string Endereco { get; set; }
    }
}