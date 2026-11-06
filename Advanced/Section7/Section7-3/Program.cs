namespace Section7_3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var array = new int[] {0, 1, 2};

            // 4回分のループをtry-catchで囲む
            try
            {
                for (var i = 0; i < 4; i++)
                {
                    // array[3]で例外発生
                    Console.WriteLine($"a[{i}]={array[i]}");
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("配列の範囲を超えています。");
            }
            finally
            {
                Console.WriteLine("終了");
            }
        }
    }
}
