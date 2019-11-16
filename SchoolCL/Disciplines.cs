namespace ScholCL
{
    public class Disciplines
    {
        public int Id { get; set; }
        public string Disciplin { get; set; }

        public override string ToString()
        {
            return $"{Disciplin}";
        }
    }
}