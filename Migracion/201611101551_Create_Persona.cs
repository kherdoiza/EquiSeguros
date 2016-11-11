using FluentMigrator;

namespace Migracion
{
    [Migration(201611101551)]
    public class Create_Persona : Migration
    {
        public override void Up()
        {
            Create.Table("Persona")
                .WithColumn("Id").AsInt32().NotNullable().PrimaryKey().Identity()
                .WithColumn("Nombre").AsString(200).NotNullable()
                .WithColumn("ApellidoPaterno").AsString(90).Nullable()
                .WithColumn("ApellidoMaterno").AsString(90).Nullable()
                .WithColumn("TipoPersona").AsInt32().NotNullable()
                .WithColumn("TipoDocumento").AsInt32().NotNullable()
                .WithColumn("Documento").AsString(15).NotNullable()
                .WithColumn("FechaNacimiento").AsDate().NotNullable()
                .WithColumn("EstadoCivil").AsInt32().NotNullable();
        }

        public override void Down()
        {
            Delete.Table("Persona");
        }
    }
}
