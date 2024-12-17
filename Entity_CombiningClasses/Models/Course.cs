using System.ComponentModel.DataAnnotations;

namespace Entity_CombiningClasses.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public int Duration { get; set; }

        public IList<Training>? training { get; set; }

    }
}
