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
    public partial class Control : Form
    {
        public Control()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool menu = false;

            foreach (Form form in Application.OpenForms)
            {
                if (form.Name.ToString() == "Menu")
                {
                    Hide();
                    form.Visible = true;
                    menu = true;
                    break;
                }
            }

            if (menu == false)
            {
                Menu menu1 = new Menu();
                Hide();
                menu1.Show();
            }
        }
    }
}
