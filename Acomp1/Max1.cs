namespace Acomp1
{
    public class Max1 : IMax
    {
        public int Max(int[] E, int n)
        {
            if (n == 1) return E[0];
            int M = Max(E, n-1);
            if (M > E[n-1]) return M;
            else return E[n-1];
        }
    }
}