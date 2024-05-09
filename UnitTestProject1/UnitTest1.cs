using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using maximocomundivisor;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void mcdTestMethod1()
        {
            int nro1 = 50;
            int nro2 = 90;
            int esperado = 10;
            int prueba = tdd.mcd(nro1, nro2);
            Assert.AreEqual(esperado, prueba);
        }
    }
}
