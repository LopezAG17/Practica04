namespace Practica04
{
  public static class SelectPoscion
  {
    public static void Posiciones()
    {
      try
      {
        frmPosicion.txtPosicion.Text = frmConsultaPosicion.dgv.CurrentRow.Cells[0].Value.ToString();
        frmPosicion.txtNombrePosicion.Text = frmConsultaPosicion.dgv.CurrentRow.Cells[1].Value.ToString();
      }
      catch
      {
        // 
      }
    }
    public static void Departamentos()
    {
      try
      {
        frmPosicion.txtDepartamento.Text = frmConsultaDepartamento.dgv.CurrentRow.Cells[0].Value.ToString();
        frmPosicion.lblDepartamento.Text = frmConsultaDepartamento.dgv.CurrentRow.Cells[1].Value.ToString();
      }
      catch
      {
        // 
      }
    }
    public static void Fabricas()
    {
      try
      {
        frmPosicion.txtFabrica.Text = frmConsultaFabrica.dgv.CurrentRow.Cells[0].Value.ToString();
        frmPosicion.lblFabricaNombre.Text = frmConsultaFabrica.dgv.CurrentRow.Cells[1].Value.ToString();
      }
      catch
      {
        // 
      }
    }
  }
  public static class SelectDepartamento
  {
    public static void Departamentos()
    {
      try
      {
        frmDepartamento.txtDepartamento.Text = frmConsultaDepartamento.dgv.CurrentRow.Cells[0].Value.ToString();
        frmDepartamento.txtNombreDepartamento.Text = frmConsultaDepartamento.dgv.CurrentRow.Cells[1].Value.ToString();
      }
      catch
      {
        // 
      }
    }
    public static void Fabricas()
    {
      try
      {
        frmDepartamento.txtFabrica.Text = frmConsultaFabrica.dgv.CurrentRow.Cells[0].Value.ToString();
        frmDepartamento.lblFabricaNombre.Text = frmConsultaFabrica.dgv.CurrentRow.Cells[1].Value.ToString();
      }
      catch
      {
        // 
      }
    }
  }
  public static class SelectFabrica
  {
    public static void Fabricas()
    {
      try
      {
        frmFabrica.txtFabrica.Text = frmConsultaFabrica.dgv.CurrentRow.Cells[0].Value.ToString();
        frmFabrica.txtNombreFabrica.Text = frmConsultaFabrica.dgv.CurrentRow.Cells[1].Value.ToString();
      }
      catch
      {
        // 
      }
    }
    public static void Localidad()
    {
      try
      {
        frmFabrica.txtLocalidad.Text = frmConsultaLocalidad.dgv.CurrentRow.Cells[0].Value.ToString();
        frmFabrica.lblLocalidad.Text = frmConsultaLocalidad.dgv.CurrentRow.Cells[1].Value.ToString();
      }
      catch
      {
        // 
      }
    }
  }
  public static class SelectLocalidad
  {
    public static void Localidad()
    {
      try
      {
        frmLocalidad.txtLocalidad.Text = frmConsultaLocalidad.dgv.CurrentRow.Cells[0].Value.ToString();
        frmLocalidad.txtNombreLocalidad.Text = frmConsultaLocalidad.dgv.CurrentRow.Cells[1].Value.ToString();
      }
      catch
      {
        // 
      }
    }
  }
}