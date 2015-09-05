using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Helpdesk
{
    public partial class providers_form : Form
    {
        public providers_form()
        {
            InitializeComponent();
        }

        private void backToMainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new main_form().Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void service_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            int service_selection = service_comboBox.SelectedIndex;

            if (service_selection == 0)
            {
                details_listBox.Text = service_comboBox.SelectedText;
            }
            else if (service_selection == 1)
            {
                details_listBox.Text = "Electrical";
            }
            else if (service_selection == 2)
            {
                details_listBox.Text = "Locksmith";
            }
            else if (service_selection == 3)
            {
                details_listBox.Text = "Plumber";
            }
            else if (service_selection == 4)
            {
                details_listBox.Text = "Roof Tilers";
            }
            else if (service_selection == 5)
            {
                details_listBox.Text = "Technicians";
            }
        }
    }
}
