using CyberTestKursovaya.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CyberTestKursovaya
{
    public partial class FormTheory : Form
    {


        public FormTheory()
        {
            InitializeComponent();

            
            var list = DAL.SQLiteHelper.GetSections();
            if (list != null )
            {
                foreach (Sections section in list)
                {

                }
            }
            
        }

        private void readButton_Click(object sender, EventArgs e)
        {
            // var list = DAL.SQLiteHelper.GetSections();
        }
    }
}
