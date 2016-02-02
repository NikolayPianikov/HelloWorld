using NUnit.Framework;

namespace HelloWorld.Tests2
{
	using System;
	using System.Diagnostics;
	using System.Threading;

	[TestFixture]
    [Parallelizable]
    public class UnitTest1
    {
		private static readonly Random Rnd = new Random();

		[Test]
        [Parallelizable]
        public void TestDo()
        {
            var a = new Class1();
            a.Do();
        }

		[Test]
		public void Test1()
		{
			Assert.Throws<Exception>(() => { throw new Exception("Test exception"); });
			;
			DoTest(1);
		}

		[Test]
		public void Test2()
		{
			DoTest(2);
		}

		[Test]
		public void Test3()
		{
			DoTest(3);
		}

		[Test]
		public void Test4()
		{
			DoTest(4);
		}

		[Test]
		public void Test5()
		{
			DoTest(5);
		}

		[Test]
		public void Test6()
		{
			DoTest(6);
		}

		[Test]
		public void Test7()
		{
			DoTest(7);
		}

		[Test]
		public void Test8()
		{
			DoTest(8);
		}

		[Test]
		public void Test9()
		{
			DoTest(9);
		}

		[Test]
		public void Test10()
		{
			DoTest(10);
		}

		private static void DoTest(int testId)
		{
			var testName = string.Format("Test2 {0}", testId);
			Console.WriteLine("Start test {0}", testName);
			Thread.Sleep(Rnd.Next(500));
			Console.WriteLine("ProcessID {0}", Process.GetCurrentProcess().Id);
			Console.WriteLine("Finish test {0}", testName);
		}
	}
}
