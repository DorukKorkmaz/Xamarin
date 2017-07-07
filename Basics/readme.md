# Xamarin Basics

Bu projemizde Xamarin’in temel özelliklerinden Kontrolleri, Tasarım Yapılarını ve Sayfa Yapılarını inceleyeceğiz.

## İçindekiler

1. Kontrol Örnekleri
1. Tasarım Yapıları
1. Sayfa Yapıları

## Kontrol Örnekleri

Bu sayfada Xamarin’in kontrolleri(Ingilizce Views olarak geçiyor) nasıl kullanıldığını inceleyeceğiz. Xamarin’e başlayanların en büyük problemlerinden biri hangi kontrolün nerede kullanılacağını bilememektir.

Ben [MyViewsPage](https://github.com/DorukKorkmaz/Xamarin/blob/master/Basics/Basics/MyViewsPage.cs) sayfasında bütün kontrolleri topladım ve hepsiyle ilgili ufak birer örnek verdim. O sayfaya göz atmanızı öneririm.

<p align="center">
<img src="images.fld/image003.png" alt="" height=350>
<img src="images.fld/image001.png" alt="" height=350>
</p>

ListView üzerinde ayrıca durduğum [ListViewExample](https://github.com/DorukKorkmaz/Xamarin/tree/master/ListViewExample) projesini de inceleyebilirsiniz.

Bu konu hakkında daha fazla bilgiye ulaşmak istiyorsanız [Xamarin dökümanını](https://developer.xamarin.com/guides/xamarin-forms/user-interface/controls/views/) inceleyebilirsiniz.

Kontrolleri 5 grup altında inceleyebiliriz:

### Temel

* **Label** – Sadece okunabilir yazı görüntüleyen kontrol.

<p align="center">
<img src="images.fld/image005.png" alt="" height=200>
</p>

* **Image** – İçerisinde resim barındıran kontrol.

<p align="center">
<img src="images.fld/image007.png" alt="" height=200>
</p>

* **Button** – Touch eventleri karşılık veren control

<p align="center">
<img src="images.fld/image009.png" alt="" height=200>
</p>

* **BoxView** – Tek renk dikdörtgen çizmeyi sağlayan control. 

<p align="center">
<img src="images.fld/image011.png" alt="" height=200>
</p>
	
### Liste
* **ListView** – dikey bir şekilde data görüntüsü sağlar

<p align="center">
<img src="images.fld/image013.png" alt="" height=200>
</p>
	
### Text Entry
Text Enry çeşitleri kullanıcıdan keyboard ile komut almaya yarar.
* Entry – Tek satır

<p align="center">
<img src="images.fld/image015.png" alt="" height=200>
</p>

* **Editor** – Çoklu satır desteği sağlar.

<p align="center">
<img src="images.fld/image017.png" alt="" height=200>
</p>

### Selection
Selection çeşitleri kullanıcının seçenekler arasından birini seçmesine yarar.
* **Picker** – Verilen listeden bir tanesi seçmeyi sağlan kontrol

<p align="center">
<img src="images.fld/image019.png" alt="" height=200>
</p>

* **DatePicker** – Tarih seçmenizi sağlayan control

<p align="center">
<img src="images.fld/image021.png" alt="" height=200>
</p>

* **TimePicker** – Saat seçmenizi sağlayan control

<p align="center">
<img src="images.fld/image023.png" alt="" height=200>
</p>

* Stepper – Değeri verilen aralık içerisinde belli miktarda arttırıp azaltmayı sağlayan kontrol

<p align="center">
<img src="images.fld/image025.png" alt="" height=200>
</p>

* **Slider**

<p align="center">
<img src="images.fld/image027.png" alt="" height=200>
</p>

* **Switch** – Boolean döndüren kontrol

<p align="center">
<img src="images.fld/image029.png" alt="" height=200>
</p>

### User Feedback
User Feedback kontrolleri kullanıcının app’in durumuyla ilgili bilgilendirildiği kontrollerdir.
* **ActivityIndicator** – Bir işlemin gerçekleştiğini belirten kontrol

<p align="center">
<img src="images.fld/image031.png" alt="" height=200>
</p>

* **ProgressBar** – Progressi belirten kontrol

<p align="center">
<img src="images.fld/image033.png" alt="" height=200>
</p>

## Tasarım Yapıları	
Bu bölümde Xamarin’in Tasarım Yapılarınının(Layouts) nasıl kullanıldığını inceleyeceğiz ve bunları örneklerle destekleyeceğiz. Öncelikle şu fotoğrafı incelemenizi öneririm.

<p align="center">
<img src="images.fld/image035.png" alt="" height=200>
</p>

Xamarin’de kullanılan tasarım yapıları aşağıdaki gibidir:



* **StackLayout** – Kontrolleri dikey veya yatay olarak yerleştirmek için kullanılır. [Örnek](https://github.com/DorukKorkmaz/Xamarin/blob/master/Basics/Basics/MyLayoutsPage.cs)

<p align="center">
<img src="images.fld/image039.png" alt="" height=350>
<img src="images.fld/image037.png" alt="" height=350>
</p>

* **AbsoluteLayout** – Kontrolleri mutlak değer veya oran vererek yerleştirmek için kullanılır. [Örnek](https://github.com/DorukKorkmaz/Xamarin/blob/master/Basics/Basics/MyAbsoluteLayoutPage.cs)

<p align="center">
<img src="images.fld/image047.png" alt="" height=350>
<img src="images.fld/image045.png" alt="" height=350>
</p>

 

* **RelativeLayout** – Kontrolleri diğer kontrollerin pozisyonuna göre yerleştirmek için kullanılır. [Örnek](https://github.com/DorukKorkmaz/Xamarin/blob/master/Basics/Basics/MyRelativeLayoutPage.cs)

<p align="center">
<img src="images.fld/image041.png" alt="" height=350>
<img src="images.fld/image043.png" alt="" height=350>
</p>
 

* **Grid** – Kontrolleri bir gride yerleştirir. Kontrollere bu gridin hangi sütun ve satırında olacağı belirtilir. [Örnek](https://github.com/DorukKorkmaz/Xamarin/blob/master/Basics/Basics/MyGridLayoutPage.cs)

<p align="center">
<img src="images.fld/image051.png" alt="" height=350>
<img src="images.fld/image049.png" alt="" height=350>
</p>


* **ScrollView** – Kontrollerin bir ekrana sığmayacağı zaman kaydırma imkanı verir. [Örnek](https://github.com/DorukKorkmaz/Xamarin/blob/master/Basics/Basics/MyViewsPage.cs)


## Sayfa Yapıları

Bir sayfa ekranın büyük bir çoğunluğunu kapsar ve bir tane child’ı vardır. Xamarin’de 6 çeşit sayfa yapısı bulunmaktadır. 

6 sayfa yapısı arasındaki farkları gösteren aşağıdaki fotoğrafı incelemenizi öneririm.

<p align="center">
<img src="images.fld/image053.png" alt="" height=200>
</p>

6 sayfa yapısını ayrıntılı bir şekilde incelemek gerekirse:

* **ContentPage** – Bir View görüntüler ve genelde StackLayout veya ScrollView gibi bir container ile kullanılır. 

<p align="center">
<img src="images.fld/image055.png" alt="" height=200>
</p>

* **MasterDetailPage** – İki panelin(master ve detail) kullanıldığı bir sayfa yapısıdır.

<p align="center">
<img src="images.fld/image057.png" alt="" height=200>
</p>

* **NavigationPage** – Stack yapısının kullanıldığı ve her yeni açılan sayfanın stacke atıldığı, eski sayfaya geri dönüldüğünde ise stackten çıkarıldığı sayfa yapısıdır. [Örnek] (https://github.com/DorukKorkmaz/Xamarin/blob/master/Basics/Basics/MyLayoutsPage.cs)

<p align="center">
<img src="images.fld/image059.png" alt="" height=200>
</p>

* **TabbedPage** – Childrenları arasında kolay geçişi sağlayan sayfa yapısıdır. [Örnek] (https://github.com/DorukKorkmaz/Xamarin/blob/master/Basics/Basics/MyTabPage.cs)

<p align="center">
<img src="images.fld/image061.png" alt="" height=200>
</p>

* **CarouselPage** – Swipe ile sayfalar arası geçişe izin verdiği bir sayfa yapısıdır. 

<p align="center">
<img src="images.fld/image063.png" alt="" height=200>
</p>

Daha fazla ayrıntı için [Xamarin'in websitesine](https://developer.xamarin.com/guides/xamarin-forms/user-interface/controls/pages/) bakabilirsiniz.


**Fotoğraflar developer.xamarin.com’dan alınmıştır.
