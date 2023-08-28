namespace Lab02_Arreglos
{
    public partial class Form1 : Form
    {
        //Arreglo:
        Atencion[] atenciones = new Atencion[100];
        int cont = 0;
        int TotalServicio1 = 0;
        int TotalServicio2 = 0;
        int TotalServicio3 = 0;
        double montoPromedio = 0;
        String ServicioMinimaDemanda = "Servicio 1";
        int minimaDemanda = 999;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistar_Click(object sender, EventArgs e)
        {
            //validaciones:
            if (cbxVehiculo.Text == "" || cbxServicio.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }
            //Creacion de la otra atencion:
            Atencion atencion = new Atencion();
            atencion.TipoAuto = cbxVehiculo.Text;
            atencion.TipoServicio = cbxServicio.Text;

            //Asignacion de los montos:
            switch (atencion.TipoServicio)
            {
                case "1": atencion.Monto = 10; TotalServicio1++; break;
                case "2": atencion.Monto = 15; TotalServicio2++; break;
                case "3": atencion.Monto = 10; TotalServicio3++; break;
            }
            if (atencion.TipoAuto == "C") atencion.Monto *= 1.05;
            //Agrega el arreglo
            atenciones[cont] = atencion;
            cont++;

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            listViewAtenciones.Items.Clear();
            montoPromedio = 0;

            //Recorre el arreglo
            for (int i = 0; i < cont; i++)
            {
                ListViewItem fila = new ListViewItem(atenciones[i].TipoAuto);
                fila.SubItems.Add(atenciones[i].TipoServicio);
                fila.SubItems.Add(atenciones[i].Monto.ToString());
                listViewAtenciones.Items.Add(fila);
                montoPromedio += atenciones[i].Monto;
            }

            //Calcula los requerimientos:
            montoPromedio = montoPromedio / cont;
            lblMontoPromedio.Text = montoPromedio.ToString();
            lblTotalServicio1.Text = TotalServicio1.ToString();
            lblTotalServicio2.Text = TotalServicio2.ToString();
            lblTotalServicio3.Text = TotalServicio3.ToString();

            //Arreglo:
            int[] totales = { TotalServicio1, TotalServicio2, TotalServicio3 };
            int min = totales.Min();

            //Calcula el servicio minima demanda:

            if (min == totales[0]) lblServicioMinDemanda.Text = "Servicio 1";
            else if (min == totales[1]) lblMinimaDemanda.Text = "Servicio 2";
            else if (min == totales[1]) lblMinimaDemanda.Text = "Servicio 3";
        }
    }
}