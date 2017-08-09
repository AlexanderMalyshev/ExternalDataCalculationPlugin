using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;

namespace ExternalDataCalculationPlugin
{
    public partial class ExternalDataCalculationRibbon
    {
        private void ExternalDataCalculationRibbon_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void CreateNewJobButton_Click(object sender, RibbonControlEventArgs e)
        {
            SubmitNewJobForm snjf = new SubmitNewJobForm();
            snjf.Show();
        }
    }
}
