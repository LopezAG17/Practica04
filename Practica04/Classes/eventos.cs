using System.Drawing;
using System.Windows.Forms;
namespace Practica04
{
  public static class Limpiar
  {
    public static void Posiciones()
    {
      frmPosicion.txtDepartamento.Clear();
      frmPosicion.txtFabrica.Clear();
      frmPosicion.txtNombrePosicion.Clear();
      frmPosicion.txtPosicion.Clear();
      frmPosicion.lblDepartamento.Text = "";
      frmPosicion.lblFabricaNombre.Text = "";
    }
    public static void Departamentos()
    {
      frmDepartamento.txtDepartamento.Clear();
      frmDepartamento.txtFabrica.Clear();
      frmDepartamento.txtNombreDepartamento.Clear();
      frmDepartamento.txtDepartamento.Clear();
      frmDepartamento.lblFabrica.Text = "";
      frmDepartamento.lblFabricaNombre.Text = "";
    }

    public static void Fabricas()
    {
      frmFabrica.txtLocalidad.Clear();
      frmFabrica.txtFabrica.Clear();
      frmFabrica.txtNombreFabrica.Clear();
      frmFabrica.lblLocalidad.Text = "";
    }
    public static void Localidades()
    {
      frmLocalidad.txtLocalidad.Clear();
      frmLocalidad.txtNombreLocalidad.Clear();
    }
  }
  public static class Diseño
  {
    public static void Posiciones()
    {
      frmConsultaPosicion.dgv.AllowUserToAddRows = false;
      frmConsultaPosicion.dgv.AllowUserToDeleteRows = false;
      frmConsultaPosicion.dgv.EnableHeadersVisualStyles = false;
      frmConsultaPosicion.dgv.BorderStyle = BorderStyle.None;
      frmConsultaPosicion.dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
      frmConsultaPosicion.dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
      frmConsultaPosicion.dgv.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
      frmConsultaPosicion.dgv.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
      frmConsultaPosicion.dgv.BackgroundColor = Color.LightGray;
      frmConsultaPosicion.dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
      frmConsultaPosicion.dgv.ColumnHeadersDefaultCellStyle.Padding = new Padding(0, 6, 0, 6);
      frmConsultaPosicion.dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.CornflowerBlue;
      frmConsultaPosicion.dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
    }
    public static void Departamentos()
    {
      frmConsultaDepartamento.dgv.AllowUserToAddRows = false;
      frmConsultaDepartamento.dgv.AllowUserToDeleteRows = false;
      frmConsultaDepartamento.dgv.EnableHeadersVisualStyles = false;
      frmConsultaDepartamento.dgv.BorderStyle = BorderStyle.None;
      frmConsultaDepartamento.dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
      frmConsultaDepartamento.dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
      frmConsultaDepartamento.dgv.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
      frmConsultaDepartamento.dgv.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
      frmConsultaDepartamento.dgv.BackgroundColor = Color.LightGray;
      frmConsultaDepartamento.dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
      frmConsultaDepartamento.dgv.ColumnHeadersDefaultCellStyle.Padding = new Padding(0, 6, 0, 6);
      frmConsultaDepartamento.dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.CornflowerBlue;
      frmConsultaDepartamento.dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
    }
    public static void Fabricas()
    {
      frmConsultaFabrica.dgv.AllowUserToAddRows = false;
      frmConsultaFabrica.dgv.AllowUserToDeleteRows = false;
      frmConsultaFabrica.dgv.EnableHeadersVisualStyles = false;
      frmConsultaFabrica.dgv.BorderStyle = BorderStyle.None;
      frmConsultaFabrica.dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
      frmConsultaFabrica.dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
      frmConsultaFabrica.dgv.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
      frmConsultaFabrica.dgv.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
      frmConsultaFabrica.dgv.BackgroundColor = Color.LightGray;
      frmConsultaFabrica.dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
      frmConsultaFabrica.dgv.ColumnHeadersDefaultCellStyle.Padding = new Padding(0, 6, 0, 6);
      frmConsultaFabrica.dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.CornflowerBlue;
      frmConsultaFabrica.dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
    }
    public static void Localidades()
    {
      frmConsultaLocalidad.dgv.AllowUserToAddRows = false;
      frmConsultaLocalidad.dgv.AllowUserToDeleteRows = false;
      frmConsultaLocalidad.dgv.EnableHeadersVisualStyles = false;
      frmConsultaLocalidad.dgv.BorderStyle = BorderStyle.None;
      frmConsultaLocalidad.dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
      frmConsultaLocalidad.dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
      frmConsultaLocalidad.dgv.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
      frmConsultaLocalidad.dgv.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
      frmConsultaLocalidad.dgv.BackgroundColor = Color.LightGray;
      frmConsultaLocalidad.dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
      frmConsultaLocalidad.dgv.ColumnHeadersDefaultCellStyle.Padding = new Padding(0, 6, 0, 6);
      frmConsultaLocalidad.dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.CornflowerBlue;
      frmConsultaLocalidad.dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
    }
  }
  public static class E_Load
  {
    public static void Posiciones()
    {
      frmConsultaPosicion.dgv.EnableHeadersVisualStyles = false;
      frmConsultaPosicion.dgv.ColumnHeadersVisible = true;
      frmConsultaPosicion.dgv.RowHeadersVisible = false;
      frmConsultaPosicion.dgv.Columns.Add("Col00", "ID Posicion");
      frmConsultaPosicion.dgv.Columns.Add("Col01", "Nombre de la Posicon");
      DataGridViewColumn
      column = frmConsultaPosicion.dgv.Columns[0]; column.Width = 150;
      column = frmConsultaPosicion.dgv.Columns[1]; column.Width = 582;
      Diseño.Posiciones();
    }
    public static void Departamentos()
    {
      frmConsultaDepartamento.dgv.EnableHeadersVisualStyles = false;
      frmConsultaDepartamento.dgv.ColumnHeadersVisible = true;
      frmConsultaDepartamento.dgv.RowHeadersVisible = false;
      frmConsultaDepartamento.dgv.Columns.Add("Col00", "ID Departamento");
      frmConsultaDepartamento.dgv.Columns.Add("Col01", "Nombre del Departamento");
      DataGridViewColumn
      column = frmConsultaDepartamento.dgv.Columns[0]; column.Width = 150;
      column = frmConsultaDepartamento.dgv.Columns[1]; column.Width = 582;
      Diseño.Departamentos();
    }
    public static void Fabricas()
    {
      frmConsultaFabrica.dgv.EnableHeadersVisualStyles = false;
      frmConsultaFabrica.dgv.ColumnHeadersVisible = true;
      frmConsultaFabrica.dgv.RowHeadersVisible = false;
      frmConsultaFabrica.dgv.Columns.Add("Col00", "ID Fabrica");
      frmConsultaFabrica.dgv.Columns.Add("Col01", "Nombre de la Fabrica");
      frmConsultaFabrica.dgv.Columns.Add("Col02", "Localidad");
      DataGridViewColumn
      column = frmConsultaFabrica.dgv.Columns[0]; column.Width = 150;
      column = frmConsultaFabrica.dgv.Columns[1]; column.Width = 400;
      column = frmConsultaFabrica.dgv.Columns[2]; column.Width = 180;
      Diseño.Fabricas();
    }
    public static void Localidades()
    {
      frmConsultaLocalidad.dgv.EnableHeadersVisualStyles = false;
      frmConsultaLocalidad.dgv.ColumnHeadersVisible = true;
      frmConsultaLocalidad.dgv.RowHeadersVisible = false;
      frmConsultaLocalidad.dgv.Columns.Add("Col00", "ID Localidad");
      frmConsultaLocalidad.dgv.Columns.Add("Col01", "Nombre de la Localidad");
      DataGridViewColumn
      column = frmConsultaLocalidad.dgv.Columns[0]; column.Width = 150;
      column = frmConsultaLocalidad.dgv.Columns[1]; column.Width = 582;
      Diseño.Localidades();
    }
  }

