namespace Exercicio_Aula81
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vect = Console.ReadLine().Split(' ');
            int m = int.Parse(vect[0]);
            int n = int.Parse(vect[1]);

            int[,] mat = new int[m, n];

            for(int i = 0; i < m; i++)
            {
                string[] values = Console.ReadLine().Split(' ');

                for(int j = 0; j < n; j++)
                {
                    mat[i,j] = int.Parse(values[j]);
                }
            }

            int pos = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < m; i++)
            {
                

                for (int j = 0; j < n; j++)
                {
                    if (mat[i,j] == pos)
                    {
                        Console.WriteLine("Position " + i + "," + j + ":");

                        if (j > 0)
                        {
                            int a = j;
                            int value = mat[i, a - 1];
                            Console.WriteLine("Left: " + value);
                        }
                        if (j < mat.GetLength(1)-1)
                        {
                            int value = mat[i, j+1];
                            Console.WriteLine("Right: " + value);
                        }

                        if(i <= mat.GetLength(0) -1)
                        {
                            int value = mat[i+1, j];  
                            Console.WriteLine("Down: " + value);
                        }

                        if (i > 0)
                        {
                            int value = mat[i - 1, j];
                            Console.WriteLine("Up: " + value);
                        }
                       
                        
                    }
                }
            }
                
        }
    }
}