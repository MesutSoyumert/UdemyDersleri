int[] dizi = new int[3];
dizi[0] = 27;
dizi[1] = 19;
dizi[2] = 15;

int enBuyukSayi = 0;
int enKucukSayi = 0;
int ortancaSayi = 0;

if (dizi[0] < dizi[1] && dizi[0] < dizi[2])
{ enKucukSayi = dizi[0]; }
else
if (dizi[1] < dizi[0] && dizi[1] < dizi[2])
{ enKucukSayi = dizi[1]; }
else
{
    if (dizi[2] < dizi[0] && dizi[2] < dizi[1])
    { enKucukSayi = dizi[2]; }
}


Console.WriteLine("En Küçük Sayı = ");
Console.WriteLine(enKucukSayi);

if (dizi[0] > dizi[1] && dizi[0] < dizi[2]) { ortancaSayi = dizi[0]; }
else if (dizi[0] > dizi[2] && dizi[0] < dizi[1]) { ortancaSayi = dizi[0]; }
    else if (dizi[1] > dizi[0] && dizi[1] < dizi[2]) { ortancaSayi = dizi[1]; }
        else if (dizi[1] > dizi[2] && dizi[1] < dizi[0]) { ortancaSayi = dizi[1]; }
            else if (dizi[2] > dizi[0] && dizi[2] < dizi[1]) { ortancaSayi = dizi[2]; }
                else if (dizi[2] > dizi[1] && dizi[2] < dizi[0]) { ortancaSayi = dizi[2]; }

Console.WriteLine("Ortanca Sayı = ");
Console.WriteLine(ortancaSayi);

if (dizi[0] > dizi[1] && dizi[0] >= dizi[2])
{ enBuyukSayi = dizi[0]; }
else
if (dizi[1] > dizi[0] && dizi[1] > dizi[2])
{ enBuyukSayi = dizi[1]; }
else
{
    if (dizi[2] > dizi[0] && dizi[2] > dizi[1])
    { enBuyukSayi = dizi[2]; }
}
Console.WriteLine("En Büyük Sayı = ");
Console.WriteLine(enBuyukSayi);