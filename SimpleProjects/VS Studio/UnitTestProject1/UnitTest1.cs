using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SimpleCalculator;

namespace UnitTestCalc
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPassValidation()
        {
            InputValidation ipVal = new InputValidation();

            Assert.AreEqual(1, ipVal.ValidNumericalInput("1")) ;
        }
        [TestMethod]
        public void TestFailValidation()
        {
            InputValidation ipVal = new InputValidation();

            Assert.ThrowsException<ArgumentException>(() => ipVal.ValidNumericalInput("test"));
        }

        [TestMethod]
        public void TestAdd()
        {
            CalculatorEngine engine = new CalculatorEngine();
            
            //Standard
            Assert.AreEqual(44, engine.Calculate(22,22,"add"));
            Assert.AreNotEqual(22, engine.Calculate(22, 22, "add"));
            //Case sensitivity
            Assert.AreEqual(12, engine.Calculate(8, 4, "Add"));
            //Negative
            Assert.AreEqual(8, engine.Calculate(10, -2, "ADD"));
            //Symbol
            Assert.AreEqual(-6, engine.Calculate(-4, -2, "+"));

        }

        [TestMethod]
        public void TestSubtract()
        {
            CalculatorEngine engine = new CalculatorEngine();

            //Standard minus
            Assert.AreEqual(0, engine.Calculate(22, 22, "minus"));
            Assert.AreNotEqual(22, engine.Calculate(22, 22, "minus"));
            //Test subtract
            Assert.AreEqual(-2, engine.Calculate(4, 6, "subtract"));
            //Case sensitivity
            Assert.AreEqual(4, engine.Calculate(8, 4, "MINUS"));
            Assert.AreEqual(12, engine.Calculate(10, -2, "SUBTRACT"));
            //Symbol
            Assert.AreEqual(-2, engine.Calculate(-4, -2, "-"));
        }

        [TestMethod]
        public void TestMultiply()
        {
            CalculatorEngine engine = new CalculatorEngine();

            //Standard multiply
            Assert.AreEqual(0, engine.Calculate(22, 0, "multiply"));
            Assert.AreNotEqual(22, engine.Calculate(22, 22, "multiply"));
            //Test times
            Assert.AreEqual(24, engine.Calculate(4, 6, "times"));
            //Case sensitivity
            Assert.AreEqual(32, engine.Calculate(8, 4, "MULTIPLY"));
            Assert.AreEqual(-20, engine.Calculate(10, -2, "TIMES"));
            //Symbol
            Assert.AreEqual(8, engine.Calculate(-4, -2, "*"));
        }
        [TestMethod]
        public void TestDivide()
        {
            CalculatorEngine engine = new CalculatorEngine();

            //Standard
            Assert.AreEqual(1, engine.Calculate(22, 22, "divide"));
            Assert.AreNotEqual(22, engine.Calculate(22, 2, "divide"));
            //Case sensitivity
            Assert.AreEqual(2, engine.Calculate(8, 4, "DIVIDE"));
            //Negative
            Assert.AreEqual(-5, engine.Calculate(10, -2, "Divide"));
            //Symbol
            Assert.AreEqual(2, engine.Calculate(-4, -2, "/"));
        }

        [TestMethod]
        public void TestDivideByZero()
        {
            CalculatorEngine engine = new CalculatorEngine();

            Assert.ThrowsException<DivideByZeroException>(() => engine.Calculate(12,0,"/"));
        }

        [TestMethod]
        public void TestBadOperation()
        {
            CalculatorEngine engine = new CalculatorEngine();

            Assert.ThrowsException<ArgumentException>(() => engine.Calculate(12, 0, "Test"));
            Assert.ThrowsException<ArgumentException>(() => engine.Calculate(12, 0, "$"));
        }

    }
}
