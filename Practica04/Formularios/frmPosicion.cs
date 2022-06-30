using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;  // habilita el cliente de SQL

namespace Practica04
{
  public partial class frmPosicion : Form
  {
    // -------------------------------------------------------
    // aqui declaramos las variable que utilizamos dentro del
    // formulario 
    // -------------------------------------------------------
    string NombreCargo;
    string NombreDepartamento;
    string NombreFabrica;
    // -------------------------------------------------------

    public frmPosicion()
    {
      InitializeComponent();
      // ------------------------------------------------------- 
      // le indica al formulario que se coloque al centro de la pantalla
      // esto tambien se puede hacer por medio de la propiedades del form.
      // -------------------------------------------------------
      this.StartPosition = FormStartPosition.CenterScreen;
    }

    private void frmPosicion_Load(object sender, EventArgs e)
    {
      // -------------------------------------------------------
      // cambia el texto de la cabecera del formulario
      // -------------------------------------------------------
      this.Text = HMenu.cia + " Maestro de Cargos y/o Posiciones";
    }


    // ------------------------------------------------------------------
    // Eventos ID de la posición 
    // ------------------------------------------------------------------
    private void txtPosicion_KeyPress(object sender, KeyPressEventArgs e)
    {
      // aqui pregunta si la tecla de funcion que fue presionada es ENTER
      if ((int)e.KeyChar == (int)Keys.Enter)
      {
        e.Handled = true;

        // esta preguntando si el contenido del textbox es diferente de vacio
        if (txtPosicion.Text.Trim() != string.Empty)
        {
          // aqui esta preguntado que si lo digitado es solo numero y si la tecla de funcion presionada es diferente la tecla BackSpace
          if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
          {
            // aqui mueve el foco del cursor al siguiente textbox en este caso es txtNombrePosicion
            txtNombrePosicion.Focus();
          }
          else  // else significa... de lo contrario haz esto
          {
            MessageBox.Show("Solo números", "MSJ",
            MessageBoxButtons.OK,
            MessageBoxIcon.Exclamation
            );
            e.Handled = true;
            return;
          }
        }
      }
    }

    // el evento LEAVE se utiliza cuando el cursor sale del textBox
    private void txtPosicion_Leave(object sender, EventArgs e)
    {
      // esta preguntando si el contenido del textbox es diferente de vacio
      if (txtPosicion.Text.Trim() != string.Empty)
      {
        // ----------------------------------------------------------------------
        // Busco.CargosPosiciones
        // Busco...                              es la clase que se esta invocando
        // CargosPosiciones...                   es el metodo dento de la clase
        // Convert.ToString(txtPosicion.Text)... es el parametro enviado al metodo de la clase, convertido en un string
        // ----------------------------------------------------------------------
        txtNombrePosicion.Text = Busco.CargosPosiciones(Convert.ToString(txtPosicion.Text));
        //txtNombrePosicion.Text = NombreCargo;
        buscar_datos();
      }
    }


    // ------------------------------------------------------------------
    // Eventos TextBox Nombre de la posición el colaborador
    // ------------------------------------------------------------------
    private void txtNombrePosicion_KeyPress(object sender, KeyPressEventArgs e)
    {
      if ((int)e.KeyChar == (int)Keys.Enter)
      {
        e.Handled = true;
        if (txtNombrePosicion.Text.Trim() != string.Empty)
        {
          txtDepartamento.Focus();
        }
      }
    }

    private void txtNombrePosicion_Leave(object sender, EventArgs e)
    {
      txtDepartamento.Focus();
    }



    // ------------------------------------------------------------------
    // Eventos TextBox Departamento al que pertenece el colaborador
    // ------------------------------------------------------------------
    private void txtDepartamento_KeyPress(object sender, KeyPressEventArgs e)
    {
      if ((int)e.KeyChar == (int)Keys.Enter)
      {
        e.Handled = true;
        if (txtDepartamento.Text.Trim() != string.Empty)
        {
          txtFabrica.Focus();
        }
      }
    }

