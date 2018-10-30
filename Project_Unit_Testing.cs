using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    [TestFixture]
    class Project_Unit_Testing
    {
        [TestCase]
        public void Test_Spin()
        {
            PlayTheRoulette testspin = new PlayTheRoulette();
            Assert.AreEqual(1, testspin.spinchambervalue(6));
        }

        [TestCase]
        public void Test_Fire()
        {
            RouletteGame testfire = new RouletteGame();
            Assert.AreEqual(10, testfire.Fire_Bullet(1,1));
        }

    }
}
