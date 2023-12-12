using System;
using AutoIt;

namespace AutoItLoginExample
{
    class Program
    {
        //Nuget ile kütüphane kurulmalı
        // AutoItX3.Assembly.dll dosyansı referans eklenmeli
        /// <summary>
        /// https://www.autoitscript.com/site/autoit/downloads/
        /// </summary>

        static void Main()
        {

            AutoItX.Sleep(1000);
            int result = AutoItX.Run("C:\\Program Files (x86)\\Microsoft\\Edge\\Application\\msedge.exe", "", AutoItX.SW_MAXIMIZE);
            

            AutoItX.Sleep(1000);
            AutoItX.WinSetState(AutoItX.WinGetTitle().ToString(), "", AutoItX.SW_MAXIMIZE);


            //AutoItX.Send("https://kariyer.baykartech.com/tr/hesaplar/login/?next=/tr/dashboard/");
            AutoItX.Send("https://www.trendyol.com/giris?cb=/sepet"); 

            AutoItX.Send("{ENTER}");

            AutoItX.Sleep(1000);

            AutoItX.MouseMove(0, 400,1);
            AutoItX.MouseMove(850, 400);
            AutoItX.MouseClick();

            AutoItX.Send("deneme@gmail.com");
            
            AutoItX.Send("{TAB}");
            AutoItX.Send("deneme123");
            

            AutoItX.Send("{TAB}");
            //AutoItX.Send("{TAB}");
            AutoItX.Send("{ENTER}");

            Console.WriteLine("Giriş başarılı!");


            AutoItX.ClipPut("https://www.msn.com/tr-tr/havadurumu/havadurumutahmini/in-Esenyurt,%C4%B0stanbul?loc=eyJsIjoiRXNlbnl1cnQiLCJyIjoixLBzdGFuYnVsIiwiYyI6IlTDvHJraXllIiwiaSI6IlRSIiwiZyI6InRyLXRyIiwieCI6IjI4LjY0MTk3OTIxNzUyOTI5NyIsInkiOiI0MS4wOTc0MTU5MjQwNzIyNjYifQ%3D%3D&weadegreetype=C&ocid=msedgntp&cvid=dd84efd1a6a34f6e8a97c9a4eadd4ea0");


            AutoItX.Sleep(1000);
            AutoItX.Send("^t");;
            AutoItX.Send("^v");
            AutoItX.Send("{ENTER}");

            AutoItX.Sleep(1500);
            AutoItX.MouseWheel("down", 5);
            string pencere = AutoItX.WinGetTitle().ToString();

            Console.WriteLine("Hava Durumu Görüntülendi");
            Console.WriteLine("20 Sn Sonra Kapanacak");
            AutoItX.Sleep(20000);

            

            AutoItX.WinClose(pencere);
            Console.WriteLine(result +" -> " + AutoItX.WinGetTitle());

            Console.WriteLine("İşlem sonlandırıldı");

            Console.ReadLine();

            
        }

