namespace TriangleTest
{
    public class Tests
    {
        
        [TestCase("s", "8", "5")]
        [TestCase("б", "в", "4")]
        [TestCase("!", "2", "$")]
        public void Test1(string a, string b, string c)
        {
            List<(int, int)> vertices = new List<(int, int)>();
            vertices = new List<(int, int)> { (-2, -2), (-2, -2), (-2, -2) };
            var expected = ("", vertices);

            var actual = Triangle.GetTriangleInfo(a, b, c);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase("2", "2", "5")]
        [TestCase("6.2", "3.1", "3.1")]
        [TestCase("4,2", "8", "2")]
        public void Test2(string a, string b, string c)
        {
            List<(int, int)> vertices = new List<(int, int)>();
            vertices = new List<(int, int)> { (-1, -1), (-1, -1), (-1, -1) };
            var expected = ("не треугольник", vertices);

            var actual = Triangle.GetTriangleInfo(a, b, c);

            Assert.That(actual, Is.EqualTo(expected));
        }

        #region равносторонний
        [Test]
        public void Test3()
        {
            List<(int, int)> vertices = new List<(int, int)>();
            vertices = new List<(int, int)> { (0, 0), (10, 0), (5, 8) };
            var expected = ("равносторонний", vertices);

            var actual = Triangle.GetTriangleInfo("10","10","10");

            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase("231.43", "231.43", "231.43")]
        [TestCase("231,43", "231,43", "231,43")]
        [TestCase("231,43", "231,43", "231.43")]
        [TestCase("231,43", "231,43", "231.43")]
        public void Test4(string a, string b, string c)
        {
            List<(int, int)> vertices = new List<(int, int)>();
            vertices = new List<(int, int)> { (0, 0), (231, 0), (115, 200) };
            var expected = ("равносторонний", vertices);

            var actual = Triangle.GetTriangleInfo(a, b, c);

            Assert.That(actual, Is.EqualTo(expected));
        }
        #endregion

        #region равнобедренный
        [Test]
        public void Test5()
        {
            List<(int, int)> vertices = new List<(int, int)>();
            vertices = new List<(int, int)> { (0, 0), (7, 0), (6, 2) };
            var expected = ("равнобедренный", vertices);

            var actual = Triangle.GetTriangleInfo("3", "7", "7");

            Assert.That(actual, Is.EqualTo(expected));
        }

        public void Test6()
        {
            List<(int, int)> vertices = new List<(int, int)>();
            vertices = new List<(int, int)> { (0, 0), (5, 0), (1, 4) };
            var expected = ("равнобедренный", vertices);

            var actual = Triangle.GetTriangleInfo("8", "5", "5");

            Assert.That(actual, Is.EqualTo(expected));
        }


