using System.ComponentModel.DataAnnotations.Schema;

namespace ScholCL
{
    public class Teachers
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int DisciplinesID { get; set; }
        [ForeignKey("DisciplinesID")]
        public Disciplines Disciplines { get; set; }
        public byte[] Avatar { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public override string ToString()
        {
            return $"{Name} {Surname}";
        }
    }
}