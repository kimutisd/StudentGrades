namespace StudentsGrades.UnitTests
{
    using NUnit.Framework;

    [TestFixture]
    public class GradesAgentNUnitTests
    {
        [Test]
        [TestCase(1, "1.2")]
        [TestCase(12, "0")]
        [TestCase(7, "1")]
        public void GradesAgent_GetGradeCoefficient_TestCases(int weekOfTheReporting, decimal expectedCoefficient)
        {
            // Act
            var actualCoefficient = GradesAgent.GetGradeCoefficient(weekOfTheReporting);

            // Assert
            Assert.AreEqual(expectedCoefficient, actualCoefficient);
        }
    }
}