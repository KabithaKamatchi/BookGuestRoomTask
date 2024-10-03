using GuestsRoomLogic;

namespace GuestsRoom.Test
{
    [TestClass]
    public class RoomSeperationTest
    {
        #region Tests
        [TestMethod]
        public void TestBookRooms_3A_5C()
        {
            //Arrange 
            int nAdult = 3;
            int nChildren = 5;

            //Act
            string strResult = BookRoom.RoomSeperation(nAdult, nChildren);

            string expected = "Room 1: Adults 2 - Children 2\nRoom 2: Adults 1 - Children 3";

            //Assert
            Assert.AreEqual(expected, strResult);
        }

        [TestMethod]
        public void TestBookRooms_4A_5C()
        {
            //Arrange 
            int nAdult = 4;
            int nChildren = 5;

            //Act
            string strResult = BookRoom.RoomSeperation(nAdult, nChildren);

            string expected = "Room 1: Adults 2 - Children 2\nRoom 2: Adults 2 - Children 2\nNo adults available. 1 children have no rooms.";

            //Assert
            Assert.AreEqual(expected, strResult);


        }

        [TestMethod]
        public void TestBookRooms_4A_6C()
        {
            //Arrange 
            int nAdult = 4;
            int nChildren = 6;

            //Act
            string strResult = BookRoom.RoomSeperation(nAdult, nChildren);

            string expected = "Room 1: Adults 2 - Children 2\nRoom 2: Adults 2 - Children 2\nRoom 3: Adults 0 - Children 2";

            //Assert
            Assert.AreEqual(expected, strResult);
        }

        [TestMethod]
        public void TestBookRooms_1A_0C()
        {
            //Arrange 
            int nAdult = 1;
            int nChildren = 0;

            //Act
            string strResult = BookRoom.RoomSeperation(nAdult, nChildren);

            string expected = "Room 1: Adults 1 - Children 0";

            //Assert
            Assert.AreEqual(expected, strResult);
        }

        [TestMethod]
        public void TestBookRooms_1A_1C()
        {
            //Arrange 
            int nAdult = 1;
            int nChildren = 1;

            //Act
            string strResult = BookRoom.RoomSeperation(nAdult, nChildren);

            string expected = "Room 1: Adults 1 - Children 1";

            //Assert
            Assert.AreEqual(expected, strResult);
        }

        [TestMethod]
        public void TestBookRooms_4A_0C()
        {
            //Arrange 
            int nAdult = 1;
            int nChildren = 1;

            //Act
            string strResult = BookRoom.RoomSeperation(nAdult, nChildren);

            string expected = "Room 1: Adults 1 - Children 1";

            //Assert
            Assert.AreEqual(expected, strResult);
        }

        [TestMethod]
        public void TestBookRooms_0A_0C()
        {
            //Arrange 
            int nAdult = 0;
            int nChildren = 0;

            //Act
            string strResult = BookRoom.RoomSeperation(nAdult, nChildren);

            string expected = "Error: At least one adult is required to book rooms.";

            //Assert
            Assert.AreEqual(expected, strResult);
        }

        [TestMethod]
        public void TestBookRooms_3A_8C()
        {
            //Arrange 
            int nAdult = 3;
            int nChildren = 8;

            //Act
            string strResult = BookRoom.RoomSeperation(nAdult, nChildren);

            string expected = "Room 1: Adults 2 - Children 2\nRoom 2: Adults 1 - Children 3\nNo adults available. 3 children have no rooms.";

            //Assert
            Assert.AreEqual(expected, strResult);
        }
        [TestMethod]
        public void TestBookRooms_2A_8C()
        {
            //Arrange 
            int nAdult = 2;
            int nChildren = 8;

            //Act
            string strResult = BookRoom.RoomSeperation(nAdult, nChildren);

            string expected = "Room 1: Adults 2 - Children 2\nNo adults available. 6 children have no rooms.";

            //Assert
            Assert.AreEqual(expected, strResult);
        }

        #endregion
    }
}