using SharedInterface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExternalDataCalculationPlugin
{
    public partial class SubmitNewJobForm : Form
    {
        public SubmitNewJobForm()
        {
            InitializeComponent();
        }

        private void CancelJobWindowButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SubmitJobWindowButton_Click(object sender, EventArgs e)
        {
            JobManager jm = new JobManager();
            jm.AddJobToQueue(new Job(new Random().Next(), 
                JobNameTextBox.Text, FromTextBox.Text, QueryTextBox.Text, ToTextBox.Text));

            Close();
        }
    }
}
