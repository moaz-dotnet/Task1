

Console.WriteLine("Hello in my program. ");
Console.WriteLine("-------------------");
int pricePerSmall = 25;
int pricePerLarge = 35;
 double taxRate = 0.06;
Console.Write("Enter the number of small carpets: ");

int smallCerpets = int.Parse(Console.ReadLine()  );
Console.Write("Enter the number of large carpets: ");
int largeCerpets = int.Parse(Console.ReadLine()  );
Console.WriteLine("--------------------");
int totalPrice = (smallCerpets * pricePerSmall) + (largeCerpets * pricePerLarge);
double tax = totalPrice * taxRate;
double totalAmount = totalPrice + tax;

Console.WriteLine($"the totalPrice is ${totalPrice}");
Console.WriteLine($"the tax is ${tax}");
Console.WriteLine($"the totalAmount is ${totalAmount}");
Console.WriteLine($"This estimate is valid for 30 days.");
Console.WriteLine("--------------------");
Console.WriteLine("Thank you for using our comany");









