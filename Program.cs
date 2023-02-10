// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

void RandArray(float[] collection, int lBound, int hBound)        //  метод наполняет массив случайными числами
{
    for (int i = 0; i < collection.Length; i++)
        collection[i] = new Random().Next(lBound, hBound);
}

Console.Clear();                                                  //  очистка консоли
Console.WriteLine("Введите количество элементов в массиве: ");    //  ввод числа
int num = Convert.ToInt32(Console.ReadLine());
if (num <= 0)                                                     // если отрицательное значение
    Console.WriteLine($"Число должно быть больше 0!");
else
    {
    float[] array = new float[num];                               //  объявление массива
    RandArray(array,0,100);                                       //  наполнение массива
    Console.WriteLine(String.Join(" ",array));                    //  вывод массива
    float minEl = array[0], maxEl = array[0];                     //  минимум и максимум
    for (int i = 1; i < array.Length; i++)                        //  обход массива
        {
            if (array[i] < minEl) minEl = array[i];               //  элемент массива < минимума
            if (array[i] > maxEl) maxEl = array[i];               //  элемент массива > максимума
        }    
    Console.WriteLine($"Максимум: {maxEl}. Минимум: {minEl}. Разность между ними: {maxEl-minEl}.");
    }