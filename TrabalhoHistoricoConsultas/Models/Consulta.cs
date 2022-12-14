using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TrabalhoHistoricoConsultas.Models
{
    [Table("Consultas")]
    public class Consulta
    {
        [Key]
        public int ConsultaId { get; set; }
        public DateTime DataConsulta { get; set; }
        [Required]
        public DescricaoConsulta DescricaoConsulta { get; set; }
        public List<FormaPagamento> FormasPagamento { get; set; }
        public Hospital Hospital { get; set; }
        public Usuario Medico { get; set; }
        public Paciente Paciente { get; set; }
    }
}