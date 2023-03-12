
using petShopFight.Classes;



var cachorro = new Cachorro();
double distPercCac = cachorro.Andar(30);

var gato = new Gato();
double distaPercGat = gato.Andar(60);

Console.WriteLine("O cachorro andou: " + distPercCac + " metros.");

Console.WriteLine("O gato andou: " + distaPercGat + " metros.");

gato.Life = Convert.ToInt32(cachorro.Morder(gato.Life));
 