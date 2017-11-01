using Microsoft.VisualStudio.TestTools.UnitTesting;
using JAMK.IT.Laskin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT.Laskin.Tests
{
    [TestClass()]
    public class MyCalculatorTests
    {
        [TestMethod()]
        public void AddTest()
        {
            //Testataan MyCalculator-luokan Add-metodia, AAA-malli
            //Arrange
            int i = 10;
            int j = 12;
            int tulos = 22;
            MyCalculator laskin = new MyCalculator();

            //Act
            int summa = laskin.Add(i, j);

            //Assert
            Assert.AreEqual(tulos, summa);

            //Assert.Fail();
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            //Arrange
            int i = 10;
            int j = 12;
            int tulos = 120;
            MyCalculator laskin = new MyCalculator();

            //Act
            int summa = laskin.Multiply(i, j);

            //Assert
            Assert.AreEqual(tulos, summa);

            //Assert.Fail();
        }

        [TestMethod()]
        public void DivideTest()
        {
            //Arrange
            int i = 24;
            int j = 4;
            int odotettu = 6;
            MyCalculator laskin = new MyCalculator();

            //Act
            int jako = laskin.Divide(i, j);

            //Assert
            Assert.AreEqual(jako, odotettu);

            //Assert.Fail();
        }

        public void DivideWithZeroTest()
        {
            //Arrange
            int i = 24;
            int j = 0;
            int odotettu = 1;
            MyCalculator laskin = new MyCalculator();

            //Act
            try
            {
                int jako = laskin.Divide(i, j);
                Assert.Fail();
            }
            //Assert
            catch(DivideByZeroException)
            {
                //ok, tulee oikea poikkeus  
            }
            catch(Exception ex)
            {
                Assert.Fail();
            }
            
            //DivideByZeroException dbze = new DivideByZeroException();

            //Assert.Fail();
        }
    }
}