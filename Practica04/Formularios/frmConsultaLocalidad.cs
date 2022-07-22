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
  public partial class frmConsultaLocalidad : Form
  {
    public frmConsultaLocalidad()
    {
      InitializeComponent();
    }

    private void frmConsultaLocalidad_Load(object sender, EventArgs e)
    {
      this.KeyPreview = true;
      E_Load.Localidades();
    }
    private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
    {
      if ((int)e.KeyChar == (int)Keys.Enter)
      {
        e.Handled = true;
        if (txtBuscar.Text.Trim() != string.Empty)
        {
          btnBuscar.PerformClick();
        }
      }
    }

    private void frmConsultaLocalidad_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Escape)
      {
        this.Close();
      }
    }
    private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      btnSeleccionar.PerformClick();
    }

    private void txtBuscar_Leave(object sender, EventArgs e)
    {
      DGridView.BuscarLocalidad();
    }
    private void btnBuscar_Click(object sender, EventArgs e)
    {
      DGridView.BuscarLocalidad();
    }

    private void btnSeleccionar_Click(object sender, EventArgs e)
    {
      try
      {
        DialogResult = DialogResult.OK;
        this.Close();
      }
      catch (Exception)
      {
        //
      }
    }
    private void btnCerrar_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
