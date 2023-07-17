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
            panel1 = new Panel();
            btnVerCandidatos = new Button();
            btnRegistrarCandidato = new Button();
            btnVerVacantes = new Button();
            btnRegistrarVacante = new Button();
            panel2 = new Panel();
            btnInicio = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnInicio);
            panel1.Controls.Add(btnVerCandidatos);
            panel1.Controls.Add(btnRegistrarCandidato);
            panel1.Controls.Add(btnVerVacantes);
            panel1.Controls.Add(btnRegistrarVacante);
            panel1.Location = new Point(9, 9);
            panel1.Name = "panel1";
            panel1.Size = new Size(218, 427);
            panel1.TabIndex = 0;
            // 
            // btnVerCandidatos
            // 
            btnVerCandidatos.Location = new Point(3, 268);
            btnVerCandidatos.Name = "btnVerCandidatos";
            btnVerCandidatos.Size = new Size(197, 47);
            btnVerCandidatos.TabIndex = 3;
            btnVerCandidatos.Text = "Ver candidatos";
            btnVerCandidatos.UseVisualStyleBackColor = true;
            btnVerCandidatos.Click += btnVerCandidatos_Click;
            // 
            // btnRegistrarCandidato
            // 
            btnRegistrarCandidato.Location = new Point(3, 194);
            btnRegistrarCandidato.Name = "btnRegistrarCandidato";
            btnRegistrarCandidato.Size = new Size(197, 47);
            btnRegistrarCandidato.TabIndex = 2;
            btnRegistrarCandidato.Text = "Registrar candidato";
            btnRegistrarCandidato.UseVisualStyleBackColor = true;
            btnRegistrarCandidato.Click += btnRegistrarCandidato_Click;
            // 
            // btnVerVacantes
            // 
            btnVerVacantes.Location = new Point(3, 117);
            btnVerVacantes.Name = "btnVerVacantes";
            btnVerVacantes.Size = new Size(197, 47);
            btnVerVacantes.TabIndex = 1;
            btnVerVacantes.Text = "Ver vacantes";
            btnVerVacantes.UseVisualStyleBackColor = true;
            btnVerVacantes.Click += btnVerVacantes_Click;
            // 
            // btnRegistrarVacante
            // 
            btnRegistrarVacante.Location = new Point(3, 40);
            btnRegistrarVacante.Name = "btnRegistrarVacante";
            btnRegistrarVacante.Size = new Size(197, 47);
            btnRegistrarVacante.TabIndex = 0;
            btnRegistrarVacante.Text = "Registrar vacante";
            btnRegistrarVacante.UseVisualStyleBackColor = true;
            btnRegistrarVacante.Click += btnRegistrarVacante_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Location = new Point(272, 9);
            panel2.Name = "panel2";
            panel2.Size = new Size(714, 427);
            panel2.TabIndex = 1;
            // 
            // btnInicio
            // 
            btnInicio.Location = new Point(3, 344);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(197, 47);
            btnInicio.TabIndex = 4;
            btnInicio.Text = "Ver informacion del inicio";
            btnInicio.UseVisualStyleBackColor = true;
            btnInicio.Click += btnInicio_Click;
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
            Load += Inicio_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btnVerCandidatos;
        private Button btnRegistrarCandidato;
        private Button btnVerVacantes;
        private Button btnRegistrarVacante;
        private Button btnInicio;
    }
}