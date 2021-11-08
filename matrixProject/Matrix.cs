using System;

class Matrix
    {
        private const int N = 5;
        private double[,] _matrix;

        public double[,] GetMatrix => _matrix;

        public Matrix()
        {
            SetMatrix();
        }

        public Matrix(double[,] initialMatrix)
        {
            _matrix = powMatrix(initialMatrix, 2);
        }

        private double[,] powMatrix(double[,] inputMatrix, int power)
        {
            var resultMatrix = new double[N, N]; 
            for (var i = 0; i < N; i++)
            {
                for (var j = 0; j < N; j++)
                {
                    resultMatrix[i, j] = Math.Pow(inputMatrix[i, j], power);
                }
            }

            return resultMatrix;
        }
        private void SetMatrix()
        {
            _matrix = new double[N, N];
            Console.WriteLine("Введите матрицу 5х5");
            for (int i = 0; i < N; i++)
            {
                string[] line = Console.ReadLine()?.Split(new [] {' '}, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < N; j++)
                {
                    _matrix[i, j] = int.Parse(line[j]);
                }
            }
            Console.WriteLine();
        }
        
        public double GetMinNumberFromEvenColumns()
        {
            var minNumber = _matrix[1, 0];
            for (var i = 1; i < N; i = i + 2)
            {
                for (var j = 0; j < N; j++)
                {
                    if (_matrix[i, j] < minNumber)
                    {
                        minNumber = _matrix[i, j];
                    }
                }
            }

            return minNumber;
        }

        private double GetSumOfElements()
        {
            double sum = 0;
            foreach (var d in _matrix)
            {
                sum += d;
            }

            return sum;
        }

        public double CalculateFormula()
        {
            var arg = GetSumOfElements();
            return Math.Cos(arg) + Math.Sin(arg) + Math.Cos(3 * arg) + Math.Sin(3 * arg);
        }

        public double GetSumOfNegativeNumbers()
        {
            double sum = 0;
            foreach (var d in _matrix)
            {
                if (d < 0)
                {
                    sum += d;
                }
            }

            return sum;
        }
    }