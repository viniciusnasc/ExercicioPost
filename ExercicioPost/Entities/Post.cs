using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPost.Entities
{
    class Post
    {
        public DateTime Date { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Coment> Coments { get; set; } = new List<Coment>();

        public Post(DateTime date, string title, string content, int Likes)
        {
            Date = date;
            Title = title;
            Content = content;
        }

        public void AddComent(Coment coment)
        {
            Coments.Add(coment);
        }

        public void RemoveComent(Coment coment)
        {
            Coments.Remove(coment);
        }

        public override string ToString()
        {
            StringBuilder sb = new();
            sb.AppendLine(Title);
            sb.Append(Likes);
            sb.Append(" Likes - ");
            sb.AppendLine(Date.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.AppendLine("Coments: ");
            foreach (Coment c in Coments)
            {
                sb.AppendLine(c.Text);
            }
            return sb.ToString();
        }
    }
}
