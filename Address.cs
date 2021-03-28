namespace DotNet5AndCSharp9Tests
{
    public record Address(string Street, string Number, string City, string State, string Country)
    {
        public override string ToString()
        {
            return $"{Street}, {Number} ({City}-{State}-{Country})";
        }
    }
}
