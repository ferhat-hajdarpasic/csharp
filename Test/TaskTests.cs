using System;
using Xunit;

namespace Experiments {
    public class TaskTests {
        [Fact]
        public void TestWait()
        {
        //Given
        int delay = 5000;
        
        //When
        TaskExperiment te = new TaskExperiment();
        var d1 = DateTime.Now;
        te.wait(delay);
        var d2 = DateTime.Now;

        //Then
        Assert.InRange(d2.Subtract(d1).TotalMilliseconds, delay, 2*delay);
        }
    }
}