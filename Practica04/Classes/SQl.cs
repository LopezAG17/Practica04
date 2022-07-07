using System;
using System.Data.SqlClient;  // permite hacer el llamado a la base de datos

namespace Practica04
{
  public static class Db
  {
    public static string Stringcnx = "Server=localhost;Database=DBpractica;Trusted_Connection=True;";
    public static SqlConnection cnx = new SqlConnection(Stringcnx);
  }
  public static class SQl
  {

    public static void SelectPosicion()
    {
      Db.cnx.Open();
      SqlCommand cmmnd = new SqlCommand("SELECT a.NombreDePosicion, a.Fabrica,a.Departamento,c.NombreDepartamento,b.NombreDeFabrica " +
                                        "FROM POSICIONES A " +
                                        "LEFT join FABRICA B on a.Fabrica = b.IDfabrica " +
                                        "LEFT join DEPARTAMENTO C on A.Departamento = C.IDdepartamento " +
                                        "WHERE a.IDPOSICION =@PV", Db.cnx);

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


      cmmnd.Dispose();
      Db.cnx.Close();
    }
    public static void DeletePosicion()
    {
      Db.cnx.Open();
      SqlCommand cmmnd = new SqlCommand("DELETE FROM POSICIONES WHERE IDPOSICION = @RG", Db.cnx);
      cmmnd.Parameters.AddWithValue("@RG", frmPosicion.txtPosicion.Text);
      cmmnd.ExecuteNonQuery();
      cmmnd.Dispose();
      Db.cnx.Close();
    }
    public static void InsertPosicion()
    {
      Db.cnx.Open();
      SqlCommand cmmnd = new SqlCommand("INSERT INTO POSICIONES (NOMBREDEPOSICION, FABRICA, DEPARTAMENTO) VALUES (@A0,@A1,@A2,@A3)", Db.cnx);
      cmmnd.Parameters.AddWithValue("@A0", frmPosicion.txtPosicion.Text);
      cmmnd.Parameters.AddWithValue("@A1", frmPosicion.txtNombrePosicion.Text);
      cmmnd.Parameters.AddWithValue("@A2", frmPosicion.txtFabrica.Text);
      cmmnd.Parameters.AddWithValue("@A3", frmPosicion.txtDepartamento.Text);
      cmmnd.ExecuteNonQuery();
      cmmnd.Dispose();
      Db.cnx.Close();
    }
    public static void SelectDepartamento()
    {
      Db.cnx.Open();
      SqlCommand cmmnd = new SqlCommand("SELECT a.NombreDepartamento, a.IdFabrica, b.NombreDefabrica " +
                                        "From Departamento A LEFT JOIN Fabrica B ON a.IDfabrica = b.IDfabrica " +
                                        "WHERE a.IDdepartamento =@PV",
                                        Db.cnx
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

      cmmnd.Dispose();
      Db.cnx.Close();
    }
    public static void DeleteDepartamento()
    {
      Db.cnx.Open();
      SqlCommand cmmnd = new SqlCommand("DELETE FROM DEPARTAMENTO WHERE IDdepartamento = @RG", Db.cnx);
      cmmnd.Parameters.AddWithValue("@RG", frmDepartamento.txtDepartamento.Text);
      cmmnd.ExecuteNonQuery();
      cmmnd.Dispose();
      Db.cnx.Close();
    }
    public static void InsertDepartamento()
    {
      Db.cnx.Open();
      SqlCommand cmmnd = new SqlCommand("INSERT INTO DEPARTAMENTO (IDdepartamento, NombreDepartamento, IDfabrica) VALUES (@A0, @A1, @A2)", Db.cnx);
      cmmnd.Parameters.AddWithValue("@A0", frmDepartamento.txtDepartamento.Text);
      cmmnd.Parameters.AddWithValue("@A1", frmDepartamento.txtNombreDepartamento.Text);
      cmmnd.Parameters.AddWithValue("@A2", frmDepartamento.txtFabrica.Text);
      cmmnd.ExecuteNonQuery();
      cmmnd.Dispose();
      Db.cnx.Close();
    }
    public static void SelectFabrica()
    {
      Db.cnx.Open();
      SqlCommand cmmnd = new SqlCommand("SELECT b.NombreLocalidad, a.NombreDeFabrica, a.Localidad, a.IDfabrica " +
                                        "FROM Fabrica A Left Join Localidad B On  A.Localidad = B.IDLocalidad " +
                                        "WHERE a.IDfabrica =@PV",
                                        Db.cnx
                                       );

      cmmnd.Parameters.AddWithValue("@PV", Convert.ToString(frmFabrica.txtFabrica.Text));
      SqlDataReader recordn = cmmnd.ExecuteReader();
      if (recordn.Read())
      {
        frmFabrica.txtNombreFabrica.Text = Convert.ToString(recordn["NombreDeFabrica"]);
        frmFabrica.txtLocalidad.Text = Convert.ToString(recordn["Localidad"]);
        frmFabrica.lblLocalidad.Text = Convert.ToString(recordn["NombreLocalidad"]);
      }
      cmmnd.Dispose();
      Db.cnx.Close();
    }
    public static void DeleteFabrica()
    {
      Db.cnx.Open();
      SqlCommand cmmnd = new SqlCommand("DELETE FROM FABRICA WHERE IDfabrica = @RG", Db.cnx);
      cmmnd.Parameters.AddWithValue("@RG", frmFabrica.txtFabrica.Text);
      cmmnd.ExecuteNonQuery();
      cmmnd.Dispose();
      Db.cnx.Close();
    }
    public static void InsertFabrica()
    {
      Db.cnx.Open();
      SqlCommand cmmnd = new SqlCommand("INSERT INTO FABRICA (IDfabrica, NombreDeFabrica, Localidad) VALUES (@A0, @A1, @A2)", Db.cnx);
      cmmnd.Parameters.AddWithValue("@A0", frmFabrica.txtFabrica.Text);
      cmmnd.Parameters.AddWithValue("@A1", frmFabrica.txtNombreFabrica.Text);
      cmmnd.Parameters.AddWithValue("@A2", frmFabrica.txtLocalidad.Text);
      cmmnd.ExecuteNonQuery();
      cmmnd.Dispose();
      Db.cnx.Close();
    }
  }
  public static class DGridView
  {
    public static void BuscarDepartamento()
    {
      frmConsultaDepartamento.dgv.Rows.Clear();
      frmConsultaDepartamento.dgv.Refresh();
      Db.cnx.Open();
      SqlCommand PCmd = new SqlCommand("SELECT IdDepartamento, NombreDepartamento " +
                                       "FROM Departamento " +
                                       "WHERE NombreDepartamento LIKE '%" + frmConsultaDepartamento.txtBuscar.Text + "%'" +
                                       "ORDER BY IdDepartamento ASC", Db.cnx);
      SqlDataReader recordset = PCmd.ExecuteReader();
      try
      {
        while (recordset.Read())
        {
          frmConsultaDepartamento.dgv.Rows.Add();
          int xRows = frmConsultaDepartamento.dgv.Rows.Count - 1;
          frmConsultaDepartamento.dgv[0, xRows].Value = Convert.ToString(recordset["IdDepartamento"]);
          frmConsultaDepartamento.dgv[1, xRows].Value = Convert.ToString(recordset["NombreDepartamento"]);
        }
      }
      catch
      {
        //
      }
      PCmd.Dispose();
      Db.cnx.Close();
    }
    public static void BuscarPosicion()
    {
      frmConsultaPosicion.dgv.Rows.Clear();
      frmConsultaPosicion.dgv.Refresh();
      Db.cnx.Open();
      SqlCommand PCmd = new SqlCommand("SELECT IDposicion, NombreDePosicion " +
                                       "FROM Posiciones " +
                                       "WHERE NombreDePosicion LIKE '%" + frmConsultaPosicion.txtBuscar.Text + "%'" +
                                       "ORDER BY IDposicion ASC", Db.cnx);
      SqlDataReader recordset = PCmd.ExecuteReader();
      try
      {
        while (recordset.Read())
        {
          frmConsultaPosicion.dgv.Rows.Add();
          int xRows = frmConsultaPosicion.dgv.Rows.Count - 1;
          frmConsultaPosicion.dgv[0, xRows].Value = Convert.ToString(recordset["IdPosicion"]);
          frmConsultaPosicion.dgv[1, xRows].Value = Convert.ToString(recordset["NombreDePosicion"]);
        }
      }
      catch
      {
        //
      }
      PCmd.Dispose();
      Db.cnx.Close();
    }
    public static void BuscarFabrica()
    {
      frmConsultaFabrica.dgv.Rows.Clear();
      frmConsultaFabrica.dgv.Refresh();
      Db.cnx.Open();
      SqlCommand Fcmd = new SqlCommand("SELECT IDFabrica, NombreDeFabrica,Localidad " +
                                       "FROM Fabrica " +
                                       "WHERE NombreDeFabrica LIKE '%" + frmConsultaFabrica.txtBuscar.Text + "%'" +
                                       "ORDER BY IdFabrica ASC", Db.cnx);
      SqlDataReader recordset = Fcmd.ExecuteReader();
      try
      {
        while (recordset.Read())
        {  // no es fin de archivo true false
          frmConsultaFabrica.dgv.Rows.Add();
          int xRows = frmConsultaFabrica.dgv.Rows.Count - 1;
          frmConsultaFabrica.dgv[0, xRows].Value = Convert.ToString(recordset["IdFabrica"]);
          frmConsultaFabrica.dgv[1, xRows].Value = Convert.ToString(recordset["NombreDeFabrica"]);
          frmConsultaFabrica.dgv[2, xRows].Value = Convert.ToString(recordset["Localidad"]);
        }
      }
      catch
      {
        //
      }
      Fcmd.Dispose();
      Db.cnx.Close();
    }
  }
}
