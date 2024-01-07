 namespace ClassLibrary1
{
    public class Person
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public DateTime DateOfBirth { get; set; }

        public virtual string ShowInfo()
        {
            return $"{Name} {SurName}, Дата народження: {DateOfBirth.ToShortDateString()}";
        }
    }
}
