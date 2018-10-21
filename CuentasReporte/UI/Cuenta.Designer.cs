namespace CuentasReporte.UI
{
    partial class Cuenta
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.IDnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.IDTiponumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.MontonumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.Tcuentasbutton = new System.Windows.Forms.Button();
            this.DescripcioncomboBox = new System.Windows.Forms.ComboBox();
            this.Buscarbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.IDnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IDTiponumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MontonumericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripcion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Monto";
            // 
            // IDnumericUpDown
            // 
            this.IDnumericUpDown.Location = new System.Drawing.Point(118, 61);
            this.IDnumericUpDown.Name = "IDnumericUpDown";
            this.IDnumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.IDnumericUpDown.TabIndex = 4;
            // 
            // IDTiponumericUpDown
            // 
            this.IDTiponumericUpDown.Location = new System.Drawing.Point(118, 109);
            this.IDTiponumericUpDown.Name = "IDTiponumericUpDown";
            this.IDTiponumericUpDown.Size = new System.Drawing.Size(321, 22);
            this.IDTiponumericUpDown.TabIndex = 5;
            // 
            // MontonumericUpDown1
            // 
            this.MontonumericUpDown1.DecimalPlaces = 2;
            this.MontonumericUpDown1.Location = new System.Drawing.Point(118, 191);
            this.MontonumericUpDown1.Name = "MontonumericUpDown1";
            this.MontonumericUpDown1.Size = new System.Drawing.Size(321, 22);
            this.MontonumericUpDown1.TabIndex = 7;
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Image = global::CuentasReporte.Properties.Resources.icons8_nuevo_48;
            this.Nuevobutton.Location = new System.Drawing.Point(49, 228);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(75, 56);
            this.Nuevobutton.TabIndex = 10;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Image = global::CuentasReporte.Properties.Resources.icons8_guardar_48;
            this.Guardarbutton.Location = new System.Drawing.Point(152, 228);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 56);
            this.Guardarbutton.TabIndex = 11;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Image = global::CuentasReporte.Properties.Resources.Eliminar;
            this.Eliminarbutton.Location = new System.Drawing.Point(253, 228);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(75, 56);
            this.Eliminarbutton.TabIndex = 12;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Tcuentasbutton
            // 
            this.Tcuentasbutton.Location = new System.Drawing.Point(364, 228);
            this.Tcuentasbutton.Name = "Tcuentasbutton";
            this.Tcuentasbutton.Size = new System.Drawing.Size(75, 56);
            this.Tcuentasbutton.TabIndex = 13;
            this.Tcuentasbutton.Text = "Tipo Cuenta";
            this.Tcuentasbutton.UseVisualStyleBackColor = true;
            this.Tcuentasbutton.Click += new System.EventHandler(this.Tcuentasbutton_Click);
            // 
            // DescripcioncomboBox
            // 
            this.DescripcioncomboBox.FormattingEnabled = true;
            this.DescripcioncomboBox.Location = new System.Drawing.Point(119, 153);
            this.DescripcioncomboBox.Name = "DescripcioncomboBox";
            this.DescripcioncomboBox.Size = new System.Drawing.Size(320, 24);
            this.DescripcioncomboBox.TabIndex = 14;
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = global::CuentasReporte.Properties.Resources.Buscar1;
            this.Buscarbutton.Location = new System.Drawing.Point(265, 50);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(94, 48);
            this.Buscarbutton.TabIndex = 8;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // Cuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 311);
            this.Controls.Add(this.DescripcioncomboBox);
            this.Controls.Add(this.Tcuentasbutton);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.MontonumericUpDown1);
            this.Controls.Add(this.IDTiponumericUpDown);
            this.Controls.Add(this.IDnumericUpDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Cuenta";
            this.Text = "Cuenta";
            ((System.ComponentModel.ISupportInitialize)(this.IDnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IDTiponumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MontonumericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown IDnumericUpDown;
        private System.Windows.Forms.NumericUpDown IDTiponumericUpDown;
        private System.Windows.Forms.NumericUpDown MontonumericUpDown1;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button Tcuentasbutton;
        private System.Windows.Forms.ComboBox DescripcioncomboBox;
    }
}