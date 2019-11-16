using System.ComponentModel.DataAnnotations.Schema;

namespace ScholCL
{
    public class Ratings
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        [ForeignKey("StudentId")]
        public Students Students { get; set; }
        public int DisciplinId { get; set; }
        [ForeignKey("DisciplinId")]
        public Disciplines Disciplines { get; set; }
        public int Rating { get; set; }
    }
}