using System;
using System.Collections.Generic;

namespace Module3HW4
{
    public class Program
    {
        private static Func<int, int, int> _rezSumHandler;
        public static void Main(string[] args)
        {
            var rez = 0;
            TryCatch(() =>
            {
                rez = Zamikan();
            });
            Console.WriteLine(rez);
            var h = new HWLINQ();
            h.Linq();
        }

        public static void TryCatch(Action action)
        {
            try
            {
                action();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        private static int Zamikan()
        {
            _rezSumHandler += (x, y) => x + y;
            _rezSumHandler += (x, y) => x + y;
            var rezultat = 0;
            var result = _rezSumHandler.GetInvocationList();
            foreach (var item in result)
            {
                var resultInMethod = item.DynamicInvoke(5, 9);
                rezultat += (int)resultInMethod;
            }

            return rezultat;
        }
    }
}