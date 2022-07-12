using System;
using System.Windows.Forms;

namespace Practica04
{
  public partial class frmFabrica : Form
  {
    public frmFabrica()
    {
      InitializeComponent();
    }
    private void frmFabrica_Load(object sender, EventArgs e)
    {
      this.KeyPreview = true;
    }
    private void frmFabrica_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Escape)
      {
        btnSalir.PerformClick();
      }
    }
    private void txtFabrica_Leave(object sender, EventArgs e)
    {
      if (txtFabrica.Text.Trim() != string.Empty)
      {
        SQl.SelectFabrica();
      }
    }
    private void btnLimpiar_Click_1(object sender, EventArgs e)
    {
      Limpiar.Fabricas();
      txtFabrica.Focus();
    }
    private void btnGuardar_Click(object sender, EventArgs e)
    {
      SQl.InsertFabrica();
      btnLimpiar.PerformClick();
    }
    private void bntBorrar_Click(object sender, EventArgs e)
    {
      SQl.DeleteFabrica();
    }
    private void btnConsulta_Click(object sender, EventArgs e)
    {
      frmConsultaFabrica Consulta = new frmConsultaFabrica();
      Consulta.ShowDialog();
    }
    private void btnConsultaFabrica_Click(object sender, EventArgs e)
    {
      frmConsultaFabrica ConsultaLocalidad = new frmConsultaFabrica();
      ConsultaLocalidad.ShowDialog();
    }
    private void btnPosiciones_Click(object sender, EventArgs e)
    {
      frmPosicion Posiciones = new frmPosicion();
      Posiciones.ShowDialog();
      this.Close();

    }
    private void btnDepatamento_Click(object sender, EventArgs e)
    {
      frmDepartamento Departamento = new frmDepartamento();
      Departamento.ShowDialog();
      this.Close();

    }
    private void btnLocalidad_Click(object sender, EventArgs e)
    {
      frmLocalidad Localidad = new frmLocalidad();
      Localidad.ShowDialog();
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
