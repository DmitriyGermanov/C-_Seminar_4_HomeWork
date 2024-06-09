namespace HomeWork
{
    internal class FindSummOfNum
    {
        public Tuple<int, int, int> FindNumbers(int[] array, int num)
        {
            Dictionary<int, int[]> pairs = new Dictionary<int, int[]>();
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    int sum = array[i] + array[j];
                    if (!pairs.ContainsKey(sum))
                    {
                        pairs.Add(sum, new int[] { i, j });
                    }
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (pairs.ContainsKey(num - array[i]) && pairs[num - array[i]][0] != i && pairs[num - array[i]][1] != i)
                {
                    return new Tuple<int, int, int>(i, pairs[num - array[i]][0], pairs[num - array[i]][1]);
                }
            }
            return null;
        }
    }
}
