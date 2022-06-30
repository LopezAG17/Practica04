using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;  // permite hacer el llamado a la base de datos

namespace Practica04
{
  public static class SQl
  {
    public static class Db
    {
      public static string Stringcnx = "Server=localhost;Database=DBpractica;Trusted_Connection=True;";
      public static SqlConnection cnx = new SqlConnection(Stringcnx);
    }

    private static class Query
    {
      public static string InsertarDepartamento = "INSERT INTO Departamento (Nombre) VALUES (@Nombre)";
      public static string ConsultaDepartamento = "SELECT * FROM Departamento";
      public static string ConsultaDepartamentoId = "SELECT * FROM Departamento WHERE Id = @Id";
      public static string ActualizarDepartamento = "UPDATE Departamento SET Nombre = @Nombre WHERE Id = @Id";
      public static string EliminarDepartamento = "DELETE FROM Departamento WHERE Id = @Id";
    }

    private static class Cmd
    {
    }
  }
}
