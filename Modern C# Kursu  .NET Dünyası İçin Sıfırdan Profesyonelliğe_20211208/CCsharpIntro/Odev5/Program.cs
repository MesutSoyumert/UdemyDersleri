// İki sayı birbirinin kendisi hariç bölenleri toplamına
// eşitse bu sayılara arkadaş sayılar denir.

int sayi1 = 200;
int sayi2 = 284;
int sayi1BolenlerToplami = 0;
int sayi2BolenlerToplami = 0;
int i = 0;

for (i = 1; i < sayi1; i++)
{
    if (sayi1 % i == 0)
    {
        sayi1BolenlerToplami = sayi1BolenlerToplami + i;
    }
}
for (i = 1; i < sayi2; i++)
{
    if (sayi2 % i == 0)
    {
        sayi2BolenlerToplami = sayi2BolenlerToplami + i;
    }
}
if (sayi1 == sayi2BolenlerToplami && sayi2 == sayi1BolenlerToplami)
{
    Console.WriteLine("Girilen sayılar Arkadaş sayıdır");

}
else
{
    Console.WriteLine("Sayılar arkadaş sayı değildir");
}