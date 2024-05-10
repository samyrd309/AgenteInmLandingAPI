using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgenteInmLandingAPI.Migrations
{
    /// <inheritdoc />
    public partial class ReEstructure : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_AgentesInmobiliarios_IdAgenteInmobiliario",
                table: "Clientes");

            migrationBuilder.DropForeignKey(
                name: "FK_Propiedades_AgentesInmobiliarios_IdAgenteInmobiliario",
                table: "Propiedades");

            migrationBuilder.DropForeignKey(
                name: "FK_Propiedades_Clientes_IdCliente",
                table: "Propiedades");

            migrationBuilder.DropForeignKey(
                name: "FK_Propiedades_TipoPropiedades_IdTipoPropiedad",
                table: "Propiedades");

            migrationBuilder.DropForeignKey(
                name: "FK_Visitas_AgentesInmobiliarios_AgenteInmobiliarioId",
                table: "Visitas");

            migrationBuilder.DropForeignKey(
                name: "FK_Visitas_Clientes_ClienteId",
                table: "Visitas");

            migrationBuilder.DropForeignKey(
                name: "FK_Visitas_Propiedades_PropiedadId",
                table: "Visitas");

            migrationBuilder.DropIndex(
                name: "IX_Visitas_AgenteInmobiliarioId",
                table: "Visitas");

            migrationBuilder.DropIndex(
                name: "IX_Visitas_ClienteId",
                table: "Visitas");

            migrationBuilder.DropIndex(
                name: "IX_Visitas_PropiedadId",
                table: "Visitas");

            migrationBuilder.DropIndex(
                name: "IX_Propiedades_IdAgenteInmobiliario",
                table: "Propiedades");

            migrationBuilder.DropIndex(
                name: "IX_Propiedades_IdCliente",
                table: "Propiedades");

            migrationBuilder.DropIndex(
                name: "IX_Propiedades_IdTipoPropiedad",
                table: "Propiedades");

            migrationBuilder.DropIndex(
                name: "IX_Clientes_IdAgenteInmobiliario",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "AgenteInmobiliarioId",
                table: "Visitas");

            migrationBuilder.DropColumn(
                name: "ClienteId",
                table: "Visitas");

            migrationBuilder.DropColumn(
                name: "PropiedadId",
                table: "Visitas");

            migrationBuilder.DropColumn(
                name: "IdAgenteInmobiliario",
                table: "Propiedades");

            migrationBuilder.DropColumn(
                name: "IdCliente",
                table: "Propiedades");

            migrationBuilder.DropColumn(
                name: "IdTipoPropiedad",
                table: "Propiedades");

            migrationBuilder.DropColumn(
                name: "IdAgenteInmobiliario",
                table: "Clientes");

            migrationBuilder.RenameColumn(
                name: "Estado",
                table: "Clientes",
                newName: "PropiedadesDeInteres");

            migrationBuilder.RenameColumn(
                name: "FechaContratacion",
                table: "AgentesInmobiliarios",
                newName: "FechaCreacion");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PropiedadesDeInteres",
                table: "Clientes",
                newName: "Estado");

            migrationBuilder.RenameColumn(
                name: "FechaCreacion",
                table: "AgentesInmobiliarios",
                newName: "FechaContratacion");

            migrationBuilder.AddColumn<int>(
                name: "AgenteInmobiliarioId",
                table: "Visitas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ClienteId",
                table: "Visitas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PropiedadId",
                table: "Visitas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdAgenteInmobiliario",
                table: "Propiedades",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdCliente",
                table: "Propiedades",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdTipoPropiedad",
                table: "Propiedades",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdAgenteInmobiliario",
                table: "Clientes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Visitas_AgenteInmobiliarioId",
                table: "Visitas",
                column: "AgenteInmobiliarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Visitas_ClienteId",
                table: "Visitas",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Visitas_PropiedadId",
                table: "Visitas",
                column: "PropiedadId");

            migrationBuilder.CreateIndex(
                name: "IX_Propiedades_IdAgenteInmobiliario",
                table: "Propiedades",
                column: "IdAgenteInmobiliario");

            migrationBuilder.CreateIndex(
                name: "IX_Propiedades_IdCliente",
                table: "Propiedades",
                column: "IdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_Propiedades_IdTipoPropiedad",
                table: "Propiedades",
                column: "IdTipoPropiedad");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_IdAgenteInmobiliario",
                table: "Clientes",
                column: "IdAgenteInmobiliario");

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_AgentesInmobiliarios_IdAgenteInmobiliario",
                table: "Clientes",
                column: "IdAgenteInmobiliario",
                principalTable: "AgentesInmobiliarios",
                principalColumn: "IdAgenteInmobiliario",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Propiedades_AgentesInmobiliarios_IdAgenteInmobiliario",
                table: "Propiedades",
                column: "IdAgenteInmobiliario",
                principalTable: "AgentesInmobiliarios",
                principalColumn: "IdAgenteInmobiliario",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Propiedades_Clientes_IdCliente",
                table: "Propiedades",
                column: "IdCliente",
                principalTable: "Clientes",
                principalColumn: "IdCliente",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Propiedades_TipoPropiedades_IdTipoPropiedad",
                table: "Propiedades",
                column: "IdTipoPropiedad",
                principalTable: "TipoPropiedades",
                principalColumn: "IdTipoPropiedad",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Visitas_AgentesInmobiliarios_AgenteInmobiliarioId",
                table: "Visitas",
                column: "AgenteInmobiliarioId",
                principalTable: "AgentesInmobiliarios",
                principalColumn: "IdAgenteInmobiliario",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Visitas_Clientes_ClienteId",
                table: "Visitas",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "IdCliente",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Visitas_Propiedades_PropiedadId",
                table: "Visitas",
                column: "PropiedadId",
                principalTable: "Propiedades",
                principalColumn: "IdPropiedad",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
