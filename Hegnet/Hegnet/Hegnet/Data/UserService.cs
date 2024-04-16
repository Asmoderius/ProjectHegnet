using Hegnet.Data.Model;

namespace Hegnet.Data
{
    public class UserService
    {
        public Task<User[]> GetUsersAsync()
        {
            var testService = new TestUserService();
            return Task.FromResult(testService.GetTestUsers());
        }
    }

    public class TestUserService
    {
        private User[] users = new User[3];

        public TestUserService() 
        {
            users[0] = new User() { FirstName = "Louis", LastName="Fleron", TelephoneNumber="30144433", Role = Role.Developer, Id = 0, Email = "louis@fleron.dk", Address = new Address() { RoadName = "Hegnet", Number = "67", Town = "Roskilde", ZipCode = "4000" } };
            users[1] = new User() { FirstName = "KristineMus", LastName="Fleron", Role = Role.Administrator, Id = 1, Email = "kristine@fleron.dk", Address = new Address() { RoadName = "Hegnet", Number = "67", Town = "Roskilde", ZipCode = "4000" } };
            users[2] = new User() { FirstName = "Bob", LastName="Hansen", Role = Role.User, Id = 2, Email = "bob@hansen.dk", Address = new Address() { RoadName = "Hegnet", Number = "69", Town = "Roskilde", ZipCode = "4000" } };
        }
        public User[] GetTestUsers()
        {
            return users;

        }
    }
}
