using System.Text;
using WeekDaysInArmenian; //for #1 and #2
using EasyNumbering; //for numbering
using Arrays; //for array
Console.OutputEncoding = Encoding.UTF8;

Numbering.PrintWithColor(1, Colors.Green);
Console.WriteLine();

Console.WriteLine("Using switch");
Console.WriteLine(WeekDays.GetWeekDayBySwitch());
Console.WriteLine();

Numbering.PrintWithColor(2, Colors.Green);

Console.WriteLine("Using if else");
Console.WriteLine(WeekDays.GetWeekDayByIfElse());
Console.WriteLine();

Numbering.PrintWithColor(3, Colors.Green);
Console.WriteLine();

Arr TestArray = new Arr(); //seting arr size
//TestArray.SetElements(); //manual filling
TestArray.FillArray(); //you can use quick fill
TestArray.PrintElements(); //using class function for print elements


Console.WriteLine();
int[] Test = TestArray.GetArray(); //you can get an array to use for different purposes

for (int i = 0; i < Test.Length; i++)
{
    Console.Write(Test[i] + " ");
}




