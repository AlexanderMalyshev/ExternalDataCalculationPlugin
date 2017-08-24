using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using SharedInterface;
using System.Timers;
using Microsoft.Office.Interop.Excel;

namespace ExternalDataCalculationPlugin
{
    public partial class ExternalDataCalculationRibbon
    {
        private JobStateManager jsm = new JobStateManager();

        private void ExternalDataCalculationRibbon_Load(object sender, RibbonUIEventArgs e)
        {
            UpdateJobStatusItems();
        }

        private void UpdateJobStatusItems()
        {
            List<JobState> jl = jsm.GetListOfJobWithLastState();
            JobStatusDropDown.Items.Clear();
            jl.ForEach(js => {
                var item = this.Factory.CreateRibbonDropDownItem();
                var lastState = js.states.OrderBy(state => state.Value).Last();
                item.Label = "Name: " + js.name + " Status: " + lastState.Key + " (" + lastState.Value + ")";
                JobStatusDropDown.Items.Add(item);
            });
        }

        private void CreateNewJobButton_Click(object sender, RibbonControlEventArgs e)
        {
            SubmitNewJobForm snjf = new SubmitNewJobForm();
            snjf.Show();
        }

        private void RefreshJobStateButton_Click(object sender, RibbonControlEventArgs e)
        {
            int selected = JobStatusDropDown.SelectedItemIndex;

            UpdateJobStatusItems();

            if (selected < JobStatusDropDown.Items.Count)
                JobStatusDropDown.SelectedItemIndex = selected;
        }

        private void InsertButton_Click(object sender, RibbonControlEventArgs e)
        {
            string selectedItems = JobStatusDropDown.SelectedItem.Label;
            string name = selectedItems.Split(' ')[1];

            TableManager tm = new TableManager("result" + name);
            List<List<string>> data = tm.GetData();

            Range rg = Globals.ThisAddIn.Application.ActiveCell;
            int startCol = rg.Column;
            int startRow = rg.Row;

            var sheet = Globals.ThisAddIn.Application.ActiveSheet;
            data.ForEach(line =>
            {
                int row = startRow;
                int col = startCol;
                line.ForEach(item =>
                {
                    sheet.Cells[row, col].Value = item;
                    col++;
                });
                startRow++;
            });
        }
    }
}
