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
            tasks_checkedListBox.Items.Add("Check mail");
            tasks_checkedListBox.Items.Add("Get quotes from all plumbers");
            tasks_checkedListBox.Items.Add("Book a plumber for Thursday 17th September at 9am");
            tasks_checkedListBox.Items.Add("Attend Volunteers Meeting");
            tasks_checkedListBox.Items.Add("Organise Roster for next week");
            tasks_checkedListBox.Items.Add("Download last weeks performance reports");
            tasks_checkedListBox.Items.Add("Put together performance reports");
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            CheckedListBox.CheckedItemCollection checkedItems = tasks_checkedListBox.CheckedItems;

            while (checkedItems.Count > 0)
            {
                tasks_checkedListBox.Items.Remove(checkedItems[0]);
                label4.Text = "Completed Tasks: " + checkedItems.Count; 
            }
        }

        private void tasks_checkedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            CheckedListBox.CheckedItemCollection checkedItems = tasks_checkedListBox.CheckedItems;
            int completed_tasks = checkedItems.Count+1;
            label4.Text = "Completed Tasks: " + completed_tasks;
        }
    }
}
