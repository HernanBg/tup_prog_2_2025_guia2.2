namespace Guia2._2Ejercicio2
{
    partial class FormDatosEmbarque
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
            tbNroEmbarque = new TextBox();
            gbAltaEmbarque = new Button();
            tbAñoFabricacion = new TextBox();
            tbMontoFabricacion = new TextBox();
            btnIngresarVehiculo = new Button();
            btnAceptar = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 27);
            label1.Name = "label1";
            label1.Size = new Size(171, 15);
            label1.TabIndex = 0;
            label1.Text = "Datos del embaruqe ingresante";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 212);
            label2.Name = "label2";
            label2.Size = new Size(128, 15);
            label2.TabIndex = 1;
            label2.Text = "Vehículo del embarque";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 93);
            label3.Name = "label3";
            label3.Size = new Size(108, 15);
            label3.TabIndex = 2;
            label3.Text = "Número embarque";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(55, 267);
            label4.Name = "label4";
            label4.Size = new Size(107, 15);
            label4.TabIndex = 3;
            label4.Text = "Año de fabricación";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 311);
            label5.Name = "label5";
            label5.Size = new Size(121, 15);
            label5.TabIndex = 4;
            label5.Text = "Monto de fabricación";
            // 
            // tbNroEmbarque
            // 
            tbNroEmbarque.Location = new Point(185, 90);
            tbNroEmbarque.Name = "tbNroEmbarque";
            tbNroEmbarque.Size = new Size(109, 23);
            tbNroEmbarque.TabIndex = 5;
            // 
            // gbAltaEmbarque
            // 
            gbAltaEmbarque.Location = new Point(337, 76);
            gbAltaEmbarque.Name = "gbAltaEmbarque";
            gbAltaEmbarque.Size = new Size(127, 48);
            gbAltaEmbarque.TabIndex = 6;
            gbAltaEmbarque.Text = "Alta Embarque";
            gbAltaEmbarque.UseVisualStyleBackColor = true;
            // 
            // tbAñoFabricacion
            // 
            tbAñoFabricacion.Location = new Point(194, 259);
            tbAñoFabricacion.Name = "tbAñoFabricacion";
            tbAñoFabricacion.Size = new Size(100, 23);
            tbAñoFabricacion.TabIndex = 7;
            // 
            // tbMontoFabricacion
            // 
            tbMontoFabricacion.Location = new Point(194, 303);
            tbMontoFabricacion.Name = "tbMontoFabricacion";
            tbMontoFabricacion.Size = new Size(100, 23);
            tbMontoFabricacion.TabIndex = 8;
            // 
            // btnIngresarVehiculo
            // 
            btnIngresarVehiculo.DialogResult = DialogResult.OK;
            btnIngresarVehiculo.Location = new Point(352, 258);
            btnIngresarVehiculo.Name = "btnIngresarVehiculo";
            btnIngresarVehiculo.Size = new Size(112, 68);
            btnIngresarVehiculo.TabIndex = 9;
            btnIngresarVehiculo.Text = "Ingresar Vehiculo del embarque";
            btnIngresarVehiculo.UseVisualStyleBackColor = true;
            btnIngresarVehiculo.Click += button2_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.DialogResult = DialogResult.OK;
            btnAceptar.Location = new Point(130, 380);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(99, 53);
            btnAceptar.TabIndex = 10;
            btnAceptar.Text = "Aceptar y Terminar Proceso";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // button4
            // 
            button4.DialogResult = DialogResult.Cancel;
            button4.Location = new Point(301, 380);
            button4.Name = "button4";
            button4.Size = new Size(75, 53);
            button4.TabIndex = 11;
            button4.Text = "Cancelar";
            button4.UseVisualStyleBackColor = true;
            // 
            // FormDatosEmbarque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(btnAceptar);
            Controls.Add(btnIngresarVehiculo);
            Controls.Add(tbMontoFabricacion);
            Controls.Add(tbAñoFabricacion);
            Controls.Add(gbAltaEmbarque);
            Controls.Add(tbNroEmbarque);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormDatosEmbarque";
            Text = "FormDatosEmbarque";
            Load += FormDatosEmbarque_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        public Button gbAltaEmbarque;
        public Button btnIngresarVehiculo;
        public Button btnAceptar;
        public Button button4;
        public TextBox tbNroEmbarque;
        public TextBox tbAñoFabricacion;
        public TextBox tbMontoFabricacion;
    }
}