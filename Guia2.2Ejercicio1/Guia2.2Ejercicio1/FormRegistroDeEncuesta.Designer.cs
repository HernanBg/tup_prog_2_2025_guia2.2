namespace Guia2._2Ejercicio1
{
    partial class FormRegistroDeEncuesta
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            chkUsaBicicleta = new CheckBox();
            chkUsaAuto = new CheckBox();
            chkTranspPub = new CheckBox();
            tbDistanciaASuDestino = new TextBox();
            tbEmail = new TextBox();
            chkPuedeSerContactado = new CheckBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 20);
            label1.Name = "label1";
            label1.Size = new Size(151, 15);
            label1.TabIndex = 0;
            label1.Text = "Modo de trasporte habitual";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 235);
            label2.Name = "label2";
            label2.Size = new Size(193, 15);
            label2.TabIndex = 1;
            label2.Text = "Sobre el destino al trabajo / estudio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 278);
            label3.Name = "label3";
            label3.Size = new Size(99, 15);
            label3.TabIndex = 2;
            label3.Text = "Distancia en (km)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 334);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 3;
            label4.Text = "Contacto";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(78, 373);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 4;
            label5.Text = "Email";
            // 
            // chkUsaBicicleta
            // 
            chkUsaBicicleta.AutoSize = true;
            chkUsaBicicleta.Location = new Point(191, 45);
            chkUsaBicicleta.Name = "chkUsaBicicleta";
            chkUsaBicicleta.Size = new Size(93, 19);
            chkUsaBicicleta.TabIndex = 5;
            chkUsaBicicleta.Text = "¿Usa Bicleta?";
            chkUsaBicicleta.UseVisualStyleBackColor = true;
            // 
            // chkUsaAuto
            // 
            chkUsaAuto.AutoSize = true;
            chkUsaAuto.Location = new Point(191, 70);
            chkUsaAuto.Name = "chkUsaAuto";
            chkUsaAuto.Size = new Size(112, 19);
            chkUsaAuto.TabIndex = 6;
            chkUsaAuto.Text = "¿Usa automóvil?";
            chkUsaAuto.UseVisualStyleBackColor = true;
            // 
            // chkTranspPub
            // 
            chkTranspPub.AutoSize = true;
            chkTranspPub.Location = new Point(191, 95);
            chkTranspPub.Name = "chkTranspPub";
            chkTranspPub.Size = new Size(155, 19);
            chkTranspPub.TabIndex = 7;
            chkTranspPub.Text = "¿Usa transporte público?";
            chkTranspPub.UseVisualStyleBackColor = true;
            // 
            // tbDistanciaASuDestino
            // 
            tbDistanciaASuDestino.Location = new Point(184, 275);
            tbDistanciaASuDestino.Name = "tbDistanciaASuDestino";
            tbDistanciaASuDestino.Size = new Size(100, 23);
            tbDistanciaASuDestino.TabIndex = 8;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(134, 370);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(98, 23);
            tbEmail.TabIndex = 9;
            // 
            // chkPuedeSerContactado
            // 
            chkPuedeSerContactado.AutoSize = true;
            chkPuedeSerContactado.Location = new Point(134, 334);
            chkPuedeSerContactado.Name = "chkPuedeSerContactado";
            chkPuedeSerContactado.Size = new Size(150, 19);
            chkPuedeSerContactado.TabIndex = 10;
            chkPuedeSerContactado.Text = "¿Puede ser contactado?";
            chkPuedeSerContactado.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(60, 458);
            button1.Name = "button1";
            button1.Size = new Size(92, 33);
            button1.TabIndex = 11;
            button1.Text = "Confirmar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(252, 458);
            button2.Name = "button2";
            button2.Size = new Size(94, 33);
            button2.TabIndex = 12;
            button2.Text = "Cerrar";
            button2.UseVisualStyleBackColor = true;
            // 
            // FormRegistroDeEncuesta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(463, 574);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(chkPuedeSerContactado);
            Controls.Add(tbEmail);
            Controls.Add(tbDistanciaASuDestino);
            Controls.Add(chkTranspPub);
            Controls.Add(chkUsaAuto);
            Controls.Add(chkUsaBicicleta);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormRegistroDeEncuesta";
            Text = "FormRegistroDeEncuesta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        public CheckBox chkTranspPub;
        public TextBox tbDistanciaASuDestino;
        private TextBox textBox2;
        private CheckBox checkBox4;
        public CheckBox chkUsaBicicleta;
        public CheckBox chkUsaAuto;
        public TextBox tbEmail;
        public CheckBox chkPuedeSerContactado;
        public Button button1;
        public Button button2;
    }
}