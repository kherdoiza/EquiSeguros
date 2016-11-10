using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migracion
{
    [Migration(201611101649)]
    public class Create_TipoDocumento : Migration
    {
        public override void Up()
        {
            Create.Table("TipoDocumento")
                .WithColumn("Id").AsInt32().NotNullable().PrimaryKey().Identity()
                .WithColumn("Descripcion").AsString(100).NotNullable();
        }

        public override void Down()
        {
            Delete.Table("TipoDocumento");
        }
    }
}
