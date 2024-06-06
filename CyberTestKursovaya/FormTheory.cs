using CyberTestKursovaya.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CyberTestKursovaya
{
    public partial class FormTheory : Form
    {


        public FormTheory()
        {
            InitializeComponent();
            
            theorySectionsListBox.Items.Clear();

            String[] sectionsNames = new string[5];
            sectionsNames = (string[])DAL.SQLiteHelper.GetSections();

            


            if (sectionsNames != null )
            {
                foreach (var section in sectionsNames)
                {
                    theorySectionsListBox.Items.Add(section);
                }
            }
            
        }

        private void readButton_Click(object sender, EventArgs e)
        {
            String[] sectionsNames = new string[5];
            sectionsNames = (string[])DAL.SQLiteHelper.GetSections();
            var selectedSection = theorySectionsListBox.SelectedItem.ToString();


            int index = Array.IndexOf(sectionsNames, selectedSection);
            String[] sectiontsTexts = new string[5];
            sectiontsTexts = (string[])DAL.SQLiteHelper.GetSectionsTexts();
            

            theoryOutput.Text = sectiontsTexts[index]; 

        }
    }
}
