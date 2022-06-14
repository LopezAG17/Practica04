using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Practica04
{
  public class cnn
  {
    public static string db = "Data Source=192.168.0.88;Initial Catalog=dbhdesk; user id = hd; password = hd685328@";
    // public static string db = "server=NUT-LP-24\\SQLEXPRESS; database=dbQBOne; integrated security = true";
  }

  public class HMenu
  {
    public static string nCia = "Nutriciosa";
    public static string cia = "QHDesk - La Nutriciosa   (  ";
    public static string pc = "  )   PC - " + System.Environment.MachineName;

  }

  public class Item
  {
    public string Name { get; set; }
    public int Value { get; set; }

    public Item(string name, int value)
    {
      Name = name;
      Value = value;
    }
    public override string ToString()
    {
      return Name;
    }
  }

  // ------------------------------------
  // declaracion de clase publica Usuario
  // ------------------------------------
  public class Usuario
  {
    public static string nombre { get; set; }   // Componentes de la clase tipo string
    public static string correo { get; set; }   // Componentes de la clase tipo string
    public static string cargo { get; set; }    // Componentes de la clase tipo string
    public static int Id { get; set; }          // Componentes de la clase tipo string
  }

  public class Busco
  {
    public static string UsuarioSistema(string numCliente)
    {
      SqlConnection cnxn = new SqlConnection(cnn.db); cnxn.Open();
      SqlCommand cmmnd = new SqlCommand("SELECT USUARIO.NUMEROEMPLEADO, USUARIO.CARGO, USUARIO.NOMBRECORTO, USUARIO.CORREO, USUARIO.CLAVE " +
                                        "  FROM USUARIO " +
                                        " WHERE ACTIVO = 'TRUE' " +
                                        "   AND NOMBRECORTO = @PV", cnxn);
      cmmnd.Parameters.AddWithValue("@PV", numCliente);
      SqlDataReader rdr = cmmnd.ExecuteReader();

      if (rdr.Read())
      {
        Usuario.cargo = Convert.ToString(rdr["CARGO"]);
        Usuario.nombre = Convert.ToString(rdr["NOMBRECORTO"]);
        Usuario.correo = Convert.ToString(rdr["CORREO"]);
        Usuario.Id = Convert.ToInt32(rdr["NUMEROEMPLEADO"]);

        return Convert.ToString(rdr["CLAVE"]);
      }

      cmmnd.Dispose();
      cnxn.Close();
      return null;
    }
  }
}
