// See https://aka.ms/new-console-template for more information

Console.WriteLine("--------------Program to find HCF of two positive numbers..");
Console.WriteLine("Enter number 1");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number 2");
int num2 = Convert.ToInt32(Console.ReadLine());

//While...
while(num1 != num2)
{
    if(num1 > num2)
        num1 -= num2;
    
    else
        num2 -= num1;
}

Console.WriteLine("HCF is {0}",num1);

