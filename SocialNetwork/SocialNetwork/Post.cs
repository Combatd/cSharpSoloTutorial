using System;


namespace SocialNetwork
{
    public class Post
    {
        private string text;

        // write a constructor here

        public Post()
        {
            Console.WriteLine("New post");
        }

        public void ShowPost()
        {
            Console.WriteLine(text);
        }

        // write a property for member text

        public string Text
        {
            get
            {
                return text;
            }

            set
            {
                text = value;
            }
        }
    }
}
