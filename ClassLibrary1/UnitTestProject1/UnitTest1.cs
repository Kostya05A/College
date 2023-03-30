using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MathClassLibrary;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int R = 6;
            int H = 4;
            // Оидаемый результат - должен совпасть с рациональным значением
            double Volt = 150.79645;
            double Sas = 376.99112;
            
            Geometry g = new Geometry();
            double actual1 = g.Compute(R, H, Volt);
            double actual2 = g.Compute(R, H, Sas);// Получение фактического результата

            Assert.AreEqual(Volt, actual1);
            Assert.AreEqual(Sas, actual2);
            // Итог - тест не будет пройден ввиду наличия погрешности результатов 
        }
    }
}
