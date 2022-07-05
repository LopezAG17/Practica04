using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

    }
    private void txtFabrica_Leave(object sender, EventArgs e)
    {
      if (txtFabrica.Text.Trim() != string.Empty)
      {
        SQl.SelectFabrica();
      }
      SQl.SelectFabrica();
    }
    private void btnLimpiar_Click_1(object sender, EventArgs e)
    {
      Limpiar.FormularioFab();
      txtFabrica.Focus();
    }
    private void btnGuardar_Click(object sender, EventArgs e)
    {
      btnLimpiar.PerformClick();
      SQl.InsertFabrica();
    }
    private void bntBorrar_Click(object sender, EventArgs e)
    {
      SQl.DeleteFabrica();

    }
    private void btnSalir_Click(object sender, EventArgs e)
    {
      this.Close();
    }
    private void btnConsulta_Click(object sender, EventArgs e)
    {
      frmConsultaFabrica Consulta = new frmConsultaFabrica();
      Consulta.Show();
    }
    private void btnConsultaFabrica_Click(object sender, EventArgs e)
    {
      frmConsultaFabrica ConsultaLocalidad = new frmConsultaFabrica();
      ConsultaLocalidad.Show();
    }
  }
}
