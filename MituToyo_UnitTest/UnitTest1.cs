using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System;

namespace MituToyo_UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        private const string Expected = "Welcome to MituToyo!";
        [TestMethod]
        public void TestMethod1()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                MituToyo_ConsoleApp.Program.Main();

                var result = sw.ToString().Trim();
                Assert.AreEqual(Expected, result);
            }
        }
    }
}
