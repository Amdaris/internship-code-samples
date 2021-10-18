namespace JoinDemo
{
    public class Pet
    {
        public Pet(string name, string type, string ownerName)
        {
            Name = name;
            Type = type;
            OwnerName = ownerName;
        }

        public string Name { get; }
        public string Type { get; }
        public string OwnerName { get; }
    }
}
