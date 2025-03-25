namespace algos
{
    public class Program
    {
        static int[] BubbleSort(int[] a)
        {
            int temp = 0;
            for (int pass = 0; pass <= a.Length - 2; pass++)
            {
                for (int i = 0; i <= a.Length - 2; i++)
                {
                    if (a[i] > a[i + 1])
                    {
                        temp = a[i + 1];
                        a[i + 1] = a[i];
                        a[i] = temp;
                    }
                }
            }
            return a;
        }
        
        
        public static void Main(string[] args)
        {
            string[] s1256 = System.IO.File.ReadAllLines("Share_1_256.txt");
            string[] s2256 = System.IO.File.ReadAllLines("Share_2_256.txt");
            string[] s3256 = System.IO.File.ReadAllLines("Share_3_256.txt"); 
            int[] a = s1256.Select(x => int.Parse(x)).ToArray();
            int[] b = s2256.Select(x => int.Parse(x)).ToArray();
            int[] c = s3256.Select(x => int.Parse(x)).ToArray();
            a = BubbleSort(a);
            b = BubbleSort(b);
            c = BubbleSort(c);
            
        }
    }
}

