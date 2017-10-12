using System;
using System.Threading.Tasks;
using Xunit;

namespace Experiments {
    public class TestDelegate {
        [Fact]
        public void TestDelegateVariableAndMethodScopes()
        {
            Console.WriteLine("Hello World!");
            Delegate @static = new Delegate();
            Delegate.Haba haba1 = @static.getHaba("prefix one");
            @static.P1 = "smart";
            haba1(age: 55, name: "ferhat");
            Task.Delay(1000).Wait();
            haba1(age: 55, name: "ferhat");
            string result = new Delegate().getHaba("prefix two")(age: 55, name: "ferhat");
            Assert.StartsWith("prefix two", result);
        }         

        public void TestReferenceScopes()
        {
            Delegate.Haba haba1;
            using(Delegate @static = new Delegate()) {
            haba1 = @static.getHaba("prefix one");
            @static.P1 = "smart";
            };
            haba1(age: 55, name: "ferhat");
            Task.Delay(1000).Wait();
            haba1(age: 55, name: "ferhat");
            Console.WriteLine("All done!");
        }
    }
}
