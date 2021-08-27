using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sutterrøv
{
    public partial class loading : Form
    {
        public loading()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void loading_Load(object sender, EventArgs e)
        {
            

          
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void background_Worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (progressBar1.Maximum == e.ProgressPercentage)
            {
                label1.Text = "Succes";
            }
        }
    }
}
