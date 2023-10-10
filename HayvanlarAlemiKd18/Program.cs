using HayvanlarAlemiKd18;

Kedi ke1 = new Kedi();
ke1.Beslen();
ke1.SesCikar();
ke1.HareketEt();

Kopek ko1 = new Kopek();
ko1.KulaklariniDik();
ko1.SesCikar();

// POLYMORPHISM: ÇOK BİÇİMLİLİK YA DA ÇOK GÖRÜNÜMLÜLÜK
// HER KÖPEK AYNI ZAMANDA BİR HAYVANDIR
Hayvan h1 = ko1;
h1.SesCikar(); // Köpeğin Hayvan görünümünde sesini çıkarttık

// SORU: ne yazar?
Console.WriteLine(ke1);
Console.WriteLine(ke1.ToString());

// SORU: Ben kedi sınıfına ToString diye bir metot koyduğumu hatırlamıyorum. Bu metot nereden geldi?

// CEVAP: Her sınıf miras alacağı sınıf belirtilmezse default olarak object sınıfından miras alır.
// Soruyu cevaplayacak olursak Kedi, Hayvan'dan miras almıştır. Hayvan da object sınıfından miras almıştır.
// object sınıfı da public ve virtual olarak tanımlı ToString metoduna sahiptir.


// SORU: Kedi Köpek farketmeksizin herhangi bir hayvanı Console.WriteLine ile yazdırdığımda
// o hayvanın türü ekrana yazılsın, bunu nasıl sağlarım?

Console.ReadKey();