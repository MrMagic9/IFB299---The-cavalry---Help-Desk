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
    public partial class volunteers_details : Form
    {
        int CALENDAR_COUNTER = 0;

        public volunteers_details()
        {
            InitializeComponent();
        }

        private void backToMainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            int ID = 0;

            details_listBox.Items.Add("ID: " + ID++);
            details_listBox.Items.Add("Name: " + name_textBox.Text);
            name_textBox.Text = "";
            details_listBox.Items.Add("DOB: " + day_numeric.Value + "/" + month_numeric.Value + "/" + year_textBox.Text);
            day_numeric.Value = 1;
            month_numeric.Value = 1;
            year_textBox.Text = "";
            details_listBox.Items.Add("Phone: " + phone_textBox.Text);
            phone_textBox.Text = "";
            details_listBox.Items.Add("E-Mail: " + email_textBox.Text);
            email_textBox.Text = "";
            details_listBox.Items.Add("Role: " + role_comboBox.SelectedItem);
            role_comboBox.ResetText();
            details_listBox.Items.Add("Roster:");
            details_listBox.Items.Add(textBox1.Text);
            details_listBox.Items.Add(textBox2.Text);
            details_listBox.Items.Add(textBox3.Text);
            details_listBox.Items.Add("");

            CALENDAR_COUNTER = 0;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

        }

        private void volunteers_details_Load(object sender, EventArgs e)
        {
        
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            CALENDAR_COUNTER++;

            if (CALENDAR_COUNTER == 1)
            {
                textBox1.Text = "" + dateTimePicker1.Value;
            }

            else if (CALENDAR_COUNTER == 2)
            {
                textBox2.Text = "" + dateTimePicker1.Value;
            }

            else if (CALENDAR_COUNTER == 3)
            {
                textBox3.Text = "" + dateTimePicker1.Value;
            }
        }
    }
}
