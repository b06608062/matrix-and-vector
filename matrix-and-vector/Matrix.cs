using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrix_and_vector
{
    internal class Matrix
    {
        static public string Vector2String(double[] vector)
        {
            string result = "";
            foreach (double d in vector)
            {
                result += $"{d:0.00}\t";
            }
            return result;
        }

        static public string Matrix2String(double[,] matrix)
        {
            string result = "";
            int row = matrix.GetLength(0);
            int col = matrix.GetLength(1);
            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < col; c++)
                {
                    result += $"{matrix[r, c]:0.00}\t";
                }
                if (r != row - 1)
                {
                    result += "\r\n";
                }
            }

            return result;
        }

        static public double[,] Multiplication(double[,] a, double[,] b)
        {
            int m = a.GetLength(0);
            int n = a.GetLength(1);
            if (b.GetLength(0) != n)
                throw new Exception("Dimensions are not matching");
            int p = b.GetLength(1);
            double[,] c = new double[m, p];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < p; j++)
                {
                    c[i, j] = 0.0;
                    for (int k = 0; k < n; k++)
                    {
                        c[i, j] += a[i, k] * b[k, j];
                    }
                }
            }

            return c;
        }

        static public double[,] Addition(double[,] a, double[,] b)
        {
            int m = a.GetLength(0);
            int n = a.GetLength(1);
            double[,] c = new double[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    c[i, j] = a[i, j] + b[i, j];
                }
            }

            return c;
        }

        static public double[,] Subtraction(double[,] a, double[,] b)
        {
            double[,] c;
            int m = a.GetLength(0);
            int n = a.GetLength(1);
            c = new double[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    c[i, j] = a[i, j] - b[i, j];
                }
            }

            return c;
        }

        static public double Norm(double[] vector)
        {
            double result = 0.0;
            for (int i = 0; i < 4; i++)
            {
                result += Math.Pow(vector[i], 2);
            }

            result = Math.Pow(result, 0.5);
            return result;
        }

        static public double[] Subtraction(double[] v1, double[] v2)
        {
            double[] v = new double[4];
            for (int i = 0; i < 4; i++)
            {
                v[i] = v1[i] - v2[i];
            }

            return v;
        }

        static public double[] Addition(double[] v1, double[] v2)
        {
            double[] v = new double[4];
            for (int i = 0; i < 4; i++)
            {
                v[i] = v1[i] + v2[i];
            }

            return v;
        }

        static public double InnerProduct(double[] v1, double[] v2)
        {
            double result = 0;
            for (int i = 0; i < 4; i++)
            {
                result += v1[i] * v2[i];
            }

            return result;
        }

        static public double[,] Transpose(double[,] matrix)
        {
            int m = matrix.GetLength(0);
            int n = matrix.GetLength(1);
            double[,] t = new double[n, m];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    t[j, i] = matrix[i, j];
                }
            }

            return t;
        }

        static public double Determinant(double[,] matrix)
        {
            double result = 0.0;
            if (matrix.GetLength(0) == 2)
            {
                return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
            }
            else
            {
                int sign = 1;
                double[,] tmp = new double[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(0) - 1; j++)
                    {
                        for (int k = 0; k < matrix.GetLength(1) - 1; k++)
                        {
                            tmp[j, k] = matrix[j >= i ? j + 1 : j, k + 1];
                        }
                    }

                    result += sign * Determinant(tmp);
                    sign *= -1;
                }
            }

            return result;
        }

    }
}
