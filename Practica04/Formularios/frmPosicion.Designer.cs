namespace Practica04
{
  partial class frmPosicion
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
      btnGuardar = new System.Windows.Forms.Button();
      btnLimpiar = new System.Windows.Forms.Button();
      bntBorrar = new System.Windows.Forms.Button();
      btnSalir = new System.Windows.Forms.Button();
      label1 = new System.Windows.Forms.Label();
      label2 = new System.Windows.Forms.Label();
      label3 = new System.Windows.Forms.Label();
      label4 = new System.Windows.Forms.Label();
      txtPosicion = new System.Windows.Forms.TextBox();
      txtNombrePosicion = new System.Windows.Forms.TextBox();
      txtDepartamento = new System.Windows.Forms.TextBox();
      txtFabrica = new System.Windows.Forms.TextBox();
      lblDepartamento = new System.Windows.Forms.Label();
      lblFabricaNombre = new System.Windows.Forms.Label();
      label5 = new System.Windows.Forms.Label();
      btnConsultaDepto = new System.Windows.Forms.Button();
      btnConsultaFabrica = new System.Windows.Forms.Button();
      btnConsulta = new System.Windows.Forms.Button();
      SuspendLayout();
      // 
      // btnGuardar
      // 
      btnGuardar.Location = new System.Drawing.Point(18, 232);
      btnGuardar.Name = "btnGuardar";
      btnGuardar.Size = new System.Drawing.Size(101, 34);
      btnGuardar.TabIndex = 6;
      btnGuardar.Text = "Guardar";
      btnGuardar.UseVisualStyleBackColor = true;
      btnGuardar.Click += new System.EventHandler(btnGuardar_Click);
      // 
      // btnLimpiar
      // 
      btnLimpiar.Location = new System.Drawing.Point(125, 232);
      btnLimpiar.Name = "btnLimpiar";
      btnLimpiar.Size = new System.Drawing.Size(101, 34);
      btnLimpiar.TabIndex = 7;
      btnLimpiar.Text = "Limpiar";
      btnLimpiar.UseVisualStyleBackColor = true;
      btnLimpiar.Click += new System.EventHandler(btnLimpiar_Click);
      // 
      // bntBorrar
      // 
      bntBorrar.Location = new System.Drawing.Point(232, 232);
      bntBorrar.Name = "bntBorrar";
      bntBorrar.Size = new System.Drawing.Size(101, 34);
      bntBorrar.TabIndex = 8;
      bntBorrar.Text = "Borrar";
      bntBorrar.UseVisualStyleBackColor = true;
      bntBorrar.Click += new System.EventHandler(bntBorrar_Click);
      // 
      // btnSalir
      // 
      btnSalir.Location = new System.Drawing.Point(446, 232);
      btnSalir.Name = "btnSalir";
      btnSalir.Size = new System.Drawing.Size(101, 34);
      btnSalir.TabIndex = 10;
      btnSalir.Text = "Salir";
      btnSalir.UseVisualStyleBackColor = true;
      btnSalir.Click += new System.EventHandler(btnSalir_Click);
      // 
      // label1
      // 
      label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      label1.Location = new System.Drawing.Point(12, 77);
      label1.Name = "label1";
      label1.Size = new System.Drawing.Size(169, 20);
      label1.TabIndex = 5;
      label1.Text = "ID Posición";
      // 
      // label2
      // 
      label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      label2.Location = new System.Drawing.Point(12, 103);
      label2.Name = "label2";
      label2.Size = new System.Drawing.Size(169, 20);
      label2.TabIndex = 6;
      label2.Text = "Nombre de la Posición";
      // 
      // label3
      // 
      label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      label3.Location = new System.Drawing.Point(12, 129);
      label3.Name = "label3";
      label3.Size = new System.Drawing.Size(169, 20);
      label3.TabIndex = 7;
      label3.Text = "ID Departamento";
      // 
      // label4
      // 
      label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      label4.Location = new System.Drawing.Point(12, 155);
      label4.Name = "label4";
      label4.Size = new System.Drawing.Size(169, 20);
      label4.TabIndex = 8;
      label4.Text = "ID Fabrica";
      // 
      // txtPosicion
      // 
      txtPosicion.Location = new System.Drawing.Point(187, 77);
      txtPosicion.Name = "txtPosicion";
      txtPosicion.Size = new System.Drawing.Size(65, 20);
      txtPosicion.TabIndex = 0;
      txtPosicion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txtPosicion_KeyPress);
      txtPosicion.Leave += new System.EventHandler(txtPosicion_Leave);
      // 
      // txtNombrePosicion
      // 
      txtNombrePosicion.Location = new System.Drawing.Point(187, 103);
      txtNombrePosicion.Name = "txtNombrePosicion";
      txtNombrePosicion.Size = new System.Drawing.Size(360, 20);
      txtNombrePosicion.TabIndex = 1;
      txtNombrePosicion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txtNombrePosicion_KeyPress);
      txtNombrePosicion.Leave += new System.EventHandler(txtNombrePosicion_Leave);
      // 
      // txtDepartamento
      // 
      txtDepartamento.Location = new System.Drawing.Point(187, 129);
      txtDepartamento.Name = "txtDepartamento";
      txtDepartamento.Size = new System.Drawing.Size(65, 20);
      txtDepartamento.TabIndex = 2;
      txtDepartamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txtDepartamento_KeyPress);
      txtDepartamento.Leave += new System.EventHandler(txtDepartamento_Leave);
      // 
      // txtFabrica
      // 
      txtFabrica.Location = new System.Drawing.Point(187, 155);
      txtFabrica.Name = "txtFabrica";
      txtFabrica.Size = new System.Drawing.Size(65, 20);
      txtFabrica.TabIndex = 4;
      txtFabrica.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txtFabrica_KeyPress);
      txtFabrica.Leave += new System.EventHandler(txtFabrica_Leave);
      // 
      // lblDepartamento
      // 
      lblDepartamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      lblDepartamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      lblDepartamento.Location = new System.Drawing.Point(285, 129);
      lblDepartamento.Name = "lblDepartamento";
      lblDepartamento.Size = new System.Drawing.Size(262, 20);
      lblDepartamento.TabIndex = 13;
      // 
      // lblFabricaNombre
      // 
      lblFabricaNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      lblFabricaNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      lblFabricaNombre.Location = new System.Drawing.Point(285, 155);
      lblFabricaNombre.Name = "lblFabricaNombre";
      lblFabricaNombre.Size = new System.Drawing.Size(262, 20);
      lblFabricaNombre.TabIndex = 14;
      // 
      // label5
      // 
      label5.BackColor = System.Drawing.Color.CornflowerBlue;
      label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      label5.ForeColor = System.Drawing.Color.White;
      label5.Location = new System.Drawing.Point(-1, 0);
      label5.Name = "label5";
      label5.Size = new System.Drawing.Size(559, 49);
      label5.TabIndex = 15;
      label5.Text = " Maestro de Cargos y/o Posiciones";
      label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // btnConsultaDepto
      // 
      btnConsultaDepto.Location = new System.Drawing.Point(252, 128);
      btnConsultaDepto.Name = "btnConsultaDepto";
      btnConsultaDepto.Size = new System.Drawing.Size(27, 22);
      btnConsultaDepto.TabIndex = 3;
      btnConsultaDepto.Text = "...";
      btnConsultaDepto.UseVisualStyleBackColor = true;
      btnConsultaDepto.Click += new System.EventHandler(btnConsultaDepto_Click);
      // 
      // btnConsultaFabrica
      // 
      btnConsultaFabrica.Location = new System.Drawing.Point(252, 154);
      btnConsultaFabrica.Name = "btnConsultaFabrica";
      btnConsultaFabrica.Size = new System.Drawing.Size(27, 22);
      btnConsultaFabrica.TabIndex = 5;
      btnConsultaFabrica.Text = "...";
      btnConsultaFabrica.UseVisualStyleBackColor = true;
      btnConsultaFabrica.Click += new System.EventHandler(btnConsultaFabrica_Click);
      // 
      // btnConsulta
      // 
      btnConsulta.Location = new System.Drawing.Point(252, 76);
      btnConsulta.Name = "btnConsulta";
      btnConsulta.Size = new System.Drawing.Size(27, 22);
      btnConsulta.TabIndex = 16;
      btnConsulta.Text = "...";
      btnConsulta.UseVisualStyleBackColor = true;
      btnConsulta.Click += new System.EventHandler(btnConsulta_Click);
      // 
      // frmPosicion
      // 
      AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      ClientSize = new System.Drawing.Size(559, 287);
      Controls.Add(btnConsulta);
      Controls.Add(btnConsultaFabrica);
      Controls.Add(btnConsultaDepto);
      Controls.Add(label5);
      Controls.Add(lblFabricaNombre);
      Controls.Add(lblDepartamento);
      Controls.Add(txtFabrica);
      Controls.Add(txtDepartamento);
      Controls.Add(txtNombrePosicion);
      Controls.Add(txtPosicion);
      Controls.Add(label4);
      Controls.Add(label3);
      Controls.Add(label2);
      Controls.Add(label1);
      Controls.Add(btnSalir);
      Controls.Add(bntBorrar);
      Controls.Add(btnLimpiar);
      Controls.Add(btnGuardar);
      Name = "frmPosicion";
      Text = "frmPosicion";
      Load += new System.EventHandler(frmPosicion_Load);
      ResumeLayout(false);
      PerformLayout();

    }

    #endregion

    public static System.Windows.Forms.Button btnGuardar;
    public static System.Windows.Forms.Button btnLimpiar;
    public static System.Windows.Forms.Button bntBorrar;
    public static System.Windows.Forms.Button btnSalir;
    public static System.Windows.Forms.Label label1;
    public static System.Windows.Forms.Label label2;
    public static System.Windows.Forms.Label label3;
    public static System.Windows.Forms.Label label4;
    public static System.Windows.Forms.TextBox txtPosicion;
    public static System.Windows.Forms.TextBox txtNombrePosicion;
    public static System.Windows.Forms.TextBox txtDepartamento;
    public static System.Windows.Forms.TextBox txtFabrica;
    public static System.Windows.Forms.Label lblDepartamento;
    public static System.Windows.Forms.Label lblFabricaNombre;
    public static System.Windows.Forms.Label label5;
    public static System.Windows.Forms.Button btnConsultaDepto;
    public static System.Windows.Forms.Button btnConsultaFabrica;
    public static System.Windows.Forms.Button btnConsulta;
  }
}