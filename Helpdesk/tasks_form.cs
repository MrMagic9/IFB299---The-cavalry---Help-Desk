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
                checkBox1.Enabled = false;
                comboBox1.Enabled = false;
            }
            if (checkBox2.Checked == true)
            {
                textBox2.Text = "";
                comboBox2.ResetText();
                checkBox2.Checked = false;
                pictureBox2.BackColor = Color.Empty;
                checkBox2.Enabled = false;
                comboBox2.Enabled = false;
            }
            if (checkBox3.Checked == true)
            {
                textBox3.Text = "";
                comboBox3.ResetText();
                checkBox3.Checked = false;
                pictureBox3.BackColor = Color.Empty;
                checkBox3.Enabled = false;
                comboBox3.Enabled = false;
            }
            if (checkBox4.Checked == true)
            {
                textBox4.Text = "";
                comboBox4.ResetText();
                checkBox4.Checked = false;
                pictureBox4.BackColor = Color.Empty;
                checkBox4.Enabled = false;
                comboBox4.Enabled = false;
            }
            if (checkBox5.Checked == true)
            {
                textBox5.Text = "";
                comboBox5.ResetText();
                checkBox5.Checked = false;
                pictureBox5.BackColor = Color.Empty;
                checkBox5.Enabled = false;
                comboBox5.Enabled = false;
            }
            if (checkBox6.Checked == true)
            {
                textBox6.Text = "";
                comboBox6.ResetText();
                checkBox6.Checked = false;
                pictureBox6.BackColor = Color.Empty;
                checkBox6.Enabled = false;
                comboBox6.Enabled = false;
            }
            if (checkBox7.Checked == true)
            {
                textBox7.Text = "";
                comboBox7.ResetText();
                checkBox7.Checked = false;
                pictureBox7.BackColor = Color.Empty;
                checkBox7.Enabled = false;
                comboBox7.Enabled = false;
            }
            if (checkBox8.Checked == true)
            {
                textBox8.Text = "";
                comboBox8.ResetText();
                checkBox8.Checked = false;
                pictureBox8.BackColor = Color.Empty;
                checkBox8.Enabled = false;
                comboBox8.Enabled = false;
            }
            if (checkBox9.Checked == true)
            {
                textBox9.Text = "";
                comboBox9.ResetText();
                checkBox9.Checked = false;
                pictureBox9.BackColor = Color.Empty;
                checkBox9.Enabled = false;
                comboBox9.Enabled = false;
            }
            if (checkBox10.Checked == true)
            {
                textBox10.Text = "";
                comboBox10.ResetText();
                checkBox10.Checked = false;
                pictureBox10.BackColor = Color.Empty;
                checkBox10.Enabled = false;
                comboBox10.Enabled = false;
            }
            if (checkBox11.Checked == true)
            {
                textBox11.Text = "";
                comboBox11.ResetText();
                checkBox11.Checked = false;
                pictureBox11.BackColor = Color.Empty;
                checkBox11.Enabled = false;
                comboBox11.Enabled = false;
            }
            if (checkBox12.Checked == true)
            {
                textBox12.Text = "";
                comboBox12.ResetText();
                checkBox12.Checked = false;
                pictureBox12.BackColor = Color.Empty;
                checkBox12.Enabled = false;
                comboBox12.Enabled = false;
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
                checkBox1.Checked = false;
            }
            else if (status_index == 1)
            {
                pictureBox1.BackColor = Color.Orange;
                checkBox1.Checked = false;
            }
            else if (status_index == 2)
            {
                pictureBox1.BackColor = Color.Blue;
                checkBox1.Checked = false;
            }
            else if (status_index == 3)
            {
                pictureBox1.BackColor = Color.Green;
                checkBox1.Checked = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 3;
            if (checkBox1.Checked == false)
            {
                comboBox1.ResetText();
                pictureBox1.BackColor = Color.Empty;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int status_index = comboBox2.SelectedIndex;

            if (status_index == 0)
            {
                pictureBox2.BackColor = Color.Red;
                checkBox2.Checked = false;
            }
            else if (status_index == 1)
            {
                pictureBox2.BackColor = Color.Orange;
                checkBox2.Checked = false;
            }
            else if (status_index == 2)
            {
                pictureBox2.BackColor = Color.Blue;
                checkBox2.Checked = false;
            }
            else if (status_index == 3)
            {
                pictureBox2.BackColor = Color.Green;
                checkBox2.Checked = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            comboBox2.SelectedIndex = 3;
            if (checkBox2.Checked == false)
            {
                comboBox2.ResetText();
                pictureBox2.BackColor = Color.Empty;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            checkBox1.Enabled = true;
            comboBox1.Enabled = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            checkBox2.Enabled = true;
            comboBox2.Enabled = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            checkBox3.Enabled = true;
            comboBox3.Enabled = true;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            int status_index = comboBox3.SelectedIndex;

            if (status_index == 0)
            {
                pictureBox3.BackColor = Color.Red;
                checkBox3.Checked = false;
            }
            else if (status_index == 1)
            {
                pictureBox3.BackColor = Color.Orange;
                checkBox3.Checked = false;
            }
            else if (status_index == 2)
            {
                pictureBox3.BackColor = Color.Blue;
                checkBox3.Checked = false;
            }
            else if (status_index == 3)
            {
                pictureBox3.BackColor = Color.Green;
                checkBox3.Checked = true;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            comboBox3.SelectedIndex = 3;
            if (checkBox3.Checked == false)
            {
                comboBox3.ResetText();
                pictureBox3.BackColor = Color.Empty;
            }
        }

        private void menuStrip1_ItemClicked(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            checkBox4.Enabled = true;
            comboBox4.Enabled = true;
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            int status_index = comboBox4.SelectedIndex;

            if (status_index == 0)
            {
                pictureBox4.BackColor = Color.Red;
                checkBox4.Checked = false;
            }
            else if (status_index == 1)
            {
                pictureBox4.BackColor = Color.Orange;
                checkBox4.Checked = false;
            }
            else if (status_index == 2)
            {
                pictureBox4.BackColor = Color.Blue;
                checkBox4.Checked = false;
            }
            else if (status_index == 3)
            {
                pictureBox4.BackColor = Color.Green;
                checkBox4.Checked = true;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            comboBox4.SelectedIndex = 3;
            if (checkBox4.Checked == false)
            {
                comboBox4.ResetText();
                pictureBox4.BackColor = Color.Empty;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            checkBox5.Enabled = true;
            comboBox5.Enabled = true;
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            int status_index = comboBox5.SelectedIndex;

            if (status_index == 0)
            {
                pictureBox5.BackColor = Color.Red;
                checkBox5.Checked = false;
            }
            else if (status_index == 1)
            {
                pictureBox5.BackColor = Color.Orange;
                checkBox5.Checked = false;
            }
            else if (status_index == 2)
            {
                pictureBox5.BackColor = Color.Blue;
                checkBox5.Checked = false;
            }
            else if (status_index == 3)
            {
                pictureBox5.BackColor = Color.Green;
                checkBox5.Checked = true;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            comboBox5.SelectedIndex = 3;
            if (checkBox5.Checked == false)
            {
                comboBox5.ResetText();
                pictureBox5.BackColor = Color.Empty;
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            checkBox6.Enabled = true;
            comboBox6.Enabled = true;
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            int status_index = comboBox6.SelectedIndex;

            if (status_index == 0)
            {
                pictureBox6.BackColor = Color.Red;
                checkBox6.Checked = false;
            }
            else if (status_index == 1)
            {
                pictureBox6.BackColor = Color.Orange;
                checkBox6.Checked = false;
            }
            else if (status_index == 2)
            {
                pictureBox6.BackColor = Color.Blue;
                checkBox6.Checked = false;
            }
            else if (status_index == 3)
            {
                pictureBox6.BackColor = Color.Green;
                checkBox6.Checked = true;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            comboBox6.SelectedIndex = 3;
            if (checkBox6.Checked == false)
            {
                comboBox6.ResetText();
                pictureBox6.BackColor = Color.Empty;
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            checkBox7.Enabled = true;
            comboBox7.Enabled = true;
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            int status_index = comboBox7.SelectedIndex;

            if (status_index == 0)
            {
                pictureBox7.BackColor = Color.Red;
                checkBox7.Checked = false;
            }
            else if (status_index == 1)
            {
                pictureBox7.BackColor = Color.Orange;
                checkBox7.Checked = false;
            }
            else if (status_index == 2)
            {
                pictureBox7.BackColor = Color.Blue;
                checkBox7.Checked = false;
            }
            else if (status_index == 3)
            {
                pictureBox7.BackColor = Color.Green;
                checkBox7.Checked = true;
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            comboBox7.SelectedIndex = 3;
            if (checkBox7.Checked == false)
            {
                comboBox7.ResetText();
                pictureBox7.BackColor = Color.Empty;
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            checkBox8.Enabled = true;
            comboBox8.Enabled = true;
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            int status_index = comboBox8.SelectedIndex;

            if (status_index == 0)
            {
                pictureBox8.BackColor = Color.Red;
                checkBox8.Checked = false;
            }
            else if (status_index == 1)
            {
                pictureBox8.BackColor = Color.Orange;
                checkBox8.Checked = false;
            }
            else if (status_index == 2)
            {
                pictureBox8.BackColor = Color.Blue;
                checkBox8.Checked = false;
            }
            else if (status_index == 3)
            {
                pictureBox8.BackColor = Color.Green;
                checkBox8.Checked = true;
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            comboBox8.SelectedIndex = 3;
            if (checkBox8.Checked == false)
            {
                comboBox8.ResetText();
                pictureBox8.BackColor = Color.Empty;
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            checkBox9.Enabled = true;
            comboBox9.Enabled = true;
        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            int status_index = comboBox9.SelectedIndex;

            if (status_index == 0)
            {
                pictureBox9.BackColor = Color.Red;
                checkBox9.Checked = false;
            }
            else if (status_index == 1)
            {
                pictureBox9.BackColor = Color.Orange;
                checkBox9.Checked = false;
            }
            else if (status_index == 2)
            {
                pictureBox9.BackColor = Color.Blue;
                checkBox9.Checked = false;
            }
            else if (status_index == 3)
            {
                pictureBox9.BackColor = Color.Green;
                checkBox9.Checked = true;
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            comboBox9.SelectedIndex = 3;
            if (checkBox9.Checked == false)
            {
                comboBox9.ResetText();
                pictureBox9.BackColor = Color.Empty;
            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            checkBox10.Enabled = true;
            comboBox10.Enabled = true;
        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            int status_index = comboBox10.SelectedIndex;

            if (status_index == 0)
            {
                pictureBox10.BackColor = Color.Red;
                checkBox10.Checked = false;
            }
            else if (status_index == 1)
            {
                pictureBox10.BackColor = Color.Orange;
                checkBox10.Checked = false;
            }
            else if (status_index == 2)
            {
                pictureBox10.BackColor = Color.Blue;
                checkBox10.Checked = false;
            }
            else if (status_index == 3)
            {
                pictureBox10.BackColor = Color.Green;
                checkBox10.Checked = true;
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            comboBox10.SelectedIndex = 3;
            if (checkBox10.Checked == false)
            {
                comboBox10.ResetText();
                pictureBox10.BackColor = Color.Empty;
            }
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            checkBox11.Enabled = true;
            comboBox11.Enabled = true;
        }

        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {
            int status_index = comboBox11.SelectedIndex;

            if (status_index == 0)
            {
                pictureBox11.BackColor = Color.Red;
                checkBox11.Checked = false;
            }
            else if (status_index == 1)
            {
                pictureBox11.BackColor = Color.Orange;
                checkBox11.Checked = false;
            }
            else if (status_index == 2)
            {
                pictureBox11.BackColor = Color.Blue;
                checkBox11.Checked = false;
            }
            else if (status_index == 3)
            {
                pictureBox11.BackColor = Color.Green;
                checkBox11.Checked = true;
            }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            comboBox11.SelectedIndex = 3;
            if (checkBox11.Checked == false)
            {
                comboBox11.ResetText();
                pictureBox11.BackColor = Color.Empty;
            }
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            checkBox12.Enabled = true;
            comboBox12.Enabled = true;
        }

        private void comboBox12_SelectedIndexChanged(object sender, EventArgs e)
        {
            int status_index = comboBox12.SelectedIndex;

            if (status_index == 0)
            {
                pictureBox12.BackColor = Color.Red;
                checkBox12.Checked = false;
            }
            else if (status_index == 1)
            {
                pictureBox12.BackColor = Color.Orange;
                checkBox12.Checked = false;
            }
            else if (status_index == 2)
            {
                pictureBox12.BackColor = Color.Blue;
                checkBox12.Checked = false;
            }
            else if (status_index == 3)
            {
                pictureBox12.BackColor = Color.Green;
                checkBox12.Checked = true;
            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            comboBox12.SelectedIndex = 3;
            if (checkBox12.Checked == false)
            {
                comboBox12.ResetText();
                pictureBox12.BackColor = Color.Empty;
            }
        }
    }
}
