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
    public string varf1;
    public string varf2;
    public frmConsultaPosicion()
    {
      InitializeComponent();
    }
    private void frmConsultaPosicion_Load(object sender, EventArgs e)
    {
      this.KeyPreview = true;     // puedo presionar la tecla escape
      E_Load.Posiciones();
    }
    private void frmConsultaPosicion_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Escape)
      {
        this.Close();
      }
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
    private void txtBuscar_Leave(object sender, EventArgs e)
    {
      DGridView.BuscarPosicion();
    }
    private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      btnSeleccionar.PerformClick();
    }
    private void btnBuscar_Click(object sender, EventArgs e)
    {
      DGridView.BuscarPosicion();
    }
    private void btnSeleccionar_Click(object sender, EventArgs e)
    {
      try
      { //Data grid View 
        varf1 = dgv.CurrentRow.Cells[0].Value.ToString();
        varf2 = dgv.CurrentRow.Cells[1].Value.ToString();
        this.Close();
      }
      catch
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
