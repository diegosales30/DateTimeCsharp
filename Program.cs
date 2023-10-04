using System;
using System.Globalization;

namespace DateTimeCsharp
{
  class Program
  {
    static void Main(string[] args)
    {
      //com construtores
      DateTime d1 = new DateTime(2000, 8, 15);
      DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58);
      DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58, 275);

      //Demo - Now, UtcNow, Today
      DateTime d4 = DateTime.Now;
      DateTime d5 = DateTime.UtcNow;
      DateTime d6 = DateTime.Today;

      //com parse ao receber do banco de dados
      DateTime d7 = DateTime.Parse("2000-08-15");
      DateTime d8 = DateTime.Parse("2000-08-15 13:05:58");
      DateTime d9 = DateTime.Parse("15/08/2000");
      DateTime d10 = DateTime.Parse("15/08/2000 13:05:58");

      //criando proria formatação
      DateTime d11 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
      DateTime d12 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss",CultureInfo.InvariantCulture);

      
    }
  }
}
