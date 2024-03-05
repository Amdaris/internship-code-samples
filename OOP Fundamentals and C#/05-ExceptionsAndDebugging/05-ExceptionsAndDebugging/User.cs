namespace _05_ExceptionsAndDebugging
{
    public class User
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }

        public Address HomeAddress { get; set; }

        public override string ToString()
        {
            return $"Name: {FullName} Address: {HomeAddress.City}";
        }
    }
}