        [TestCase("3.37", "5.12", "5.12")]
        [TestCase("3,37", "5.12", "5.12")]
        [TestCase("3,37", "5,12", "5.12")]
        [TestCase("3,37", "5,12", "5,12")]
        public void Test7(string a, string b, string c)
        {
            List<(int, int)> vertices = new List<(int, int)>();
            vertices = new List<(int, int)> { (0, 0), (5, 0), (4, 3) };
            var expected = ("равнобедренный", vertices);

            var actual = Triangle.GetTriangleInfo(a, b, c);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase("8.37", "5.12", "5.12")]
        [TestCase("8,37", "5.12", "5.12")]
        [TestCase("8,37", "5,12", "5.12")]
        [TestCase("8,37", "5,12", "5,12")]
        public void Test8(string a, string b, string c)
        {
            List<(int, int)> vertices = new List<(int, int)>();
            vertices = new List<(int, int)> { (0, 0), (5, 0), (1, 4) };
            var expected = ("равнобедренный", vertices);

            var actual = Triangle.GetTriangleInfo(a, b, c);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test9()
        {
            List<(int, int)> vertices = new List<(int, int)>();
            vertices = new List<(int, int)> { (0, 0), (15, 0), (7, 6) };
            var expected = ("равнобедренный", vertices);

            var actual = Triangle.GetTriangleInfo("10", "10", "15");

            Assert.That(actual, Is.EqualTo(expected));
        }

        public void Test10()
        {
            List<(int, int)> vertices = new List<(int, int)>();
            vertices = new List<(int, int)> { (0, 0), (8, 0), (4, 9) };
            var expected = ("равнобедренный", vertices);

            var actual = Triangle.GetTriangleInfo("10", "10", "8");

            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase("12.5", "12.5", "20.1")]
        [TestCase("12,5", "12,5", "20,1")]
        [TestCase("12,5", "12,5", "20.1")]
        [TestCase("12,5", "12.5", "20.1")]
        public void Test11(string a, string b, string c)
        {
            List<(int, int)> vertices = new List<(int, int)>();
            vertices = new List<(int, int)> { (0, 0), (20, 0), (10, 7) };
            var expected = ("равнобедренный", vertices);

            var actual = Triangle.GetTriangleInfo(a, b, c);

            Assert.That(actual, Is.EqualTo(expected));
        }


        [TestCase("12.5", "12.5", "9.75")]
        [TestCase("12,5", "12,5", "9,75")]
        [TestCase("12,5", "12,5", "9.75")]
        [TestCase("12,5", "12.5", "9.75")]
        public void Test12(string a, string b, string c)
        {
            List<(int, int)> vertices = new List<(int, int)>();
            vertices = new List<(int, int)> { (0, 0), (9, 0), (4, 11) };
            var expected = ("равнобедренный", vertices);

            var actual = Triangle.GetTriangleInfo(a, b, c);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test13()
        {
            List<(int, int)> vertices = new List<(int, int)>();
            vertices = new List<(int, int)> { (0, 0), (312, 0), (413, 295) };
            var expected = ("равнобедренный", vertices);

            var actual = Triangle.GetTriangleInfo("312", "508", "312");

            Assert.That(actual, Is.EqualTo(expected));
        }

        public void Test14()
        {
            List<(int, int)> vertices = new List<(int, int)>();
            vertices = new List<(int, int)> { (0, 0), (312, 0), (152, 267) };
            var expected = ("равнобедренный", vertices);

            var actual = Triangle.GetTriangleInfo("312", "308", "312");

            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase("123.16", "172.76", "123.16")]
        [TestCase("123,16", "172,76", "123,16")]
        [TestCase("123,16", "172,76", "123.16")]
        [TestCase("123,16", "172.76", "123.16")]
        public void Test15(string a, string b, string c)
        {
            List<(int, int)> vertices = new List<(int, int)>();
            vertices = new List<(int, int)> { (0, 0), (123, 0), (121, 123) };
            var expected = ("равнобедренный", vertices);

            var actual = Triangle.GetTriangleInfo(a, b, c);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase("123.16", "95.76", "123.16")]
        [TestCase("123,16", "95,76", "123,16")]
        [TestCase("123,16", "95,76", "123.16")]
        [TestCase("123,16", "95.76", "123.16")]
        public void Test16(string a, string b, string c)
        {
            List<(int, int)> vertices = new List<(int, int)>();
            vertices = new List<(int, int)> { (0, 0), (123, 0), (37, 88) };
            var expected = ("равнобедренный", vertices);

            var actual = Triangle.GetTriangleInfo(a, b, c);

            Assert.That(actual, Is.EqualTo(expected));
        }
        #endregion

        #region разносторонний
        [Test]
        public void Test17()
        {
            List<(int, int)> vertices = new List<(int, int)>();
            vertices = new List<(int, int)> { (0, 0), (12, 0), (6, 4) };
            var expected = ("разносторонний", vertices);

            var actual = Triangle.GetTriangleInfo("7", "8", "12");

            Assert.That(actual, Is.EqualTo(expected));
        }
        public void Test18()
        {
            List<(int, int)> vertices = new List<(int, int)>();
            vertices = new List<(int, int)> { (0, 0), (12, 0), (4, 6) };
            var expected = ("разносторонний", vertices);

            var actual = Triangle.GetTriangleInfo("10", "8", "12");

            Assert.That(actual, Is.EqualTo(expected));
        }

        public void Test19()
        {
            List<(int, int)> vertices = new List<(int, int)>();
            vertices = new List<(int, int)> { (0, 0), (9, 0), (9, 12) };
            var expected = ("разносторонний", vertices);

            var actual = Triangle.GetTriangleInfo("12", "15", "9");

            Assert.That(actual, Is.EqualTo(expected));
        }
        [TestCase("6.3", "8.7", "11.4")]
        [TestCase("6,3", "8,7", "11.4")]
        [TestCase("6,3", "8,7", "11,4")]
        [TestCase("6.3", "8,7", "11,4")]
        public void Test20(string a, string b, string c)
        {
            List<(int, int)> vertices = new List<(int, int)>();
            vertices = new List<(int, int)> { (0, 0), (11, 0), (7, 4) };
            var expected = ("разносторонний", vertices);

            var actual = Triangle.GetTriangleInfo(a, b, c);

            Assert.That(actual, Is.EqualTo(expected));
        }
        #endregion
    }
}