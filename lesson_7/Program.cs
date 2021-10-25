class Program
{
    static void Main()
    {
        Test();
        Console.ReadLine();
    }
    public static void Test()
    {
        Console.WriteLine("Введите высоту поля от 2 до 20: ");
        int N = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите ширину поля от 2 до 20: ");
        int M = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        int[,] A = new int[N, M];
        int i, j;
        for (j = 0; j < M; j++)
            A[0, j] = 1; // Первая строка заполнена единицами
        for (i = 1; i < N; i++)
        {
            A[i, 0] = 1;
            for (j = 1; j < M; j++)
                A[i, j] = A[i, j - 1] + A[i - 1, j];
        }

        WriteBorad(N, M, A);

        Console.WriteLine($"\nМаксимальное количество маршрутов из левого верхнего угла в правый нижний:" +
            $"{A[N - 1, M - 1]}");
    }
    public static void WriteBorad(int n, int m, int[,] a)
    {
        int i, j;
        for (i = 0; i < n; i++)
        {
            for (j = 0; j < m; j++)
                Console.Write($"{a[i, j]}\t");
            Console.Write("\r\n");
        }
    }
}
