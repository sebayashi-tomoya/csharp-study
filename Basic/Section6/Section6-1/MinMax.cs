namespace Section6_1
{
    class MinMax
    {
        public int Max(int n1, int n2, int n3)
        {
            return Math.Max(n1, Math.Max(n2, n3));
        }

        public int Min(int n1, int n2, int n3)
        {
            return Math.Min(n1, Math.Min(n2, n3));
        }
    }
}
