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
      txtDepartamento.Focus();
    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
      SQl.Db.cnx.Open();


    }

    private void btnConsultaFabrica_Click(object sender, EventArgs e)
    {
      frmConsultaDep consultaDep = new frmConsultaDep();
      consultaDep.Show();

    }
  }
}

