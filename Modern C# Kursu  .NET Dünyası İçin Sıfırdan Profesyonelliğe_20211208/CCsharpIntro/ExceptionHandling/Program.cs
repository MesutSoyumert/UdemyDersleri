using System;

namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Matematik matematik = new Matematik();
            Console.WriteLine(matematik.Bol(20,0));
        }
    }

    class Matematik
    {
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public decimal Bol(int sayi1, int sayi2)
        {
            try
            {
                return (sayi1 / sayi2);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Catch çalıştı. Bir hata oluştu");
                  throw new DivideByZeroException("Sayılar sıfıra bölünemez");
            }

            catch (DllNotFoundException)
            {
                Console.WriteLine("Catch çalıştı. Başka Bir hata oluştu");
                throw new DllNotFoundException("Dll bulunamadı");
            }

            catch (Exception exception)
            {
                Console.WriteLine("Catch çalıştı. Öngörülemeyen hata oluştu, Yöneticinize başvurun");
                Console.WriteLine(exception.InnerException);
                throw;
            }

            finally
            {
                Console.WriteLine("Finally çalıştı");
            }
        }
    }
}
