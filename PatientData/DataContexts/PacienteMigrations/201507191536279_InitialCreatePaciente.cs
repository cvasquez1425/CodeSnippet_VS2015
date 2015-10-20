namespace PatientData.DataContexts.PacienteMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreatePaciente : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pacientes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Ailments",
                c => new
                    {
                        ailmentId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Paciente_Id = c.Int(),
                    })
                .PrimaryKey(t => t.ailmentId)
                .ForeignKey("dbo.Pacientes", t => t.Paciente_Id)
                .Index(t => t.Paciente_Id);
            
            CreateTable(
                "dbo.Medications",
                c => new
                    {
                        medicationId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Doses = c.Int(nullable: false),
                        Paciente_Id = c.Int(),
                    })
                .PrimaryKey(t => t.medicationId)
                .ForeignKey("dbo.Pacientes", t => t.Paciente_Id)
                .Index(t => t.Paciente_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Medications", "Paciente_Id", "dbo.Pacientes");
            DropForeignKey("dbo.Ailments", "Paciente_Id", "dbo.Pacientes");
            DropIndex("dbo.Medications", new[] { "Paciente_Id" });
            DropIndex("dbo.Ailments", new[] { "Paciente_Id" });
            DropTable("dbo.Medications");
            DropTable("dbo.Ailments");
            DropTable("dbo.Pacientes");
        }
    }
}
