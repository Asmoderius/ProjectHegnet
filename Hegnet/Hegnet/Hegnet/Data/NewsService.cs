using Hegnet.Data.Model;

namespace Hegnet.Data
{
    public class NewsService
    {
        private List<NewsPost> newsPosts = new List<NewsPost>();

        public NewsService() { }

        public NewsPost[] GetPosts()
        {
            return newsPosts.ToArray();
        }

        public NewsPost GetNewsPostById(int id)
        {
            return newsPosts.SingleOrDefault(x => x.ID == id);
        }

        public int AddNewsPort(NewsPost post) 
        {
            post.ID = newsPosts.Count + 1;
            newsPosts.Add(post);
            return post.ID;
        }

        public void UpdateNewsPort(int postId, string topic, string content) 
        {
            var post = newsPosts.Find(x => x.ID == postId);
            post.Content = content;
            post.Topic = topic;
        }

        public void DeleteNewsPort(int postId) 
        {
            var post = newsPosts.Find(x=>x.ID == postId);
            newsPosts.Remove(post);

        }
    }

}
