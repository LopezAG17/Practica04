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
  public partial class frmConsultaPosicion : Form
  {
    public frmConsultaPosicion()
    {
      InitializeComponent();
    }
    private void frmConsultaPosicion_Load(object sender, EventArgs e)
    {

    }
    private void frmConsultaPosicion_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Escape)
      {
        this.Close();
      }
    }
    private void txtBuscar_Leave(object sender, EventArgs e)
    {
      DGridView.BuscarPosicion();
    }
    private void btnBuscar_Click(object sender, EventArgs e)
    {
      DGridView.BuscarPosicion();
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
