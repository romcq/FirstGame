using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstGame
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void StartGameBtn_Click(object sender, EventArgs e)
        {
            bool mainGame = false;

            foreach(Form form in Application.OpenForms)
            {
                if (form.Name.ToString() == "Game")
                {
                    Hide();
                    form.Visible = true;
                    mainGame = true;
                    break;
                }
            }

            if (mainGame == false)
            {
                Game form1 = new Game();
                Hide();
                form1.Show();
            }
        }

        private void ExitGameBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool control = false;

            foreach (Form form in Application.OpenForms)
            {
                if (form.Name.ToString() == "Control")
                {
                    Hide();
                    form.Visible = true;
                    control = true;
                    break;
                }
            }

            if (control == false)
            {
                Control control1 = new Control();
                Hide();
                control1.Show();
            }
        }
    }
}
