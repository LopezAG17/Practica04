using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica04
{
  public static class Limpiar
  {
    private void Posicion()
    {

      txtDepartamento.Clear();
      txtFabrica.Clear();
      txtNombrePosicion.Clear();
      txtPosicion.Clear();
      lblDepartamento.Text = "";
      lblFabricaNombre.Text = "";
    }
  }
}
