using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TrabalhoHistoricoConsultas.Models
{
    public class Context : DbContext
    {

        public Context() : base("TrabalhoHistoricoConsultas") { }
        public DbSet<Consulta> Consulta { get; set; }
        public DbSet<DescricaoConsulta> DescricaoConsulta { get; set; }
        public DbSet<Especialidade> Especialidade { get; set; }
        public DbSet<FormaPagamento> FormaPagamento { get; set; }
        public DbSet<Hospital> Hospital { get; set; }
        public DbSet<Paciente> Paciente { get; set; }
        public DbSet<PlanoSaude> PlanoSaude { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
    }
}