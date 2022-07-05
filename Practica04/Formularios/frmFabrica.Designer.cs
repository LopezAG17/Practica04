namespace Practica04
{
  partial class frmFabrica
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
      btnConsultaFabrica = new System.Windows.Forms.Button();
      lblLocalidad = new System.Windows.Forms.Label();
      txtLocalidad = new System.Windows.Forms.TextBox();
      label4 = new System.Windows.Forms.Label();
      btnSalir = new System.Windows.Forms.Button();
      bntBorrar = new System.Windows.Forms.Button();
      btnLimpiar = new System.Windows.Forms.Button();
      btnGuardar = new System.Windows.Forms.Button();
      btnConsulta = new System.Windows.Forms.Button();
      label5 = new System.Windows.Forms.Label();
      txtNombreFabrica = new System.Windows.Forms.TextBox();
      txtFabrica = new System.Windows.Forms.TextBox();
      lblTxNmDep = new System.Windows.Forms.Label();
      lblTxIDDep = new System.Windows.Forms.Label();
      SuspendLayout();
      // 
      // btnConsultaFabrica
      // 
      btnConsultaFabrica.BackColor = System.Drawing.SystemColors.InactiveCaption;
      btnConsultaFabrica.Location = new System.Drawing.Point(254, 128);
      btnConsultaFabrica.Name = "btnConsultaFabrica";
      btnConsultaFabrica.Size = new System.Drawing.Size(27, 22);
      btnConsultaFabrica.TabIndex = 47;
      btnConsultaFabrica.Text = "...";
      btnConsultaFabrica.UseVisualStyleBackColor = false;
      btnConsultaFabrica.Click += new System.EventHandler(btnConsultaFabrica_Click);
      // 
      // lblLocalidad
      // 
      lblLocalidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      lblLocalidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      lblLocalidad.Location = new System.Drawing.Point(286, 129);
      lblLocalidad.Name = "lblLocalidad";
      lblLocalidad.Size = new System.Drawing.Size(262, 20);
      lblLocalidad.TabIndex = 49;
      // 
      // txtLocalidad
      // 
      txtLocalidad.Location = new System.Drawing.Point(189, 129);
      txtLocalidad.Name = "txtLocalidad";
      txtLocalidad.Size = new System.Drawing.Size(65, 20);
      txtLocalidad.TabIndex = 46;
      // 
      // label4
      // 
      label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      label4.Location = new System.Drawing.Point(14, 129);
      label4.Name = "label4";
      label4.Size = new System.Drawing.Size(169, 20);
      label4.TabIndex = 48;
      label4.Text = "Localidad";
      // 
      // btnSalir
      // 
      btnSalir.BackColor = System.Drawing.SystemColors.InactiveCaption;
      btnSalir.Location = new System.Drawing.Point(448, 167);
      btnSalir.Name = "btnSalir";
      btnSalir.Size = new System.Drawing.Size(101, 34);
      btnSalir.TabIndex = 45;
      btnSalir.Text = "Salir";
      btnSalir.UseVisualStyleBackColor = false;
      btnSalir.Click += new System.EventHandler(btnSalir_Click);
      // 
      // bntBorrar
      // 
      bntBorrar.BackColor = System.Drawing.SystemColors.InactiveCaption;
      bntBorrar.Location = new System.Drawing.Point(234, 167);
      bntBorrar.Name = "bntBorrar";
      bntBorrar.Size = new System.Drawing.Size(101, 34);
      bntBorrar.TabIndex = 44;
      bntBorrar.Text = "Borrar";
      bntBorrar.UseVisualStyleBackColor = false;
      bntBorrar.Click += new System.EventHandler(bntBorrar_Click);
      // 
      // btnLimpiar
      // 
      btnLimpiar.BackColor = System.Drawing.SystemColors.InactiveCaption;
      btnLimpiar.Location = new System.Drawing.Point(127, 167);
      btnLimpiar.Name = "btnLimpiar";
      btnLimpiar.Size = new System.Drawing.Size(101, 34);
      btnLimpiar.TabIndex = 43;
      btnLimpiar.Text = "Limpiar";
      btnLimpiar.UseVisualStyleBackColor = false;
      btnLimpiar.Click += new System.EventHandler(btnLimpiar_Click_1);
      // 
      // btnGuardar
      // 
      btnGuardar.BackColor = System.Drawing.SystemColors.InactiveCaption;
      btnGuardar.Location = new System.Drawing.Point(20, 167);
      btnGuardar.Name = "btnGuardar";
      btnGuardar.Size = new System.Drawing.Size(101, 34);
      btnGuardar.TabIndex = 42;
      btnGuardar.Text = "Guardar";
      btnGuardar.UseVisualStyleBackColor = false;
      btnGuardar.Click += new System.EventHandler(btnGuardar_Click);
      // 
      // btnConsulta
      // 
      btnConsulta.BackColor = System.Drawing.SystemColors.InactiveCaption;
      btnConsulta.Location = new System.Drawing.Point(254, 77);
      btnConsulta.Name = "btnConsulta";
      btnConsulta.Size = new System.Drawing.Size(27, 20);
      btnConsulta.TabIndex = 41;
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
      label5.Location = new System.Drawing.Point(1, 0);
      label5.Name = "label5";
      label5.Size = new System.Drawing.Size(562, 49);
      label5.TabIndex = 40;
      label5.Text = "Maestro Fabrica";
      label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // txtNombreFabrica
      // 
      txtNombreFabrica.Location = new System.Drawing.Point(189, 103);
      txtNombreFabrica.Name = "txtNombreFabrica";
      txtNombreFabrica.Size = new System.Drawing.Size(360, 20);
      txtNombreFabrica.TabIndex = 36;
      // 
      // txtFabrica
      // 
      txtFabrica.Location = new System.Drawing.Point(189, 77);
      txtFabrica.Name = "txtFabrica";
      txtFabrica.Size = new System.Drawing.Size(65, 20);
      txtFabrica.TabIndex = 35;
      txtFabrica.Leave += new System.EventHandler(txtFabrica_Leave);
      // 
      // lblTxNmDep
      // 
      lblTxNmDep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      lblTxNmDep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      lblTxNmDep.Location = new System.Drawing.Point(14, 103);
      lblTxNmDep.Name = "lblTxNmDep";
      lblTxNmDep.Size = new System.Drawing.Size(169, 20);
      lblTxNmDep.TabIndex = 38;
      lblTxNmDep.Text = "Nombre Fabrica";
      // 
      // lblTxIDDep
      // 
      lblTxIDDep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      lblTxIDDep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      lblTxIDDep.Location = new System.Drawing.Point(14, 77);
      lblTxIDDep.Name = "lblTxIDDep";
      lblTxIDDep.Size = new System.Drawing.Size(169, 20);
      lblTxIDDep.TabIndex = 37;
      lblTxIDDep.Text = "ID Fabrica";
      // 
      // frmFabrica
      // 
      AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      ClientSize = new System.Drawing.Size(560, 215);
      Controls.Add(btnConsultaFabrica);
      Controls.Add(lblLocalidad);
      Controls.Add(txtLocalidad);
      Controls.Add(label4);
      Controls.Add(btnSalir);
      Controls.Add(bntBorrar);
      Controls.Add(btnLimpiar);
      Controls.Add(btnGuardar);
      Controls.Add(btnConsulta);
      Controls.Add(label5);
      Controls.Add(txtNombreFabrica);
      Controls.Add(txtFabrica);
      Controls.Add(lblTxNmDep);
      Controls.Add(lblTxIDDep);
      Name = "frmFabrica";
      Text = "Maestro Fabrica";
      Load += new System.EventHandler(frmFabrica_Load);
      ResumeLayout(false);
      PerformLayout();

    }

    #endregion

    public static System.Windows.Forms.Button btnConsultaFabrica;
    public static System.Windows.Forms.Label lblLocalidad;
    public static System.Windows.Forms.TextBox txtLocalidad;
    public static System.Windows.Forms.Label label4;
    public static System.Windows.Forms.Button btnSalir;
    public static System.Windows.Forms.Button bntBorrar;
    public static System.Windows.Forms.Button btnLimpiar;
    public static System.Windows.Forms.Button btnGuardar;
    public static System.Windows.Forms.Button btnConsulta;
    public static System.Windows.Forms.Label label5;
    public static System.Windows.Forms.TextBox txtNombreFabrica;
    public static System.Windows.Forms.TextBox txtFabrica;
    public static System.Windows.Forms.Label lblTxNmDep;
    public static System.Windows.Forms.Label lblTxIDDep;
  }
}