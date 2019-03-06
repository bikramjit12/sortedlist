using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sortedlist
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private SortedList <int, string> RunnerList = new SortedList<int, string>();
        private void btnLoadRunner_Click(object sender, EventArgs e)
        {
            //this is a Key Value pair
            RunnerList.Add(1, "Howard");
            RunnerList.Add(2, "Jones");
            RunnerList.Add(3, "James");
            RunnerList.Add(4, "Speedy");
            loadLBxRunners();
        
    }

        private void loadLBxRunners()
        {  //clear the listbox

            lbxRunnerList.Items.Clear();
            foreach (KeyValuePair<int, string> Runner in RunnerList)
            {
                lbxRunnerList.Items.Add(Runner.Key + " " + Runner.Value);
            }
           
        }
    }
}
