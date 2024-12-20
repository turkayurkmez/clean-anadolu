// See https://aka.ms/new-console-template for more information
using OpenClosed;

Console.WriteLine("Hello, World!");
/*
 * Bir nesne ......GELİŞİME.......... Açık ..........DEĞİŞİME..... Kapalı olmalıdır.
 */

/*
 * Senaryo:
 * 
 *    Bir sipariş yönetim sistemi yazacaksınız. Buna göre, nesneniz siparişiniz üzerinde indirim yapacak.
 *    Müşterilerilerinizin, sadakat kartlarına göre indirim yapılacak.
 *    Standart : %5
 *    Silver : %10
 *    Gold : %15
 *    
 *    
 */

Customer customer = new Customer { Name = "Türkay", LoyaltyCard = new PremiumCard() };
OrderManagement orderManagement = new OrderManagement() { Customer = customer};

decimal discountedPrice = orderManagement.GetDiscountedPrice(1000);
Console.WriteLine($"İndirimli Fiyat: {discountedPrice}");

