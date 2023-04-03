// See https://aka.ms/new-console-template for more information

using System;

Console.WriteLine("Ümumi əmək haqqını daxil edin: ");
int grossSalary = int.Parse(Console.ReadLine());
Console.WriteLine("Ailə vəziyyətini daxil edin (e / E: evli, b / B: subay, d / D: dul): ");
char familyStatus = char.Parse(Console.ReadLine());
int familyAllowance = 0;
int childAllowance = 0;
if (familyStatus != 'b' && familyStatus != 'B')
{
    Console.WriteLine("Usaqlarin sayi");
    int childCount = int.Parse(Console.ReadLine());
    //İşçilərin Gross əmək haqqına evli olanlar üçün 50 AZN ailə müavinəti elave olunur
    if (familyStatus == 'e' || familyStatus == 'E')
    {
        familyAllowance += 50;
    }

    //Uşaq sahibi olanlar üçün birinci uşaq üçün 30 AZN, ikinci uşaq üçün 25 AZN, üçüncü uşaq üçün 20 AZN və
    //digər uşaqların hər biri üçün 15 AZN əlavə olunur.
    if (childCount >= 1)
    {
        childAllowance += 30;
    }

    if (childCount >= 2)
    {
        childAllowance += 25;
    }

    if (childCount >= 3)
    {
        childAllowance += 20;

    }
    if (childCount > 3)
    {
        childAllowance += ((childCount) - 3) * 15;
    }
}
Console.WriteLine("Elil olub olmamasi(e / E: bəli, n / N: yox)");
char disabilityStatus = char.Parse(Console.ReadLine());

grossSalary += familyAllowance+childAllowance;

//İşçilər tərəfindən ödəniləcək gəlir vergisi aşağıdakı kimi hesablanır.  
double taxRate =0;
if (grossSalary <= 1000)
 
{
    taxRate = 0.15;
}
else if ( grossSalary>1000 &&  grossSalary<= 2000)
{
    taxRate = 0.20;
}
else if (grossSalary > 2000 && grossSalary <= 3000)
{
    taxRate = 0.25;
}

else if (grossSalary > 3000 )
{
    taxRate = 0.30;
}
if (disabilityStatus == 'e')
{
    taxRate /= 2;
}

double taxAmount = grossSalary * taxRate;
double netSalary = (double)grossSalary - taxAmount;


Console.WriteLine("aile muavineti:" + familyAllowance);
Console.WriteLine("usaq pulu:" + childAllowance);
Console.WriteLine("gelir vergi derecesi:" + taxRate);
Console.WriteLine("gelir vergisinin meblegi:" + taxAmount);
Console.WriteLine("umumi emek haqqi:" + grossSalary);
Console.WriteLine("xalis emek haqqi:" + netSalary);



