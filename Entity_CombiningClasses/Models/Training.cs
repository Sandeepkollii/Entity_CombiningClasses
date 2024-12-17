namespace Entity_CombiningClasses.Models
{
    public class Training
    {
        public int TrainingId { get; set; }
        public string Desc { get; set; }
        public string? TrainingName { get; set; }
        public DateTime StartDate { get; set; }
        public int Seats { get; set; }
        public string TrainerName { get; set; }

        //Now we have to add foreign key
        public int  CourseId { get; set; }
        public Course? Course { get; set; }
        

    }
}
