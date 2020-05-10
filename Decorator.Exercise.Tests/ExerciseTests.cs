using NUnit.Framework;

namespace Decorator.Exercise.Tests
{
    public class ExerciseTests
    {
        [Test]
        public void Test()
        {
            var dragon = new Dragon();

            Assert.That(dragon.Fly(), Is.EqualTo("flying"));
            Assert.That(dragon.Crawl(), Is.EqualTo("too young"));

            dragon.Age = 20;

            Assert.That(dragon.Fly(), Is.EqualTo("too old"));
            Assert.That(dragon.Crawl(), Is.EqualTo("crawling"));
        }
    }
}