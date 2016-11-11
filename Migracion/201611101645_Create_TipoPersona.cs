using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migracion
{
    [Migration(201611101645)]
    public class Create_TipoPersona : Migration
    {
        public override void Up()
        {
            Create.Table("TipoPersona")
                .WithColumn("Id").AsInt32().NotNullable().PrimaryKey().Identity()
                .WithColumn("Descripcion").AsString(100).NotNullable();
        }

        public override void Down()
        {
            Delete.Table("TipoPersona");
        }
    }
}
