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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }



        string[] users = { "Diego", "Antonio", "Imer", "Juan", "Javier" };
        string[] password = { "123", "321", "abc", "ggg", "hhh" };

        public Dictionary<string, int> userkey = new Dictionary<string, int>();

        int intentos = 0; // intentos

        private void btnEntrar_Login_Click(object sender, EventArgs e)
        {
            userkey.Add("Diego", 0);
            userkey.Add("Antonio", 1);
            userkey.Add("Imer", 2);
            userkey.Add("Juan", 0);
            userkey.Add("Javier", 2);

            string name = txtName_Login.Text;
            string pass = txtPass_Login.Text;
            int key = userkey[name];

            int nameElement = Array.IndexOf(users, name);
            int passElement = Array.IndexOf(password, pass);

            if (intentos == 3)
            {
                MessageBox.Show("Ha llegado al número de intentos maximos");
                Application.Exit();
            }
            else if (nameElement == -1)
            {
                MessageBox.Show("Usuario Incorrecto");
                MessageBox.Show("Intentos: " + intentos);
                intentos++;
                txtName_Login.Clear();
                txtPass_Login.Clear();
            }
            else if (passElement == -1)
            {
                MessageBox.Show("Contraseña Incorrecta");
                MessageBox.Show("Intentos: " + intentos);
                intentos++;
                txtName_Login.Clear();
                txtPass_Login.Clear();
            }
            else if (users[nameElement] == name && password[passElement] == pass)
            {
                if (nameElement == passElement)
                {
                    MessageBox.Show("Usuario correcto");
                    this.Hide(); //Ocultamos la ventana de login
                    Dentro dentro = new Dentro();  //Instaciamos la ventana de "Dentro"
                    dentro.Show(); //Mostramos la nueva ventana
                    dentro.txtvat_dentro.Text = key.ToString();
                }
                else
                {
                    MessageBox.Show("Error: ingresar los datos correctos");
                    intentos++;
                    txtName_Login.Clear();
                    txtPass_Login.Clear();
                }
            }
            else
            {
                MessageBox.Show("Error inesperado");
                Application.Exit();
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El sistema se cerrara");
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}