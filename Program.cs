namespace Task1;

class Program
{
    static void Main(string[] args)
    {
        int[] x1 = {10,20,30,40,50};
        int[] x2 = {6,7,8,9,10};

        int y = x1.Length + x2.Length;

        int[] x3 = new int[y];

        for (int i = 0; i < x1.Length; i++) {
            x3[i] = x1[i];
        }

        for (int i = x1.Length; i < y; i++) {
            x3[i] = x2[i-x1.Length];
        }
        
        foreach (int i in x3) {
            Console.WriteLine(i);
        }
    }
}