    private void txtDepartamento_Leave(object sender, EventArgs e)
    {
      if (txtDepartamento.Text.Trim() != string.Empty)
      {
        // ----------------------------------------------------------------------
        // Busco.NombreDepartamento
        // Busco...                                  es la clase que se esta invocando
        // NombreDepartamento...                     es el metodo dento de la clase
        // Convert.ToString(txtDepartamento.Text)... es el parametro enviado al metodo de la clase, convertido en un string
        // ----------------------------------------------------------------------

        lblDepartamento.Text = Busco.Departamento(Convert.ToString(txtDepartamento.Text)); // valor retornado por la clase es asignado al TextBox


        // lblDepartamento.Text = NombreDepartamento;   // asigna el valor contenido en la variable al textbox
      }
    }


    // ------------------------------------------------------------------
    // Eventos TextBox Fabrica a la que pertenece el departamento
    // ------------------------------------------------------------------
    private void txtFabrica_KeyPress(object sender, KeyPressEventArgs e)
    {
      if ((int)e.KeyChar == (int)Keys.Enter)
      {
        e.Handled = true;
        if (txtFabrica.Text.Trim() != string.Empty)
        {
          btnGuardar.Focus();
        }
      }
    }

    private void txtFabrica_Leave(object sender, EventArgs e)
    {
      if (txtFabrica.Text.Trim() != string.Empty)
      {
        NombreFabrica = Busco.Fabrica(Convert.ToString(txtFabrica.Text));
        lblFabricaNombre.Text = NombreFabrica;
      }
    }



    // ------------------------------------------------------------------
    // Evento Boton Guardar
    // ------------------------------------------------------------------
    private void btnGuardar_Click(object sender, EventArgs e)
    {
      BorrarInformacion(Convert.ToString(txtPosicion.Text));  // Borra la informacion en la tabla POSICIONES en la base de datos antes de grabar
                                                              // y se envia Convert.ToString(txtPosicion.Text) como parametro que es recibido 
                                                              // por la funcion BorrarInformacion.

      GuardarInformacion();                                   // Inserta la informacion en la tabla POSICIONES en la base de datos
      btnLimpiar.PerformClick();                              // invoca el boto limpiar (btnLimpiar) y ejecuta su contenido
    }

    // ------------------------------------------------------------------
    // Evento Boton Limpiar
    // ------------------------------------------------------------------
    private void btnLimpiar_Click(object sender, EventArgs e)
    {
      Limpiar.Posicion();  // viaja hasta la funcion LimpiarEsteFormulario() y ejecuta su contenido
      txtPosicion.Focus();      // mueve el cursor al textBox indicado
    }

    // ------------------------------------------------------------------
    // Evento Boton Borrar
    // ------------------------------------------------------------------
    private void bntBorrar_Click(object sender, EventArgs e)
    {
      // Borra la informacion en la tabla POSICIONES en la base de datos antes de grabar
      // y se envia Convert.ToString(txtPosicion.Text) como parametro que es recibido 
      // por la funcion BorrarInformacion.
      BorrarInformacion(Convert.ToString(txtPosicion.Text));
    }

    // ------------------------------------------------------------------
    // Evento Boton Consultar
    // ------------------------------------------------------------------
    private void bntConsulta_Click(object sender, EventArgs e)
    {

    }

    // ------------------------------------------------------------------
    // Evento Boton Salir
    // ------------------------------------------------------------------
    private void btnSalir_Click(object sender, EventArgs e)
    {
      this.Close(); // Cierra este formulario
    }

    // ------------------------------------------------------------------
    // Evento Boton Cnsulta Departamento
    // ------------------------------------------------------------------
    private void btnConsultaDepto_Click(object sender, EventArgs e)
    {

    }

    // ------------------------------------------------------------------
    // Evento Boton Consulta Fabrica
    // ------------------------------------------------------------------
    private void btnConsultaFabrica_Click(object sender, EventArgs e)
    {

    }


