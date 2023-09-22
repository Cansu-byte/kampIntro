

string kategorietiketi = "kategoriler";
int ogrenciSayisi = 32000;
double faizOrani = 1.45;
bool sistemeGirisYapmisMi = true;
double dolarDun = 7.55;
double dolarBugun = 7.45;





if (dolarDun > dolarBugun)
{
    Console.WriteLine("Azalış butonu");
}
else if (dolarDun < dolarBugun)
{
    Console.WriteLine("Artış butonu");
}
else
{
    Console.WriteLine("Degismedi");
}



if (sistemeGirisYapmisMi == true)
{
    Console.WriteLine("Kullanıcı ayarlari butonu ");

}
else
{
    Console.WriteLine("Giris yap butonu");
}
