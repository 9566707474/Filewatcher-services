namespace Timesheet.Discriminator
{
    partial class TimesheetDiscriminatorInstaller
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.ServiceProcess.ServiceProcessInstaller serviceProcessInstaller;

        private System.ServiceProcess.ServiceInstaller serviceInstaller;

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
            components = new System.ComponentModel.Container();

            serviceProcessInstaller = new System.ServiceProcess.ServiceProcessInstaller();
            serviceInstaller = new System.ServiceProcess.ServiceInstaller();

            InitializeServiceInstaller();
        }

        private void InitializeServiceInstaller()
        {
            serviceInstaller.DisplayName = ApplicationConfiguration.ServiceDisplayName;
            serviceInstaller.ServiceName = ApplicationConfiguration.ServiceName;
            serviceInstaller.Description = ApplicationConfiguration.ServiceDescriptionName;
        }

        #endregion
    }
}