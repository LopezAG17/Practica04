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
  public partial class frmConsultaDepartamento : Form
  {
    public frmConsultaDepartamento()
    {
      InitializeComponent();
    }
    private void frmConsultaDepartamento_Load(object sender, EventArgs e)
    {

    }
    private void frmConsultaDepartamento_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Escape)
      {
        this.Close();
      }
    }
    private void txtBuscar_Leave(object sender, EventArgs e)
    {
      DGridView.BuscarDepartamento();
    }
    private void btnBuscar_Click(object sender, EventArgs e)
    {
      DGridView.BuscarDepartamento();
    }
    private void btnSeleccionar_Click(object sender, EventArgs e)
    {

    }
    private void btnCerrar_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
