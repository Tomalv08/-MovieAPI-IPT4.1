using Microsoft.AspNetCore.Components;

namespace MovieAPI_IPT4_1.Models
{
    public class Kommentar
    {
        public string Text { get; set; }
        public int Likes { get; set; }
        public int Dislikes { get; set; }

        public Kommentar(string text, int likes, int dislikes)
        {
            Text = text;
            Likes = likes;
            Dislikes = dislikes;
        }
    }
}
