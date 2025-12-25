using System;

namespace BridgeLabzTraining.methods.level_03
{
    internal class Matrix
    {
        
        public static double[,] Create(int r, int c)
        {
            double[,] m = new double[r, c];
            Random rnd = new Random();

            for (int i = 0; i < r; i++)
                for (int j = 0; j < c; j++)
                    m[i, j] = rnd.Next(1, 10);

            return m;
        }

        
        public static double[,] Add(double[,] A, double[,] B)
        {
            int r = A.GetLength(0);
            int c = A.GetLength(1);
            double[,] C = new double[r, c];

            for (int i = 0; i < r; i++)
                for (int j = 0; j < c; j++)
                    C[i, j] = A[i, j] + B[i, j];

            return C;
        }

        
        public static double[,] Sub(double[,] A, double[,] B)
        {
            int r = A.GetLength(0);
            int c = A.GetLength(1);
            double[,] C = new double[r, c];

            for (int i = 0; i < r; i++)
                for (int j = 0; j < c; j++)
                    C[i, j] = A[i, j] - B[i, j];

            return C;
        }

        
        public static double[,] Mul(double[,] A, double[,] B)
        {
            int r1 = A.GetLength(0);
            int c1 = A.GetLength(1);
            int c2 = B.GetLength(1);

            double[,] C = new double[r1, c2];

            for (int i = 0; i < r1; i++)
                for (int j = 0; j < c2; j++)
                    for (int k = 0; k < c1; k++)
                        C[i, j] += A[i, k] * B[k, j];

            return C;
        }

        public static double[,] Transpose(double[,] A)
        {
            int r = A.GetLength(0);
            int c = A.GetLength(1);
            double[,] T = new double[c, r];

            for (int i = 0; i < r; i++)
                for (int j = 0; j < c; j++)
                    T[j, i] = A[i, j];

            return T;
        }

        public static double Determinant2(double[,] m)
        {
            return (m[0, 0] * m[1, 1]) - (m[0, 1] * m[1, 0]);
        }

        
        public static double Determinant3(double[,] m)
        {
            return
                m[0, 0] * (m[1, 1] * m[2, 2] - m[1, 2] * m[2, 1]) - m[0, 1] * (m[1, 0] * m[2, 2] - m[1, 2] * m[2, 0]) + m[0, 2] * (m[1, 0] * m[2, 1] - m[1, 1] * m[2, 0]);
        }

        
        public static double[,] Inverse2(double[,] m)
        {
            double det = Determinant2(m);
            if (det == 0) return null;

            double[,] inverse = new double[2, 2];

            inverse[0, 0] = m[1, 1] / det;
            inverse[0, 1] = -m[0, 1] / det;
            inverse[1, 0] = -m[1, 0] / det;
            inverse[1, 1] = m[0, 0] / det;

            return inverse;
        }

        
        public static double[,] Inverse3(double[,] m)
        {
            double det = Determinant3(m);
            if (det == 0) return null;

            double[,] inv = new double[3, 3];

            inv[0, 0] = (m[1, 1] * m[2, 2] - m[1, 2] * m[2, 1]) / det;
            inv[0, 1] = (m[0, 2] * m[2, 1] - m[0, 1] * m[2, 2]) / det;
            inv[0, 2] = (m[0, 1] * m[1, 2] - m[0, 2] * m[1, 1]) / det;

            inv[1, 0] = (m[1, 2] * m[2, 0] - m[1, 0] * m[2, 2]) / det;
            inv[1, 1] = (m[0, 0] * m[2, 2] - m[0, 2] * m[2, 0]) / det;
            inv[1, 2] = (m[0, 2] * m[1, 0] - m[0, 0] * m[1, 2]) / det;

            inv[2, 0] = (m[1, 0] * m[2, 1] - m[1, 1] * m[2, 0]) / det;
            inv[2, 1] = (m[0, 1] * m[2, 0] - m[0, 0] * m[2, 1]) / det;
            inv[2, 2] = (m[0, 0] * m[1, 1] - m[0, 1] * m[1, 0]) / det;

            return inv;
        }

        
        public static void Display(double[,] m)
        {
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    Console.Write($"{m[i, j],6}");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        
        public static void Caller()
        {

            double[,] A = Create(3, 3);
            double[,] B = Create(3, 3);

            Console.WriteLine("Matrix A:");
            Display(A);

            Console.WriteLine("Matrix B:");
            Display(B);

            Console.WriteLine("A + B:");
            Display(Add(A, B));

            Console.WriteLine("A - B:");
            Display(Sub(A, B));

            Console.WriteLine("A * B:");
            Display(Mul(A, B));

            Console.WriteLine("Transpose of A:");
            Display(Transpose(A));

            Console.WriteLine($"Determinant of A: {Determinant3(A)}");

            Console.WriteLine("Inverse A:");
            double[,] inv = Inverse3(A);

            if (inv != null)
                Display(inv);
            else
                Console.WriteLine("Not exist");

        }
    }
}
