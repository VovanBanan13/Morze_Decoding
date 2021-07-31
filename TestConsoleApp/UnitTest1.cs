using NUnit.Framework;
using ConsoleApp;

namespace TestConsoleApp
{
    public class Tests
    {
        [Test]
        public void TestHelloWorld()
        {
            var test = Decoding.Morze2English(".... . .-.. .-.. ---   .-- --- .-. .-.. -..");

            Assert.AreEqual(test, "HELLO WORLD");
        }
        
        [Test]
        public void Test1()
        {
            var test = Decoding.Morze2English(".- -... -.-.   .---- ..--- ...--");

            Assert.AreEqual(test, "ABC ***");
        }

        [Test]
        public void Test2()
        {
            var test = Decoding.Morze2English("q q q   q q q");

            Assert.AreEqual(test, "*** ***");
        }

        [Test]
        public void Test3()
        {
            var test = Decoding.Morze2English("....");

            Assert.AreEqual(test, "H");
        }

        [Test]
        public void Test4()
        {
            var test = Decoding.Morze2English(". . . .");

            Assert.AreEqual(test, "EEEE");
        }

        [Test]
        public void Test5()
        {
            var test = Decoding.Morze2English("");

            Assert.AreEqual(test, " ");
        }
    }
}