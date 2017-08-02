namespace ExternalDataCalculationPlugin
{
    partial class ExternalDataCalculationRibbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public ExternalDataCalculationRibbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExternalDataCalculationRibbon));
            this.ExternalCalculationTab = this.Factory.CreateRibbonTab();
            this.CreateJobGroup = this.Factory.CreateRibbonGroup();
            this.JobStatusGroup = this.Factory.CreateRibbonGroup();
            this.JobStatusDropDown = this.Factory.CreateRibbonDropDown();
            this.JobActionsGroup = this.Factory.CreateRibbonGroup();
            this.RestartButton = this.Factory.CreateRibbonButton();
            this.CreateNewJobButton = this.Factory.CreateRibbonButton();
            this.InsertButton = this.Factory.CreateRibbonButton();
            this.CancelButton = this.Factory.CreateRibbonButton();
            this.ExternalCalculationTab.SuspendLayout();
            this.CreateJobGroup.SuspendLayout();
            this.JobStatusGroup.SuspendLayout();
            this.JobActionsGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExternalCalculationTab
            // 
            this.ExternalCalculationTab.Groups.Add(this.CreateJobGroup);
            this.ExternalCalculationTab.Groups.Add(this.JobStatusGroup);
            this.ExternalCalculationTab.Groups.Add(this.JobActionsGroup);
            this.ExternalCalculationTab.Label = "External Calculation";
            this.ExternalCalculationTab.Name = "ExternalCalculationTab";
            // 
            // CreateJobGroup
            // 
            this.CreateJobGroup.Items.Add(this.CreateNewJobButton);
            this.CreateJobGroup.Label = "Create Job";
            this.CreateJobGroup.Name = "CreateJobGroup";
            // 
            // JobStatusGroup
            // 
            this.JobStatusGroup.Items.Add(this.JobStatusDropDown);
            this.JobStatusGroup.Label = "Job Status";
            this.JobStatusGroup.Name = "JobStatusGroup";
            // 
            // JobStatusDropDown
            // 
            this.JobStatusDropDown.Label = "JobStatusDropDown";
            this.JobStatusDropDown.Name = "JobStatusDropDown";
            this.JobStatusDropDown.ShowLabel = false;
            this.JobStatusDropDown.SizeString = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            // 
            // JobActionsGroup
            // 
            this.JobActionsGroup.Items.Add(this.InsertButton);
            this.JobActionsGroup.Items.Add(this.RestartButton);
            this.JobActionsGroup.Items.Add(this.CancelButton);
            this.JobActionsGroup.Label = "Job Actions";
            this.JobActionsGroup.Name = "JobActionsGroup";
            // 
            // RestartButton
            // 
            this.RestartButton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.RestartButton.Image = global::ExternalDataCalculationPlugin.Properties.Resources.restart;
            this.RestartButton.Label = "Restart";
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.ShowImage = true;
            // 
            // CreateNewJobButton
            // 
            this.CreateNewJobButton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.CreateNewJobButton.Image = global::ExternalDataCalculationPlugin.Properties.Resources.hammer_and_key;
            this.CreateNewJobButton.Label = "Create New Job";
            this.CreateNewJobButton.Name = "CreateNewJobButton";
            this.CreateNewJobButton.ShowImage = true;
            // 
            // InsertButton
            // 
            this.InsertButton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.InsertButton.Image = global::ExternalDataCalculationPlugin.Properties.Resources.download;
            this.InsertButton.Label = "Insert";
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.ShowImage = true;
            // 
            // CancelButton
            // 
            this.CancelButton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.CancelButton.Image = ((System.Drawing.Image)(resources.GetObject("CancelButton.Image")));
            this.CancelButton.Label = "Cancel";
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.ShowImage = true;
            // 
            // ExternalDataCalculationRibbon
            // 
            this.Name = "ExternalDataCalculationRibbon";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.ExternalCalculationTab);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.ExternalDataCalculationRibbon_Load);
            this.ExternalCalculationTab.ResumeLayout(false);
            this.ExternalCalculationTab.PerformLayout();
            this.CreateJobGroup.ResumeLayout(false);
            this.CreateJobGroup.PerformLayout();
            this.JobStatusGroup.ResumeLayout(false);
            this.JobStatusGroup.PerformLayout();
            this.JobActionsGroup.ResumeLayout(false);
            this.JobActionsGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonGroup CreateJobGroup;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton CreateNewJobButton;
        public Microsoft.Office.Tools.Ribbon.RibbonGroup JobStatusGroup;
        internal Microsoft.Office.Tools.Ribbon.RibbonDropDown JobStatusDropDown;
        private Microsoft.Office.Tools.Ribbon.RibbonTab ExternalCalculationTab;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup JobActionsGroup;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton InsertButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton RestartButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton CancelButton;
    }

    partial class ThisRibbonCollection
    {
        internal ExternalDataCalculationRibbon ExternalDataCalculationRIbbon
        {
            get { return this.GetRibbon<ExternalDataCalculationRibbon>(); }
        }
    }
}
