using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migracion
{
    [Migration(201611101651)]
    public class Create_EstadoCivil : Migration
    {
        public override void Up()
        {
            Create.Table("EstadoCivil")
                .WithColumn("Id").AsInt32().NotNullable().PrimaryKey().Identity()
                .WithColumn("Descripcion").AsString(100).NotNullable();

            Create.ForeignKey("fk_Persona_TipoPersona")
                .FromTable("Persona").ForeignColumn("TipoPersona")
                .ToTable("TipoPersona").PrimaryColumn("Id");

            Create.ForeignKey("fk_Persona_TipoDocumento")
                .FromTable("Persona").ForeignColumn("TipoDocumento")
                .ToTable("TipoDocumento").PrimaryColumn("Id");

            Create.ForeignKey("fk_Persona_EstadoCivil")
                .FromTable("Persona").ForeignColumn("EstadoCivil")
                .ToTable("EstadoCivil").PrimaryColumn("Id");
        }

        public override void Down()
        {
            Delete.Table("EstadoCivil");
        }
    }
}
