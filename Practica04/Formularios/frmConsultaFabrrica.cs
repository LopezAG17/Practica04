using System;
using System.Windows.Forms;

namespace Practica04
{
  public partial class frmConsultaFabrica : Form
  {
    public frmConsultaFabrica()
    {
      InitializeComponent();
    }
    private void frmConsultaFabrica_Load(object sender, EventArgs e)
    {
      this.KeyPreview = true;     // puedo presionar la tecla escape
      E_Load.Fabricas();
    }
    private void frmConsultaFabrica_KeyDown(object sender, KeyEventArgs e)
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
      DGridView.BuscarFabrica();
    }
    private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      btnSeleccionar.PerformClick();
    }
    private void btnBuscar_Click(object sender, EventArgs e)
    {
      DGridView.BuscarFabrica();
    }
    private void btnSeleccionar_Click(object sender, EventArgs e)
    {
      try
      {
        DialogResult = DialogResult.OK;
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
