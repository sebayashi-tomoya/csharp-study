namespace Section8_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var loopCount = 100;

            for (var a = 1; a <= loopCount; a++)
            {
                for (var b = 1; b <= loopCount; b++)
                {
                    for (var c = 1; c <= loopCount; c++)
                    {
                        if ((a * a) + (b * b) == (c * c))
                        {
                            Console.WriteLine($"{ToSquaredStr(a)} + {ToSquaredStr(b)} = {ToSquaredStr(c)}");
                        }
                    }
                }
            }
        }

        public static string ToSquaredStr(int num)
        {
            return $"{num}^2";
        }
    }
}
