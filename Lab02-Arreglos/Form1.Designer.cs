namespace Lab02_Arreglos
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
            lblTipoVehiculo = new Label();
            lblTipoServicio = new Label();
            cbxVehiculo = new ComboBox();
            cbxServicio = new ComboBox();
            listViewAtenciones = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            btnMostrar = new Button();
            btnRegistar = new Button();
            lblServicio1 = new Label();
            lblServicio2 = new Label();
            lblServicio3 = new Label();
            lblTotalServicio1 = new Label();
            lblTotalServicio2 = new Label();
            lblTotalServicio3 = new Label();
            lblServicioMinDemanda = new Label();
            label10 = new Label();
            lblMinimaDemanda = new Label();
            lblMontoPromedio = new Label();
            SuspendLayout();
            // 
            // lblTipoVehiculo
            // 
            lblTipoVehiculo.AutoSize = true;
            lblTipoVehiculo.Location = new Point(28, 25);
            lblTipoVehiculo.Name = "lblTipoVehiculo";
            lblTipoVehiculo.Size = new Size(138, 20);
            lblTipoVehiculo.TabIndex = 0;
            lblTipoVehiculo.Text = "TIPO DE VEHICULO:";
            // 
            // lblTipoServicio
            // 
            lblTipoServicio.AutoSize = true;
            lblTipoServicio.Location = new Point(28, 57);
            lblTipoServicio.Name = "lblTipoServicio";
            lblTipoServicio.Size = new Size(132, 20);
            lblTipoServicio.TabIndex = 1;
            lblTipoServicio.Text = "TIPO DE SERVICIO:";
            // 
            // cbxVehiculo
            // 
            cbxVehiculo.FormattingEnabled = true;
            cbxVehiculo.Items.AddRange(new object[] { "A", "C" });
            cbxVehiculo.Location = new Point(172, 17);
            cbxVehiculo.Name = "cbxVehiculo";
            cbxVehiculo.Size = new Size(151, 28);
            cbxVehiculo.TabIndex = 3;
            // 
            // cbxServicio
            // 
            cbxServicio.FormattingEnabled = true;
            cbxServicio.Items.AddRange(new object[] { "1", "2", "3" });
            cbxServicio.Location = new Point(172, 57);
            cbxServicio.Name = "cbxServicio";
            cbxServicio.Size = new Size(151, 28);
            cbxServicio.TabIndex = 4;
            // 
            // listViewAtenciones
            // 
            listViewAtenciones.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listViewAtenciones.Location = new Point(28, 132);
            listViewAtenciones.Name = "listViewAtenciones";
            listViewAtenciones.Size = new Size(731, 215);
            listViewAtenciones.TabIndex = 5;
            listViewAtenciones.UseCompatibleStateImageBehavior = false;
            listViewAtenciones.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Vehiculo";
            columnHeader1.Width = 70;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Tipo de Servicio";
            columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Monto a Pagar";
            columnHeader3.Width = 120;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(354, 51);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(187, 29);
            btnMostrar.TabIndex = 6;
            btnMostrar.Text = "MOSTRAR CLIENTES";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // btnRegistar
            // 
            btnRegistar.Location = new Point(354, 16);
            btnRegistar.Name = "btnRegistar";
            btnRegistar.Size = new Size(187, 29);
            btnRegistar.TabIndex = 7;
            btnRegistar.Text = "REGISTRAR ATENCION";
            btnRegistar.UseVisualStyleBackColor = true;
            btnRegistar.Click += btnRegistar_Click;
            // 
            // lblServicio1
            // 
            lblServicio1.AutoSize = true;
            lblServicio1.Location = new Point(28, 363);
            lblServicio1.Name = "lblServicio1";
            lblServicio1.Size = new Size(131, 20);
            lblServicio1.TabIndex = 8;
            lblServicio1.Text = "TOTAL SERVICIO 1:";
            // 
            // lblServicio2
            // 
            lblServicio2.AutoSize = true;
            lblServicio2.Location = new Point(28, 383);
            lblServicio2.Name = "lblServicio2";
            lblServicio2.Size = new Size(131, 20);
            lblServicio2.TabIndex = 9;
            lblServicio2.Text = "TOTAL SERVICIO 2:";
            // 
            // lblServicio3
            // 
            lblServicio3.AutoSize = true;
            lblServicio3.Location = new Point(28, 403);
            lblServicio3.Name = "lblServicio3";
            lblServicio3.Size = new Size(131, 20);
            lblServicio3.TabIndex = 10;
            lblServicio3.Text = "TOTAL SERVICIO 3:";
            // 
            // lblTotalServicio1
            // 
            lblTotalServicio1.AutoSize = true;
            lblTotalServicio1.Location = new Point(165, 364);
            lblTotalServicio1.Name = "lblTotalServicio1";
            lblTotalServicio1.Size = new Size(17, 20);
            lblTotalServicio1.TabIndex = 11;
            lblTotalServicio1.Text = "0";
            // 
            // lblTotalServicio2
            // 
            lblTotalServicio2.AutoSize = true;
            lblTotalServicio2.Location = new Point(165, 384);
            lblTotalServicio2.Name = "lblTotalServicio2";
            lblTotalServicio2.Size = new Size(17, 20);
            lblTotalServicio2.TabIndex = 12;
            lblTotalServicio2.Text = "0";
            // 
            // lblTotalServicio3
            // 
            lblTotalServicio3.AutoSize = true;
            lblTotalServicio3.Location = new Point(165, 404);
            lblTotalServicio3.Name = "lblTotalServicio3";
            lblTotalServicio3.Size = new Size(17, 20);
            lblTotalServicio3.TabIndex = 13;
            lblTotalServicio3.Text = "0";
            // 
            // lblServicioMinDemanda
            // 
            lblServicioMinDemanda.AutoSize = true;
            lblServicioMinDemanda.Location = new Point(376, 364);
            lblServicioMinDemanda.Name = "lblServicioMinDemanda";
            lblServicioMinDemanda.Size = new Size(211, 20);
            lblServicioMinDemanda.TabIndex = 14;
            lblServicioMinDemanda.Text = "SERVICIO MINIMA DEMANDA:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(376, 384);
            label10.Name = "label10";
            label10.Size = new Size(144, 20);
            label10.TabIndex = 15;
            label10.Text = "MONTO PROMEDIO:";
            // 
            // lblMinimaDemanda
            // 
            lblMinimaDemanda.AutoSize = true;
            lblMinimaDemanda.Location = new Point(593, 363);
            lblMinimaDemanda.Name = "lblMinimaDemanda";
            lblMinimaDemanda.Size = new Size(15, 20);
            lblMinimaDemanda.TabIndex = 16;
            lblMinimaDemanda.Text = "-";
            // 
            // lblMontoPromedio
            // 
            lblMontoPromedio.AutoSize = true;
            lblMontoPromedio.Location = new Point(526, 384);
            lblMontoPromedio.Name = "lblMontoPromedio";
            lblMontoPromedio.Size = new Size(17, 20);
            lblMontoPromedio.TabIndex = 17;
            lblMontoPromedio.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblMontoPromedio);
            Controls.Add(lblMinimaDemanda);
            Controls.Add(label10);
            Controls.Add(lblServicioMinDemanda);
            Controls.Add(lblTotalServicio3);
            Controls.Add(lblTotalServicio2);
            Controls.Add(lblTotalServicio1);
            Controls.Add(lblServicio3);
            Controls.Add(lblServicio2);
            Controls.Add(lblServicio1);
            Controls.Add(btnRegistar);
            Controls.Add(btnMostrar);
            Controls.Add(listViewAtenciones);
            Controls.Add(cbxServicio);
            Controls.Add(cbxVehiculo);
            Controls.Add(lblTipoServicio);
            Controls.Add(lblTipoVehiculo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTipoVehiculo;
        private Label lblTipoServicio;
        private ComboBox cbxVehiculo;
        private ComboBox cbxServicio;
        private ListView listViewAtenciones;
        private Button btnMostrar;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Button btnRegistar;
        private Label lblServicio1;
        private Label lblServicio2;
        private Label lblServicio3;
        private Label lblTotalServicio1;
        private Label lblTotalServicio2;
        private Label lblTotalServicio3;
        private Label lblServicioMinDemanda;
        private Label label10;
        private Label lblMinimaDemanda;
        private Label lblMontoPromedio;
    }
}