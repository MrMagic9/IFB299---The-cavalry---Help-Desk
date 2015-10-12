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
    public partial class forum_form : Form
    {
        public forum_form()
        {
            InitializeComponent();
        }

        private void backToMainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void forum_form_Load(object sender, EventArgs e)
        {
            service_comboBox.Items.Add("Carpentry");
            service_comboBox.Items.Add("Carpeting");
            service_comboBox.Items.Add("Electrical");
            service_comboBox.Items.Add("Flooring");
            service_comboBox.Items.Add("Gardening");
            service_comboBox.Items.Add("Locksmith");
            service_comboBox.Items.Add("Plumbing");
            service_comboBox.Items.Add("Roof Tiling");
            service_comboBox.Items.Add("Technicians");
            service_comboBox.Items.Add("Tiling");
            service_comboBox.Items.Add("Window Repair");
        }

        private void service_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            providername_comboBox.Enabled = true;

            int service_selection = service_comboBox.SelectedIndex;

            if (service_selection == 0)
            {
                providername_comboBox.Items.Clear();
                providername_comboBox.Items.Add("Bill's Carpentry");
            }

            else if (service_selection == 1)
            {
                providername_comboBox.Items.Clear();
                providername_comboBox.Items.Add("Bill's Carpets");
            }

            else if (service_selection == 2)
            {
                providername_comboBox.Items.Clear();
                providername_comboBox.Items.Add("Fallon Electrical, Plumbing & Air Conditioning");
                providername_comboBox.Items.Add("Platinum Electricians");
                providername_comboBox.Items.Add("Sunelec");
                providername_comboBox.Items.Add("Bevan Robinson Electrical Services");
                providername_comboBox.Items.Add("Algester Electrical");
                providername_comboBox.Items.Add("Spot on Electrical");
                providername_comboBox.Items.Add("FIXZIT Plumbing & Electrical");
            }

            else if (service_selection == 3)
            {
                providername_comboBox.Items.Clear();
                providername_comboBox.Items.Add("Eazy Flooring");
            }

            else if (service_selection == 4)
            {
                providername_comboBox.Items.Clear();
                providername_comboBox.Items.Add("Green Gardening");
            }

            else if (service_selection == 5)
            {
                providername_comboBox.Items.Clear();
                providername_comboBox.Items.Add("Allstrong Locksmiths & Security");
                providername_comboBox.Items.Add("Golden Locksmiths");
                providername_comboBox.Items.Add("Retro Security");
                providername_comboBox.Items.Add("Secure Locksmiths");
            }

            else if (service_selection == 6)
            {
                providername_comboBox.Items.Clear();
                providername_comboBox.Items.Add("Plumbworks");
                providername_comboBox.Items.Add("Express Plumbing Solutions");
            }

            else if (service_selection == 7)
            {
                providername_comboBox.Items.Clear();
                providername_comboBox.Items.Add("Total Roof Tilers");
            }

            else if (service_selection == 8)
            {
                providername_comboBox.Items.Clear();
                providername_comboBox.Items.Add("Fast Technicians");
            }

            else if (service_selection == 9)
            {
                providername_comboBox.Items.Clear();
                providername_comboBox.Items.Add("Tilerworks");
            }

            else if (service_selection == 10)
            {
                providername_comboBox.Items.Clear();
                providername_comboBox.Items.Add("Windows & Glass Professionals");
                providername_comboBox.Items.Add("Cracked Window Specialists");
                providername_comboBox.Items.Add("Express Window Repair");
            }
        }

        private void providername_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            feedback_textBox.Enabled = true;

            int service_selection = service_comboBox.SelectedIndex;
            int provider_name = providername_comboBox.SelectedIndex;

            if (service_selection == 0)
            {
                if (provider_name == 0)
                {
                    feedback_listBox.Items.Clear();
                    feedback_listBox.Items.Add("Bill's Carpentry:");
                }
            }

            if (service_selection == 1)
            {
                if (provider_name == 0)
                {
                    feedback_listBox.Items.Clear();
                    feedback_listBox.Items.Add("Bill's Carpets:");
                }
            }

            if (service_selection == 2)
            {
                if (provider_name == 0)
                {
                    feedback_listBox.Items.Clear();
                    feedback_listBox.Items.Add("Fallon Electrical, Plumbing & Air Conditioning:");
                }

                else if (provider_name == 1)
                {
                    feedback_listBox.Items.Clear();
                    feedback_listBox.Items.Add("Platinum Electricians:");
                }

                else if (provider_name == 2)
                {
                    feedback_listBox.Items.Clear();
                    feedback_listBox.Items.Add("Sunelec:");
                }

                else if (provider_name == 3)
                {
                    feedback_listBox.Items.Clear();
                    feedback_listBox.Items.Add("Bevan Robinson Electrical Services:");
                }

                else if (provider_name == 4)
                {
                    feedback_listBox.Items.Clear();
                    feedback_listBox.Items.Add("Algester Electrical:");
                }

                else if (provider_name == 5)
                {
                    feedback_listBox.Items.Clear();
                    feedback_listBox.Items.Add("Spot on Electrical:");
                }

                else if (provider_name == 6)
                {
                    feedback_listBox.Items.Clear();
                    feedback_listBox.Items.Add("FIXZIT Plumbing & Electrical:");
                }
            }

            if (service_selection == 3)
            {
                if (provider_name == 0)
                {
                    feedback_listBox.Items.Clear();
                    feedback_listBox.Items.Add("Eazy Flooring:");
                }
            }

            if (service_selection == 4)
            {
                if (provider_name == 0)
                {
                    feedback_listBox.Items.Clear();
                    feedback_listBox.Items.Add("Green Gardening:");
                }
            }

            if (service_selection == 5)
            {
                if (provider_name == 0)
                {
                    feedback_listBox.Items.Clear();
                    feedback_listBox.Items.Add("Allstrong Locksmiths & Security:");
                }

                else if (provider_name == 1)
                {
                    feedback_listBox.Items.Clear();
                    feedback_listBox.Items.Add("Golden Locksmiths:");
                }

                else if (provider_name == 2)
                {
                    feedback_listBox.Items.Clear();
                    feedback_listBox.Items.Add("Retro Security:");
                }

                else if (provider_name == 3)
                {
                    feedback_listBox.Items.Clear();
                    feedback_listBox.Items.Add("Secure Locksmiths:");
                }
            }

            if (service_selection == 6)
            {
                if (provider_name == 0)
                {
                    feedback_listBox.Items.Clear();
                    feedback_listBox.Items.Add("Plumbworks:");
                }

                else if (provider_name == 1)
                {
                    feedback_listBox.Items.Clear();
                    feedback_listBox.Items.Add("Express Plumbing Solutions:");
                }
            }

            if (service_selection == 7)
            {
                if (provider_name == 0)
                {
                    feedback_listBox.Items.Clear();
                    feedback_listBox.Items.Add("Total Roof Tilers:");
                }
            }

            if (service_selection == 8)
            {
                if (provider_name == 0)
                {
                    feedback_listBox.Items.Clear();
                    feedback_listBox.Items.Add("Fast Technicians:");
                }
            }

            if (service_selection == 9)
            {
                if (provider_name == 0)
                {
                    feedback_listBox.Items.Clear();
                    feedback_listBox.Items.Add("Tilerworks:");
                }
            }

            if (service_selection == 10)
            {
                if (provider_name == 0)
                {
                    feedback_listBox.Items.Clear();
                    feedback_listBox.Items.Add("Windows & Glass Professionals");
                }

                else if (provider_name == 1)
                {
                    feedback_listBox.Items.Clear();
                    feedback_listBox.Items.Add("Cracked Window Specialists");
                }

                else if (provider_name == 2)
                {
                    feedback_listBox.Items.Clear();
                    feedback_listBox.Items.Add("Express Window Repair");
                }
            }
        }

        private void submit_button_Click(object sender, EventArgs e)
        {
            feedback_listBox.Items.Add(feedback_textBox.Text);
            feedback_textBox.Text = "";
            submit_button.Enabled = false;
        }

        private void feedback_textBox_TextChanged(object sender, EventArgs e)
        {
            submit_button.Enabled = true;
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }
    }
}
