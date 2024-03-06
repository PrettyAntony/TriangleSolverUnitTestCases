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

        [Test]
        public void ValidTriangle_Input40and35and40_OutputValidIsoscelesTriangle()
        {
            //Arrange
            int firstSide = 40;
            int secondSide = 35;
            int thirdSide = 40;

            string expectedResponse = "An isosceles triangle is formed";

            //Act
            var actualResposne = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Asserts
            Assert.IsNotEmpty(actualResposne);
            Assert.AreEqual(actualResposne, expectedResponse);
        }

        [Test]
        public void ValidTriangle_Input30and35and40_OutputValidScaleneTriangle()
        {
            //Arrange
            int firstSide = 30;
            int secondSide = 35;
            int thirdSide = 40;

            string expectedResponse = "A scalene triangle is formed";

            //Act
            var actualResposne = Triangle.AnalyzeTriangle(firstSide, secondSide,thirdSide);

            //Asserts
            Assert.IsNotEmpty(actualResposne);
            Assert.AreEqual(actualResposne, expectedResponse);
        }

        [Test]
        public void ValidTriangle_Input20and22and40_OutputValidScaleneTriangle()
        {
            //Arrange
            int firstSide = 20;
            int secondSide = 22;
            int thirdSide = 40;

            string expectedResponse = "A scalene triangle is formed";

            //Act
            var actualResposne = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Asserts
            Assert.IsNotEmpty(actualResposne);
            Assert.AreEqual(actualResposne, expectedResponse);
        }

        [Test]
        public void ValidTriangle_Input10and12and18_OutputValidScaleneTriangle()
        {
            //Arrange
            int firstSide = 10;
            int secondSide = 12;
            int thirdSide = 18;

            string expectedResponse = "A scalene triangle is formed";

            //Act
            var actualResposne = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Asserts
            Assert.IsNotEmpty(actualResposne);
            Assert.AreEqual(actualResposne, expectedResponse);
        }

        [Test]
        public void ValidTriangle_Input8and9and15_OutputValidScaleneTriangle()
        {
            //Arrange
            int firstSide = 8;
            int secondSide = 9;
            int thirdSide = 15;

            string expectedResponse = "A scalene triangle is formed";

            //Act
            var actualResposne = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Asserts
            Assert.IsNotEmpty(actualResposne);
            Assert.AreEqual(actualResposne, expectedResponse);
        }

        [Test]
        public void ValidTriangle_Input99and88and111_OutputValidScaleneTriangle()
        {
            //Arrange
            int firstSide = 99;
            int secondSide = 88;
            int thirdSide = 111;

            string expectedResponse = "A scalene triangle is formed";

            //Act
            var actualResposne = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Asserts
            Assert.IsNotEmpty(actualResposne);
            Assert.AreEqual(actualResposne, expectedResponse);
        }

        [Test]
        public void InValidTriangle_Input0and8and11_OutputOneSideIsZero()
        {
            //Arrange
            int firstSide = 0;
            int secondSide = 8;
            int thirdSide = 11;

            string expectedResponse = "At least one side entered had a zero - invalid triangle";

            //Act
            var actualResposne = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Asserts
            Assert.IsNotEmpty(actualResposne);
            Assert.AreEqual(actualResposne, expectedResponse);
        }

        [Test]
        public void InValidTriangle_Input9and0and11_OutputOneSideIsZero()
        {
            //Arrange
            int firstSide = 9;
            int secondSide = 0;
            int thirdSide = 11;

            string expectedResponse = "At least one side entered had a zero - invalid triangle";

            //Act
            var actualResposne = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Asserts
            Assert.IsNotEmpty(actualResposne);
            Assert.AreEqual(actualResposne, expectedResponse);
        }

        [Test]
        public void InValidTriangle_Input9and12and0_OutputOneSideIsZero()
        {
            //Arrange
            int firstSide = 9;
            int secondSide = 12;
            int thirdSide = 0;

            string expectedResponse = "At least one side entered had a zero - invalid triangle";

            //Act
            var actualResposne = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Asserts
            Assert.IsNotEmpty(actualResposne);
            Assert.AreEqual(actualResposne, expectedResponse);
        }

        [Test]
        public void InValidTriangle_Input9and10and50_OutputOneSideIsZero()
        {
            //Arrange
            int firstSide = 9;
            int secondSide = 10;
            int thirdSide = 50;

            string expectedResponse = "A triangle cannot be formed";

            //Act
            var actualResposne = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Asserts
            Assert.IsNotEmpty(actualResposne);
            Assert.AreEqual(actualResposne, expectedResponse);
        }

        [Test]
        public void InValidTriangle_Input9and75and15_OutputOneSideIsZero()
        {
            //Arrange
            int firstSide = 9;
            int secondSide = 75;
            int thirdSide = 15;

            string expectedResponse = "A triangle cannot be formed";

            //Act
            var actualResposne = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Asserts
            Assert.IsNotEmpty(actualResposne);
            Assert.AreEqual(actualResposne, expectedResponse);
        }

        [Test]
        public void InValidTriangle_Input90and10and50_OutputOneSideIsZero()
        {
            //Arrange
            int firstSide = 90;
            int secondSide = 10;
            int thirdSide = 50;

            string expectedResponse = "A triangle cannot be formed";

            //Act
            var actualResposne = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Asserts
            Assert.IsNotEmpty(actualResposne);
            Assert.AreEqual(actualResposne, expectedResponse);
        }
    }
}