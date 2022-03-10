namespace ClassLibrary2
{
    public class vscode
    {
        public static string GetStundNumber(string student, DateTime date, int group)
        {
            var FullName = student.Split(' ');
            return $"{date.ToString("yyyy")}.{group}.{FullName[0]} {FullName[1].Substring(0, 1)}.{FullName[2].Substring(0, 1)}";
        }
        public void add(int a, int b)
        {
            IEnumerable<int> nums = Enumerable.Range(a, b);
            Console.WriteLine("следовательность чисел: \n");

            foreach (int i in nums)
                Console.Write(i);
            foreach (int k in nums)
                Console.Write(k);

            double average = nums.Average();
            double min = nums.Min();
            Console.WriteLine("\n\nСреднее арифмитическое: " + average);
            Console.WriteLine("\n\nСреднее арифмитическое: " + min);

        }
    }
}