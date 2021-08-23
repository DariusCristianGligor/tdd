using Microsoft.VisualBasic.ApplicationServices;
using Moq;
using NUnit.Framework;
using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestFixture]
    public class ManagerReviewTest
    {

        private readonly Mock<ManagerReview> _contextMock = new Mock<ManagerReview>();

        [TestCase]
        public void CanBeDeleted_userIsAdmin_ReturnsTrueWithMock()
        {   var manageReview = new ManagerReview();
            Mock<User> contextMockUser = new Mock<User>();
            contextMockUser.Setup(p => p.IsAdmin()).Returns(true);
            _contextMock.Setup(p => p.CanBeDeletedUser(It.IsAny<IUser>)).Returns(true);
            var result = manageReview.CanBeDeletedUser(contextMockUser.Object);
            Assert.That(result == true);
        }

        [TestCase]
        public void CanBeDeleted_userIsAdmin_ReturnsTrue()
        {
            //Arrange
            var manageReview = new ManagerReview();
            User user = new User("Florin","Florin@gmail.com","Primaverii","Stea2021ua",true);
            Review review = new Review(98,Price.Cheap);
            manageReview.Review = review;
            //Act
            var result = manageReview.CanBeDeletedUser(user);
            //Assert
            Assert.That(result==true);
        }
        [TestCase]
        public void CanBeDeleted_userIsAdmin_ReturnsFalse()
        {
            //Arrange
            var manageReview = new ManagerReview();
            User user = new User("Florin", "Florin@gmail.com", "Primaverii", "Stea2021ua", false);
            Review review = new Review(98, Price.Cheap);
            manageReview.Review = review;
            //Act
            var result = manageReview.CanBeDeletedUser(user);
            //Assert
            Assert.IsFalse(result);
        }
        [TestCase("Florin", "Florin@gmail.com", "Primaverii", "Stea2021ua", false,9,Price.Affordable)]
        [TestCase("Florin123123", "Flori123123n@gmail.com", "Primaverii", "Stea2021ua12312", false,9,Price.Expensive)]
        public void CanBeDeleted_userIsNormal_ReturnsTrue(string name,string mail,string adress,string password,bool isAdmin,float note, Price isPrice)
        {
            //Arrange
            User user1 = new User(name, mail, adress, password, isAdmin);
            Review review = new Review(note, isPrice, user1);
            var manageReview = new ManagerReview();
            manageReview.Review = review;
            //Act
            var result = manageReview.CanBeDeletedUser(user1);
            //Assert
            Assert.That(result, Is.True);
        }
        //[TestCase]
        //public void CanBeDeleted_userIsAdmin_ReturnsTrueWithMock()
        //{
        //    var manageReview = new ManagerReview();
        //    Mock<User> contextMockUser = new Mock<User>();
        //    contextMockUser.Setup(p => p.IsAdmin()).Returns(true);
        //    _contextMock.Setup(p => p.CanBeDeletedUser(It.IsAny<IUser>)).Returns(true);
        //    var result = manageReview.CanBeDeletedUser(contextMockUser.Object);
        //    Assert.That(result == true);
        //}

    }


}