    // ----------------------------------------------------------
    // esta funcion recibe un parametro de entrada de tipo string
    // ----------------------------------------------------------
    private void BorrarInformacion(string numPosicion)
    {
      // ----------------------------------------------------------
      // se crea la conexion hacia SQL
      // cnn.db ... contiene el string conexion a la base de datos
      // cnndel ... es el objeto creado que manipulara la conexion a la base de datos
      // ----------------------------------------------------------
      SqlConnection cnndel = new SqlConnection(cnn.db);
      cnndel.Open();  // aqui abre la base de datos

      // aqui se arma el script de sql y contiene un parametro @RG
      string miQuery = "DELETE FROM POSICIONES WHERE IDPOSICION = @RG;";

      SqlCommand queri = new SqlCommand(miQuery, cnndel);  // crea el comando para ejecutar el script de sql
      queri.Parameters.AddWithValue("@RG", numPosicion);   // aqui se le envia la data contenida en numPosicion al parametro @RG
      queri.ExecuteNonQuery();                             // ejecuta el query

      cnndel.Close();                                      // cierra la conexion a la base de datos
    }

    private void GuardarInformacion()
    {
      SqlConnection cnGuardar = new SqlConnection(cnn.db);
      cnGuardar.Open();   // aqui abre la base de datos
      // script sql para insertar data dentro de la tabla POSICIONES por medio de parametros de entrada
      string stQuery = "INSERT INTO POSICIONES (IDPOSICION, NOMBREDEPOSICION, FABRICA, DEPARTAMENTO ) VALUES (@A0, @A1, @A2, @A3 );";
      SqlCommand miqueri = new SqlCommand(stQuery, cnGuardar); // crea el comando para ejecutar el script de sql

      miqueri.Parameters.AddWithValue("@A0", Convert.ToString(txtPosicion.Text));
      miqueri.Parameters.AddWithValue("@A1", Convert.ToString(txtNombrePosicion.Text));
      miqueri.Parameters.AddWithValue("@A2", Convert.ToString(txtDepartamento.Text));
      miqueri.Parameters.AddWithValue("@A3", Convert.ToString(txtFabrica.Text));

      miqueri.ExecuteNonQuery(); // ejecuta el query
      cnGuardar.Close();         // cierra la conexion a la base de datos
    }

    private void buscar_datos()
    {
      SqlConnection cnxn = new SqlConnection(cnn.db);
      cnxn.Open();

      SqlCommand cmmnd = new SqlCommand("    SELECT a.NombreDePosicion,  " +
                                        "           a.Fabrica,  " +
                                        "           a.Departamento,  " +
                                        "           B.NombreDefabrica,   " +
                                        "           C.NombreDepartamento  " +
                                        "      FROM POSICIONES   A " +
                                        " LEFT join FABRICA      B on a.Fabrica      = b.IDfabrica " +
                                        " LEFT join DEPARTAMENTO C on A.Departamento = C.IDdepartamento " +
                                        "WHERE IDPOSICION =@PV", cnxn);

      cmmnd.Parameters.AddWithValue("@PV", txtPosicion.Text);

      SqlDataReader recordn = cmmnd.ExecuteReader();

      if (recordn.Read())
      {
        txtNombrePosicion.Text = Convert.ToString(recordn["NOMBREDEPOSICION"]);
        txtDepartamento.Text = Convert.ToString(recordn["DEPARTAMENTO"]);
        txtFabrica.Text = Convert.ToString(recordn["FABRICA"]);

        lblDepartamento.Text = Convert.ToString(recordn["NombreDefabrica"]);
        lblFabricaNombre.Text = Convert.ToString(recordn["NombreDepartamento"]);
      }

      cmmnd.Dispose();
      cnxn.Close();
    }



    private void btnConsulta_Click(object sender, EventArgs e)
    {
      //txtPosicion.Focus();

      //frmVENAREA frmVENAREA = new frmVENAREA();
      //frmVENAREA.txtBusqueda.Text = Convert.ToString(1);
      //DialogResult res = frmVENAREA.ShowDialog();

      //if (res == DialogResult.OK)
      //{
      //    //txtAnuncia.Text = frmVENAREA.varf1;
      //    //lblAnuncia.Text = frmVENAREA.varf2;
      //}
    }
  }
}
