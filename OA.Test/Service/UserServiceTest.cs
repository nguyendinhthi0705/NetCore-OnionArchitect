using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OA.Service;
using Moq;
using OA.Data;
using OA.Repo;

namespace OA.Test.Service
{
    [TestClass]
    public class UserServiceTest
    {
        private UserService userService;
        private Mock<IRepository<User>> userRepository;
        private Mock<IRepository<UserProfile>> userProfileRepository;

        [TestInitialize]
        public void TestInitialize()
        {
            userRepository = new Mock<IRepository<User>>(MockBehavior.Strict);
            userProfileRepository = new Mock<IRepository<UserProfile>>(MockBehavior.Strict);

            userService = new UserService(userRepository.Object, userProfileRepository.Object);
        }

        [TestMethod]
        public void Get_Success()
        {
            long userId = 1;
            User user = new User()
            {
                Id = userId
            };

            userRepository.Setup(x => x.Get(userId)).Returns(user);

            var result = userService.GetUser(userId);

            userRepository.Verify(x => x.Get(userId), Times.Once());

            Assert.AreEqual(user, result);
        }
        
        [TestMethod]
        public void UpdateUser_Success()
        {
            long userId = 1;
            User user = new User()
            {
                Id = userId
            };

            userRepository.Setup(x => x.Update(user));

            userService.UpdateUser(user);

            userRepository.Verify(x => x.Update(user), Times.Once());

        }
    }
}
