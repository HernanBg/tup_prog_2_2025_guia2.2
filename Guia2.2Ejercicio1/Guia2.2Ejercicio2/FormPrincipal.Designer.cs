namespace Guia2._2Ejercicio2
{
    partial class FormPrincipal
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
            btnIniciarEmbarque = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbNumeroEmbBusq = new TextBox();
            btnEmbarquePorNumero = new Button();
            btnRecaudacion = new Button();
            btnEmbarqueMayor = new Button();
            btnListadoEmbarques = new Button();
            ltbInforme = new ListBox();
            gbInforme = new GroupBox();
            SuspendLayout();
            // 
            // btnIniciarEmbarque
            // 
            btnIniciarEmbarque.DialogResult = DialogResult.OK;
            btnIniciarEmbarque.Location = new Point(234, 28);
            btnIniciarEmbarque.Name = "btnIniciarEmbarque";
            btnIniciarEmbarque.Size = new Size(266, 23);
            btnIniciarEmbarque.TabIndex = 0;
            btnIniciarEmbarque.Text = "Alta Embarque";
            btnIniciarEmbarque.UseVisualStyleBackColor = true;
            btnIniciarEmbarque.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 62);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 1;
            label1.Text = "Informe";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 88);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 2;
            label2.Text = "Ver Embarque";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 119);
            label3.Name = "label3";
            label3.Size = new Size(108, 15);
            label3.TabIndex = 3;
            label3.Text = "Número embarque";
            // 
            // tbNumeroEmbBusq
            // 
            tbNumeroEmbBusq.Location = new Point(178, 116);
            tbNumeroEmbBusq.Name = "tbNumeroEmbBusq";
            tbNumeroEmbBusq.Size = new Size(100, 23);
            tbNumeroEmbBusq.TabIndex = 4;
            // 
            // btnEmbarquePorNumero
            // 
            btnEmbarquePorNumero.Location = new Point(355, 115);
            btnEmbarquePorNumero.Name = "btnEmbarquePorNumero";
            btnEmbarquePorNumero.Size = new Size(145, 23);
            btnEmbarquePorNumero.TabIndex = 5;
            btnEmbarquePorNumero.Text = "Buscar Embarque";
            btnEmbarquePorNumero.UseVisualStyleBackColor = true;
            btnEmbarquePorNumero.Click += btnEmbarquePorNumero_Click;
            // 
            // btnRecaudacion
            // 
            btnRecaudacion.Location = new Point(504, 210);
            btnRecaudacion.Name = "btnRecaudacion";
            btnRecaudacion.Size = new Size(145, 23);
            btnRecaudacion.TabIndex = 6;
            btnRecaudacion.Text = "Resumen del dia";
            btnRecaudacion.UseVisualStyleBackColor = true;
            btnRecaudacion.Click += btnRecaudacion_Click;
            // 
            // btnEmbarqueMayor
            // 
            btnEmbarqueMayor.Location = new Point(504, 295);
            btnEmbarqueMayor.Name = "btnEmbarqueMayor";
            btnEmbarqueMayor.Size = new Size(145, 23);
            btnEmbarqueMayor.TabIndex = 7;
            btnEmbarqueMayor.Text = "Embarque Mayor";
            btnEmbarqueMayor.UseVisualStyleBackColor = true;
            btnEmbarqueMayor.Click += button4_Click;
            // 
            // btnListadoEmbarques
            // 
            btnListadoEmbarques.Location = new Point(504, 384);
            btnListadoEmbarques.Name = "btnListadoEmbarques";
            btnListadoEmbarques.Size = new Size(145, 23);
            btnListadoEmbarques.TabIndex = 8;
            btnListadoEmbarques.Text = "Todos los embarques";
            btnListadoEmbarques.UseVisualStyleBackColor = true;
            btnListadoEmbarques.Click += btnListadoEmbarques_Click;
            // 
            // ltbInforme
            // 
            ltbInforme.FormattingEnabled = true;
            ltbInforme.ItemHeight = 15;
            ltbInforme.Location = new Point(12, 184);
            ltbInforme.Name = "ltbInforme";
            ltbInforme.Size = new Size(434, 244);
            ltbInforme.TabIndex = 9;
            ltbInforme.SelectedIndexChanged += ltbInforme_SelectedIndexChanged;
            // 
            // gbInforme
            // 
            gbInforme.Location = new Point(54, 235);
            gbInforme.Name = "gbInforme";
            gbInforme.Size = new Size(323, 156);
            gbInforme.TabIndex = 10;
            gbInforme.TabStop = false;
            gbInforme.Text = "groupBox1";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gbInforme);
            Controls.Add(ltbInforme);
            Controls.Add(btnListadoEmbarques);
            Controls.Add(btnEmbarqueMayor);
            Controls.Add(btnRecaudacion);
            Controls.Add(btnEmbarquePorNumero);
            Controls.Add(tbNumeroEmbBusq);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnIniciarEmbarque);
            Name = "FormPrincipal";
            Text = "FormPrincipal";
            Load += FormPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        public Button btnIniciarEmbarque;
        public TextBox tbNumeroEmbBusq;
        public Button btnEmbarquePorNumero;
        public Button btnRecaudacion;
        public Button btnEmbarqueMayor;
        public Button btnListadoEmbarques;
        public ListBox ltbInforme;
        private GroupBox gbInforme;
    }
}