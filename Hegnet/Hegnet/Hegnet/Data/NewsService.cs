using Hegnet.Data.Model;

namespace Hegnet.Data
{
    public class NewsService
    {
        public Task<NewsPost[]> GetPostsAsync()
        {
            var testService = new TestNewsService();
            return Task.FromResult(testService.GetTestPosts());
        }

        public Task<NewsPost> GetNewsPostByIdAsync(int id)
        {
            var testService = new TestNewsService();
            return Task.FromResult(testService.GetTestPostById(id));
        }
    }

    public class TestNewsService
    {
        private NewsPost[] posts = new NewsPost[1];

        public TestNewsService()
        {
            var testUser = new User() { FirstName = "Louis", LastName = "Fleron", TelephoneNumber = "30144433", Role = Role.Developer, Id = 0, Email = "louis@fleron.dk", Address = new Address() { RoadName = "Hegnet", Number = "67", Town = "Roskilde", ZipCode = "4000" } }; 
            posts[0] = new NewsPost() { Content = "Dette er en test blablablablablabla blablabla blablabla blablabla blablabla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla", ID = 1, Posted=DateTime.Now, Topic="Test", User=testUser };
        }
        public NewsPost[] GetTestPosts()
        {
            return posts;
        }

        public NewsPost GetTestPostById(int id)
        {
            foreach (var post in posts)
            {
                if(post.ID == id)
                {
                    return post;
                }
            }
            return null;
        }
    }
}