  public static class Seleccion
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

      }
    }
    public static void Departamentos()
    {
      try
      {
        frmDepartamento.txtDepartamento.Text = frmConsultaDepartamento.dgv.CurrentRow.Cells[0].Value.ToString();
        frmDepartamento.txtNombreDepartamento.Text = frmConsultaDepartamento.dgv.CurrentRow.Cells[1].Value.ToString();
      }
      catch
      {

      }
    }
    public static void Fabricas()
    {
      try
      {
        frmFabrica.txtFabrica.Text = frmConsultaFabrica.dgv.CurrentRow.Cells[0].Value.ToString();
        frmFabrica.txtNombreFabrica.Text = frmConsultaFabrica.dgv.CurrentRow.Cells[1].Value.ToString();
        frmFabrica.txtLocalidad.Text = frmConsultaFabrica.dgv.CurrentRow.Cells[2].Value.ToString();
      }
      catch
      {

      }
    }
    public static void Localidades()
    {
      try
      {
        frmLocalidad.txtLocalidad.Text = frmConsultaLocalidad.dgv.CurrentRow.Cells[0].Value.ToString();
        frmLocalidad.txtNombreLocalidad.Text = frmConsultaLocalidad.dgv.CurrentRow.Cells[1].Value.ToString();
      }
      catch
      {

      }
    }
  }
}
