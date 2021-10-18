namespace JoinDemo
{
    public class Person
    {
        public Person(string lastName, string firstName)
        {
            LastName = lastName;
            FirstName = firstName;
        }

        public string LastName { get; }
        public string FirstName { get; }

        public string FullName => $"{FirstName} {LastName}";
    }
}
