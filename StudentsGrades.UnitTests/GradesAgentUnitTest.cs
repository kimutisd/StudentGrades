namespace StudentsGrades.UnitTests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class GradesAgentUnitTest
    {
        [TestMethod]
        public void GradesAgent_GetGradeCoefficient_ReturnsMaximumCoefficient()
        {
            // Arrange
            var maximumCoefficient = 1.2m;

            // Act
            var actualCoefficient = GradesAgent.GetGradeCoefficient(1);

            // Assert
            Assert.AreEqual(maximumCoefficient, actualCoefficient);
        }

        [TestMethod]
        public void GradesAgent_GetGradeCoefficient_ReturnsMinimumCoefficient()
        {
            // Arrange
            var minimumCoefficient = decimal.Zero;

            // Act
            var actualCoefficient = GradesAgent.GetGradeCoefficient(12);

            // Assert
            Assert.AreEqual(minimumCoefficient, actualCoefficient);
        }

        [TestMethod]
        public void GradesAgent_GetGradeCoefficient_ReturnsLastNonZeroCoefficient()
        {
            // Arrange
            var minimumCoefficient = 0.2m;

            // Act
            var actualCoefficient = GradesAgent.GetGradeCoefficient(11);

            // Assert
            Assert.AreEqual(minimumCoefficient, actualCoefficient);
        }

        [TestMethod]
        [ExpectedException(typeof (InvalidOperationException))]
        public void GradesAgent_GetGradeCoefficient_ThrowsExceptionIfMonthNumberIsIncorrect()
        {
            // Act
            var actualCoefficient = GradesAgent.GetGradeCoefficient(60);
        }

        [TestMethod]
        [ExpectedException(typeof (InvalidOperationException))]
        public void GradesAgent_GetGradeCoefficient_Returns13WeekCoeff()
        {
            // Act
            GradesAgent.GetGradeCoefficient(13);
        }
    }
}