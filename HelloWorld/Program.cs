using Moq;
using NUnit.Framework;
using System;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Threading;
using Xunit;

[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2")]
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
				int a = 0;
				int b = 1;
				int c = 2;
				var mock = new Mock<Finder>();
				Expression<Func<Finder, int>> call1 = x => x.Find(a);
				Expression<Func<Finder, int>> call2 = x => x.Find(b);
				Expression<Func<Finder, int>> call3 = x => x.Find(c);
				mock.Setup(call1).Returns(a + 1);
				mock.Setup(call2).Returns(b * 10);
				mock.Setup(call3).Returns(c * 3).Verifiable();

				var enterprise = new Enterprise(mock.Object);
				Console.WriteLine(enterprise.Find(a));
				Console.WriteLine(enterprise.Find(b));
				Console.WriteLine(enterprise.Find(c));

				mock.Verify(call1, Times.AtLeast(10));
				mock.Verify(call2, Times.Once);
				mock.Verify(call3, Times.Once);
			}
		}
	}
}