        static void Ozllikler()
        {
            AutoItX.Run("notepad.exe", "", AutoItX.SW_SHOW); // Uygulamayı çalıştır

            AutoItX.WinWaitActive("Adsız");//Aktif olana kadar bekle (pencere adı)
             
            AutoItX.Send("I'm in notepad");// imlecin olduğu yere yazdırır

            AutoItX.Send("{TAB}");

            AutoItX.Send("{ENTER}");

            AutoItX.ControlSetText("Adsız", "", "Edit1", "Hello, AutoItX3!");//Set Txt

            AutoItX.MouseMove(850, 400);

            AutoItX.MouseClick("left", 200, 300); 

            AutoItX.WinClose("Adsız");

            string windowText = AutoItX.WinGetText("Adsız");

            AutoItX.ControlClick("Adsız", "", "Button1");// butona tıklama

            AutoItX.Sleep(1000); // 1000 milisaniye (1 saniye) bekler

            AutoItX.ControlFocus("Adsız", "", "Edit1");// imleci taşıma

            AutoItX.WinSetState("Adsız", "", AutoItX.SW_MINIMIZE);//Belirli bir pencerenin durumunu değiştirir (minimize, maximize, restore vb.).

            AutoItX.WinActivate("Adsız");//Pencereyi aktive et (pencere adı)

            AutoItX.WinWaitClose("Adsız");

            AutoItX.MouseWheel("down", 3); //srcoll down

            //int[] pixelCoord = AutoItX.PixelSearch(0, 0, 800, 600, 0xFF0000);

            AutoItX.ClipPut("Hello, Clipboard!"); // panoya koypala
            string clipboardText = AutoItX.ClipGet();  // Panodan veri al

            //AutoItX.ProcessWait("notepad.exe");

            AutoItX.ProcessClose("notepad.exe");

            int windowExists = AutoItX.WinExists("Adsız");//Belirli bir pencerenin var olup olmadığını kontrol eder.

            var windowPosition = AutoItX.WinGetPos("Adsız");//Belirli bir pencerenin pozisyonunu ve boyutunu alır.

            AutoItX.WinSetTitle("Adsız", "", "Yeni Başlık");

            AutoItX.WinSetTrans("Adsız", "", 150);//Belirli bir pencerenin şeffaflığını ayarlar.

            AutoItX.MouseClickDrag("left", 100, 200, 300, 400);// Sürükle-Bırak işlemi yapar

            //AutoItX.ControlCommand("Adsız" ,"", "Edit1", "EditPaste"); //Belirli bir penceredeki belirli bir kontrol elemanı üzerinde özel bir komut çalıştırır.

            AutoItX.ProcessWaitClose("notepad.exe",timeout:1000);//Belirli bir sürecin kapatılmasını bekler.

            //AutoItX.DriveMapAdd("Z:", "\\server\share");//Bir ağ sürücüsünü eşler veya eşleme işlemini geri alır.
            //AutoItX.DriveMapDel("Z:");

            //int checksum = AutoItX3.PixelChecksum(100, 100, 200, 200); //Ekran üzerinde belirli bir alanın piksel değerlerinin toplamını alır.

            int processExists = AutoItX.ProcessExists("notepad.exe");//Belirli bir sürecin var olup olmadığını kontrol eder.

            string windowTitle = AutoItX.WinGetTitle();// Belirli bir pencerenin başlığını alır.

            AutoItX.WinMinimizeAll(); //Tüm pencereleri minimize eder veya minimize edilen pencereleri geri getirir.
            AutoItX.WinMinimizeAllUndo();

            AutoItX.WinSetOnTop("Adsız", "", AutoItX.SW_RESTORE); //Bir pencereyi diğer pencerelerin üzerine taşır veya altına gönderir.

            string classList = AutoItX.WinGetClassList("Adsız");//Belirli bir pencerenin sınıf listesini alır.

            AutoItX.ControlEnable("Adsız", "", "Edit1");//Belirli bir penceredeki belirli bir kontrol elemanını etkinleştirir veya devre dışı bırakır
            AutoItX.ControlDisable("Adsız", "", "Edit1");

            AutoItX.ControlHide("Adsız", "", "Edit1");//Belirli bir penceredeki belirli bir kontrol elemanını gizler veya gösterir.
            AutoItX.ControlShow("Adsız", "", "Edit1");

            AutoItX.ControlFocus("Adsız", "", "Edit1");//Belirli bir penceredeki bir kontrol elemanına odaklanır veya odaklanmış kontrolün adını alır.
            string focusedControl = AutoItX.ControlGetFocus("Adsız");

            var clientSize = AutoItX.WinGetClientSize("Adsız");//Belirli bir pencerenin içerik alanının genişliğini ve yüksekliğini alır.

            int windowState = AutoItX.WinGetState("Adsız");//Belirli bir pencerenin durumunu alır (normal, minimize, maximize).

            var processName = AutoItX.WinGetProcess("Adsız"); //Belirli bir pencerenin sürecin adını veya PID'sini alır.
            var processPID = AutoItX.WinGetProcess("Adsız", "");

            AutoItX.WinKill("Adsız");//Belirli bir pencereyi kapatır.

            IntPtr windowHandle = AutoItX.WinGetHandle("Adsız");//Belirli bir pencerenin tanımlayıcı (handle) değerini alır.

            AutoItX.WinMove("Adsız", "", 100, 100);//Belirli bir pencerenin pozisyonunu değiştirir.

            //AutoItX.ControlTreeView("Untitled - Notepad", "", "SysTreeView321", "Expand", "#1|#2");//Bir TreeView kontrolü üzerinde işlemler yapar.

            // AutoItX.ControlListView("Adsız", "", "SysListView321", "SelectAll");//Belirli bir ListView kontrolü üzerinde işlemler yapar.

            //AutoItX.ControlCommand("Adsız", "", "Edit1", "EditPaste");//Belirli bir penceredeki belirli bir kontrol elemanı üzerinde özel bir komut çalıştırır.

            string controlText = AutoItX.ControlGetText("Untitled - Notepad", "", "Edit1");//Belirli bir kontrol elemanının metin içeriğini alır.

            var mousePosition = AutoItX.MouseGetPos(); //Fare imlecinin ekran koordinatlarını alır.

            int pixelColor = AutoItX.PixelGetColor(500, 500); //Belirli bir ekran koordinatındaki pikselin rengini alır.


        }
    }
}
