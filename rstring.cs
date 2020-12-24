using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandString
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine(randStr(5));
      Console.ReadKey();
    }

    public static string randStr(int len)
    {
      const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()";
      Random random=new Random();
      return new string(Enumerable.Repeat(chars, len).Select(s=>s[random.Next(s.Length)]).ToArray());
    }

  }

}
