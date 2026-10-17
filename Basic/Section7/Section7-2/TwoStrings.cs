namespace Section7_2
{
    public class TwoStrings
    {
        public string String1 { get; } = "Hello";
        public string String2 { get; } = "World";

        public string GetConnectedString()
        {
            return $"{String1}{String2}";
        }
    }
}