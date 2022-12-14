using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TrabalhoHistoricoConsultas.Models
{
    [Table("DescricoesConsulta")]
    public class DescricaoConsulta
    {
        [Key]
        public int DescricaoConsultaId { get; set; }
        public string Anotacoes { get; set; }
        public Consulta Consulta { get; set; }
        public string Medicamentos { get; set; }
        public string Sintomas { get; set; }
    }
}