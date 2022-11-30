using System;
using System.Linq;
public class quiz
{
    public static void Main()
    {
                // 1
            var list = new List<string> { "a", "b", "a", "c", "a", "b" };
            var q = list.GroupBy(x => x)
                        .Select(g => new { Value = g.Key, Count = g.Count() })
                        .OrderByDescending(x => x.Count);

            foreach (var x in q)
            {
                Console.WriteLine("Value: " + x.Value + " Count: " + x.Count);
    }

            // 2
            string str = "abcdef";
            char ch = 'e';

            int e = str.Where(x => (x == ch)).Count();
            Console.WriteLine(e);


            //3
            String s = Console.ReadLine();
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsUpper(s[i])) count++;
            }

        //4

         static IEnumerable<T> GetRange<T>(this IList<T> list, int startIndex, int endIndex)
        {
            for (int i = startIndex; i <= endIndex; i++)
            {
                yield return list[i];
            }
        }


        foreach (var item in list.GetRange(0, 5))
        {
            Console.WriteLine(item);
        }


    }
        //5

        private static char[] FrequentChar(string str)
        {
            Dictionary<char, int> chars = new Dictionary<char, int>();

            foreach (char c in str)
            {
                if (chars.ContainsKey(c)) chars[c]++;
                else chars.Add(c, 1);
            }

            int max = chars.Values.Max();
            return chars.Where(b => b.Value == max).Select(b => b.Key).ToArray();

        }


}
