
using CollectionEntities;
using CollectionLogic.Entities;
using NUnit.Framework;

namespace UnitTests.Entities
{
    public class UserEntity
    {
        private readonly int Id = 1;
        private readonly string FirstName = "Maarten";
        private readonly string LastName = "Jakobs";
        private readonly string Email = "Maarten.jakobs@gmail.com";
        private readonly string ProfilePicture = null;

        private UserDTO userDto;

        [SetUp]
        public void Setup()
        {
            userDto = new UserDTO()
            {
                Id = this.Id,
                FirstName = this.FirstName,
                LastName = this.LastName,
                Email = this.Email,
                ProfilePicture = this.ProfilePicture
            };
        }

        [Test]
        public void Test1()
        {
            CollectionLogic.Entities.UserEntitiy user = new UserEntitiy().UserDTOToUser(userDto);
            if (user.Id == this.Id && user.FirstName == this.FirstName && user.LastName == this.LastName && user.Email == this.Email && user.ProfilePicture == this.ProfilePicture)
            {
                Assert.Pass();
            }
            Assert.Fail();
        }
    }
}