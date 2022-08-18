using Moq;
using NUnit.Framework;
using Xunit;

namespace std
{

	class MySample
	{

		public static void Main()
		{
			var test = new TestClass();
			test.TestMain();
			Console.WriteLine("Writing to event log successfully.");

		}

		/// <summary>
		/// You did better impl this class by a numeric type
		/// </summary>
		/// <typeparam name="T"></typeparam>
		class NumberContainer<T>
			where T : struct, IEquatable<T>, IConvertible, IFormattable
		{

		}

		public interface Finder
		{
			int Find(int value);
		}

		public class Enterprise
		{
			Finder Consumer;
			public Enterprise(Finder comsumer)
			{
				Consumer = comsumer;
			}

			public int Find(int x)
			{
				return Consumer.Find(x);
			}
		}

		[TestFixture]
		public class TestClass
		{
			[Test]
			[Fact]
			public void TestMain()
			{

			}
		}
	}
}
