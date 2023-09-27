namespace Front
{
    partial class CuentaBancaria
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
            listBox1 = new ListBox();
            comboBoxTipoCuenta = new ComboBox();
            buttonVolver = new Button();
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
            buttonCrearCuentaBancaria.Location = new Point(148, 358);
            buttonCrearCuentaBancaria.Name = "buttonCrearCuentaBancaria";
            buttonCrearCuentaBancaria.Size = new Size(191, 52);
            buttonCrearCuentaBancaria.TabIndex = 8;
            buttonCrearCuentaBancaria.Text = "Crear cuenta";
            buttonCrearCuentaBancaria.UseVisualStyleBackColor = true;
            buttonCrearCuentaBancaria.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(402, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(386, 364);
            listBox1.TabIndex = 9;
            // 
            // comboBoxTipoCuenta
            // 
            comboBoxTipoCuenta.FormattingEnabled = true;
            comboBoxTipoCuenta.Items.AddRange(new object[] { "Caja de ahorro", "Cuenta corriente" });
            comboBoxTipoCuenta.Location = new Point(148, 276);
            comboBoxTipoCuenta.Name = "comboBoxTipoCuenta";
            comboBoxTipoCuenta.Size = new Size(194, 28);
            comboBoxTipoCuenta.TabIndex = 10;
            // 
            // buttonVolver
            // 
            buttonVolver.Location = new Point(657, 394);
            buttonVolver.Name = "buttonVolver";
            buttonVolver.Size = new Size(131, 53);
            buttonVolver.TabIndex = 11;
            buttonVolver.Text = "Volver";
            buttonVolver.UseVisualStyleBackColor = true;
            buttonVolver.Click += buttonVolver_Click;
            // 
            // CuentaBancaria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonVolver);
            Controls.Add(comboBoxTipoCuenta);
            Controls.Add(listBox1);
            Controls.Add(buttonCrearCuentaBancaria);
            Controls.Add(textBoxSaldoCuenta);
            Controls.Add(textBoxNumeroCuenta);
            Controls.Add(textBoxIdCuentaBancaria);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CuentaBancaria";
            Text = "CuentaBancaria";
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
        private ListBox listBox1;
        private ComboBox comboBoxTipoCuenta;
        private Button buttonVolver;
    }
}