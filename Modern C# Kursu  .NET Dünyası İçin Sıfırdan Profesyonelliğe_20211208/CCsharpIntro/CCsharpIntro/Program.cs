// See https://aka.ms/new-console-template for more information

double aboneSayisi = 34.5;
int yas = 61;

string duyuru = "Duyurumuz var";

bool deger = true;

double piyasaDun = 115000.6;
double piyasaBugun = 115000.6;
bool sonuc = piyasaBugun > piyasaDun;

string mesajArtis = "Artış oku";
string mesajAzalis = "Azalış oku";
string mesajAyni = "Sabit oku";

if (piyasaBugun > piyasaDun)
{
    Console.WriteLine(mesajArtis);
}
else if (piyasaBugun == piyasaDun)
{
    Console.WriteLine(mesajAyni);
}
else
{
    Console.WriteLine(mesajAzalis);
}


