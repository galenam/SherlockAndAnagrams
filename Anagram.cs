namespace SherlockAndAnagrams;
public static class Anagram
{
    public static int SherlockAndAnagrams(string s)
    {
        var storageString = new Dictionary<string, int>();
        var count = 0;
        for (int i = 0; i < s.Length; i++)
        {
            for (int j = 1; j < s.Length - i + 1; j++)
            {
                var keyArbitrary = s.Substring(i, j);
                var keySorted = string.Concat(keyArbitrary.OrderBy(c => c));
                if (!storageString.ContainsKey(keySorted))
                {
                    storageString.Add(keySorted, 1);
                    continue;
                }
                storageString[keySorted] = storageString[keySorted] + 1;
            }
        }

        foreach (var item in storageString)
        {
            if (item.Value > 1)
            {
                count += item.Value * (item.Value - 1) / 2;
            }
        }

        return count;
    }
}
