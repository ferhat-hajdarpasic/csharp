using System;
using System.Threading.Tasks;

namespace Experiments {
    public class TaskExperiment {
        public void wait(int msec) {
            Task.Delay(msec).Wait();
        }
    }
}