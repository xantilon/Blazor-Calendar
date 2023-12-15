using Microsoft.VisualStudio.TestTools.UnitTesting;
using BlazorCalendar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorCalendar.Models.Tests
{
	using Microsoft.VisualStudio.TestTools.UnitTesting;
	using System;
	using System.Linq;

	[TestClass]
	public class TaskTests
	{
		[TestMethod]
		public void TestSplitMonths()
		{
			// Arrange
			var task = new Tasks
			{
				ID = 1,
				DateStart = new DateTime(2022, 1, 15),
				DateEnd = new DateTime(2022, 3, 15)
			};

			// Act
			var result = task.SplitMonths().ToList();

			// Assert
			Assert.AreEqual(3, result.Count);
			Assert.AreEqual(new DateTime(2022, 1, 15), result[0].DateStart);
			Assert.AreEqual(new DateTime(2022, 1, 31), result[0].DateEnd);
			Assert.AreEqual(new DateTime(2022, 2, 1), result[1].DateStart);
			Assert.AreEqual(new DateTime(2022, 2, 28), result[1].DateEnd);
			Assert.AreEqual(new DateTime(2022, 3, 1), result[2].DateStart);
			Assert.AreEqual(new DateTime(2022, 3, 15), result[2].DateEnd);
		}


		[TestMethod]
		[DataRow("2022-01-15", "2022-03-15", 3)]
		[DataRow("2022-01-01", "2022-01-31", 1)]
		[DataRow("2022-01-01", "2022-12-31", 12)]
		[DataRow("2022-01-03", "2022-01-13", 1)]
		public void TestSplitMonths(string start, string end, int expectedCount)
		{
			// Arrange
			var task = new Tasks
			{
				ID = 1,
				DateStart = DateTime.Parse(start),
				DateEnd = DateTime.Parse(end)
			};

			// Act
			var result = task.SplitMonths().ToList();

			// Assert
			Assert.AreEqual(expectedCount, result.Count);
			Assert.AreEqual(end, result.Last().DateEnd);
		}

	}


}