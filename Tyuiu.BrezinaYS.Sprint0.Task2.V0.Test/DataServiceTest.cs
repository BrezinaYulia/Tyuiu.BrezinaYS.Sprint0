using System;
using Tyuiu.BrezinaYS.Sprint0.Task2.V0.Lib;

namespace Tyuiu.BrezinaYS.Sprint0.Task2.V0.Test

{
    [TestClass]
    public class DataServiceTest

    {
        [TestMethod]
        public void CheckGetMessageVaild()

        {
            var name = "Юлия";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Юлия", res);
        }
    }
}