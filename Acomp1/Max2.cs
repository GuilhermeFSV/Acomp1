namespace Acomp1
{
    public class Max2 : IMax
    {
        public int Max(int[] E, int n)
        {
            int M = E[0];
            for (int i = 1; i < n; i++)
            {
                if (E[i] > M)
                    M = E[i];
            }
            return M;
        }
    }
}
