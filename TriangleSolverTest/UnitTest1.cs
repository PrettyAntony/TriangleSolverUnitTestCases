using TriangleSolver;

namespace TriangleSolverTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void ValidTriangle_Input30and30and30_OutputValidEquilateralTriangle()
        {
            //Arrange
            int firstSide = 30;
            int secondSide = 30;
            int thirdSide = 30;

            string expectedResponse = "An equilateral triangle is formed";

            //Act
            var actualResposne = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Asserts
            Assert.IsNotEmpty(actualResposne);
            Assert.AreEqual(actualResposne, expectedResponse);
        }

        [Test]
        public void ValidTriangle_Input30and30and25_OutputValidIsoscelesTriangle()
        {
            //Arrange
            int firstSide = 30;
            int secondSide = 30;
            int thirdSide = 25;

            string expectedResponse = "An isosceles triangle is formed";

            //Act
            var actualResposne = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Asserts
            Assert.IsNotEmpty(actualResposne);
            Assert.AreEqual(actualResposne, expectedResponse);
        }

        [Test]
        public void ValidTriangle_Input30and35and35_OutputValidIsoscelesTriangle()
        {
            //Arrange
            int firstSide = 30;
            int secondSide = 35;
            int thirdSide = 35;

            string expectedResponse = "An isosceles triangle is formed";

            //Act
            var actualResposne = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Asserts
            Assert.IsNotEmpty(actualResposne);
            Assert.AreEqual(actualResposne, expectedResponse);
        }
    }
}