// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hacmini hesaplamak istediğiniz diktörtgenler prizmasının kenarlarını sizden istenilen şekilde giriniz");
Console.WriteLine("Tabanın bir kenarının uzunluğunu giriniz");
int tkenar1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Tabanın diğer kenarının uzunluğunu giriniz");
int tkenar2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Yüksekliği giriniz");
int yukseklik = Convert.ToInt32(Console.ReadLine());
int hacim = (tkenar1 * tkenar2) * yukseklik;
Console.WriteLine("Girdiğiniz dikdörtgenler prizmasının hacmi:" + hacim);
Console.ReadKey();