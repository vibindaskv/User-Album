using System.ComponentModel.DataAnnotations;

namespace User_Albums.Models
{
    public class Album
    {
        public int Id { get; set; }

        [Display(Name = "Album Titles")]
        public string Title { get; set; }
    }
}