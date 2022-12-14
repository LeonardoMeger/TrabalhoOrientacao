using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TrabalhoHistoricoConsultas.Models
{
    [Table("FormasPagamento")]
    public class FormaPagamento
    {
        [Key]
        public int FormaPagamentoId { get; set; }
        public string Nome { get; set; }
    }
}