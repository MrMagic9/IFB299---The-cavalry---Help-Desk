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
            this.Close();
        }

        private void service_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            int service_selection = service_comboBox.SelectedIndex;

            if (service_selection == 0)
            {
                label2.Text = "1";
                label3.Text = "Carpenter";
                details_listBox.Items.Clear();
                details_listBox.Items.Add("Name: Bill's Carpentry");
                details_listBox.Items.Add("Location: Moorooka");
                details_listBox.Items.Add("Phone: 33995833");
                details_listBox.Items.Add("Website: www.billthecarpenter.com.au");
                details_listBox.Items.Add("E-Mail: info@billthecarpenter.com.au");
                details_listBox.Items.Add("Rating: 9/10");

            }
            else if (service_selection == 1)
            {
                label2.Text = "1";
                label3.Text = "Carpeter";
                details_listBox.Items.Clear();
                details_listBox.Items.Add("Name: Bill's Carpets");
                details_listBox.Items.Add("Location: Inala");
                details_listBox.Items.Add("Phone: 1300889983");
                details_listBox.Items.Add("Website: www.billcarpet.com.au");
                details_listBox.Items.Add("E-Mail: info@billcarpet.com.au");
                details_listBox.Items.Add("Rating: 7/10");
            }
            else if (service_selection == 2)
            {
                label2.Text = "7";
                label3.Text = "Electricians";

                details_listBox.Items.Clear();
                details_listBox.Items.Add("Name: Fallon Electrical, Plumbing & Air Conditioning");
                details_listBox.Items.Add("Location: Forest Lake");
                details_listBox.Items.Add("Phone: 30296319");
                details_listBox.Items.Add("Website: www.fallonsolutions.com.au/electrical.html");
                details_listBox.Items.Add("E-Mail: admin@fallonsolutions.com.au");
                details_listBox.Items.Add("Rating: 10/10");

                details_listBox.Items.Add("");
                details_listBox.Items.Add("Name: Platinum Electricians");
                details_listBox.Items.Add("Location: Bowen Hills");
                details_listBox.Items.Add("Phone: 36098521");
                details_listBox.Items.Add("Website: ");
                details_listBox.Items.Add("E-Mail: info@platinumelectricians.com.au");
                details_listBox.Items.Add("Rating: 8/10");

                details_listBox.Items.Add("");
                details_listBox.Items.Add("Name: Sunelec");
                details_listBox.Items.Add("Location: Eagle Farm");
                details_listBox.Items.Add("Phone: 1300897564");
                details_listBox.Items.Add("Website: www.sunelec.com.au");
                details_listBox.Items.Add("E-Mail: info@sunelec.com.au");
                details_listBox.Items.Add("Rating: 7/10");

                details_listBox.Items.Add("");
                details_listBox.Items.Add("Name: Bevan Robinson Electrical Services");
                details_listBox.Items.Add("Location: Sunnybank Hills");
                details_listBox.Items.Add("Phone: 39095566");
                details_listBox.Items.Add("Website: ");
                details_listBox.Items.Add("E-Mail: info@bevanrobinsonelectrical.com.au");
                details_listBox.Items.Add("Rating: 5/10");

                details_listBox.Items.Add("");
                details_listBox.Items.Add("Name: Algester Electrical");
                details_listBox.Items.Add("Location: Algester");
                details_listBox.Items.Add("Phone: 55667788");
                details_listBox.Items.Add("Website: www.algesterelectrical.com.au");
                details_listBox.Items.Add("E-Mail: info@algesterelectrical.com.au");
                details_listBox.Items.Add("Rating: 4/10");

                details_listBox.Items.Add("");
                details_listBox.Items.Add("Name: Spot on Electrical");
                details_listBox.Items.Add("Location: Brisbane CBD");
                details_listBox.Items.Add("Phone: 33445566");
                details_listBox.Items.Add("Website: www.spotonelectrical.com.au");
                details_listBox.Items.Add("E-Mail: info@spotonelectrical.com.au");
                details_listBox.Items.Add("Rating: 4/10");

                details_listBox.Items.Add("");
                details_listBox.Items.Add("Name: FIXZIT Plumbing & Electrical");
                details_listBox.Items.Add("Location: Brisbane CBD");
                details_listBox.Items.Add("Phone: 1300899899");
                details_listBox.Items.Add("Website: www.fixzit.com.au");
                details_listBox.Items.Add("E-Mail: info@fixzit.com.au");
                details_listBox.Items.Add("Rating: 3/10");
            }
            else if (service_selection == 3)
            {
                label2.Text = "1";
                label3.Text = "Floorer";

                details_listBox.Items.Clear();
                details_listBox.Items.Add("Name: Eazy Flooring");
                details_listBox.Items.Add("Location: Brisbane CBD");
                details_listBox.Items.Add("Phone: 35672211");
                details_listBox.Items.Add("Website: www.eazyflooring.com.au");
                details_listBox.Items.Add("E-Mail: info@eazyflooring.com.au");
                details_listBox.Items.Add("Rating: 6/10");
            }
            else if (service_selection == 4)
            {
                label2.Text = "1";
                label3.Text = "Gardener";

                details_listBox.Items.Clear();
                details_listBox.Items.Add("Name: Green Gardening");
                details_listBox.Items.Add("Location: Brisbane CBD");
                details_listBox.Items.Add("Phone: 39876633");
                details_listBox.Items.Add("Website: www.greengardening.com.au");
                details_listBox.Items.Add("E-Mail: info@greengardening.com.au");
                details_listBox.Items.Add("Rating: 9/10");
            }
            else if (service_selection == 5)
            {
                label2.Text = "4";
                label3.Text = "Locksmiths";

                details_listBox.Items.Clear();
                details_listBox.Items.Add("Name: Allstrong Locksmiths & Security");
                details_listBox.Items.Add("Location: Brisbane CBD");
                details_listBox.Items.Add("Phone: 33769970");
                details_listBox.Items.Add("Website: www.allstrong.com.au");
                details_listBox.Items.Add("E-Mail: info@allstrong.com.au");
                details_listBox.Items.Add("Rating: 9/10");

                details_listBox.Items.Add("");
                details_listBox.Items.Add("Name: Golden Locksmiths");
                details_listBox.Items.Add("Location: Toowong");
                details_listBox.Items.Add("Phone: 1300774433");
                details_listBox.Items.Add("Website: www.goldenlocksmiths");
                details_listBox.Items.Add("E-Mail: info@goldenlocksmiths.com.au");
                details_listBox.Items.Add("Rating: 8/10");

                details_listBox.Items.Add("");
                details_listBox.Items.Add("Name: Retro Security");
                details_listBox.Items.Add("Location: Caboolture");
                details_listBox.Items.Add("Phone: 33225543");
                details_listBox.Items.Add("Website: www.retrosecurity.com.au");
                details_listBox.Items.Add("E-Mail: info@retrosecurity.com.au");
                details_listBox.Items.Add("Rating: 6/10");

                details_listBox.Items.Add("");
                details_listBox.Items.Add("Name: Secure Locksmiths");
                details_listBox.Items.Add("Location: Eagleby");
                details_listBox.Items.Add("Phone: 33745621");
                details_listBox.Items.Add("Website: www.securelocksmiths.com.au");
                details_listBox.Items.Add("E-Mail: info@securelocksmiths.com.au");
                details_listBox.Items.Add("Rating: 5/10");
            }
            else if (service_selection == 6)
            {
                label2.Text = "2";
                label3.Text = "Plumbers";

                details_listBox.Items.Clear();
                details_listBox.Items.Add("Name: Plumbworks");
                details_listBox.Items.Add("Location: Wynnum");
                details_listBox.Items.Add("Phone: 33843855");
                details_listBox.Items.Add("Website: www.plumbworks.com.au");
                details_listBox.Items.Add("E-Mail: info@plumbworks.com.au");
                details_listBox.Items.Add("Rating: 10/10");

                details_listBox.Items.Add("");
                details_listBox.Items.Add("Name: Express Plumbing Solutions");
                details_listBox.Items.Add("Location: Kuraby");
                details_listBox.Items.Add("Phone: 1300722517");
                details_listBox.Items.Add("Website: www.expressplumber.com.au");
                details_listBox.Items.Add("E-Mail: info@expressplumber.com.au ");
                details_listBox.Items.Add("Rating: 7/10");
            }
            else if (service_selection == 7)
            {
                label2.Text = "1";
                label3.Text = "Roof Tiler";

                details_listBox.Items.Clear();
                details_listBox.Items.Add("Name: Total Roof Tilers");
                details_listBox.Items.Add("Location: Mt Gravatt");
                details_listBox.Items.Add("Phone: 33551132");
                details_listBox.Items.Add("Website: www.totalrooftilers.com.au");
                details_listBox.Items.Add("E-Mail: info@totalrooftilers.com.au");
                details_listBox.Items.Add("Rating: 8/10");

            }
            else if (service_selection == 8)
            {
                label2.Text = "1";
                label3.Text = "Technician";

                details_listBox.Items.Clear();
                details_listBox.Items.Add("Name: Fast Technicians");
                details_listBox.Items.Add("Location: Windsor");
                details_listBox.Items.Add("Phone: 1300467867");
                details_listBox.Items.Add("Website: www.fastechnicians.com.au");
                details_listBox.Items.Add("E-Mail: info@fasttechnicians.com.au");
                details_listBox.Items.Add("Rating: 7/10");
            }
            else if (service_selection == 9)
            {
                label2.Text = "1";
                label3.Text = "Tiler";

                details_listBox.Items.Clear();
                details_listBox.Items.Add("Name: Tilerworks");
                details_listBox.Items.Add("Location: Rocklea");
                details_listBox.Items.Add("Phone: 1300999333");
                details_listBox.Items.Add("Website: www.tilerworks.com.au");
                details_listBox.Items.Add("E-Mail: info@totalrooftilers.com.au");
                details_listBox.Items.Add("Rating: 8/10");
            }
            else if (service_selection == 10)
            {
                label2.Text = "3";
                label3.Text = "Window Repairers";

                details_listBox.Items.Clear();
                details_listBox.Items.Add("Name: Windows & Glass Professionals");
                details_listBox.Items.Add("Location: Stafford");
                details_listBox.Items.Add("Phone: 38674523");
                details_listBox.Items.Add("Website: www.windowprofessionals.com.au");
                details_listBox.Items.Add("E-Mail: info@windowprofessionals.com.au ");
                details_listBox.Items.Add("Rating: 10/10");

                details_listBox.Items.Add("");
                details_listBox.Items.Add("Name: Cracked Window Specialists");
                details_listBox.Items.Add("Location: Coorparoo");
                details_listBox.Items.Add("Phone: 1300889112");
                details_listBox.Items.Add("Website: www.crackedwindowspecialists.com.au");
                details_listBox.Items.Add("E-Mail: info@crackedwindowspecialists.com.au ");
                details_listBox.Items.Add("Rating: 7/10");

                details_listBox.Items.Add("");
                details_listBox.Items.Add("Name: Express Window Repair");
                details_listBox.Items.Add("Location: Morningside");
                details_listBox.Items.Add("Phone: 1300777888");
                details_listBox.Items.Add("Website: www.expresswindowrepair.com.au");
                details_listBox.Items.Add("E-Mail: info@expresswindowrepair.com.au ");
                details_listBox.Items.Add("Rating: 6/10");
            }
        }

        private void providers_form_Load(object sender, EventArgs e)
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
    }
}
