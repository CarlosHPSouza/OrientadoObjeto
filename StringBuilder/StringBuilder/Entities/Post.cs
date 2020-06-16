using System;
using System.Collections.Generic;
using System.Text;

namespace StringBuilder.Entities
{
    class Post
    {
        public DateTime Moment { get; set; }
        public string Title  { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comentario> Comments { get; set; } = new List<Comentario>();

        public Post()
        {

        }

        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }

        public void AddComentario (Comentario comentario)
        {
            Comments.Add(comentario);
        }

        public void RemoveComentario (Comentario comentario)
        {
            Comments.Remove(comentario);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Title);
            sb.Append(Likes);
            sb.Append(" Likes - ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.AppendLine("Comments:");
            foreach (Comentario c in Comments)
            {
                sb.AppendLine(c.Text);
            }
            return sb.ToString();
        }
    }
}
