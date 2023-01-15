//Задача 64: Написать рекурсивную функцию перевода из десятичной системы исчисления в двоичную.
  
// перевод натурального числа из 10-й системы в двоичную



string BinarySystem (int num, string res){
  if (num < 2)
  {
    int t = num % 2;
    res = res + t.ToString();
    
        string res2 = "";
    for (int i = res.Length-1; i>=0; i--)
      res2 = res2 + res[i];
    return res2;
  }
    else
  {
    int t = num % 2;
    res = res + t.ToString();
    return BinarySystem(num / 2, res);
    
  }

}

Console.Write("Enter your number: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(BinarySystem);


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
/*
void ShowNumbers(int n, int m, int sum){

    if (n<m) {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
        return;
    }
     sum = sum + (m++);
    ShowNumbers(n, m, sum);
}

Console.Write("Enter your number: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter your number: ");
int n = Convert.ToInt32(Console.ReadLine());
ShowNumbers(n, m, 0);
*/