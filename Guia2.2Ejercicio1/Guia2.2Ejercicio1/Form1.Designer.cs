namespace Guia2._2Ejercicio1
{
    partial class Form1
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
            btnRegistroDeEncuesta = new Button();
            btnInforme = new Button();
            btnListadoContactables = new Button();
            SuspendLayout();
            // 
            // btnRegistroDeEncuesta
            // 
            btnRegistroDeEncuesta.DialogResult = DialogResult.OK;
            btnRegistroDeEncuesta.Location = new Point(91, 48);
            btnRegistroDeEncuesta.Name = "btnRegistroDeEncuesta";
            btnRegistroDeEncuesta.Size = new Size(202, 48);
            btnRegistroDeEncuesta.TabIndex = 0;
            btnRegistroDeEncuesta.Text = "Registro de Encuesta";
            btnRegistroDeEncuesta.UseVisualStyleBackColor = true;
            btnRegistroDeEncuesta.Click += btnRegistroDeEncuesta_Click;
            // 
            // btnInforme
            // 
            btnInforme.DialogResult = DialogResult.OK;
            btnInforme.Location = new Point(91, 119);
            btnInforme.Name = "btnInforme";
            btnInforme.Size = new Size(202, 42);
            btnInforme.TabIndex = 1;
            btnInforme.Text = "Resultados";
            btnInforme.UseVisualStyleBackColor = true;
            btnInforme.Click += btnInforme_Click;
            // 
            // btnListadoContactables
            // 
            btnListadoContactables.DialogResult = DialogResult.OK;
            btnListadoContactables.Location = new Point(91, 204);
            btnListadoContactables.Name = "btnListadoContactables";
            btnListadoContactables.Size = new Size(202, 40);
            btnListadoContactables.TabIndex = 2;
            btnListadoContactables.Text = "Listado contactables";
            btnListadoContactables.UseVisualStyleBackColor = true;
            btnListadoContactables.Click += btnListadoContactables_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 313);
            Controls.Add(btnListadoContactables);
            Controls.Add(btnInforme);
            Controls.Add(btnRegistroDeEncuesta);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        public Button btnRegistroDeEncuesta;
        public Button btnInforme;
        public Button btnListadoContactables;
        private Button btn3;
    }
}
