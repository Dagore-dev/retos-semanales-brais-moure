using LostNumbers;
namespace TestLostNumbers
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void NotASet()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Program.LostNumbers(new int[] { 1, 1, 5, 6, 7 });
            });
        }
        [Test]
        public void NotSortedArray()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Program.LostNumbers(new int[] { 6, 5, 1, 7 });
            });
        }
        [Test]
        public void SimpleUseCase()
        {
            int[] a = { 1, 3, 6, 7 };
            int[] expected = { 2, 4, 5 };
            int[] result = Program.LostNumbers(a);
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void EmptyArrayCase()
        {
            int[] a = Array.Empty<int>();
            int[] result = Program.LostNumbers(a);

            Assert.That(a, Is.EqualTo(result));
        }
        [Test]
        public void OneElementArrayCase()
        {
            int[] a = { 1 };
            int[] expected = Array.Empty<int>();
            int[] result = Program.LostNumbers(a);

            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void SmallArrayCaseWithoutLostNumbers()
        {
            int[] a = { 1, 2 };
            int[] expected = Array.Empty<int>();
            int[] result = Program.LostNumbers(a);

            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void SmallArrayCaseWithLostNumbers()
        {
            int[] a = { 1, 4 };
            int[] expected = { 2, 3 };
            int[] result = Program.LostNumbers(a);

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}