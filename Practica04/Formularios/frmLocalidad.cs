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
  public partial class frmLocalidad : Form
  {
    public frmLocalidad()
    {
      InitializeComponent();
    }

    private void frmLocalidad_Load(object sender, EventArgs e)
    {

    }
    private void txtLocalidad_Leave(object sender, EventArgs e)
    {
      if (txtLocalidad.Text.Trim() != string.Empty)
      {
        SQl.SelectLocalidad();
      }
    }
    private void btnConsulta_Click(object sender, EventArgs e)
    {
      frmConsultaLocalidad Consulta = new frmConsultaLocalidad();
      Consulta.ShowDialog();
    }

    private void btnDepatamento_Click(object sender, EventArgs e)
    {
      frmDepartamento Departamento = new frmDepartamento();
      Departamento.ShowDialog();
      this.Close();
    }

    private void btnPosiciones_Click(object sender, EventArgs e)
    {
      frmPosicion Posiciones = new frmPosicion();
      Posiciones.ShowDialog();
      this.Close();
    }

    private void btnFabrica_Click(object sender, EventArgs e)
    {
      frmFabrica Fabrica = new frmFabrica();
      Fabrica.ShowDialog();
      this.Close();
    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
      SQl.InsertLocalidad();
      btnLimpiar.PerformClick();
    }

    private void btnLimpiar_Click(object sender, EventArgs e)
    {
      Limpiar.Localidades();
      txtLocalidad.Focus();
    }

    private void bntBorrar_Click(object sender, EventArgs e)
    {
      SQl.DeleteLocalidad();
    }

    private void btnSalir_Click(object sender, EventArgs e)
    {
      this.Close();
      frmPosicion MaestoPosiciones = new frmPosicion();
      MaestoPosiciones.ShowDialog();
    }
  }
}
