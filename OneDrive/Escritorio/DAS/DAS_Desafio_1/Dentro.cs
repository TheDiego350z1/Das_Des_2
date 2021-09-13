using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DAS_Desafio_1
{
    public partial class Dentro : Form
    {
        public Dentro()
        {
            InitializeComponent();
        }

        public string Datos;
        //internal object textVar_Dentro;

        private void Dentro_Load(object sender, EventArgs e)
        {
            //Lenguaje_tabControl.Hide();
            //Series_tabControl.Hide();
            //Libros_tabControl.Hide();
            groupBox1.Hide();
            groupBox2.Hide();
            groupBox3.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void CHERNOBYL_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {
            //Vectores con los datos
            String[] serie = { "Juego de Tronos", "Chernobil", "La Maravillosa Señora Maisel" };
            int[] numero = { 40, 34, 26 };

            //Agregar título al grafico
            chart1.Titles.Add("Grafico de Seríes");

            //Agregar color al grafico
            chart1.Palette = ChartColorPalette.Pastel;

            //Insertar valores y series al grafico
            for (int i = 0; i < serie.Length; i++)
            {
                //Agregar las series
                chart1.Series["Series1"].Points.AddXY(serie[i], numero[i]);

            }
        }


        private void GAMES_OF_THRONES_Click(object sender, EventArgs e)
        {

        }

        private void textBox56_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox67_TextChanged(object sender, EventArgs e)
        {

        }

        private void chart2_Click(object sender, EventArgs e)
        {
            //Vectores con los datos
            string[] libro = { "Harry Potter", "Goosebumps", "Perry Mason" };
            int[] numero2 = { 44, 30, 26 };

            //Agregar título al grafico
            chart2.Titles.Add("Grafico de Libros");

            //Agregar color al grafico
            chart2.Palette = ChartColorPalette.Pastel;

            //Insertar valores y series al grafico
            for (int i = 0; i < libro.Length; i++)
            {
                //Agregar las series
                chart2.Series["Series1"].Points.AddXY(libro[i], numero2[i]);

            }
        }

        private void txtvat_dentro_TextChanged(object sender, EventArgs e)
        {
            txtvat_dentro.Hide();
        }

        private void btnMostar_Dentro_Click(object sender, EventArgs e)
        {
            int number;
            number = Int32.Parse(txtvat_dentro.Text);

            if (number == 2)
            {
                groupBox1.Show();
            }
            else if (number == 1)
            {
                groupBox1.Show();

            }
            else if (number == 0)
            {
                groupBox1.Show();
            }
            btnMostar_Dentro.Hide();
        }

        private void chart3_Click_1(object sender, EventArgs e)
        {
                //Vectores con los datos
                string[] lenguaje = { "Python", "Java", "JavaScript" };
                int[] numero1 = { 47, 38, 15 };

                //Agregar título al grafico
                chart3.Titles.Add("Grafico de Lenguajes");

                //Agregar color al grafico
                chart3.Palette = ChartColorPalette.Pastel;

                //Insertar valores y series al grafico
                for (int i = 0; i < lenguaje.Length; i++)
                {
                    //Agregar las series
                    chart3.Series["Series1"].Points.AddXY(lenguaje[i], numero1[i]);
                }
        }

        private void Series_tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}