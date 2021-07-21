using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPost.Entities
{
    public class Coment
    {
        public string Text { get; set; }

        public Coment(string text)
        {
            Text = text;
        }
    }
}
