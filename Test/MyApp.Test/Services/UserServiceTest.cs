using Xunit;
using MyApp.Services;
using MyApp.Models;

namespace MyApp.Test.Services
{
    public class UserServicesTest
    {
        [Fact]
        public void AddUser_ShouldAddUserSuccessfully()
        {
            // Arrange
            var service = new UserServices();
            var user = new User(1, "Franciszek Kowalski");

            // Act
            service.AddUser(user);

            // Assert
            var result = service.GetUserById(1);
            Assert.NotNull(result);
            Assert.Equal("Franciszek Kowalski", result.Name);
        }
        [Fact]
        public void GetUserById_UserDoesNotExist_ShouldReturnNull()
        {
            //Arrange
            var service = new UserServices();

            //Act
            var result = service.GetUserById(1000);

            //Assert
            Assert.Null(result);
        }

        [Fact]
        public void RemoveUser_ShouldRemoveUserSuccessfully()
        {
            //Arrange
            var service = new UserServices();
            var user = new User(2, "Tomasz Nowak");
            service.AddUser(user);

            //Act
            var removed = service.RemoveUsers(2);


            //Assert
            Assert.True(removed);
            Assert.Null(service.GetUserById(2));
        }

        [Fact]
        public void GetAllUsers_ShouldReturnUserSuccessfully()
        {
            //Arrange
            var service = new UserServices();
            service.AddUser(new User(1, "Franciszek"));

            //Act
            var removed = service.RemoveUsers(2);


            //Assert
            Assert.True(removed);
            Assert.Null(service.GetUserById(2));
        }
    }
}
