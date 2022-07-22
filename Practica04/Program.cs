using System;
using System.Windows.Forms;

namespace Practica04
{
  static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    // / </summary>

    /// -------------------------------------------------------------------------------
    /// cuando se corre el proyecto este programa es el primero que buscar y lo ejecuta
    /// -------------------------------------------------------------------------------
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new frmPosicion());   // aqui invoca el formulario a correr
    }
  }
}
