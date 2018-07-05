using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;


namespace CustomListTesting
{
    [TestClass]
    public class CalculatorTesting
    {
        [TestMethod]
        
            public void AddPositiveNumbers()
            {
                int firstNumber = 5;
                int secondNumber = 6;

                Calculator calculate = new Calculator();

                int sum = calculate.Add(firstNumber, secondNumber);

                Assert.AreEqual(11, sum);

            }

        [TestMethod]
        public void AddNegativeNumbers()
        {
            int firstNumber = -5;
            int secondNumber = -6;

            Calculator calculate = new Calculator();
            int sum = calculate.Add(firstNumber, secondNumber);

            Assert.AreEqual(-11, sum);


        }
    
    }
}
