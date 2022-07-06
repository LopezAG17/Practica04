namespace Practica04
{
  partial class frmConsultaFabrica
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
      txtBuscar.Location = new System.Drawing.Point(-1, 40);
      txtBuscar.Name = "txtBuscar";
      txtBuscar.Size = new System.Drawing.Size(276, 20);
      txtBuscar.TabIndex = 35;
      txtBuscar.Leave += new System.EventHandler(txtBuscar_Leave);
      // 
      // btnCerrar
      // 
      btnCerrar.BackColor = System.Drawing.SystemColors.InactiveCaption;
      btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
      btnCerrar.Location = new System.Drawing.Point(585, 0);
      btnCerrar.Name = "btnCerrar";
      btnCerrar.Size = new System.Drawing.Size(146, 60);
      btnCerrar.TabIndex = 34;
      btnCerrar.Text = "Cerrar Ventana";
      btnCerrar.UseVisualStyleBackColor = false;
      btnCerrar.Click += new System.EventHandler(btnCerrar_Click);
      // 
      // btnSeleccionar
      // 
      btnSeleccionar.BackColor = System.Drawing.SystemColors.InactiveCaption;
      btnSeleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
      btnSeleccionar.Location = new System.Drawing.Point(433, 0);
      btnSeleccionar.Name = "btnSeleccionar";
      btnSeleccionar.Size = new System.Drawing.Size(146, 60);
      btnSeleccionar.TabIndex = 33;
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
      lbl1.Location = new System.Drawing.Point(-1, 0);
      lbl1.Name = "lbl1";
      lbl1.Size = new System.Drawing.Size(276, 37);
      lbl1.TabIndex = 32;
      lbl1.Text = "Busar a:";
      lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // btnBuscar
      // 
      btnBuscar.BackColor = System.Drawing.SystemColors.InactiveCaption;
      btnBuscar.Location = new System.Drawing.Point(281, 0);
      btnBuscar.Name = "btnBuscar";
      btnBuscar.Size = new System.Drawing.Size(146, 60);
      btnBuscar.TabIndex = 31;
      btnBuscar.Text = "Buscar";
      btnBuscar.UseVisualStyleBackColor = false;
      btnBuscar.Click += new System.EventHandler(btnBuscar_Click);
      // 
      // dgv
      // 
      dgv.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
      dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      dgv.Location = new System.Drawing.Point(-1, 66);
      dgv.Name = "dgv";
      dgv.Size = new System.Drawing.Size(732, 328);
      dgv.TabIndex = 30;
      // 
      // frmConsultaFabrica
      // 
      AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      ClientSize = new System.Drawing.Size(734, 398);
      Controls.Add(txtBuscar);
      Controls.Add(btnCerrar);
      Controls.Add(btnSeleccionar);
      Controls.Add(lbl1);
      Controls.Add(btnBuscar);
      Controls.Add(dgv);
      Name = "frmConsultaFabrica";
      StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      Text = "Consulta Fabrica";
      Load += new System.EventHandler(frmConsultaFabrica_Load);
      KeyDown += new System.Windows.Forms.KeyEventHandler(frmConsultaFabrica_KeyDown);
      KeyPress += new System.Windows.Forms.KeyPressEventHandler(txtBuscar_KeyPress);
      ((System.ComponentModel.ISupportInitialize)(dgv)).EndInit();
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