// See https://aka.ms/new-console-template for more information
using LiskovSubstution;

Console.WriteLine("Hello, World!");

//Liskov Substitution Principle (LSP) Kuralları:
//1- Türetilmiş sınıfların, temel sınıfların yaptığı işi yapabilmesi gerekir.
//2- Türetilmiş sınıfların temel sınıfların davranışlarını değiştirmemesi gerekir.


//Bu sınıfı, bir ilkokul öğretmeninin, çocuklara iki boyutlu şekillerin alanlarını hesaplatmasını sağlayacak şekilde kodlayacağını düşünelim.

IArea rectangle = new Geometry().CreateRectangle(5,7);



Console.WriteLine($"Alan: {rectangle.Area()}");

