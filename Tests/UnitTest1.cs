using ClassRoom;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        [DataRow(12,1,2, "Winter")]
        [DataRow(3,4,5,"Spring")]
        [DataRow(6,7,8, "Summer")]
        [DataRow(9,10,11, "Autumn")]
        public void CheckSeasonSpring(int monthOne, int monthTwo, int monthThree, string monthName)
        {
            //Arrange
            Student s1 = new Student("Someone1", monthOne, 1);
            Student s2 = new Student("Someone2", monthTwo, 1);
            Student s3 = new Student("Someone3", monthThree, 1);

            //Act
            string seasonName1 = s1.Season();
            string seasonName2 = s2.Season();
            string seasonName3 = s3.Season();

            //Assert
            Assert.AreEqual(monthName, seasonName1, seasonName2, seasonName3);
        }
    }
}
