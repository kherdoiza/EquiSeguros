using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migracion
{
    [Migration(201611101533)]
    public class Create_PersonaDir : Migration
    {
        public override void Down()
        {
            Delete.Table("PersonaDir");
            Delete.Table("Pais");
            Delete.Table("Provincia");
            Delete.Table("TipoDireccion");
        }

        public override void Up()
        {
            Create.Table("PersonaDir")
                .WithColumn("IdPersona").AsInt32().NotNullable().PrimaryKey().Identity()
                .WithColumn("CodTipoDir").AsInt32().NotNullable()
                .WithColumn("CodPais").AsString(90).NotNullable()
                .WithColumn("CodProvincia").AsString(90).NotNullable()
                .WithColumn("TxtCallePrin").AsString(90).Nullable()
                .WithColumn("TxtCalleSec").AsString(90).Nullable()
                .WithColumn("Longitud").AsString(90).Nullable()
                .WithColumn("Latitud").AsString(90).Nullable()
                .WithColumn("TxtLugrReferencia").AsString(90).Nullable();

            Create.Table("TipoDireccion")
                .WithColumn("CodTipoDir").AsInt32().NotNullable().PrimaryKey().Identity()
                .WithColumn("TxtDescripcion").AsString(100).NotNullable();

            Create.Table("Pais")
                .WithColumn("CodPais").AsInt32().NotNullable().PrimaryKey().Identity()
                .WithColumn("TxtDescripcion").AsString(100).NotNullable();
         
            Create.Table("Provincia")
                .WithColumn("CodProvincia").AsInt32().NotNullable().PrimaryKey().Identity()
                .WithColumn("CodPais").AsInt32().NotNullable()                
                .WithColumn("TxtDescripcion").AsString(100).NotNullable();


        }
    }

}