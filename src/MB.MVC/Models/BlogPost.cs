namespace MB.MVC.Models
{
    public class BlogPost
    {
        public BlogPost(string action, string title)
        {
            Action = action;
            Title = title;
        }

        public string Action { get; }

        public string Title { get; }

        public static BlogPost AddPost(string action, string title)
        {
            return new BlogPost(action, title);
        }
    }
}
