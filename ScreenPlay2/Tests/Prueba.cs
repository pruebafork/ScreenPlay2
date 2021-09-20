using NUnit.Framework;
using ScreenPlay2.Bases;
using ScreenPlay2.Tareas;
using System;

namespace ScreenPlay2.Tests
{
    public class Prueba : Base
    {
        [Test]
        public void Test_logeo()
        {
            try
            {
                report.test = report.extent.CreateTest(TestContext.CurrentContext.Test.Name, "Logearse");
                Logeo.Loge(report);
            }
            catch (Exception)
            { }
        }

        [TearDown]
        public void TearDownReport()
        {
            report.EndTest2();
        }
    }
}
