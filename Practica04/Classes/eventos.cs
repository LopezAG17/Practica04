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
      //frmConsultaDepartamento.dgv.AllowUserToAddRows = false;
      //frmConsultaDepartamento.dgv.AllowUserToDeleteRows = false;
      //frmConsultaDepartamento.dgv.EnableHeadersVisualStyles = false;
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
  }
}
