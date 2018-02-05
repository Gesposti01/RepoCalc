using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibraryCalc;

namespace LibraryCalc.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSomma()
        {
            double num1 = 7;
            double num2 = 2;
            double ris = 9;

            double somma = Calcolatrice.Somma(num1, num2);

            Assert.AreEqual(ris, somma);
        }
        [TestMethod]
        public void TestSommaPerZero()
        {
            double num1 = 0;
            double num2 = 1;
            double ris = 1;

            double somma = Calcolatrice.Somma(num1, num2);

            Assert.AreEqual(ris, somma);
        }
        [TestMethod]
        public void TestSomma2Zeri()
        {
            double num1 = 0;
        double num2 = 0;
        double ris = 0;

        double somma = Calcolatrice.Somma(num1, num2);

        Assert.AreEqual(ris, somma);
        }
        [TestMethod]
        public void TestSomma5()
        {
            double num1 = 5;
            double num2 = 0;
            double ris = 5;

            double somma = Calcolatrice.Somma(num1, num2);

            Assert.AreEqual(ris, somma);
        }
        [TestMethod]
        public void TestDivisione()
        {
            double num1 = 7;
            double num2 = 2;
            double ris = 3.5;

            double Divisione = Calcolatrice.Divisione(num1, num2);

            Assert.AreEqual(ris, Divisione);
        }
        [TestMethod]
        public void TestDivisionePerZero()
        {
            double num1 = 0;
            double num2 = 1;
            double ris = 0;

            double Divisione = Calcolatrice.Divisione(num1, num2);

            Assert.AreEqual(ris, Divisione);
        }
        [TestMethod]
        public void TestDivisionePer2Zeri()
        {
            double num1 = 0;
            double num2 = 0;
            double ris = 0;

            double Divisione = Calcolatrice.Divisione(num1, num2);

            Assert.AreEqual(ris, Divisione);
        }
        [TestMethod]
        public void TestDivisionePer5()
        {
            double num1 = 5;
            double num2 = 0;
            double ris = 0;

            double Divisione = Calcolatrice.Divisione(num1, num2);

            Assert.AreEqual(ris, Divisione);
        }

    }
}
