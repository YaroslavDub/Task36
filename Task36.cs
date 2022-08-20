// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите количество элементов массива:");
int i = Convert.ToInt32(Console.ReadLine());
int[] array = new int [i];
int Sum = 0;
for (int count = 0; count < i; count++) {
    array[count] = new Random().Next(1, 10);
}
for (int count = 0; count < i; count ++) {
    if (count % 2 != 0) {
        Sum = Sum + array[count];
    }
}
Console.WriteLine('[' + string.Join(", ", array) + ']');
Console.WriteLine ($"Сумма элементов массива стоящих на нечетных позициях = {Sum}");