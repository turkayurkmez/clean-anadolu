

using SingleResponsibility;

internal class Program
{

    /*
     * Eğer bir nesne içinde değişiklik yapmak için birden fazla sebebiniz varsa, SRP prensibini ihlal ediyorsunuz demektir.
     */
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Console.WriteLine("Ürün Adını girin:");
        var productName = Console.ReadLine();
        Console.WriteLine("Ürün Fiyatını girin:");
        var productPrice = decimal.Parse(Console.ReadLine());

        var affectedRows = new ProductService().CreateNewProduct(productName, productPrice);

        var message = affectedRows > 0 ? "Ürün başarıyla eklendi." : "Ürün eklenirken bir hata oluştu.";
        Console.WriteLine(message);

    }


}