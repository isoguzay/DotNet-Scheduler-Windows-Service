using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Ioay.WindowsService.Sample
{
    public partial class Schedular : ServiceBase
    {
        private Timer timer1;  

        public Schedular()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            timer1 = new Timer();
            this.timer1.Interval = 10000;
            this.timer1.Elapsed += new System.Timers.ElapsedEventHandler(this.Timer_Schedule);
            timer1.Enabled = true;
            Library.WriteErrorLog("Test Windows Service is running now !");
        }

        private void Timer_Schedule(object sender, ElapsedEventArgs e)
        {
            Library.WriteErrorLog("Timer is running, Job is scheduled by successfully");
        }

        protected override void OnStop()
        {
            timer1.Enabled = false;
            Library.WriteErrorLog("Test Windows Service is stopped now !");

        }
    }
}
