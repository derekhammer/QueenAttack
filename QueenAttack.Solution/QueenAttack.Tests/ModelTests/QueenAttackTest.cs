using Microsoft.VisualStudio.TestTools.UnitTesting;
using QueenAttack;

namespace QueenAttack.TestTools
{
    [TestClass]
    public class QueenAttackTest
    {
        [TestMethod]
        public void CanAttack_CanPlaceQueen_True()
        {
            Queen testQueenAttack = new Queen();
            Assert.AreEqual(true, testQueenAttack.QueenPlace());
        }
    }
}
