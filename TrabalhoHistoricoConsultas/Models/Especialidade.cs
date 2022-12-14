using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TrabalhoHistoricoConsultas.Models
{
    [Table("Especialidades")]
    public class Especialidade
    {
        [Key]
        public int EspecialidadeId { get; set; }
        public string Descricao { get; set; }
        public string Nome { get; set; }

    }
}