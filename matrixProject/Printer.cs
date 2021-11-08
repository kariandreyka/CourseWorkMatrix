using System;
using System.IO;

    class Printer
    {
        private StreamWriter _stream;

        public Printer(string path)
        {
            this._stream = new StreamWriter(path);
        }
        
        public void WriteLine(string message)
        {
            Console.WriteLine(message);
            _stream.WriteLine(message);
        }

        public void WriteLine()
        {
            Console.WriteLine();
            _stream.WriteLine();
        }

        public void Write(string message)
        {
            Console.Write(message);
            _stream.Write(message);
        }
        
        public void PrintMatrix(double[,] matrix)
        {
            for (int i = 0; i < matrix.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < matrix.GetUpperBound(1) + 1; j++)
                {
                    this.Write($"{matrix[i, j]} ");
                }
                this.WriteLine();
            }
            this.WriteLine();
        }

        public void Close()
        {
            _stream.Close();
        }
    }