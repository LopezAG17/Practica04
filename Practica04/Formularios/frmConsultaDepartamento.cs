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
    public string varf0;
    public string varf1;
    public frmConsultaDepartamento()
    {
      InitializeComponent();
    }
    private void frmConsultaDepartamento_Load(object sender, EventArgs e)
    {
      this.KeyPreview = true;
      E_Load.Departamentos();

    }
    private void frmConsultaDepartamento_KeyDown(object sender, KeyEventArgs e)
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
      DGridView.BuscarDepartamento();
    }
    private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      btnSeleccionar.PerformClick();
    }
    private void btnBuscar_Click(object sender, EventArgs e)
    {
      DGridView.BuscarDepartamento();
    }
    private void btnSeleccionar_Click(object sender, EventArgs e)
    {
      try
      {
        varf0 = dgv.CurrentRow.Cells[0].Value.ToString();
        varf1 = dgv.CurrentRow.Cells[1].Value.ToString();
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
