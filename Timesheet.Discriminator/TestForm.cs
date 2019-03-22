using System.Windows.Forms;

namespace Timesheet.Discriminator
{
    public partial class TestForm : Form
    {
        private System.Timers.Timer timer;

        private FileWatcher fileWatcher;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public TestForm()
        {
            InitializeComponent();
            OnStart();
        }

        protected void OnStart()
        {
            log.Info("Service started");
            fileWatcher = new FileWatcher();
            fileWatcher.InitializeFileSystemWatcher();
            timer = new System.Timers.Timer(ApplicationConfiguration.ThreadWaitingTime)
            {
                AutoReset = true
            };
            timer.Elapsed += new System.Timers.ElapsedEventHandler(Timer_Elapsed);
            timer.Start();
        }

        protected void OnStop()
        {
            this.timer.Stop();
            this.timer = null;
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            log.Info("Timer_Elapsed");
        }
    }
}
