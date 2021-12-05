using Microsoft.VisualStudio.TestTools.UnitTesting;
using KATA_DOOR;


namespace KATADOOR
{
    [TestClass]
    public class KataDoor
    {
        [TestMethod]
        public void ClosedDoor()
        {
            Door status = new Door(false, false);
            bool statusdoor = status.IsClosed;
            Assert.IsTrue(statusdoor);
        }

        [TestMethod]
        public void OpenedDoor()
        {
            Door status = new Door(true, false);
            bool statusdoor = status.IsOpen;
            Assert.IsTrue(statusdoor);
        }

        [TestMethod]
        public void LockedDoor()
        {
            Door status = new Door(false, false);
            bool statusdoor = status.IsLocked;
            Assert.IsTrue(statusdoor);
        }

        [TestMethod]
        public void UnlockedDoor()
        {
            Door status = new Door(false, true) ;
            bool statusdoor = status.IsUnlocked;
            Assert.IsTrue(statusdoor);
        }

        [TestMethod]
        public void OpenAndLocked()
        {
            Door status = new Door(true, false);
            bool statusdoor = status.IsOpen && status.IsLocked;
            Assert.IsTrue(statusdoor);
        }

        [TestMethod]
        public void OpenAndUnlocked()
        {
            Door status = new Door(true, true);
            bool statusdoor = status.IsOpen && status.IsUnlocked;
            Assert.IsTrue(statusdoor);
        }

        [TestMethod]
        public void CloseAndUnlocked()
        {
            Door status = new Door(false, true);
            bool statusdoor = status.IsClosed && status.IsUnlocked;
            Assert.IsTrue(statusdoor);
        }

        [TestMethod]
        public void CloseAndLocked()
        {
            Door status = new Door(false, false);
            bool statusdoor = status.IsClosed && status.IsLocked;
            Assert.IsTrue(statusdoor);
        }

       
    }
}
