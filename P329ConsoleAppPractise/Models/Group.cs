namespace P329ConsoleAppPractise.Models
{
    internal class Group
    {
        internal int Id { get; set; }
        internal string Name { get; set; }
        internal Student[] Students { get; set; } = new Student[50];

        public override string ToString()
        {
            return $"{Id} {Name}";
        }
    }
}
