using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jokesWebApp.Models
{
    public class Joke
    {

        /* prob*/
        public int Id { get; set; }
        public String  JokeQuestions { get; set; }

        public String  JokeAnswers { get; set; }

        /* ctor*/
        public Joke()
        {

        }
    }
}
