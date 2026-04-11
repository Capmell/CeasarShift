namespace CeasarShiftTest
{
    public class Tests
    {
        CeasarShift.Cypher cc;


        [SetUp]
        public void Setup()
        {
            cc = new CeasarShift.Cypher();
        }

        [Test]
        public void shiftCorrectly()
        {
            var s = cc.shift("a", 5);
            Assert.That(s, Is.EqualTo("f"));
        }

        [Test]

        public void shiftBackCorrectly()
        {
            var s = cc.shift("d", 5);
            Assert.That(s, Is.EqualTo("f"));
        }

        [Test]

        public void shiftSentenceCorrectly()
        {
            var s = cc.shift("hey you your finally awake", 5);
            Assert.That(s, Is.EqualTo("mjd dtz dtzw knsfqqd fbfpj"));
        }

        [Test]

        public void shiftBackSentenceCorrectly()
        {
            var s = cc.shift("mjd dtz dtzw knsfqqd fbfpj", 5);
            Assert.That(s, Is.EqualTo("hey you your finally awake"));

        }
    }
}
