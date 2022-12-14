using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TrabalhoHistoricoConsultas.Models
{
    [Table("Hospitais")]
    public class Hospital
    {
        [Key]
        public int HospitalId { get; set; }
        public string Cep { get; set; }
        public string Estado { get; set; }
        public string Rua { get; set; }
        public string Complemento { get; set; }
        public int Numero { get; set; }
        public string Nome { get; set; }
        public List<Usuario> Medicos { get; set; }
    }
}