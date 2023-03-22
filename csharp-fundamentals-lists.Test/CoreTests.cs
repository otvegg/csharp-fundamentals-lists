using csharp_fundamentals_lists.Main;
using NUnit.Framework;

namespace csharp_fundamentals_lists.Test
{
    [TestFixture]
    public class CoreTests
    {
        Core _core;
        public CoreTests()
        {
            _core = new Core();
        }

        [Test]
        public void Question1()
        {

            Assert.IsTrue(_core.Question1().Contains("Phish Food", StringComparer.OrdinalIgnoreCase) && _core.Question1().Contains("Peanut Butter Cup", StringComparer.OrdinalIgnoreCase));
            
        }
        [Test]
        public void Question2()
        {
            Assert.IsTrue(_core.Question1().Count > 5);
        }
        [Test]
        public void Question3()
        {
            Assert.IsTrue(_core.Question3().Contains("Praline"));
        }
        //Where(x => x.Equals(occur)).Count();
        [Test]
        public void Question4()
        {
            Assert.IsTrue(_core.Question4().Where(x => x.Equals("Strawberry Cheesecake")).Count()==1);
        }
    }
}