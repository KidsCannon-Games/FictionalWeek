using NUnit.Framework;
using FictionalWeek;

namespace FictionalWeekTest
{
    [TestFixture]
    public class WeeksTest
    {
        [Test]
        public void TestMatch()
        {
            var w = new Weeks ();            
            Assert.IsTrue(w.IsMatch("*", "*", "*"));
            Assert.IsTrue(w.IsMatch("*", "*", "1"));
            Assert.IsTrue(w.IsMatch("*", "1", "1"));
            Assert.IsTrue(w.IsMatch("1", "1", "1"));
            
            Assert.IsFalse(w.IsMatch("*", "*", "2"));
            Assert.IsFalse(w.IsMatch("*", "2", "1"));
            Assert.IsFalse(w.IsMatch("2", "1", "1"));
            
            Assert.IsFalse(w.IsMatch("*", "a", "*"));
        }

        [Test]
        public void TestWeeks()
        {
            var w = new Weeks ();
            Assert.That (w.Year (), Is.EqualTo (1));
            Assert.That (w.Month (), Is.EqualTo (1));
            Assert.That (w.Week (), Is.EqualTo (1));
            // 12*4-1 進める (= 12*4 週目)
            for (var i = 0; i < 12 * 4 - 1; i++) {
                w.Next ();
            }
            Assert.That (w.Year (), Is.EqualTo (1));
            Assert.That (w.Month (), Is.EqualTo (12));
            Assert.That (w.Week (), Is.EqualTo (4));
            w.Next ();
            // 12*4+1 週目
            Assert.That (w.Week (), Is.EqualTo (1));
            Assert.That (w.Month (), Is.EqualTo (1));
            Assert.That (w.Year (), Is.EqualTo (2));

            for (var x = 0; x < 4; x++) {
                // 12*4-1 進める (= 12*4 週目)
                for (var y = 0; y < 12 * 4; y++) {
                    w.Next ();
                }
            }

            // 12*4*4+1 週目
            Assert.That (w.Week (), Is.EqualTo (1));
            Assert.That (w.Month (), Is.EqualTo (1));
            Assert.That (w.Year (), Is.EqualTo (6));
        }

        [Test]
        public void TestWeeks_week20()
        {
            var w = new Weeks ();
            for (var i = 0; i < 19; i++) {
                w.Next ();
            }
            Assert.That (w.Month (), Is.EqualTo (5));
        }

        [Test]
        public void TestWeeks_week50()
        {
            var w = new Weeks ();
            for (var i = 0; i < 49; i++) {
                w.Next ();
            }
            Assert.That (w.Month (), Is.EqualTo (1));
        }

        [Test]
        public void TestWeeks_week53()
        {
            var w = new Weeks ();
            for (var i = 0; i < 52; i++) {
                w.Next ();
            }
            Assert.That (w.Month (), Is.EqualTo (2));
        }
    }
}