using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TrabalhoHistoricoConsultas.Models
{
    [Table("PlanosSaude")]
    public class PlanoSaude
    {
        [Key]
        public int PlanoSaudeId { get; set; }
        public string Nome { get; set; }
    }
}