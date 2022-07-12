namespace Practica04
{
  partial class frmDepartamento
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      btnConsulta = new System.Windows.Forms.Button();
      label5 = new System.Windows.Forms.Label();
      lblFabricaNombre = new System.Windows.Forms.Label();
      txtNombreDepartamento = new System.Windows.Forms.TextBox();
      txtDepartamento = new System.Windows.Forms.TextBox();
      lblTxNmDep = new System.Windows.Forms.Label();
      lblTxIDDep = new System.Windows.Forms.Label();
      btnSalir = new System.Windows.Forms.Button();
      bntBorrar = new System.Windows.Forms.Button();
      btnLimpiar = new System.Windows.Forms.Button();
      btnGuardar = new System.Windows.Forms.Button();
      btnConsultaFabrica = new System.Windows.Forms.Button();
      lblFabrica = new System.Windows.Forms.Label();
      txtFabrica = new System.Windows.Forms.TextBox();
      label4 = new System.Windows.Forms.Label();
      btnFabrica = new System.Windows.Forms.Button();
      btnPosiciones = new System.Windows.Forms.Button();
      btnLocalidad = new System.Windows.Forms.Button();
      SuspendLayout();
      // 
      // btnConsulta
      // 
      btnConsulta.BackColor = System.Drawing.SystemColors.InactiveCaption;
      btnConsulta.Location = new System.Drawing.Point(253, 76);
      btnConsulta.Name = "btnConsulta";
      btnConsulta.Size = new System.Drawing.Size(27, 20);
      btnConsulta.TabIndex = 26;
      btnConsulta.Text = "...";
      btnConsulta.UseVisualStyleBackColor = false;
      btnConsulta.Click += new System.EventHandler(btnConsulta_Click);
      // 
      // label5
      // 
      label5.BackColor = System.Drawing.Color.CornflowerBlue;
      label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      label5.ForeColor = System.Drawing.Color.White;
      label5.Location = new System.Drawing.Point(0, -1);
      label5.Name = "label5";
      label5.Size = new System.Drawing.Size(562, 49);
      label5.TabIndex = 25;
      label5.Text = " Maestro de  Departamentos";
      label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // lblFabricaNombre
      // 
      lblFabricaNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      lblFabricaNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      lblFabricaNombre.Location = new System.Drawing.Point(286, 75);
      lblFabricaNombre.Name = "lblFabricaNombre";
      lblFabricaNombre.Size = new System.Drawing.Size(262, 20);
      lblFabricaNombre.TabIndex = 24;
      // 
      // txtNombreDepartamento
      // 
      txtNombreDepartamento.Location = new System.Drawing.Point(188, 102);
      txtNombreDepartamento.Name = "txtNombreDepartamento";
      txtNombreDepartamento.Size = new System.Drawing.Size(360, 20);
      txtNombreDepartamento.TabIndex = 18;
      // 
      // txtDepartamento
      // 
      txtDepartamento.Location = new System.Drawing.Point(188, 76);
      txtDepartamento.Name = "txtDepartamento";
      txtDepartamento.Size = new System.Drawing.Size(65, 20);
      txtDepartamento.TabIndex = 17;
      txtDepartamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txtDepartamento_KeyPress);
      txtDepartamento.Leave += new System.EventHandler(txtDepartamento_Leave);
      // 
      // lblTxNmDep
      // 
      lblTxNmDep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      lblTxNmDep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      lblTxNmDep.Location = new System.Drawing.Point(13, 102);
      lblTxNmDep.Name = "lblTxNmDep";
      lblTxNmDep.Size = new System.Drawing.Size(169, 20);
      lblTxNmDep.TabIndex = 22;
      lblTxNmDep.Text = "Nombre del Departamento";
      // 
      // lblTxIDDep
      // 
      lblTxIDDep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      lblTxIDDep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      lblTxIDDep.Location = new System.Drawing.Point(13, 76);
      lblTxIDDep.Name = "lblTxIDDep";
      lblTxIDDep.Size = new System.Drawing.Size(169, 20);
      lblTxIDDep.TabIndex = 21;
      lblTxIDDep.Text = "ID Derpartamento";
      // 
      // btnSalir
      // 
      btnSalir.BackColor = System.Drawing.SystemColors.InactiveCaption;
      btnSalir.Location = new System.Drawing.Point(447, 189);
      btnSalir.Name = "btnSalir";
      btnSalir.Size = new System.Drawing.Size(101, 34);
      btnSalir.TabIndex = 30;
      btnSalir.Text = "Salir";
      btnSalir.UseVisualStyleBackColor = false;
      btnSalir.Click += new System.EventHandler(btnSalir_Click);
      // 
      // bntBorrar
      // 
      bntBorrar.BackColor = System.Drawing.SystemColors.InactiveCaption;
      bntBorrar.Location = new System.Drawing.Point(233, 189);
      bntBorrar.Name = "bntBorrar";
      bntBorrar.Size = new System.Drawing.Size(101, 34);
      bntBorrar.TabIndex = 29;
      bntBorrar.Text = "Borrar";
      bntBorrar.UseVisualStyleBackColor = false;
      bntBorrar.Click += new System.EventHandler(bntBorrar_Click);
      // 
      // btnLimpiar
      // 
      btnLimpiar.BackColor = System.Drawing.SystemColors.InactiveCaption;
      btnLimpiar.Location = new System.Drawing.Point(126, 189);
      btnLimpiar.Name = "btnLimpiar";
      btnLimpiar.Size = new System.Drawing.Size(101, 34);
      btnLimpiar.TabIndex = 28;
      btnLimpiar.Text = "Limpiar";
      btnLimpiar.UseVisualStyleBackColor = false;
      btnLimpiar.Click += new System.EventHandler(btnLimpiar_Click);
      // 
      // btnGuardar
      // 
      btnGuardar.BackColor = System.Drawing.SystemColors.InactiveCaption;
      btnGuardar.Location = new System.Drawing.Point(19, 189);
      btnGuardar.Name = "btnGuardar";
      btnGuardar.Size = new System.Drawing.Size(101, 34);
      btnGuardar.TabIndex = 27;
      btnGuardar.Text = "Guardar";
      btnGuardar.UseVisualStyleBackColor = false;
      btnGuardar.Click += new System.EventHandler(btnGuardar_Click);
      // 
      // btnConsultaFabrica
      // 
      btnConsultaFabrica.BackColor = System.Drawing.SystemColors.InactiveCaption;
      btnConsultaFabrica.Location = new System.Drawing.Point(253, 127);
      btnConsultaFabrica.Name = "btnConsultaFabrica";
      btnConsultaFabrica.Size = new System.Drawing.Size(27, 22);
      btnConsultaFabrica.TabIndex = 32;
      btnConsultaFabrica.Text = "...";
      btnConsultaFabrica.UseVisualStyleBackColor = false;
      btnConsultaFabrica.Click += new System.EventHandler(btnConsultaFabrica_Click_1);
      // 
      // lblFabrica
      // 
      lblFabrica.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      lblFabrica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      lblFabrica.Location = new System.Drawing.Point(286, 128);
      lblFabrica.Name = "lblFabrica";
      lblFabrica.Size = new System.Drawing.Size(262, 20);
      lblFabrica.TabIndex = 34;
      // 
      // txtFabrica
      // 
      txtFabrica.Location = new System.Drawing.Point(188, 128);
      txtFabrica.Name = "txtFabrica";
      txtFabrica.Size = new System.Drawing.Size(65, 20);
      txtFabrica.TabIndex = 31;
      // 
      // label4
      // 
      label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      label4.Location = new System.Drawing.Point(13, 128);
      label4.Name = "label4";
      label4.Size = new System.Drawing.Size(169, 20);
      label4.TabIndex = 33;
      label4.Text = "ID Fabrica";
      // 
      // btnFabrica
      // 
      btnFabrica.BackColor = System.Drawing.SystemColors.InactiveCaption;
      btnFabrica.Location = new System.Drawing.Point(206, 151);
      btnFabrica.Name = "btnFabrica";
      btnFabrica.Size = new System.Drawing.Size(150, 34);
      btnFabrica.TabIndex = 36;
      btnFabrica.Text = "Maestro de Fabrica";
      btnFabrica.UseVisualStyleBackColor = false;
      btnFabrica.Click += new System.EventHandler(btnFabrica_Click);
      // 
      // btnPosiciones
      // 
      btnPosiciones.BackColor = System.Drawing.SystemColors.InactiveCaption;
      btnPosiciones.Location = new System.Drawing.Point(36, 151);
      btnPosiciones.Name = "btnPosiciones";
      btnPosiciones.Size = new System.Drawing.Size(146, 34);
      btnPosiciones.TabIndex = 35;
      btnPosiciones.Text = "Maestro de Posiciones";
      btnPosiciones.UseVisualStyleBackColor = false;
      btnPosiciones.Click += new System.EventHandler(btnPosiciones_Click);
      // 
      // btnLocalidad
      // 
      btnLocalidad.BackColor = System.Drawing.SystemColors.InactiveCaption;
      btnLocalidad.Location = new System.Drawing.Point(379, 151);
      btnLocalidad.Name = "btnLocalidad";
      btnLocalidad.Size = new System.Drawing.Size(150, 34);
      btnLocalidad.TabIndex = 37;
      btnLocalidad.Text = "Maestro de Localidad";
      btnLocalidad.UseVisualStyleBackColor = false;
      btnLocalidad.Click += new System.EventHandler(btnLocalidad_Click);

      // 
      // frmDepartamento
      // 
      AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      BackColor = System.Drawing.SystemColors.ButtonFace;
      ClientSize = new System.Drawing.Size(560, 235);
      Controls.Add(btnLocalidad);
      Controls.Add(btnFabrica);
      Controls.Add(btnPosiciones);
      Controls.Add(btnConsultaFabrica);
      Controls.Add(lblFabrica);
      Controls.Add(txtFabrica);
      Controls.Add(label4);
      Controls.Add(btnSalir);
      Controls.Add(bntBorrar);
      Controls.Add(btnLimpiar);
      Controls.Add(btnGuardar);
      Controls.Add(btnConsulta);
      Controls.Add(label5);
      Controls.Add(lblFabricaNombre);
      Controls.Add(txtNombreDepartamento);
      Controls.Add(txtDepartamento);
      Controls.Add(lblTxNmDep);
      Controls.Add(lblTxIDDep);
      Name = "frmDepartamento";
      StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      Text = "frmDepartamento";
      Load += new System.EventHandler(frmDepartamento_Load);
      KeyDown += new System.Windows.Forms.KeyEventHandler(frmDepartamento_KeyDown);
      ResumeLayout(false);
      PerformLayout();

    }

    #endregion

    public static System.Windows.Forms.Button btnLocalidad;
    public static System.Windows.Forms.Button btnConsulta;
    public static System.Windows.Forms.Label label5;
    public static System.Windows.Forms.Label lblFabricaNombre;
    public static System.Windows.Forms.TextBox txtNombreDepartamento;
    public static System.Windows.Forms.TextBox txtDepartamento;
    public static System.Windows.Forms.Label lblTxNmDep;
    public static System.Windows.Forms.Label lblTxIDDep;
    public static System.Windows.Forms.Button btnSalir;
    public static System.Windows.Forms.Button bntBorrar;
    public static System.Windows.Forms.Button btnLimpiar;
    public static System.Windows.Forms.Button btnGuardar;
    public static System.Windows.Forms.Button btnConsultaFabrica;
    public static System.Windows.Forms.Label lblFabrica;
    public static System.Windows.Forms.TextBox txtFabrica;
    public static System.Windows.Forms.Label label4;
    public static System.Windows.Forms.Button btnFabrica;
    public static System.Windows.Forms.Button btnPosiciones;
  }
}