namespace Capa_Presentacion.Controles_usuarios
{
    partial class RegistrarVacante
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreVacante = new System.Windows.Forms.TextBox();
            this.nudSalarioVacante = new System.Windows.Forms.NumericUpDown();
            this.cbxDisponibilidad = new System.Windows.Forms.ComboBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudSalarioVacante)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(39, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del puesto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(39, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Salario del puesto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(39, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Estado inicial del puesto:";
            // 
            // txtNombreVacante
            // 
            this.txtNombreVacante.Location = new System.Drawing.Point(306, 103);
            this.txtNombreVacante.Name = "txtNombreVacante";
            this.txtNombreVacante.Size = new System.Drawing.Size(211, 23);
            this.txtNombreVacante.TabIndex = 3;
            // 
            // nudSalarioVacante
            // 
            this.nudSalarioVacante.Location = new System.Drawing.Point(306, 177);
            this.nudSalarioVacante.Name = "nudSalarioVacante";
            this.nudSalarioVacante.Size = new System.Drawing.Size(128, 23);
            this.nudSalarioVacante.TabIndex = 4;
            // 
            // cbxDisponibilidad
            // 
            this.cbxDisponibilidad.FormattingEnabled = true;
            this.cbxDisponibilidad.Items.AddRange(new object[] {
            "Disponible",
            "Ocupado"});
            this.cbxDisponibilidad.Location = new System.Drawing.Point(306, 242);
            this.cbxDisponibilidad.Name = "cbxDisponibilidad";
            this.cbxDisponibilidad.Size = new System.Drawing.Size(139, 23);
            this.cbxDisponibilidad.TabIndex = 5;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.Lime;
            this.btnRegistrar.Location = new System.Drawing.Point(504, 305);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(163, 35);
            this.btnRegistrar.TabIndex = 6;
            this.btnRegistrar.Text = "Registrar vacante";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Yellow;
            this.btnLimpiar.Location = new System.Drawing.Point(504, 366);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(163, 35);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar campos";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Snap ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(28, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(288, 27);
            this.label4.TabIndex = 8;
            this.label4.Text = "Registro de vacantes";
            // 
            // RegistrarVacante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.cbxDisponibilidad);
            this.Controls.Add(this.nudSalarioVacante);
            this.Controls.Add(this.txtNombreVacante);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegistrarVacante";
            this.Size = new System.Drawing.Size(714, 427);
            ((System.ComponentModel.ISupportInitialize)(this.nudSalarioVacante)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNombreVacante;
        private NumericUpDown nudSalarioVacante;
        private ComboBox cbxDisponibilidad;
        private Button btnRegistrar;
        private Button btnLimpiar;
        private Label label4;
    }
}
