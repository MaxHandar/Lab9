using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Lab9;

namespace TestDialClock
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            DialClock expected = new DialClock();
            //Actual
            DialClock actual = new DialClock(0, 0);
            //Assert
            Assert.AreEqual(expected.Minutes, actual.Minutes);
            Assert.AreEqual(expected.Hours, actual.Hours);
        }
        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            DialClock expected = new DialClock(12, 0);
            //Actual
            DialClock actual = new DialClock(0, 0);
            //Assert
            Assert.AreEqual(expected.Minutes, actual.Minutes);
            Assert.AreEqual(expected.Hours, actual.Hours);
        }
        [TestMethod]
        public void TestMethod3()
        {
            //Arrange
            DialClock expected = new DialClock(-3, -1);
            //Actual
            DialClock actual = new DialClock(8, 59);
            //Assert
            Assert.AreEqual(expected.Minutes, actual.Minutes);
            Assert.AreEqual(expected.Hours, actual.Hours);
        }
        [TestMethod]
        public void TestMethod4()
        {
            //Arrange
            DialClock expected = new DialClock(0, 2000);
            //Actual
            DialClock actual = new DialClock(9, 20);
            //Assert
            Assert.AreEqual(expected.Minutes, actual.Minutes);
            Assert.AreEqual(expected.Hours, actual.Hours);
        }
        [TestMethod]
        public void TestMethod5()
        {
            //Arrange
            double angle1Static = DialClock.GetAngle(new DialClock(9, 0)); //статический метод
            double angle2Static = DialClock.GetAngle(new DialClock(0, 0));
            double angle1NotStatic = new DialClock(9, 0).GetAngle(); //96,5
            double angle2NotStatic = new DialClock(0, 0).GetAngle(); //0
            //Actual
            double actualAngle1Static = 90;
            double actualAngle2Static = 0;
            double actualAngle1NotStatic = 90;
            double actualAngle2NotStatic = 0;
            //Assert
            Assert.AreEqual(angle1Static, actualAngle1Static);
            Assert.AreEqual(angle2Static, actualAngle2Static);
            Assert.AreEqual(angle1NotStatic, actualAngle1NotStatic);
            Assert.AreEqual(angle2NotStatic, actualAngle2NotStatic);
        }
        [TestMethod]
        public void TestMethod6()
        {
            //Arrange
            DialClockArray clocks = new DialClockArray();
            DialClockArray clocks2 = new DialClockArray(clocks);
            int countArrays = DialClockArray.GetCount;
            //Actual
            int actualCount = 2;
            int actualLength = 0;
            //Assert
            Assert.AreEqual(countArrays, actualCount);
            Assert.AreEqual(clocks.Length, actualLength);
            Assert.AreEqual(clocks2.Length, actualLength);
        }
        [TestMethod]
        public void TestMethod7()
        {
            //Arrange
            string dc1 = new DialClock(1,5).ToString();
            string dc2 = new DialClock(11,5).ToString();
            string dc3 = new DialClock(1,55).ToString();
            string dc4 = new DialClock(11,55).ToString();
            //Actual
            string dc1Actual = "'01 : 05'.";
            string dc2Actual = "'11 : 05'.";
            string dc3Actual = "'01 : 55'.";
            string dc4Actual = "'11 : 55'.";
            //Assert
            Assert.AreEqual(dc1, dc1Actual);
            Assert.AreEqual(dc2, dc2Actual);
            Assert.AreEqual(dc3, dc3Actual);
            Assert.AreEqual(dc4, dc4Actual);
        }
        [TestMethod]
        public void TestMethod8()
        {
            //Arrange
            DialClock dc = new DialClock(5, 59);
            dc++;
            //Actual
            DialClock dcActual = new DialClock(6, 0);
            //Assert
            Assert.AreEqual(dc.Minutes, dcActual.Minutes);
            Assert.AreEqual(dc.Hours, dcActual.Hours);
        }
        [TestMethod]
        public void TestMethod9()
        {
            //Arrange
            DialClock dc = new DialClock(6, 0);
            dc--;
            //Actual
            DialClock dcActual = new DialClock(5, 59);
            //Assert
            Assert.AreEqual(dc.Minutes, dcActual.Minutes);
            Assert.AreEqual(dc.Hours, dcActual.Hours);
        }
        [TestMethod]
        public void TestMethod10()
        {
            //Arrange
            DialClock dc = new DialClock(6, 00);
            dc = dc - 60;
            DialClock dc2 = new DialClock(60 - dc);
            //Actual
            DialClock dcActual = new DialClock(5, 0);
            DialClock dc2Actual = new DialClock(4, 0);
            //Assert
            Assert.AreEqual(dc.Minutes, dcActual.Minutes);
            Assert.AreEqual(dc.Hours, dcActual.Hours);
            Assert.AreEqual(dc2.Minutes, dc2Actual.Minutes);
            Assert.AreEqual(dc2.Hours, dc2Actual.Hours);
        }
        [TestMethod]
        public void TestMethod11()
        {
            //Arrange
            DialClock dc = new DialClock(10, 00);
            dc = dc + 60;
            DialClock dc2 = new DialClock(60 + dc);
            //Actual
            DialClock dcActual = new DialClock(11, 0);
            DialClock dc2Actual = new DialClock(12, 0);
            //Assert
            Assert.AreEqual(dc.Minutes, dcActual.Minutes);
            Assert.AreEqual(dc.Hours, dcActual.Hours);
            Assert.AreEqual(dc2.Minutes, dc2Actual.Minutes);
            Assert.AreEqual(dc2.Hours, dc2Actual.Hours);
        }
        [TestMethod]
        public void TestMethod12()
        {
            //Arrange
            bool AngleDivisibleBy2and5Right = (bool)new DialClock(9, 55);
            bool AngleDivisibleBy2and5Wrong = (bool)new DialClock(9, 56);
            //Actual
            bool AngleDivisibleRightActual = true;
            bool AngleDivisibleWrongActual = false;
            //Assert
            Assert.AreEqual(AngleDivisibleBy2and5Wrong, AngleDivisibleWrongActual);
            Assert.AreEqual(AngleDivisibleBy2and5Right, AngleDivisibleRightActual);
        }
        [TestMethod]
        public void TestMethod13()
        {
            //Arrange
            int divisions = new DialClock(6, 30);
            //Actual
            int divisionsActual = 78;
            //Assert
            Assert.AreEqual(divisions, divisionsActual);
        }
        [TestMethod]
        public void TestMethos14()
        {
            //Arrange
            DialClock d1 = new DialClock(1, 2);
            DialClock d2 = new DialClock(3, 4);
            DialClock[] arr = { d1, d2 };
            DialClockArray dc = new DialClockArray(arr);
            DialClockArray dcCopy = new DialClockArray(dc);
            dcCopy[0] = d2;

            //Actual
            int dc0Hours = 1;
            int dc1Hours = 3;
            //Assert
            Assert.AreEqual(dc[0].Hours, dc0Hours);
            Assert.AreEqual(dc[1].Hours, dc1Hours);
            Assert.AreEqual(dcCopy[0].Hours, dc1Hours);
            Assert.AreEqual(dcCopy[1].Hours, dc1Hours);
        }
        [TestMethod]
        public void TestMethod15()
        {
            //Arrange
            string exception = "no";
            try
            {
                DialClock d1 = new DialClock(1, 2);
                DialClock d2 = new DialClock(3, 4);
                DialClock[] arr = { d1, d2 };
                DialClockArray dc = new DialClockArray(arr);
                dc[2] = new DialClock();
            }
            catch (Exception ex)
            {
                exception = (ex.Message);
            }

            //Actual
            string exceptionAct = "Индекс 2 выходит за пределы массива";

            //Assert
            Assert.AreEqual(exception,exceptionAct);
        }
        [TestMethod]
        public void TestMethod16()
        {
            //Arrange
            string exception = "no";
            try
            {
                DialClock d1 = new DialClock(1, 2);
                DialClock d2 = new DialClock(3, 4);
                DialClock[] arr = { d1, d2 };
                DialClockArray dc = new DialClockArray(arr);
                int minutes = dc[2].Minutes;
            }
            catch (Exception ex)
            {
                exception = (ex.Message);
            }

            //Actual
            string exceptionAct = "Индекс 2 выходит за пределы массива";

            //Assert
            Assert.AreEqual(exception,exceptionAct);
            
        }
    }
}
