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
    public partial class tasks_form : Form
    {
        int CLICK_COUNTER = 0;

        public tasks_form()
        {
            InitializeComponent();
        }

        private void backToMainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tasks_form_Load(object sender, EventArgs e)
        {

        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox1.Text = "";
                comboBox1.ResetText();
                checkBox1.Checked = false;
                pictureBox1.BackColor = Color.Empty;
            }
            if (checkBox2.Checked == true)
            {
                textBox2.Text = "";
                comboBox2.ResetText();
                checkBox2.Checked = false;
                pictureBox2.BackColor = Color.Empty;
            }
            if (checkBox3.Checked == true)
            {
                textBox3.Text = "";
                comboBox3.ResetText();
                checkBox3.Checked = false;
                pictureBox3.BackColor = Color.Empty;
            }
            if (checkBox4.Checked == true)
            {
                textBox4.Text = "";
                comboBox4.ResetText();
                checkBox4.Checked = false;
                pictureBox4.BackColor = Color.Empty;
            }
            if (checkBox5.Checked == true)
            {
                textBox5.Text = "";
                comboBox5.ResetText();
                checkBox5.Checked = false;
                pictureBox5.BackColor = Color.Empty;
            }
            if (checkBox6.Checked == true)
            {
                textBox6.Text = "";
                comboBox6.ResetText();
                checkBox6.Checked = false;
                pictureBox6.BackColor = Color.Empty;
            }
            if (checkBox7.Checked == true)
            {
                textBox7.Text = "";
                comboBox7.ResetText();
                checkBox7.Checked = false;
                pictureBox7.BackColor = Color.Empty;
            }
            if (checkBox8.Checked == true)
            {
                textBox8.Text = "";
                comboBox8.ResetText();
                checkBox8.Checked = false;
                pictureBox8.BackColor = Color.Empty;
            }
            if (checkBox9.Checked == true)
            {
                textBox9.Text = "";
                comboBox9.ResetText();
                checkBox9.Checked = false;
                pictureBox9.BackColor = Color.Empty;
            }
            if (checkBox10.Checked == true)
            {
                textBox10.Text = "";
                comboBox10.ResetText();
                checkBox10.Checked = false;
                pictureBox10.BackColor = Color.Empty;
            }
            if (checkBox11.Checked == true)
            {
                textBox11.Text = "";
                comboBox11.ResetText();
                checkBox11.Checked = false;
                pictureBox11.BackColor = Color.Empty;
            }
            if (checkBox12.Checked == true)
            {
                textBox12.Text = "";
                comboBox12.ResetText();
                checkBox12.Checked = false;
                pictureBox12.BackColor = Color.Empty;
            }
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            CLICK_COUNTER++;

            if (CLICK_COUNTER == 1)
            {
                textBox2.Visible = true;
                comboBox2.Visible = true;
                checkBox2.Visible = true;
                pictureBox2.Visible = true;
            }
            if (CLICK_COUNTER == 2)
            {
                textBox3.Visible = true;
                comboBox3.Visible = true;
                checkBox3.Visible = true;
                pictureBox3.Visible = true;
            }
            if (CLICK_COUNTER == 3)
            {
                textBox4.Visible = true;
                comboBox4.Visible = true;
                checkBox4.Visible = true;
                pictureBox4.Visible = true;
            }
            if (CLICK_COUNTER == 4)
            {
                textBox5.Visible = true;
                comboBox5.Visible = true;
                checkBox5.Visible = true;
                pictureBox5.Visible = true;
            }
            if (CLICK_COUNTER == 5)
            {
                textBox6.Visible = true;
                comboBox6.Visible = true;
                checkBox6.Visible = true;
                pictureBox6.Visible = true;
            }
            if (CLICK_COUNTER == 6)
            {
                textBox7.Visible = true;
                comboBox7.Visible = true;
                checkBox7.Visible = true;
                pictureBox7.Visible = true;
            }
            if (CLICK_COUNTER == 7)
            {
                textBox8.Visible = true;
                comboBox8.Visible = true;
                checkBox8.Visible = true;
                pictureBox8.Visible = true;
            }
            if (CLICK_COUNTER == 8)
            {
                textBox9.Visible = true;
                comboBox9.Visible = true;
                checkBox9.Visible = true;
                pictureBox9.Visible = true;
            }
            if (CLICK_COUNTER == 9)
            {
                textBox10.Visible = true;
                comboBox10.Visible = true;
                checkBox10.Visible = true;
                pictureBox10.Visible = true;
            }
            if (CLICK_COUNTER == 10)
            {
                textBox11.Visible = true;
                comboBox11.Visible = true;
                checkBox11.Visible = true;
                pictureBox11.Visible = true;
            }
            if (CLICK_COUNTER == 11)
            {
                textBox12.Visible = true;
                comboBox12.Visible = true;
                checkBox12.Visible = true;
                pictureBox12.Visible = true;
                add_button.Enabled = false;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int status_index = comboBox1.SelectedIndex;

            if (status_index == 0)
            {
                pictureBox1.BackColor = Color.Red;
            }
            else if (status_index == 1)
            {
                pictureBox1.BackColor = Color.Orange;
            }
            else if (status_index == 2)
            {
                pictureBox1.BackColor = Color.Green;
            }
            else
            {
                pictureBox1.BackColor = Color.Empty;
            }
        }
    }
}
