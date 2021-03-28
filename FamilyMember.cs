namespace DotNet5AndCSharp9Tests
{
    public record FamilyMemberApproach1
    {
        public string FirstName { get; init; }
        public string MiddleName { get; init; }
        public string LastName { get; init; }

        public FamilyMemberApproach1(string firstName, string middleName, string lastName)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
        }

        public void Deconstruct(out string firstName, out string middleName, out string lastName)
        {
            firstName = FirstName;
            middleName = MiddleName;
            lastName = LastName;
        }

        public override string ToString()
        {
            return $"{FirstName} {MiddleName} {LastName}";
        }
    }

    //Tudo junto, propriedades com init setters, constructor e Deconstruct (tuplas)
    public record FamilyMemberApproach2(string FirstName, string MiddleName, string LastName);

    //Tudo junto, propriedades com init setters, constructor, Deconstruct (tuplas) e implementações internas
    public record FamilyMemberApproach3(string FirstName, string MiddleName, string LastName)
    {
        public override string ToString()
        {
            return $"{FirstName} {MiddleName} {LastName}";
        }
    }
}
