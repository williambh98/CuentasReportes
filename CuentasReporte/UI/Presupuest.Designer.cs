namespace CuentasReporte.UI
{
    partial class Presupuest
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CuentadataGridView = new System.Windows.Forms.DataGridView();
            this.AgregardataGrid = new System.Windows.Forms.Button();
            this.TipoCuentascomboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.MontonumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.DescripciontextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IDnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CuentaID = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardar = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.RemoveFilabutton = new System.Windows.Forms.Button();
            this.TipodeCuentabutton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CuentadataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MontonumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IDnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RemoveFilabutton);
            this.groupBox1.Controls.Add(this.TipodeCuentabutton);
            this.groupBox1.Controls.Add(this.CuentadataGridView);
            this.groupBox1.Controls.Add(this.AgregardataGrid);
            this.groupBox1.Controls.Add(this.TipoCuentascomboBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(53, 159);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(465, 263);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipos de Cuentas";
            // 
            // CuentadataGridView
            // 
            this.CuentadataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CuentadataGridView.Location = new System.Drawing.Point(0, 64);
            this.CuentadataGridView.Name = "CuentadataGridView";
            this.CuentadataGridView.RowTemplate.Height = 24;
            this.CuentadataGridView.Size = new System.Drawing.Size(475, 150);
            this.CuentadataGridView.TabIndex = 3;
            // 
            // AgregardataGrid
            // 
            this.AgregardataGrid.Location = new System.Drawing.Point(371, 18);
            this.AgregardataGrid.Name = "AgregardataGrid";
            this.AgregardataGrid.Size = new System.Drawing.Size(94, 40);
            this.AgregardataGrid.TabIndex = 2;
            this.AgregardataGrid.Text = "Agragar";
            this.AgregardataGrid.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AgregardataGrid.UseVisualStyleBackColor = true;
            this.AgregardataGrid.Click += new System.EventHandler(this.Agragar_Click);
            // 
            // TipoCuentascomboBox
            // 
            this.TipoCuentascomboBox.FormattingEnabled = true;
            this.TipoCuentascomboBox.Location = new System.Drawing.Point(126, 31);
            this.TipoCuentascomboBox.Name = "TipoCuentascomboBox";
            this.TipoCuentascomboBox.Size = new System.Drawing.Size(161, 24);
            this.TipoCuentascomboBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tipo De Cuentas";
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechadateTimePicker.Location = new System.Drawing.Point(330, 115);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(166, 22);
            this.FechadateTimePicker.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(277, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Fecha";
            // 
            // MontonumericUpDown
            // 
            this.MontonumericUpDown.Location = new System.Drawing.Point(150, 115);
            this.MontonumericUpDown.Name = "MontonumericUpDown";
            this.MontonumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.MontonumericUpDown.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Monto";
            // 
            // DescripciontextBox
            // 
            this.DescripciontextBox.Location = new System.Drawing.Point(150, 68);
            this.DescripciontextBox.Name = "DescripciontextBox";
            this.DescripciontextBox.Size = new System.Drawing.Size(346, 22);
            this.DescripciontextBox.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Descripcion";
            // 
            // IDnumericUpDown
            // 
            this.IDnumericUpDown.Location = new System.Drawing.Point(151, 19);
            this.IDnumericUpDown.Name = "IDnumericUpDown";
            this.IDnumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.IDnumericUpDown.TabIndex = 14;
            // 
            // CuentaID
            // 
            this.CuentaID.AutoSize = true;
            this.CuentaID.Location = new System.Drawing.Point(62, 24);
            this.CuentaID.Name = "CuentaID";
            this.CuentaID.Size = new System.Drawing.Size(66, 17);
            this.CuentaID.TabIndex = 13;
            this.CuentaID.Text = "CuentaID";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = global::CuentasReporte.Properties.Resources.Buscar;
            this.Buscarbutton.Location = new System.Drawing.Point(304, 11);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(101, 43);
            this.Buscarbutton.TabIndex = 25;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Image = global::CuentasReporte.Properties.Resources.Eliminar1;
            this.Eliminarbutton.Location = new System.Drawing.Point(385, 428);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(93, 69);
            this.Eliminarbutton.TabIndex = 24;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Guardar
            // 
            this.Guardar.Image = global::CuentasReporte.Properties.Resources.icons8_guardar_481;
            this.Guardar.Location = new System.Drawing.Point(230, 428);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(94, 69);
            this.Guardar.TabIndex = 23;
            this.Guardar.Text = "Guardar";
            this.Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Image = global::CuentasReporte.Properties.Resources.icons8_nuevo_48;
            this.Nuevobutton.Location = new System.Drawing.Point(74, 428);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(99, 69);
            this.Nuevobutton.TabIndex = 22;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // RemoveFilabutton
            // 
            this.RemoveFilabutton.Image = global::CuentasReporte.Properties.Resources.Eliminar;
            this.RemoveFilabutton.Location = new System.Drawing.Point(6, 220);
            this.RemoveFilabutton.Name = "RemoveFilabutton";
            this.RemoveFilabutton.Size = new System.Drawing.Size(130, 37);
            this.RemoveFilabutton.TabIndex = 5;
            this.RemoveFilabutton.Text = "Remove Fila";
            this.RemoveFilabutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.RemoveFilabutton.UseVisualStyleBackColor = true;
            this.RemoveFilabutton.Click += new System.EventHandler(this.RemoveFilabutton_Click);
            // 
            // TipodeCuentabutton
            // 
            this.TipodeCuentabutton.Image = global::CuentasReporte.Properties.Resources.New;
            this.TipodeCuentabutton.Location = new System.Drawing.Point(290, 21);
            this.TipodeCuentabutton.Name = "TipodeCuentabutton";
            this.TipodeCuentabutton.Size = new System.Drawing.Size(75, 33);
            this.TipodeCuentabutton.TabIndex = 4;
            this.TipodeCuentabutton.UseVisualStyleBackColor = true;
            this.TipodeCuentabutton.Click += new System.EventHandler(this.TipodeCuentabutton_Click);
            // 
            // Presupuest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 527);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.FechadateTimePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MontonumericUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DescripciontextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IDnumericUpDown);
            this.Controls.Add(this.CuentaID);
            this.Name = "Presupuest";
            this.Text = "Presupuest";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CuentadataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MontonumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IDnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Guardar;
        public System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView CuentadataGridView;
        private System.Windows.Forms.Button AgregardataGrid;
        private System.Windows.Forms.ComboBox TipoCuentascomboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown MontonumericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DescripciontextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown IDnumericUpDown;
        private System.Windows.Forms.Label CuentaID;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button TipodeCuentabutton;
        private System.Windows.Forms.Button RemoveFilabutton;
    }
}