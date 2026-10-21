namespace Section2_4
{
    public class Counter
    {
        private static int totalCount;

        public static int TotalCount
        {
            get { return totalCount; }
        }

        public void Increment()
        {
            totalCount++;
        }
    }
}
