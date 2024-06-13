using HTS_Proxy;

Console.WriteLine("début : "+ DateTime.UtcNow.ToString("HH:mm:ss:fff"));
Image image = new Image(@"c:\test\image.jpg");
//image.DisplayImage();
Console.WriteLine("fin : " + DateTime.UtcNow.ToString("HH:mm:ss:fff"));


Console.WriteLine("début : " + DateTime.UtcNow.ToString("HH:mm:ss:fff"));
ImageProxy image2 = new ImageProxy(@"c:\test\image.jpg");
Console.WriteLine("fin : " + DateTime.UtcNow.ToString("HH:mm:ss:fff"));
image.DisplayImage();


Console.WriteLine("début : " + DateTime.UtcNow.ToString("HH:mm:ss:fff"));
//autres méthodes fournies par le framework, en utilisant le lazy
Lazy<Image> image3 = new Lazy<Image>(() => new Image(@"c:\test\image.jpg"));
Console.WriteLine("fin : " + DateTime.UtcNow.ToString("HH:mm:ss:fff"));
image3.Value.DisplayImage();

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
