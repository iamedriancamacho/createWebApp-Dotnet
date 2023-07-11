using System.ComponentModel.DataAnnotations;

namespace SampleWebApp.Models
{
    public class Joke
    {
        [Key]
        public int Id { get; set; }
        public string JokeQuestion { get; set; }
        public string Answer { get; set; }

        public Joke()
        {

        }
    }
}
