namespace P329ConsoleAppPractise.Models
{
    internal class Teacher : Person
    {
        internal Group[] Groups { get; set; } = new Group[10];

        internal string Profession { get; set; }

        public override string ToString()
        {
            string groups = "";

            foreach (var item in groups)
            {
                if (item == null)
                    continue;

                groups += item + "\n";
            }

            return $"{Id} {Firstname} {Lastname} {Age} \n {Profession} \n Groups :{groups}";
        }
    }
}
