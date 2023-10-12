namespace Front
{
    partial class MenuAltaCliente
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
            listBoxClientes = new ListBox();
            menuStrip1 = new MenuStrip();
            operacionesToolStripMenuItem = new ToolStripMenuItem();
            cuentaBancariaToolStripMenuItem = new ToolStripMenuItem();
            crearUnaCuentaBancariaToolStripMenuItem = new ToolStripMenuItem();
            tarjetaDeCreditoToolStripMenuItem = new ToolStripMenuItem();
            emitirTarjetaDeCreditoToolStripMenuItem = new ToolStripMenuItem();
            pagarTarjetaDeCreditoToolStripMenuItem = new ToolStripMenuItem();
            pausarTarjetaDeCreditoToolStripMenuItem = new ToolStripMenuItem();
            movimientosToolStripMenuItem = new ToolStripMenuItem();
            transferenciaToolStripMenuItem = new ToolStripMenuItem();
            extracciónToolStripMenuItem = new ToolStripMenuItem();
            depositoToolStripMenuItem = new ToolStripMenuItem();
            resumenToolStripMenuItem = new ToolStripMenuItem();
            generarResumenDeCuentaToolStripMenuItem = new ToolStripMenuItem();
            operacionesToolStripMenuItem1 = new ToolStripMenuItem();
            buttonAgregarCliente = new Button();
            textBoxDni = new TextBox();
            textBoxApellido = new TextBox();
            textBoxNombre = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            buttonEliminarCliente = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // listBoxClientes
            // 
            listBoxClientes.FormattingEnabled = true;
            listBoxClientes.ItemHeight = 20;
            listBoxClientes.Location = new Point(436, 12);
            listBoxClientes.Name = "listBoxClientes";
            listBoxClientes.Size = new Size(458, 324);
            listBoxClientes.TabIndex = 0;
            listBoxClientes.SelectedIndexChanged += listBoxClientes_SelectedIndexChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { operacionesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(906, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // operacionesToolStripMenuItem
            // 
            operacionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cuentaBancariaToolStripMenuItem, tarjetaDeCreditoToolStripMenuItem, movimientosToolStripMenuItem, resumenToolStripMenuItem, operacionesToolStripMenuItem1 });
            operacionesToolStripMenuItem.Name = "operacionesToolStripMenuItem";
            operacionesToolStripMenuItem.Size = new Size(106, 24);
            operacionesToolStripMenuItem.Text = "Operaciones";
            operacionesToolStripMenuItem.Click += operacionesToolStripMenuItem_Click;
            // 
            // cuentaBancariaToolStripMenuItem
            // 
            cuentaBancariaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { crearUnaCuentaBancariaToolStripMenuItem });
            cuentaBancariaToolStripMenuItem.Name = "cuentaBancariaToolStripMenuItem";
            cuentaBancariaToolStripMenuItem.Size = new Size(208, 26);
            cuentaBancariaToolStripMenuItem.Text = "Cuenta bancaria";
            cuentaBancariaToolStripMenuItem.Click += cuentaBancariaToolStripMenuItem_Click;
            // 
            // crearUnaCuentaBancariaToolStripMenuItem
            // 
            crearUnaCuentaBancariaToolStripMenuItem.Name = "crearUnaCuentaBancariaToolStripMenuItem";
            crearUnaCuentaBancariaToolStripMenuItem.Size = new Size(264, 26);
            crearUnaCuentaBancariaToolStripMenuItem.Text = "Crear una cuenta bancaria";
            crearUnaCuentaBancariaToolStripMenuItem.Click += crearUnaCuentaBancariaToolStripMenuItem_Click;
            // 
            // tarjetaDeCreditoToolStripMenuItem
            // 
            tarjetaDeCreditoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { emitirTarjetaDeCreditoToolStripMenuItem, pagarTarjetaDeCreditoToolStripMenuItem, pausarTarjetaDeCreditoToolStripMenuItem });
            tarjetaDeCreditoToolStripMenuItem.Name = "tarjetaDeCreditoToolStripMenuItem";
            tarjetaDeCreditoToolStripMenuItem.Size = new Size(208, 26);
            tarjetaDeCreditoToolStripMenuItem.Text = "Tarjeta de credito";
            // 
            // emitirTarjetaDeCreditoToolStripMenuItem
            // 
            emitirTarjetaDeCreditoToolStripMenuItem.Name = "emitirTarjetaDeCreditoToolStripMenuItem";
            emitirTarjetaDeCreditoToolStripMenuItem.Size = new Size(253, 26);
            emitirTarjetaDeCreditoToolStripMenuItem.Text = "Emitir tarjeta de credito";
            // 
            // pagarTarjetaDeCreditoToolStripMenuItem
            // 
            pagarTarjetaDeCreditoToolStripMenuItem.Name = "pagarTarjetaDeCreditoToolStripMenuItem";
            pagarTarjetaDeCreditoToolStripMenuItem.Size = new Size(253, 26);
            pagarTarjetaDeCreditoToolStripMenuItem.Text = "Pagar tarjeta de credito";
            // 
            // pausarTarjetaDeCreditoToolStripMenuItem
            // 
            pausarTarjetaDeCreditoToolStripMenuItem.Name = "pausarTarjetaDeCreditoToolStripMenuItem";
            pausarTarjetaDeCreditoToolStripMenuItem.Size = new Size(253, 26);
            pausarTarjetaDeCreditoToolStripMenuItem.Text = "Pausar tarjeta de credito";
            // 
            // movimientosToolStripMenuItem
            // 
            movimientosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { transferenciaToolStripMenuItem, extracciónToolStripMenuItem, depositoToolStripMenuItem });
            movimientosToolStripMenuItem.Name = "movimientosToolStripMenuItem";
            movimientosToolStripMenuItem.Size = new Size(208, 26);
            movimientosToolStripMenuItem.Text = "Movimientos";
            // 
            // transferenciaToolStripMenuItem
            // 
            transferenciaToolStripMenuItem.Name = "transferenciaToolStripMenuItem";
            transferenciaToolStripMenuItem.Size = new Size(179, 26);
            transferenciaToolStripMenuItem.Text = "Transferencia";
            // 
            // extracciónToolStripMenuItem
            // 
            extracciónToolStripMenuItem.Name = "extracciónToolStripMenuItem";
            extracciónToolStripMenuItem.Size = new Size(179, 26);
            extracciónToolStripMenuItem.Text = "Extracción";
            // 
            // depositoToolStripMenuItem
            // 
            depositoToolStripMenuItem.Name = "depositoToolStripMenuItem";
            depositoToolStripMenuItem.Size = new Size(179, 26);
            depositoToolStripMenuItem.Text = "Deposito";
            // 
            // resumenToolStripMenuItem
            // 
            resumenToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { generarResumenDeCuentaToolStripMenuItem });
            resumenToolStripMenuItem.Name = "resumenToolStripMenuItem";
            resumenToolStripMenuItem.Size = new Size(208, 26);
            resumenToolStripMenuItem.Text = "Cuenta";
            resumenToolStripMenuItem.Click += resumenToolStripMenuItem_Click;
            // 
            // generarResumenDeCuentaToolStripMenuItem
            // 
            generarResumenDeCuentaToolStripMenuItem.Name = "generarResumenDeCuentaToolStripMenuItem";
            generarResumenDeCuentaToolStripMenuItem.Size = new Size(273, 26);
            generarResumenDeCuentaToolStripMenuItem.Text = "Generar resumen de cuenta";
            // 
            // operacionesToolStripMenuItem1
            // 
            operacionesToolStripMenuItem1.Name = "operacionesToolStripMenuItem1";
            operacionesToolStripMenuItem1.Size = new Size(208, 26);
            operacionesToolStripMenuItem1.Text = "Operaciones";
            // 
            // buttonAgregarCliente
            // 
            buttonAgregarCliente.Location = new Point(149, 305);
            buttonAgregarCliente.Name = "buttonAgregarCliente";
            buttonAgregarCliente.Size = new Size(151, 57);
            buttonAgregarCliente.TabIndex = 17;
            buttonAgregarCliente.Text = "Agregar cliente";
            buttonAgregarCliente.UseVisualStyleBackColor = true;
            buttonAgregarCliente.Click += buttonAgregarCliente_Click;
            // 
            // textBoxDni
            // 
            textBoxDni.Location = new Point(118, 210);
            textBoxDni.Name = "textBoxDni";
            textBoxDni.Size = new Size(214, 27);
            textBoxDni.TabIndex = 16;
            // 
            // textBoxApellido
            // 
            textBoxApellido.Location = new Point(118, 163);
            textBoxApellido.Name = "textBoxApellido";
            textBoxApellido.Size = new Size(214, 27);
            textBoxApellido.TabIndex = 15;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(118, 116);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(214, 27);
            textBoxNombre.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 213);
            label4.Name = "label4";
            label4.Size = new Size(35, 20);
            label4.TabIndex = 12;
            label4.Text = "DNI";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 166);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 11;
            label3.Text = "Apellido";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 116);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 10;
            label2.Text = "Nombre";
            // 
            // buttonEliminarCliente
            // 
            buttonEliminarCliente.Location = new Point(740, 351);
            buttonEliminarCliente.Name = "buttonEliminarCliente";
            buttonEliminarCliente.Size = new Size(154, 56);
            buttonEliminarCliente.TabIndex = 18;
            buttonEliminarCliente.Text = "Eliminar cliente";
            buttonEliminarCliente.UseVisualStyleBackColor = true;
            buttonEliminarCliente.Click += buttonEliminarCliente_Click;
            // 
            // MenuIAltaCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(906, 450);
            Controls.Add(buttonEliminarCliente);
            Controls.Add(buttonAgregarCliente);
            Controls.Add(textBoxDni);
            Controls.Add(textBoxApellido);
            Controls.Add(textBoxNombre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(listBoxClientes);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MenuIAltaCliente";
            Text = "Principal";
            Load += Principal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem operacionesToolStripMenuItem;
        private ToolStripMenuItem cuentaBancariaToolStripMenuItem;
        private ToolStripMenuItem tarjetaDeCreditoToolStripMenuItem;
        private ToolStripMenuItem crearUnaCuentaBancariaToolStripMenuItem;
        private ToolStripMenuItem emitirTarjetaDeCreditoToolStripMenuItem;
        private ToolStripMenuItem pagarTarjetaDeCreditoToolStripMenuItem;
        private ToolStripMenuItem pausarTarjetaDeCreditoToolStripMenuItem;
        private ToolStripMenuItem movimientosToolStripMenuItem;
        private ToolStripMenuItem transferenciaToolStripMenuItem;
        private ToolStripMenuItem extracciónToolStripMenuItem;
        private ToolStripMenuItem depositoToolStripMenuItem;
        private ToolStripMenuItem resumenToolStripMenuItem;
        private ToolStripMenuItem generarResumenDeCuentaToolStripMenuItem;
        private ToolStripMenuItem operacionesToolStripMenuItem1;
        private Button buttonAgregarCliente;
        private TextBox textBoxDni;
        private TextBox textBoxApellido;
        private TextBox textBoxNombre;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button buttonEliminarCliente;
        public ListBox listBoxClientes;
    }
}