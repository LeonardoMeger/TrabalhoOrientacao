using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TrabalhoHistoricoConsultas.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public int UsuarioId { get; set; }
        public List<Consulta> Consultas { get; set; }
        public string Cpf { get; set; }
        public string Crm { get; set; }
        public List<Especialidade> Especialidades { get; set; }
        public List<Hospital> Hospitais { get; set; }
        public string Login { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
    }
}