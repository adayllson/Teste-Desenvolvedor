using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TesteDesenvolvedor.Models
{ 
    
    public class Imovel
    {   
        public int Id { get; set; }
        public string TipoNegocio { get; set; }
        public string Cliente { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}", ApplyFormatInEditMode = true)]
        public double ValorImovel { get; set; }
        public DateTime DataPublicacao { get; set; }
        public string Descricao { get; set; }
        public string Endereco { get; set; }

    }
}