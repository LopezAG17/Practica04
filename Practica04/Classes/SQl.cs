using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;  // permite hacer el llamado a la base de datos
using System.Windows.Forms;

namespace Practica04
{
  public static class SQl
  {
    public static class Db
    {
      public static string Stringcnx = "Server=localhost;Database=DBpractica;Trusted_Connection=True;";
      public static SqlConnection cnx = new SqlConnection(Stringcnx);
    }
    public static void SelectPosicion()
    {
      SQl.Db.cnx.Open();
      SqlCommand cmmnd = new SqlCommand("    SELECT a.NombreDePosicion,  " +
                                                  "           a.Fabrica,  " +
                                                  "           a.Departamento,  " +
                                                  "           B.NombreDefabrica,   " +
                                                  "           C.NombreDepartamento  " +
                                                  "      FROM POSICIONES   A " +
                                                  " LEFT join FABRICA      B on a.Fabrica      = b.IDfabrica " +
                                                  " LEFT join DEPARTAMENTO C on A.Departamento = C.IDdepartamento " +
                                                  "WHERE IDPOSICION =@PV", SQl.Db.cnx);

      cmmnd.Parameters.AddWithValue("@PV", frmPosicion.txtPosicion.Text);
      SqlDataReader recordn = cmmnd.ExecuteReader();
      if (recordn.Read())
      {
        frmPosicion.txtNombrePosicion.Text = Convert.ToString(recordn["NOMBREDEPOSICION"]);
        frmPosicion.txtDepartamento.Text = Convert.ToString(recordn["DEPARTAMENTO"]);
        frmPosicion.txtFabrica.Text = Convert.ToString(recordn["FABRICA"]);

        frmPosicion.lblDepartamento.Text = Convert.ToString(recordn["NombreDefabrica"]);
        frmPosicion.lblFabricaNombre.Text = Convert.ToString(recordn["NombreDepartamento"]);
      }
      else
      {
        MessageBox.Show("No se encontro el registro");
      }

      cmmnd.Dispose();
      SQl.Db.cnx.Close();
    }
    public static void DeletePosicion()
    {
      SQl.Db.cnx.Open();
      SqlCommand cmmnd = new SqlCommand("DELETE FROM POSICIONES WHERE IDPOSICION = @RG", SQl.Db.cnx);
      cmmnd.Parameters.AddWithValue("@RG", frmPosicion.txtPosicion.Text);
      cmmnd.ExecuteNonQuery();
      cmmnd.Dispose();
      SQl.Db.cnx.Close();
    }
    public static void InsertPosicion()
    {
      SQl.Db.cnx.Open();
      SqlCommand cmmnd = new SqlCommand("INSERT INTO POSICIONES (NOMBREDEPOSICION, FABRICA, DEPARTAMENTO) VALUES (@NOMBREDEPOSICION, @FABRICA, @DEPARTAMENTO)", SQl.Db.cnx);
      cmmnd.Parameters.AddWithValue("@A0", frmPosicion.txtPosicion.Text);
      cmmnd.Parameters.AddWithValue("@A1", frmPosicion.txtNombrePosicion.Text);
      cmmnd.Parameters.AddWithValue("@A2", frmPosicion.txtFabrica.Text);
      cmmnd.Parameters.AddWithValue("@A3", frmPosicion.txtDepartamento.Text);
      cmmnd.ExecuteNonQuery();
      cmmnd.Dispose();
      SQl.Db.cnx.Close();
    }
    public static void SelectDepartamento()
    {
      SQl.Db.cnx.Open();
      SqlCommand cmmnd = new SqlCommand("SELECT a.NombreDepartamento, a.IdFabrica, b.NombreDefabrica " +
                                        "From Departamento A LEFT JOIN Fabrica B ON a.IDfabrica = b.IDfabrica " +
                                        "WHERE a.IDdepartamento =@PV",
                                        SQl.Db.cnx
                                       );

      cmmnd.Parameters.AddWithValue("@PV", Convert.ToString(frmDepartamento.txtDepartamento.Text));
      SqlDataReader recordn = cmmnd.ExecuteReader();
      if (recordn.Read())
      {
        frmDepartamento.txtNombreDepartamento.Text = Convert.ToString(recordn["NombreDepartamento"]);
        frmDepartamento.txtFabrica.Text = Convert.ToString(recordn["IDfabrica"]);
        frmDepartamento.lblFabricaNombre.Text = Convert.ToString(recordn["NombreDefabrica"]);
        frmDepartamento.lblFabrica.Text = Convert.ToString(recordn["NombreDepartamento"]);
      }
      else
      {
        MessageBox.Show("No existe el departamento");
      }

      cmmnd.Dispose();
      SQl.Db.cnx.Close();
    }
    public static void DeleteDepartamento()
    {
      SQl.Db.cnx.Open();
      SqlCommand cmmnd = new SqlCommand("DELETE FROM DEPARTAMENTO WHERE IDdepartamento = @RG", SQl.Db.cnx);
      cmmnd.Parameters.AddWithValue("@RG", frmDepartamento.txtDepartamento.Text);
      cmmnd.ExecuteNonQuery();
      cmmnd.Dispose();
      SQl.Db.cnx.Close();
    }
    public static void InsertDepartamento()
    {
      SQl.Db.cnx.Open();
      SqlCommand cmmnd = new SqlCommand("INSERT INTO DEPARTAMENTO (IDdepartamento, NombreDepartamento, IDfabrica) VALUES (@A0, @A1, @A2)", SQl.Db.cnx);
      cmmnd.Parameters.AddWithValue("@A0", frmDepartamento.txtDepartamento.Text);
      cmmnd.Parameters.AddWithValue("@A1", frmDepartamento.txtNombreDepartamento.Text);
      cmmnd.Parameters.AddWithValue("@A2", frmDepartamento.txtFabrica.Text);
      cmmnd.ExecuteNonQuery();
      cmmnd.Dispose();
      SQl.Db.cnx.Close();
    }
    public static void SelectFabrica()
    {
      SQl.Db.cnx.Open();
      SqlCommand cmmnd = new SqlCommand("SELECT b.NombreLocalidad, a.NombreDeFabrica, a.Localidad, a.IDfabrica " +
                                        "FROM Fabrica A Left Join Localidad B On  A.Localidad = B.IDLocalidad " +
                                        "WHERE a.IDfabrica =@PV",
                                        SQl.Db.cnx
                                       );

      cmmnd.Parameters.AddWithValue("@PV", Convert.ToString(frmFabrica.txtFabrica.Text));
      SqlDataReader recordn = cmmnd.ExecuteReader();
      if (recordn.Read())
      {
        frmFabrica.txtNombreFabrica.Text = Convert.ToString(recordn["NombreDeFabrica"]);
        frmFabrica.txtLocalidad.Text = Convert.ToString(recordn["Localidad"]);
        frmFabrica.lblLocalidad.Text = Convert.ToString(recordn["NombreLocalidad"]);
      }
      else
      {
        MessageBox.Show("No existe la fabrica");
      }
      cmmnd.Dispose();
      SQl.Db.cnx.Close();
    }
    public static void DeleteFabrica()
    {
      SQl.Db.cnx.Open();
      SqlCommand cmmnd = new SqlCommand("DELETE FROM FABRICA WHERE IDfabrica = @RG", SQl.Db.cnx);
      cmmnd.Parameters.AddWithValue("@RG", frmFabrica.txtFabrica.Text);
      cmmnd.ExecuteNonQuery();
      cmmnd.Dispose();
      SQl.Db.cnx.Close();
    }
    public static void InsertFabrica()
    {
      SQl.Db.cnx.Open();
      SqlCommand cmmnd = new SqlCommand("INSERT INTO FABRICA (IDfabrica, NombreDeFabrica, Localidad) VALUES (@A0, @A1, @A2)", SQl.Db.cnx);
      cmmnd.Parameters.AddWithValue("@A0", frmFabrica.txtFabrica.Text);
      cmmnd.Parameters.AddWithValue("@A1", frmFabrica.txtNombreFabrica.Text);
      cmmnd.Parameters.AddWithValue("@A2", frmFabrica.txtLocalidad.Text);
      cmmnd.ExecuteNonQuery();
      cmmnd.Dispose();
      SQl.Db.cnx.Close();
    }
  }
}
