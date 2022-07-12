using System;
using System.Windows.Forms;

namespace Practica04
{
  public partial class frmDepartamento : Form
  {
    public frmDepartamento()
    {
      InitializeComponent();
    }
    private void frmDepartamento_Load(object sender, EventArgs e)
    {
      this.KeyPreview = true;
    }
    private void frmDepartamento_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Escape)
      {
        btnSalir.PerformClick();
      }
    }
    private void txtDepartamento_KeyPress(object sender, KeyPressEventArgs e)
    {
      if ((int)e.KeyChar == (int)Keys.Enter)
      {
        e.Handled = true;
        if (txtDepartamento.Text.Trim() != string.Empty)
        {
          // mueve el cursor al textbox txtDepartamento
          txtNombreDepartamento.Focus();
        }
      }
    }
    private void txtDepartamento_Leave(object sender, EventArgs e)
    {
      if (txtDepartamento.Text.Trim() != string.Empty)
      {
        SQl.SelectDepartamento();
        Console.WriteLine("Funciona");
      }
    }
    private void btnLimpiar_Click(object sender, EventArgs e)
    {
      Limpiar.Departamentos();
      txtDepartamento.Focus();
    }
    private void btnGuardar_Click(object sender, EventArgs e)
    {
      SQl.InsertDepartamento();
      btnLimpiar.PerformClick();

    }
    private void bntBorrar_Click(object sender, EventArgs e)
    {
      SQl.DeleteDepartamento();

    }
    private void btnConsulta_Click(object sender, EventArgs e)
    {
      frmConsultaDepartamento consulta = new frmConsultaDepartamento();
      consulta.Show();
    }
    private void btnConsultaFabrica_Click_1(object sender, EventArgs e)
    {
      frmConsultaFabrica ConsultaFabrica = new frmConsultaFabrica();
      ConsultaFabrica.Show();
    }

    private void btnPosiciones_Click(object sender, EventArgs e)
    {
      frmPosicion MaestoPosiciones = new frmPosicion();
      MaestoPosiciones.ShowDialog();
      this.Close();

    }
    private void btnFabrica_Click(object sender, EventArgs e)
    {
      frmFabrica MaestoFabrica = new frmFabrica();
      MaestoFabrica.ShowDialog();
      this.Close();
    }
    private void btnLocalidad_Click(object sender, EventArgs e)
    {
      frmLocalidad MaestoLocalidad = new frmLocalidad();
      MaestoLocalidad.ShowDialog();
      this.Close();
    }
    private void btnSalir_Click(object sender, EventArgs e)
    {
      this.Close();
      frmPosicion MaestoPosiciones = new frmPosicion();
      MaestoPosiciones.ShowDialog();
    }

  }
}

