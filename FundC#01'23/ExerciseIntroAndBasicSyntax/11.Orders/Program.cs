

int orders = int.Parse(Console.ReadLine());
double totalPrice = 0;
for (int i = 0; i < orders; i++)
{
    double orderPrice = 0;
    double capsulePrice = double.Parse(Console.ReadLine());
    int days = int.Parse(Console.ReadLine());
    int capsuleCount = int.Parse(Console.ReadLine());
    orderPrice = days * capsuleCount * capsulePrice;
    totalPrice += orderPrice;
    Console.WriteLine($"The price for the coffee is: ${orderPrice:f2}");
}

Console.WriteLine($"Total: ${totalPrice:f2}");


