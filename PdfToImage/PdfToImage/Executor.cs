using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WordToJpg
{
    internal static class Executor
    {
        private static TaskScheduler MainUIScheduler { get; set; }

        static Executor()
        {
            MainUIScheduler = TaskScheduler.FromCurrentSynchronizationContext();
        }

        public static void Touch()
        {
        }

        public static Task ExecuteOnBackground(Action command)
        {
            return Task.Factory.StartNew(command, CancellationToken.None, TaskCreationOptions.LongRunning, TaskScheduler.Default);
        }

        public static Task ExecuteOnUI(Action command)
        {
            return Task.Factory.StartNew(command, CancellationToken.None, TaskCreationOptions.None, MainUIScheduler);
        }

        public static void SwitchToUI()
        {
            Task.Factory.StartNew(() => { }, CancellationToken.None, TaskCreationOptions.None, MainUIScheduler).Wait();
        }
    }
}
