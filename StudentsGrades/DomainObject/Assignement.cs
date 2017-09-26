namespace StudentsGrades.DomainObject
{
    public class Assignement
    {
        public int Id { get; set; }

        public string Label { get; set; }

        public override string ToString()
        {
            return Label;
        }
    }
}