

Console.WriteLine("Hello in my program. ");
Console.WriteLine("-------------------");
int pricePerSmall = 25;
int pricePerLarge = 35;
 double taxRate = 0.06;
Console.Write("Enter the number of small carpets: ");

int smallCarpets = int.Parse(Console.ReadLine()  );
Console.Write("Enter the number of large carpets: ");
int largeCarpets = int.Parse(Console.ReadLine()  );
Console.WriteLine("--------------------");
//عملية حساب سعر غسل السجاد
int totalPrice = (smallCarpets * pricePerSmall) + (largeCarpets * pricePerLarge);
//عملية حساب الضريبة
double tax = totalPrice * taxRate;
//عملية حساب المبلغ الكلي
double totalAmount = totalPrice + tax;

Console.WriteLine($"the totalPrice is {totalPrice:C}");//C: currencyحبيت اجربها في تاسك هنا
Console.WriteLine($"the tax is {tax}");
Console.WriteLine($"the totalAmount is {totalAmount:C}");
Console.WriteLine($"This estimate is valid for 30 days.");
Console.WriteLine("--------------------");
Console.WriteLine("Thank you for using our company");









