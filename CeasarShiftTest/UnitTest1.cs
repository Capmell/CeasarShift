using System.Runtime.InteropServices.Marshalling;

namespace CeasarShiftTest
{
    public class Tests
    {
 
        // need to fix this probabaly after I make the code to see if thats the issue
        // there are 2 cyphers becuase I could not figure out how to connect both projects
        // tried to fix the failed tests but could not
        CeasarShift.Cypher cc;


        [SetUp]
        public void Setup()
        {
            cc = new CeasarShift.Cypher();
        }

        [Test]
        public void shiftCorrectly()
        {
            var s = cc.Shift("a", 5);
            Assert.That(s, Is.EqualTo("f"));
        }

        [Test]
       
        public void shiftBackCorrectly()
        {
            var s = cc.UnShift("d", 5);

            Assert.That(s, Is.EqualTo("i"));
        }

        [Test]

        public void shiftSentenceCorrectly()
        {
            var s = cc.Shift("hey you your finally awake", 5);
            Assert.That(s, Is.EqualTo("mjd dtz dtzw knsfqqd fbfpj"));
        }

      
    }
}
