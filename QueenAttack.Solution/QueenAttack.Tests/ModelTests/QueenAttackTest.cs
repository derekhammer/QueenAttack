using Microsoft.VisualStudio.TestTools.UnitTesting;
using QueenAttack;

namespace QueenAttack.TestTools
{
    [TestClass]
    public class QueenAttackTest
    {
        //Placement Input Check
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

        //Placement validation
        [TestMethod]
        public void PlacementCheckRange_CanPlaceOutsideRange_False()
        {
            Queen testQueenAttack = new Queen();
            Assert.AreEqual(false, testQueenAttack.PlacementCheckRange(8,9));
        }
        [TestMethod]
        public void PlacementCheckStack_CanPlaceSameCoordinates_False()
        {
            Queen testQueenAttack = new Queen();
            Assert.AreEqual(false, testQueenAttack.PlacementCheckStack(1,1,1,1));
        }
        //Attack validations
        [TestMethod]
        public void CanAttack_CanAttackX_True()
        {
          Queen testQueenAttack = new Queen();
          Assert.AreEqual(true, testQueenAttack.CanAttack(3,8,3,2))
        }
        
    }
}
