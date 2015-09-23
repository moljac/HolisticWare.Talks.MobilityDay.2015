using System;
using NUnit.Framework;

namespace UnitTest.XamarinAndroid
{
	[TestFixture]
	public class TestsSample
	{
		
		[SetUp]
		public void Setup ()
		{
		}

		
		[TearDown]
		public void Tear ()
		{
		}

		[Test]
		public void Pass ()
		{			
			Tasky.BL.Task t = new Tasky.BL.Task()
			{
				Done=false,
				Name="Zadaca",
				Notes="Pregledati klincima zadace"
			};

			Assert.IsNotNull(t);
		}


		[Test]
		public void CreateTask ()
		{			
			Console.WriteLine ("test1");
			Assert.True (true);
		}

		[Test]
		public void Fail ()
		{
			Assert.False (true);
		}

		[Test]
		[Ignore ("another time")]
		public void Ignore ()
		{
			Assert.True (false);
		}

		[Test]
		public void Inconclusive ()
		{
			Assert.Inconclusive ("Inconclusive");
		}
	}
}

