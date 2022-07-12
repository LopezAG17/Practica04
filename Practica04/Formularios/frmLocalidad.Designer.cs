namespace Practica04
{
  partial class frmLocalidad
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
      btnFabrica = new System.Windows.Forms.Button();
      btnPosiciones = new System.Windows.Forms.Button();
      btnDepatamento = new System.Windows.Forms.Button();
      btnSalir = new System.Windows.Forms.Button();
      bntBorrar = new System.Windows.Forms.Button();
      btnLimpiar = new System.Windows.Forms.Button();
      btnGuardar = new System.Windows.Forms.Button();
      btnConsulta = new System.Windows.Forms.Button();
      label5 = new System.Windows.Forms.Label();
      txtNombreLocalidad = new System.Windows.Forms.TextBox();
      txtLocalidad = new System.Windows.Forms.TextBox();
      lblTxNmDep = new System.Windows.Forms.Label();
      lblTxIDDep = new System.Windows.Forms.Label();
      SuspendLayout();
      // 
      // btnFabrica
      // 
      btnFabrica.BackColor = System.Drawing.SystemColors.InactiveCaption;
      btnFabrica.Location = new System.Drawing.Point(365, 128);
      btnFabrica.Name = "btnFabrica";
      btnFabrica.Size = new System.Drawing.Size(150, 34);
      btnFabrica.TabIndex = 69;
      btnFabrica.Text = "Maestro de Fabrica";
      btnFabrica.UseVisualStyleBackColor = false;
      btnFabrica.Click += new System.EventHandler(btnFabrica_Click);
      // 
      // btnPosiciones
      // 
      btnPosiciones.BackColor = System.Drawing.SystemColors.InactiveCaption;
      btnPosiciones.Location = new System.Drawing.Point(188, 128);
      btnPosiciones.Name = "btnPosiciones";
      btnPosiciones.Size = new System.Drawing.Size(150, 34);
      btnPosiciones.TabIndex = 68;
      btnPosiciones.Text = "Maestro Posiciones";
      btnPosiciones.UseVisualStyleBackColor = false;
      btnPosiciones.Click += new System.EventHandler(btnPosiciones_Click);
      // 
      // btnDepatamento
      // 
      btnDepatamento.BackColor = System.Drawing.SystemColors.InactiveCaption;
      btnDepatamento.Location = new System.Drawing.Point(22, 128);
      btnDepatamento.Name = "btnDepatamento";
      btnDepatamento.Size = new System.Drawing.Size(146, 34);
      btnDepatamento.TabIndex = 67;
      btnDepatamento.Text = "Maestro de Departamento";
      btnDepatamento.UseVisualStyleBackColor = false;
      btnDepatamento.Click += new System.EventHandler(btnDepatamento_Click);
      // 
      // btnSalir
      // 
      btnSalir.BackColor = System.Drawing.SystemColors.InactiveCaption;
      btnSalir.Location = new System.Drawing.Point(433, 168);
      btnSalir.Name = "btnSalir";
      btnSalir.Size = new System.Drawing.Size(101, 34);
      btnSalir.TabIndex = 62;
      btnSalir.Text = "Salir";
      btnSalir.UseVisualStyleBackColor = false;
      btnSalir.Click += new System.EventHandler(btnSalir_Click);
      // 
      // bntBorrar
      // 
      bntBorrar.BackColor = System.Drawing.SystemColors.InactiveCaption;
      bntBorrar.Location = new System.Drawing.Point(219, 168);
      bntBorrar.Name = "bntBorrar";
      bntBorrar.Size = new System.Drawing.Size(101, 34);
      bntBorrar.TabIndex = 61;
      bntBorrar.Text = "Borrar";
      bntBorrar.UseVisualStyleBackColor = false;
      bntBorrar.Click += new System.EventHandler(bntBorrar_Click);
      // 
      // btnLimpiar
      // 
      btnLimpiar.BackColor = System.Drawing.SystemColors.InactiveCaption;
      btnLimpiar.Location = new System.Drawing.Point(112, 168);
      btnLimpiar.Name = "btnLimpiar";
      btnLimpiar.Size = new System.Drawing.Size(101, 34);
      btnLimpiar.TabIndex = 60;
      btnLimpiar.Text = "Limpiar";
      btnLimpiar.UseVisualStyleBackColor = false;
      btnLimpiar.Click += new System.EventHandler(btnLimpiar_Click);
      // 
      // btnGuardar
      // 
      btnGuardar.BackColor = System.Drawing.SystemColors.InactiveCaption;
      btnGuardar.Location = new System.Drawing.Point(5, 168);
      btnGuardar.Name = "btnGuardar";
      btnGuardar.Size = new System.Drawing.Size(101, 34);
      btnGuardar.TabIndex = 59;
      btnGuardar.Text = "Guardar";
      btnGuardar.UseVisualStyleBackColor = false;
      btnGuardar.Click += new System.EventHandler(btnGuardar_Click);
      // 
      // btnConsulta
      // 
      btnConsulta.BackColor = System.Drawing.SystemColors.InactiveCaption;
      btnConsulta.Location = new System.Drawing.Point(253, 76);
      btnConsulta.Name = "btnConsulta";
      btnConsulta.Size = new System.Drawing.Size(27, 20);
      btnConsulta.TabIndex = 58;
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
      label5.TabIndex = 57;
      label5.Text = "Maestro Localidad";
      label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // txtNombreLocalidad
      // 
      txtNombreLocalidad.Location = new System.Drawing.Point(188, 102);
      txtNombreLocalidad.Name = "txtNombreLocalidad";
      txtNombreLocalidad.Size = new System.Drawing.Size(360, 20);
      txtNombreLocalidad.TabIndex = 54;
      // 
      // txtLocalidad
      // 
      txtLocalidad.Location = new System.Drawing.Point(188, 76);
      txtLocalidad.Name = "txtLocalidad";
      txtLocalidad.Size = new System.Drawing.Size(65, 20);
      txtLocalidad.TabIndex = 53;
      txtLocalidad.Leave += new System.EventHandler(txtLocalidad_Leave);
      // 
      // lblTxNmDep
      // 
      lblTxNmDep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      lblTxNmDep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      lblTxNmDep.Location = new System.Drawing.Point(13, 102);
      lblTxNmDep.Name = "lblTxNmDep";
      lblTxNmDep.Size = new System.Drawing.Size(169, 20);
      lblTxNmDep.TabIndex = 56;
      lblTxNmDep.Text = "Nombre Localidad";
      // 
      // lblTxIDDep
      // 
      lblTxIDDep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      lblTxIDDep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      lblTxIDDep.Location = new System.Drawing.Point(13, 76);
      lblTxIDDep.Name = "lblTxIDDep";
      lblTxIDDep.Size = new System.Drawing.Size(169, 20);
      lblTxIDDep.TabIndex = 55;
      lblTxIDDep.Text = "ID Localidad";
      // 
      // frmLocalidad
      // 
      AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      ClientSize = new System.Drawing.Size(560, 221);
      Controls.Add(btnFabrica);
      Controls.Add(btnPosiciones);
      Controls.Add(btnDepatamento);
      Controls.Add(btnSalir);
      Controls.Add(bntBorrar);
      Controls.Add(btnLimpiar);
      Controls.Add(btnGuardar);
      Controls.Add(btnConsulta);
      Controls.Add(label5);
      Controls.Add(txtNombreLocalidad);
      Controls.Add(txtLocalidad);
      Controls.Add(lblTxNmDep);
      Controls.Add(lblTxIDDep);
      Name = "frmLocalidad";
      Text = "Maestro Localidad";
      StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      Load += new System.EventHandler(frmLocalidad_Load);
      ResumeLayout(false);
      PerformLayout();

    }

    #endregion

    public static System.Windows.Forms.Button btnFabrica;
    public static System.Windows.Forms.Button btnPosiciones;
    public static System.Windows.Forms.Button btnDepatamento;
    public static System.Windows.Forms.Button btnSalir;
    public static System.Windows.Forms.Button bntBorrar;
    public static System.Windows.Forms.Button btnLimpiar;
    public static System.Windows.Forms.Button btnGuardar;
    public static System.Windows.Forms.Button btnConsulta;
    public static System.Windows.Forms.Label label5;
    public static System.Windows.Forms.TextBox txtNombreLocalidad;
    public static System.Windows.Forms.TextBox txtLocalidad;
    public static System.Windows.Forms.Label lblTxNmDep;
    public static System.Windows.Forms.Label lblTxIDDep;
  }
}