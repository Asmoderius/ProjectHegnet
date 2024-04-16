namespace Hegnet.Data.Model
{
    public class NewsPost
    {
        public string Topic { get; set; }
        public int ID { get; set; }
        public DateTime Posted { get; set; }
        public User User { get; set; }
        public string Content { get; set; }
        public string ContentSummary
        {
            get
            {
                if (Content.Length > 50)
                {
                    return Content.Substring(0, 50);
                }
                return Content;
            }
        }

        public NewsPost()
        {
        }

    }
}
