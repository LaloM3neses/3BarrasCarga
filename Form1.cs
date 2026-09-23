using System;
using System.Windows.Forms;

namespace _3BarrasProgreso
{
    public partial class Form1 : Form
    {
        // Ancho que tendrán las barras cuando lleguen a su meta (100% de escala)
        private int anchoMaximo;

        // Progreso actual de cada barra (0 a 100)
        private int progreso1 = 0;
        private int progreso2 = 0;
        private int progreso3 = 0;

        // Meta a la que debe llegar cada barra
        private const int META1 = 25; // CPU
        private const int META2 = 50; // Memoria RAM
        private const int META3 = 77; // Disco Duro

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Las tres barras se diseñaron con el mismo ancho, así que
            // tomamos cualquiera de ellas como referencia del 100%
            anchoMaximo = panelBarra1.Width;

            panelBarra1.Width = 0;
            panelBarra2.Width = 0;
            panelBarra3.Width = 0;
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            // Reiniciamos las tres barras por si se vuelve a presionar el botón
            progreso1 = 0;
            progreso2 = 0;
            progreso3 = 0;

            panelBarra1.Width = 0;
            panelBarra2.Width = 0;
            panelBarra3.Width = 0;

            lblPorcentaje1.Text = "0%";
            lblPorcentaje2.Text = "0%";
            lblPorcentaje3.Text = "0%";

            btnIniciar.Enabled = false;

            // Un solo timer controla las tres barras al mismo tiempo
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Barra 1 - CPU (se detiene en 25%)
            if (progreso1 < META1)
            {
                progreso1++;
                panelBarra1.Width = (int)(anchoMaximo * (progreso1 / 100.0));
                lblPorcentaje1.Text = (progreso1 >= META1) ? "Completado" : progreso1 + "%";
            }

            // Barra 2 - Memoria RAM (se detiene en 50%)
            if (progreso2 < META2)
            {
                progreso2++;
                panelBarra2.Width = (int)(anchoMaximo * (progreso2 / 100.0));
                lblPorcentaje2.Text = (progreso2 >= META2) ? "Completado" : progreso2 + "%";
            }

            // Barra 3 - Disco Duro (se detiene en 77%)
            if (progreso3 < META3)
            {
                progreso3++;
                panelBarra3.Width = (int)(anchoMaximo * (progreso3 / 100.0));
                lblPorcentaje3.Text = (progreso3 >= META3) ? "Completado" : progreso3 + "%";
            }

            // Cuando las tres llegaron a su meta, detenemos el timer
            if (progreso1 >= META1 && progreso2 >= META2 && progreso3 >= META3)
            {
                timer1.Stop();
                btnIniciar.Enabled = true;
            }
        }
    }
}