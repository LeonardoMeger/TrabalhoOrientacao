namespace TrabalhoHistoricoConsultas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CriarBanco : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Consultas",
                c => new
                    {
                        ConsultaId = c.Int(nullable: false),
                        DataConsulta = c.DateTime(nullable: false),
                        Medico_UsuarioId = c.Int(),
                        Hospital_HospitalId = c.Int(),
                        Paciente_PacienteId = c.Int(),
                    })
                .PrimaryKey(t => t.ConsultaId)
                .ForeignKey("dbo.DescricoesConsulta", t => t.ConsultaId)
                .ForeignKey("dbo.Usuarios", t => t.Medico_UsuarioId)
                .ForeignKey("dbo.Hospitais", t => t.Hospital_HospitalId)
                .ForeignKey("dbo.Pacientes", t => t.Paciente_PacienteId)
                .Index(t => t.ConsultaId)
                .Index(t => t.Medico_UsuarioId)
                .Index(t => t.Hospital_HospitalId)
                .Index(t => t.Paciente_PacienteId);
            
            CreateTable(
                "dbo.DescricoesConsulta",
                c => new
                    {
                        DescricaoConsultaId = c.Int(nullable: false, identity: true),
                        Anotacoes = c.String(),
                        Medicamentos = c.String(),
                        Sintomas = c.String(),
                    })
                .PrimaryKey(t => t.DescricaoConsultaId);
            
            CreateTable(
                "dbo.FormasPagamento",
                c => new
                    {
                        FormaPagamentoId = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Consulta_ConsultaId = c.Int(),
                    })
                .PrimaryKey(t => t.FormaPagamentoId)
                .ForeignKey("dbo.Consultas", t => t.Consulta_ConsultaId)
                .Index(t => t.Consulta_ConsultaId);
            
            CreateTable(
                "dbo.Hospitais",
                c => new
                    {
                        HospitalId = c.Int(nullable: false, identity: true),
                        Cep = c.String(),
                        Estado = c.String(),
                        Rua = c.String(),
                        Complemento = c.String(),
                        Numero = c.Int(nullable: false),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.HospitalId);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        UsuarioId = c.Int(nullable: false, identity: true),
                        Cpf = c.String(),
                        Crm = c.String(),
                        Login = c.String(),
                        Nome = c.String(),
                        Senha = c.String(),
                    })
                .PrimaryKey(t => t.UsuarioId);
            
            CreateTable(
                "dbo.Especialidades",
                c => new
                    {
                        EspecialidadeId = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                        Nome = c.String(),
                        Usuario_UsuarioId = c.Int(),
                    })
                .PrimaryKey(t => t.EspecialidadeId)
                .ForeignKey("dbo.Usuarios", t => t.Usuario_UsuarioId)
                .Index(t => t.Usuario_UsuarioId);
            
            CreateTable(
                "dbo.Pacientes",
                c => new
                    {
                        PacienteId = c.Int(nullable: false, identity: true),
                        Cpf = c.String(),
                        DataNascimento = c.DateTime(nullable: false),
                        Idade = c.Int(nullable: false),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.PacienteId);
            
            CreateTable(
                "dbo.PlanosSaude",
                c => new
                    {
                        PlanoSaudeId = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Paciente_PacienteId = c.Int(),
                    })
                .PrimaryKey(t => t.PlanoSaudeId)
                .ForeignKey("dbo.Pacientes", t => t.Paciente_PacienteId)
                .Index(t => t.Paciente_PacienteId);
            
            CreateTable(
                "dbo.UsuarioHospitals",
                c => new
                    {
                        Usuario_UsuarioId = c.Int(nullable: false),
                        Hospital_HospitalId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Usuario_UsuarioId, t.Hospital_HospitalId })
                .ForeignKey("dbo.Usuarios", t => t.Usuario_UsuarioId, cascadeDelete: true)
                .ForeignKey("dbo.Hospitais", t => t.Hospital_HospitalId, cascadeDelete: true)
                .Index(t => t.Usuario_UsuarioId)
                .Index(t => t.Hospital_HospitalId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PlanosSaude", "Paciente_PacienteId", "dbo.Pacientes");
            DropForeignKey("dbo.Consultas", "Paciente_PacienteId", "dbo.Pacientes");
            DropForeignKey("dbo.Consultas", "Hospital_HospitalId", "dbo.Hospitais");
            DropForeignKey("dbo.UsuarioHospitals", "Hospital_HospitalId", "dbo.Hospitais");
            DropForeignKey("dbo.UsuarioHospitals", "Usuario_UsuarioId", "dbo.Usuarios");
            DropForeignKey("dbo.Especialidades", "Usuario_UsuarioId", "dbo.Usuarios");
            DropForeignKey("dbo.Consultas", "Medico_UsuarioId", "dbo.Usuarios");
            DropForeignKey("dbo.FormasPagamento", "Consulta_ConsultaId", "dbo.Consultas");
            DropForeignKey("dbo.Consultas", "ConsultaId", "dbo.DescricoesConsulta");
            DropIndex("dbo.UsuarioHospitals", new[] { "Hospital_HospitalId" });
            DropIndex("dbo.UsuarioHospitals", new[] { "Usuario_UsuarioId" });
            DropIndex("dbo.PlanosSaude", new[] { "Paciente_PacienteId" });
            DropIndex("dbo.Especialidades", new[] { "Usuario_UsuarioId" });
            DropIndex("dbo.FormasPagamento", new[] { "Consulta_ConsultaId" });
            DropIndex("dbo.Consultas", new[] { "Paciente_PacienteId" });
            DropIndex("dbo.Consultas", new[] { "Hospital_HospitalId" });
            DropIndex("dbo.Consultas", new[] { "Medico_UsuarioId" });
            DropIndex("dbo.Consultas", new[] { "ConsultaId" });
            DropTable("dbo.UsuarioHospitals");
            DropTable("dbo.PlanosSaude");
            DropTable("dbo.Pacientes");
            DropTable("dbo.Especialidades");
            DropTable("dbo.Usuarios");
            DropTable("dbo.Hospitais");
            DropTable("dbo.FormasPagamento");
            DropTable("dbo.DescricoesConsulta");
            DropTable("dbo.Consultas");
        }
    }
}
