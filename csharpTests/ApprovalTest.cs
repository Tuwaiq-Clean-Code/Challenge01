using ApprovalTests;
using ApprovalTests.Reporters;
using csharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Text;

namespace csharp
{
    [UseReporter(typeof(DiffReporter))]
    [TestClass]
    public class ApprovalTest
    {
        [TestMethod]
        public void ThirtyDays()
        {
            
            StringBuilder fakeoutput = new StringBuilder();
            Console.SetOut(new StringWriter(fakeoutput));
            Console.SetIn(new StringReader("a\n"));

            Program.Main(new string[] { });
            var output = fakeoutput.ToString();

            Approvals.Verify(output);
        }
    }
}
