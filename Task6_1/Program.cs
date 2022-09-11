// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.Write("Сколько чисел будете вводить? : ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
void Created()
{
    Console.Write("Введите первое число: ");
    for (int i=0; i<n; i++)
        {
            if (i<n-1) 
            {
                array[i]= Convert.ToInt32(Console.ReadLine());
                Console.Write("Следующее: ");
            }
            else array[i]= Convert.ToInt32(Console.ReadLine());
        }
}    
Created();
int positivNumbers = 0;
for (int i=0; i<n; i++)
{
    if (array[i]>0) positivNumbers++; 
}
Console.Write($"Вы ввели {positivNumbers} положительных числа.");