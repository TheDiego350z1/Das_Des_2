using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAS_Desafio_1
{
    public partial class Splahs : Form
    {
        public Splahs()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }

        int contador = 0;

        private void Timer_tick(object sender, EventArgs e)
        {
            contador += 1;

            label1.Text = contador + " %";

            progressBar1.Increment(1);
            if(progressBar1.Value == 100)
            {
                timer1.Stop();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
