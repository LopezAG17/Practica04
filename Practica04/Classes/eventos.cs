using System.Windows.Forms;
namespace Practica04
{
  public static class Limpiar
  {
    public static void FormularioPos()
    {
      frmPosicion.txtDepartamento.Clear();
      frmPosicion.txtFabrica.Clear();
      frmPosicion.txtNombrePosicion.Clear();
      frmPosicion.txtPosicion.Clear();
      frmPosicion.lblDepartamento.Text = "";
      frmPosicion.lblFabricaNombre.Text = "";
    }
    public static void FormularioDep()
    {
      frmDepartamento.txtDepartamento.Clear();
      frmDepartamento.txtFabrica.Clear();
      frmDepartamento.txtNombreDepartamento.Clear();
      frmDepartamento.txtDepartamento.Clear();
      frmDepartamento.lblFabrica.Text = "";
      frmDepartamento.lblFabricaNombre.Text = "";
    }

    public static void FormularioFab()
    {
      frmFabrica.txtLocalidad.Clear();
      frmFabrica.txtFabrica.Clear();
      frmFabrica.txtNombreFabrica.Clear();
      frmFabrica.lblLocalidad.Text = "";
    }
  }
  public class Diseño
  {
    public void DGV_Posiciones()
    {
    }
  }
  
}
