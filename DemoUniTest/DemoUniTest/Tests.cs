using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace DemoUniTest
{
    public class Tests
    {

        // Sum     
        [Test]
        public static void SumTest1()
        {
            Console.WriteLine("Sumtest1");
            double sum = Calculator.Class1.Sum(5, 4);
            Assert.AreEqual(9, sum);
        }
        [Test]
        public static void SumTest2()
        {
            Console.WriteLine("Sumtest2");
            double sum = Calculator.Class1.Sum(5, -15);
            Assert.AreEqual(9, sum);
        }
        [Test]
        public static void SumTest3()
        {
            Console.WriteLine("Sumtest3");
            double sum = Calculator.Class1.Sum(5, 5);
            Assert.AreEqual(10, sum);
        }
        [Test]
        public static void SumTest4()
        {
            Console.WriteLine("Sumtest4");
            double sum = Calculator.Class1.Sum(4, 4);
            Assert.AreEqual(8, sum);
        }

        [Test]
        public static void SumTest5()
        {
            Console.WriteLine("Sumtest5");
            double sum = Calculator.Class1.Sum(4, 8);
            Assert.AreEqual(12, sum);
        }

        //Difference
        [Test]
        public static void DifferenceTest1()
        {
            Console.WriteLine("DifferenceTest1");
            double difference = Calculator.Class1.Difference(4, 4);
            Assert.AreEqual(0, difference);
        }

        [Test]
        public static void DifferenceTest2()
        {
            Console.WriteLine("DifferenceTest2");
            double difference = Calculator.Class1.Difference(4, 5);
            Assert.AreEqual(-1, difference);
        }

        [Test]
        public static void DifferenceTest3()
        {
            Console.WriteLine("DifferenceTest3");
            double difference = Calculator.Class1.Difference(4, -44);
            Assert.AreEqual(48, difference);
        }

        [Test]
        public static void DifferenceTest4()
        {
            Console.WriteLine("DifferenceTest4");
            double difference = Calculator.Class1.Difference(4, 55);
            Assert.AreEqual(-51, difference);
        }

        [Test]
        public static void DifferenceTest5()
        {
            Console.WriteLine("DifferenceTest5");
            double difference = Calculator.Class1.Difference(4, -9);
            Assert.AreEqual(13, difference);
        }

        //Multiplication
        [Test]
        public static void MultiplicationTest1()
        {
            Console.WriteLine("MultiplicationTest1");
            double multiplication = Calculator.Class1.Multiplication(4, 5);
            Assert.AreEqual(20, multiplication);
        }

        [Test]
        public static void MultiplicationTest2()
        {
            Console.WriteLine("MultiplicationTest2");
            double multiplication = Calculator.Class1.Multiplication(4, 4);
            Assert.AreEqual(16, multiplication);
        }

        [Test]
        public static void MultiplicationTest3()
        {
            Console.WriteLine("MultiplicationTest3");
            double multiplication = Calculator.Class1.Multiplication(4, 3);
            Assert.AreEqual(12, multiplication);
        }

        [Test]
        public static void MultiplicationTest4()
        {
            Console.WriteLine("MultiplicationTest4");
            double multiplication = Calculator.Class1.Multiplication(4, 1);
            Assert.AreEqual(5, multiplication);
        }

        [Test]
        public static void MultiplicationTest5()
        {
            Console.WriteLine("MultiplicationTest5");
            double multiplication = Calculator.Class1.Multiplication(4, 8);
            Assert.AreEqual(333, multiplication);
        }

        //Divisin
        [Test]
        public static void DivisionTest1()
        {
            Console.WriteLine("DivisionTest1");
            double division = Calculator.Class1.Division(16, 8);
            Assert.AreEqual(double.NaN, division);
        }

        [Test]
        public static void DivisionTest2()
        {
            Console.WriteLine("DivisionTest2");
            double division = Calculator.Class1.Division(16, 8);
            Assert.AreEqual(2, division);
        }

        [Test]
        public static void DivisionTest3()
        {
            Console.WriteLine("DivisionTest3");
            double division = Calculator.Class1.Division(0, 0);
            Assert.AreEqual(double.PositiveInfinity, division);
        }

        [Test]
        public static void DivisionTest4()
        {
            Console.WriteLine("DivisionTest4");
            double division = Calculator.Class1.Division(72, 8);
            Assert.AreEqual(9, division);
        }

        [Test]
        public static void DivisionTest5()
        {
            Console.WriteLine("DivisionTest5");
            double division = Calculator.Class1.Division(0, 0);
            Assert.AreEqual(double.NaN, division);
        }

    }
}
