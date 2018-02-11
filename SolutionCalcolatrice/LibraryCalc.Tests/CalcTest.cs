using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibraryCalc;


namespace LibraryCalc.Tests
{
    [TestClass]
    public class CalcTest
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
            double ris = double.NaN;

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
        [TestMethod]
        public void TestSottrazione()
        {
            double num1 = 7;
            double num2 = 2;
            double ris = 5;

            double differenza = Calcolatrice.Sottrazione(num1, num2);

            Assert.AreEqual(ris, differenza);
        }
        [TestMethod]
        public void TestSottrazioneZero()
        {
            double num1 = 0;
            double num2 = 6;
            double ris = -6;

            double differenza = Calcolatrice.Sottrazione(num1, num2);

            Assert.AreEqual(ris, differenza);
        }
        [TestMethod]
        public void TestSottrazione2numeriNegativi()
        {
            double num1 = -7;
            double num2 = 2;
            double ris = -9;

            double differenza = Calcolatrice.Sottrazione(num1, num2);

            Assert.AreEqual(ris, differenza);
        }
        [TestMethod]
        public void Test0Sottraendo()
        {
            double num1 = 7;
            double num2 = 0;
            double ris = 7;

            double differenza = Calcolatrice.Sottrazione(num1, num2);

            Assert.AreEqual(ris, differenza);
        }
        public void TestProdotto()
        {
            double num1 = 7;
            double num2 = 2;
            double ris = 14;

            double prodotto = Calcolatrice.Prodotto(num1, num2);

            Assert.AreEqual(ris, prodotto);
        }
        public void TestProdottoNumPer0()
        {
            double num1 = 7;
            double num2 = 0;
            double ris = 0;

            double prodotto = Calcolatrice.Prodotto(num1, num2);

            Assert.AreEqual(ris, prodotto);
        }
        public void TestProdottoNumPer1()
        {
            double num1 = 7;
            double num2 = 1;
            double ris = 7;

            double prodotto = Calcolatrice.Prodotto(num1, num2);

            Assert.AreEqual(ris, prodotto);
        }
        public void TestProdotto1PerZero()
        {
            double num1 = 1;
            double num2 = 0;
            double ris = 0;

            double prodotto = Calcolatrice.Prodotto(num1, num2);

            Assert.AreEqual(ris, prodotto);
        }
        public void TestMassimo()
        {
            double num1 = 5;
            double num2 = 4;
            double ris = 5;

            double max = Calcolatrice.Massimo(num1, num2);

            Assert.AreEqual(ris, max);
        }
        public void TestMassimo2numeriUguali()
        {
            double num1 = 5;
            double num2 = 5;
            double ris = 5;

            double max = Calcolatrice.Massimo(num1, num2);

            Assert.AreEqual(ris, max);
        }
        public void TestMassimoSecondoNumMaggiore()
        {
            double num1 = 4;
            double num2 = 5;
            double ris = 5;

            double max = Calcolatrice.Massimo(num1, num2);

            Assert.AreEqual(ris, max);
        }
        public void TestMinimo()
        {
            double num1 = 5;
            double num2 = 4;
            double ris = 4;

            double min = Calcolatrice.Minimo(num1, num2);

            Assert.AreEqual(ris, min);
        }
        public void TestMinimo2numeriUguali()
        {
            double num1 = 5;
            double num2 = 5;
            double ris = 5;

            double min = Calcolatrice.Minimo(num1, num2);

            Assert.AreEqual(ris, min);
        }
        public void TestMinimoSecondoNumMinore()
        {
            double num1 = 5;
            double num2 = 4;
            double ris = 4;

            double min = Calcolatrice.Minimo(num1, num2);

            Assert.AreEqual(ris, min);
        }
        public void TestMedia()
        {
            double num1 = 5;
            double num2 = 4;
            double ris = 4.5;

            double media = Calcolatrice.Media(num1, num2);

            Assert.AreEqual(ris, media);
        }
        public void TestMediaNumUgualeZero()
        {
            double num1 = 5;
            double num2 = 0;
            double ris = 2.5;

            double media = Calcolatrice.Media(num1, num2);

            Assert.AreEqual(ris, media);
        }
    }
   
    
}

