namespace Practica04
{
  partial class frmConsultaLocalidad
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
      txtBuscar = new System.Windows.Forms.TextBox();
      btnCerrar = new System.Windows.Forms.Button();
      btnSeleccionar = new System.Windows.Forms.Button();
      lbl1 = new System.Windows.Forms.Label();
      btnBuscar = new System.Windows.Forms.Button();
      dgv = new System.Windows.Forms.DataGridView();
      ((System.ComponentModel.ISupportInitialize)(dgv)).BeginInit();
      SuspendLayout();
      // 
      // txtBuscar
      // 
      txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      txtBuscar.Location = new System.Drawing.Point(1, 39);
      txtBuscar.Name = "txtBuscar";
      txtBuscar.Size = new System.Drawing.Size(276, 20);
      txtBuscar.TabIndex = 41;
      txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txtBuscar_KeyPress);
      txtBuscar.Leave += new System.EventHandler(txtBuscar_Leave);
      // 
      // btnCerrar
      // 
      btnCerrar.BackColor = System.Drawing.SystemColors.InactiveCaption;
      btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
      btnCerrar.Location = new System.Drawing.Point(587, -1);
      btnCerrar.Name = "btnCerrar";
      btnCerrar.Size = new System.Drawing.Size(146, 60);
      btnCerrar.TabIndex = 40;
      btnCerrar.Text = "Cerrar Ventana";
      btnCerrar.UseVisualStyleBackColor = false;
      btnCerrar.Click += new System.EventHandler(btnCerrar_Click);
      // 
      // btnSeleccionar
      // 
      btnSeleccionar.BackColor = System.Drawing.SystemColors.InactiveCaption;
      btnSeleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
      btnSeleccionar.Location = new System.Drawing.Point(435, -1);
      btnSeleccionar.Name = "btnSeleccionar";
      btnSeleccionar.Size = new System.Drawing.Size(146, 60);
      btnSeleccionar.TabIndex = 39;
      btnSeleccionar.Text = "Seleccionar";
      btnSeleccionar.UseVisualStyleBackColor = false;
      btnSeleccionar.Click += new System.EventHandler(btnSeleccionar_Click);
      // 
      // lbl1
      // 
      lbl1.BackColor = System.Drawing.Color.CornflowerBlue;
      lbl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      lbl1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      lbl1.ForeColor = System.Drawing.Color.White;
      lbl1.Location = new System.Drawing.Point(1, -1);
      lbl1.Name = "lbl1";
      lbl1.Size = new System.Drawing.Size(276, 37);
      lbl1.TabIndex = 38;
      lbl1.Text = "Busar a:";
      lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // btnBuscar
      // 
      btnBuscar.BackColor = System.Drawing.SystemColors.InactiveCaption;
      btnBuscar.Location = new System.Drawing.Point(283, -1);
      btnBuscar.Name = "btnBuscar";
      btnBuscar.Size = new System.Drawing.Size(146, 60);
      btnBuscar.TabIndex = 37;
      btnBuscar.Text = "Buscar";
      btnBuscar.UseVisualStyleBackColor = false;
      btnBuscar.Click += new System.EventHandler(btnBuscar_Click);
      // 
      // dgv
      // 
      dgv.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
      dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      dgv.Location = new System.Drawing.Point(1, 65);
      dgv.Name = "dgv";
      dgv.Size = new System.Drawing.Size(732, 328);
      dgv.TabIndex = 36;
      dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(dgv_CellDoubleClick);
      // 
      // frmConsultaLocalidad
      // 
      AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      ClientSize = new System.Drawing.Size(735, 394);
      Controls.Add(txtBuscar);
      Controls.Add(btnCerrar);
      Controls.Add(btnSeleccionar);
      Controls.Add(lbl1);
      Controls.Add(btnBuscar);
      Controls.Add(dgv);
      Name = "frmConsultaLocalidad";
      Text = "Consulta Localidad";
      StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      Load += new System.EventHandler(frmConsultaLocalidad_Load);
      KeyDown += new System.Windows.Forms.KeyEventHandler(frmConsultaLocalidad_KeyDown);
      ((System.ComponentModel.ISupportInitialize)(dgv)).EndInit();
      ResumeLayout(false);
      PerformLayout();

    }

    #endregion

    public static System.Windows.Forms.TextBox txtBuscar;
    public static System.Windows.Forms.Button btnCerrar;
    public static System.Windows.Forms.Button btnSeleccionar;
    public static System.Windows.Forms.Label lbl1;
    public static System.Windows.Forms.Button btnBuscar;
    public static System.Windows.Forms.DataGridView dgv;
  }
}