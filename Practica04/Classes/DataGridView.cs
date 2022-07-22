namespace Practica04
{
  public static class DGridView
  {
    public static void BuscarDepartamento()
    {
      frmConsultaDepartamento.dgv.Rows.Clear();
      frmConsultaDepartamento.dgv.Refresh();
      Db.cnx.Open();
      SqlCommand PCmmd = new SqlCommand("SELECT IdDepartamento, NombreDepartamento " +
                                        "FROM Departamento " +
                                        "WHERE NombreDepartamento LIKE '%" + frmConsultaDepartamento.txtBuscar.Text + "%'" +
                                        "ORDER BY IdDepartamento ASC", Db.cnx);
      SqlDataReader recordset = PCmmd.ExecuteReader();
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
      PCmmd.Dispose();
      Db.cnx.Close();
    }
    public static void BuscarPosicion()
    {
      frmConsultaPosicion.dgv.Rows.Clear();
      frmConsultaPosicion.dgv.Refresh();
      Db.cnx.Open();
      SqlCommand PCmmd = new SqlCommand("SELECT IDposicion, NombreDePosicion " +
                                        "FROM Posiciones " +
                                        "WHERE NombreDePosicion LIKE '%" + frmConsultaPosicion.txtBuscar.Text + "%'" +
                                        "ORDER BY IDposicion ASC", Db.cnx);
      SqlDataReader recordset = PCmmd.ExecuteReader();
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
      PCmmd.Dispose();
      Db.cnx.Close();
    }
    public static void BuscarFabrica()
    {
      frmConsultaFabrica.dgv.Rows.Clear();
      frmConsultaFabrica.dgv.Refresh();
      Db.cnx.Open();
      SqlCommand Fcmmd = new SqlCommand("SELECT IDFabrica, NombreDeFabrica,Localidad " +
                                        "FROM Fabrica " +
                                        "WHERE NombreDeFabrica LIKE '%" + frmConsultaFabrica.txtBuscar.Text + "%'" +
                                        "ORDER BY IdFabrica ASC", Db.cnx);
      SqlDataReader recordset = Fcmmd.ExecuteReader();
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
      Fcmmd.Dispose();
      Db.cnx.Close();
    }
    public static void BuscarLocalidad()
    {
      frmConsultaLocalidad.dgv.Rows.Clear();
      frmConsultaLocalidad.dgv.Refresh();
      Db.cnx.Open();
      SqlCommand Lcmmd = new SqlCommand("SELECT IDLocalidad, NombreLocalidad " +
                                        "FROM Localidad " +
                                        "WHERE NombreLocalidad LIKE '%" + frmConsultaLocalidad.txtBuscar.Text + "%'" +
                                        "ORDER BY IdLocalidad ASC", Db.cnx);
      SqlDataReader recordset = Lcmmd.ExecuteReader();
      try
      {
        while (recordset.Read())
        {
          frmConsultaLocalidad.dgv.Rows.Add();
          int xRows = frmConsultaLocalidad.dgv.Rows.Count - 1;
          frmConsultaLocalidad.dgv[0, xRows].Value = Convert.ToString(recordset["IdLocalidad"]);
          frmConsultaLocalidad.dgv[1, xRows].Value = Convert.ToString(recordset["NombreLocalidad"]);
        }
      }
      catch
      {
        //
      }
      Lcmmd.Dispose();
      Db.cnx.Close();
    }
  }

}