namespace Capa_Presentacion.Controles_usuarios
{
    partial class InformacionInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InformacionInicial));
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBox2.Location = new Point(33, 92);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(649, 306);
            textBox2.TabIndex = 3;
            textBox2.Text = resources.GetString("textBox2.Text");
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Showcard Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(33, 28);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(649, 58);
            textBox1.TabIndex = 2;
            textBox1.Text = "Esta aplicacion tiene funcionalidades para una empresa reclutadora, dichas funcionalidades son las siguientes a continuacion:\r\n";
            // 
            // InformacionInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "InformacionInicial";
            Size = new Size(714, 427);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox2;
        private TextBox textBox1;
    }
}
