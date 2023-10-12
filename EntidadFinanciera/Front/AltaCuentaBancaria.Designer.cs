namespace Front
{
    partial class AltaCuentaBancaria
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
            textBoxIdCuentaBancaria = new TextBox();
            textBoxNumeroCuenta = new TextBox();
            textBoxSaldoCuenta = new TextBox();
            buttonCrearCuentaBancaria = new Button();
            listBoxCuentasBancarias = new ListBox();
            comboBoxTipoCuenta = new ComboBox();
            buttonVolver = new Button();
            label5 = new Label();
            label6 = new Label();
            buttonEliminarCuenta = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 54);
            label1.Name = "label1";
            label1.Size = new Size(135, 20);
            label1.TabIndex = 0;
            label1.Text = "ID Cuenta bancaria";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 138);
            label2.Name = "label2";
            label2.Size = new Size(132, 20);
            label2.TabIndex = 1;
            label2.Text = "Numero de cuenta";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 204);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 2;
            label3.Text = "Saldo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 284);
            label4.Name = "label4";
            label4.Size = new Size(108, 20);
            label4.TabIndex = 3;
            label4.Text = "Tipo de cuenta";
            // 
            // textBoxIdCuentaBancaria
            // 
            textBoxIdCuentaBancaria.Location = new Point(148, 54);
            textBoxIdCuentaBancaria.Name = "textBoxIdCuentaBancaria";
            textBoxIdCuentaBancaria.Size = new Size(194, 27);
            textBoxIdCuentaBancaria.TabIndex = 4;
            // 
            // textBoxNumeroCuenta
            // 
            textBoxNumeroCuenta.Location = new Point(148, 135);
            textBoxNumeroCuenta.Name = "textBoxNumeroCuenta";
            textBoxNumeroCuenta.Size = new Size(194, 27);
            textBoxNumeroCuenta.TabIndex = 5;
            // 
            // textBoxSaldoCuenta
            // 
            textBoxSaldoCuenta.Location = new Point(148, 201);
            textBoxSaldoCuenta.Name = "textBoxSaldoCuenta";
            textBoxSaldoCuenta.Size = new Size(194, 27);
            textBoxSaldoCuenta.TabIndex = 6;
            // 
            // buttonCrearCuentaBancaria
            // 
            buttonCrearCuentaBancaria.Location = new Point(148, 350);
            buttonCrearCuentaBancaria.Name = "buttonCrearCuentaBancaria";
            buttonCrearCuentaBancaria.Size = new Size(191, 52);
            buttonCrearCuentaBancaria.TabIndex = 8;
            buttonCrearCuentaBancaria.Text = "Crear cuenta bancaria";
            buttonCrearCuentaBancaria.UseVisualStyleBackColor = true;
            buttonCrearCuentaBancaria.Click += button1_Click;
            // 
            // listBoxCuentasBancarias
            // 
            listBoxCuentasBancarias.FormattingEnabled = true;
            listBoxCuentasBancarias.ItemHeight = 20;
            listBoxCuentasBancarias.Location = new Point(402, 12);
            listBoxCuentasBancarias.Name = "listBoxCuentasBancarias";
            listBoxCuentasBancarias.Size = new Size(558, 364);
            listBoxCuentasBancarias.TabIndex = 9;
            // 
            // comboBoxTipoCuenta
            // 
            comboBoxTipoCuenta.FormattingEnabled = true;
            comboBoxTipoCuenta.Location = new Point(148, 276);
            comboBoxTipoCuenta.Name = "comboBoxTipoCuenta";
            comboBoxTipoCuenta.Size = new Size(194, 28);
            comboBoxTipoCuenta.TabIndex = 10;
            comboBoxTipoCuenta.SelectedIndexChanged += comboBoxTipoCuenta_SelectedIndexChanged;
            // 
            // buttonVolver
            // 
            buttonVolver.Location = new Point(808, 385);
            buttonVolver.Name = "buttonVolver";
            buttonVolver.Size = new Size(131, 53);
            buttonVolver.TabIndex = 11;
            buttonVolver.Text = "Volver";
            buttonVolver.UseVisualStyleBackColor = true;
            buttonVolver.Click += buttonVolver_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(121, 12);
            label5.Name = "label5";
            label5.Size = new Size(97, 20);
            label5.TabIndex = 12;
            label5.Text = "labelNombre";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(240, 12);
            label6.Name = "label6";
            label6.Size = new Size(99, 20);
            label6.TabIndex = 13;
            label6.Text = "labelApellido";
            // 
            // buttonEliminarCuenta
            // 
            buttonEliminarCuenta.Location = new Point(555, 387);
            buttonEliminarCuenta.Name = "buttonEliminarCuenta";
            buttonEliminarCuenta.Size = new Size(140, 51);
            buttonEliminarCuenta.TabIndex = 14;
            buttonEliminarCuenta.Text = "Eliminar cuenta bancaria";
            buttonEliminarCuenta.UseVisualStyleBackColor = true;
            buttonEliminarCuenta.Click += buttonEliminarCuenta_Click;
            // 
            // AltaCuentaBancaria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(972, 450);
            Controls.Add(buttonEliminarCuenta);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(buttonVolver);
            Controls.Add(comboBoxTipoCuenta);
            Controls.Add(listBoxCuentasBancarias);
            Controls.Add(buttonCrearCuentaBancaria);
            Controls.Add(textBoxSaldoCuenta);
            Controls.Add(textBoxNumeroCuenta);
            Controls.Add(textBoxIdCuentaBancaria);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AltaCuentaBancaria";
            Text = "CuentaBancaria";
            Load += CuentaBancaria_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxIdCuentaBancaria;
        private TextBox textBoxNumeroCuenta;
        private TextBox textBoxSaldoCuenta;
        private Button buttonCrearCuentaBancaria;
        private ListBox listBoxCuentasBancarias;
        private ComboBox comboBoxTipoCuenta;
        private Button buttonVolver;
        private Label label5;
        private Label label6;
        private Button buttonEliminarCuenta;
    }
}