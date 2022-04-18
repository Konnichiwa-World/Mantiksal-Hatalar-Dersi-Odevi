using System;namespace mantıksal_Hatalar{    class Program{static void Main(string[] args){try{
Console.WriteLine(" Yeşilçam replik programına hos geldiniz. Program boyunca sadece gördüğünüz seçeneklere tıklayınız.\n Hadi başlayalım. \n Müfettiş, Mahmut hoca ile sınıfa girer: -Konumuz nedir Mahmut Bey?");
System.Console.WriteLine("1- Yükselme Devri. 2- Orta Çağ Avrupası 3- İstanbul'un fethi.");
Int16 x = Convert.ToInt16(Console.ReadLine());
if(x==1){System.Console.WriteLine(" 'Güzel, müsadenizle ben çocuklara bir iki soru sorayım.' \nMahmut Hoca: 'Buyrun sorun.' \nMüfettiş: 'Sen.' \nŞaban: 'Ben?' \nMüfettiş: 'Adın ne?' ");System.Console.WriteLine("1- Hz. Ebubekir. 2-Hz. Şaban 3- Hz. Mahmut.");Int16 y = Convert.ToInt16(Console.ReadLine());
if(y==1){System.Console.WriteLine(" Müfettiş: Adın ne dedim? ");System.Console.WriteLine("1- Hz. Ebubekir dedim. 2-Hz. Şaban dedim. 3- Hz. Mahmut dedim.");Int16 z = Convert.ToInt16(Console.ReadLine());      
if(z==1){System.Console.WriteLine(" Müfettiş: Adın ne adın??? ");System.Console.WriteLine("1- Haaa Adım. Hz. Ebubekir. 2-Haaa Adım. Hz. Şaban. 3- Haaa Adım. Hz. Mahmut.");Int16 a = Convert.ToInt16(Console.ReadLine());
if(a==2){System.Console.WriteLine(" Müfettiş:  Kaç Yaşındasın?");System.Console.WriteLine("1- 1923 2- 1942 3- 1453");Int16 b = Convert.ToInt16(Console.ReadLine());
if(b==3){System.Console.WriteLine(" Müfettiş bu sefer Güdük Necmiyi kaldırır: Sen Kaç Yaşındasın?");System.Console.WriteLine("1- 1453 2-Anam 3- Kanuni Sultan Süleyman. 4-İmparator Neron.");Int16 c = Convert.ToInt16(Console.ReadLine());
if(c==1){System.Console.WriteLine(" Müfettiş: Romayı kim yaktı? ");System.Console.WriteLine("1- 1453 2-Anam 3- Kanuni Sultan Süleyman. 4-İmparator Neron.");Int16 d = Convert.ToInt16(Console.ReadLine());
if(d==2){System.Console.WriteLine(" Müfettiş: Evladım Senin anan kim??? ");System.Console.WriteLine("1- 1453 2-Anam 3- Kanuni Sultan Süleyman. 4-İmparator Neron.");Int16 e = Convert.ToInt16(Console.ReadLine());
if(e==3){System.Console.WriteLine(" Müfettiş: İlk halife kimdir? "); System.Console.WriteLine("1- 1453 2-Anam 3- Kanuni Sultan Süleyman. 4-İmparator Neron."); Int16 f = Convert.ToInt16(Console.ReadLine());
if(f==4){System.Console.WriteLine(" Müfettiş: Çocuğum karıştırıyorsun. Romayı yakan Hz. Şabandı, ilk halife imparator neron, yani padişah neron \nromada, Hz. Şaban'la beraber, günde 1453 kere kanunen... Aferdersiniz Mahmut Bey, ben biraz karıştırdım\n galiba. ");      
}else {System.Console.WriteLine("Yanlış :) Programı baştan açın.");}
}else {System.Console.WriteLine("Yanlış :) Programı baştan açın.");}
}else {System.Console.WriteLine("Yanlış :) Programı baştan açın.");}          
}else {System.Console.WriteLine("Yanlış :) Programı baştan açın.");}
}else {System.Console.WriteLine("Yanlış :) Programı baştan açın.");}
}else {System.Console.WriteLine("Yanlış :) Programı baştan açın.");}
}else {System.Console.WriteLine("Yanlış :) Programı baştan açın.");}
}else {System.Console.WriteLine("Yanlış :) Programı baştan açın.");}
}else {System.Console.WriteLine("Yanlış :) Programı baştan açın.");}
}
catch(Exception ex){
Console.WriteLine("Ups. Yanlış bir değer türü girildi." + ex.Message);
}}}}                                                                                              
