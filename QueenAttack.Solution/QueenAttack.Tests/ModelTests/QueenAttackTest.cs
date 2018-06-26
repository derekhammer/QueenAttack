using Microsoft.VisualStudio.TestTools.UnitTesting;
using QueenAttack;

namespace QueenAttack.TestTools
{
    [TestClass]
    public class QueenAttackTest
    {
        [TestMethod]
        public void QueenPlace_CanPlaceQueenInt_True()
        {
            Queen testQueenAttack = new Queen();
            Assert.AreEqual(true, testQueenAttack.QueenPlace(3,3));
        }
        [TestMethod]
        public void QueenPlace_CanPlaceQueenChar_True()
        {
          Queen testQueenAttack = new Queen();
          Assert.AreEqual(true, testQueenAttack.QueenPlace('4','8'));
        }
        [TestMethod]
        public void UserPlace_CanPlaceUserInt_True()
        {
          Queen testQueenAttack = new Queen();
          Assert.AreEqual(true, testQueenAttack.UserPlace(3,4));
        }
        [TestMethod]
        public void UserPlace_CanPlaceUserChar_True()
        {
          Queen testQueenAttack = new Queen();
          Assert.AreEqual(true, testQueenAttack.UserPlace('2','7'));
        }
    }
}
