// Stardew Valley

string nick = "Gamer Tavşan";

int kabak_tohumu=1;
int buğday=1;

float para = 230.0f;

Console.WriteLine("Selam "+nick+"!");
Console.WriteLine("Bir şey mi almak istiyorsun? Elimdeki Ürünler;");
Console.WriteLine("Kabak Tohumu : 200 Altın " + "/ Buğday: 60 Altın");
if(para>0 && kabak_tohumu>0){
    Console.WriteLine("1 tane Kabak Tohumu Satın Aldın");
    para -=200;
    kabak_tohumu--;
    Console.WriteLine("Mevcut Altın Miktarı: "+ para);
    Console.WriteLine("Kalan Kabak Tohumu Miktarı: "+ kabak_tohumu);
    Console.WriteLine("Buğday almak ister misin Fiyat:60 Altın? Hah... pardon! Kabalık ettim eğer stokta kaldıysa sana bir tane vereyim benden.");
}
if(para==60 || buğday>0){
    buğday--;
    Console.WriteLine("Envantere Buğday Eklendi");
}




