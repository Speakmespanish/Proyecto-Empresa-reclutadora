namespace Capa_Presentacion
{
    partial class Inicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            panel1 = new Panel();
            panel2 = new Panel();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(9, 9);
            panel1.Name = "panel1";
            panel1.Size = new Size(218, 427);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(textBox1);
            panel2.Location = new Point(272, 9);
            panel2.Name = "panel2";
            panel2.Size = new Size(714, 427);
            panel2.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBox2.Location = new Point(39, 94);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(649, 306);
            textBox2.TabIndex = 1;
            textBox2.Text = resources.GetString("textBox2.Text");
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Showcard Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(39, 30);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(649, 58);
            textBox1.TabIndex = 0;
            textBox1.Text = "Esta aplicacion tiene funcionalidades para una empresa reclutadora, dichas funcionalidades son las siguientes a continuacion:\r\n";
            // 
            // button1
            // 
            button1.Location = new Point(3, 64);
            button1.Name = "button1";
            button1.Size = new Size(197, 47);
            button1.TabIndex = 0;
            button1.Text = "Registrar vacante";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(3, 141);
            button2.Name = "button2";
            button2.Size = new Size(197, 47);
            button2.TabIndex = 1;
            button2.Text = "Ver vacantes";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(3, 218);
            button3.Name = "button3";
            button3.Size = new Size(197, 47);
            button3.TabIndex = 2;
            button3.Text = "Registrar candidato";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(3, 292);
            button4.Name = "button4";
            button4.Size = new Size(197, 47);
            button4.TabIndex = 3;
            button4.Text = "Ver candidatos";
            button4.UseVisualStyleBackColor = true;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(993, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Inicio";
            Text = "Inicio";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}