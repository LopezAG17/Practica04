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
  public partial class frmDepartamento : Form
  {
    public frmDepartamento()
    {
      InitializeComponent();
    }
    private void frmDepartamento_Load(object sender, EventArgs e)
    {

    }
    private void btnLimpiar_Click(object sender, EventArgs e)
    {
      Limpiar.Posiciones();
      txtDepartamento.Focus();
    }
    private void btnGuardar_Click(object sender, EventArgs e)
    {
      btnLimpiar.PerformClick();
      SQl.InsertDepartamento();

    }
    private void btnConsultaFabrica_Click(object sender, EventArgs e)
    {
    }
    private void txtDepartamento_Leave(object sender, EventArgs e)
    {
      if (txtDepartamento.Text.Trim() != string.Empty)
      {
        SQl.SelectDepartamento();
      }
      SQl.SelectDepartamento();

    }
    private void btnSalir_Click(object sender, EventArgs e)
    {
      this.Close();
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
  }
}

