namespace Acomp1
{
    public class Max3 : IMax
    {
        public int Max(int[] E, int n)
        {
            int i, j;
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    if (E[i] < E[j])
                        break;
                }
                if (j == n)
                    break;
            }
            return E[i];
        }
    }
}
