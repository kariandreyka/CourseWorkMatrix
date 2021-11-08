namespace Курсовая {
  internal class Program
  {
    public static void Main(string[] args)
    {
      Matrix m1 = new Matrix();
      Printer printer = new Printer("курсовая.txt");
      printer.WriteLine("1 матрица");
      printer.PrintMatrix(m1.GetMatrix);

      Matrix m2 = new Matrix(m1.GetMatrix);
      printer.WriteLine("2 матрица");
      printer.PrintMatrix(m2.GetMatrix);
      printer.WriteLine($"Cумма отрицательных значений: {m2.GetSumOfNegativeNumbers()}");
      printer.WriteLine($"Минимальный элемент чётных столбцов массива: {m2.GetMinNumberFromEvenColumns()}");
      printer.WriteLine($"Результат расчёта математического выражения: {m2.CalculateFormula()}");
      printer.Close();
    }
  }
}