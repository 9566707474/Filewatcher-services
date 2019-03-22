using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;
using System.Threading.Tasks;

namespace Timesheet.Discriminator
{
    [RunInstaller(true)]
    public partial class TimesheetDiscriminatorInstaller : System.Configuration.Install.Installer
    {
        public TimesheetDiscriminatorInstaller()
        {
            InitializeComponent();
        }
    }
}
