Console.OutputEncoding = System.Text.Encoding.UTF8;
Random rnd = new Random(DateTime.Now.Millisecond);
Console.WriteLine("Размер массива:");
int[] arr = new int[int.Parse(Console.ReadLine())];
Console.WriteLine("Размер минимальную границу массива:");
int minrange = int.Parse(Console.ReadLine());
Console.WriteLine("Размер максимальную границу массива:");
int maxrange = int.Parse(Console.ReadLine());
if(minrange < maxrange || arr.Length > 2)
{
    int min = 0, max = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(minrange, maxrange);
        Console.Write($"[{i}]" + arr[i] + ", ");
        if (arr[i] >= arr[max]) max = i;
        if (arr[i] <= arr[min]) min = i;
    }
    Console.WriteLine();
    Console.WriteLine("самый большой элемент: " + arr[max] + " позиция:" + $" [{max}]");
    Console.WriteLine("самый маленький элемент: " + arr[min] + " позиция" + $" [{min}]");
    int swap = arr[min];
    arr[min] = arr[max];
    arr[max] = swap;
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"[{i}]" + arr[i] + ", ");
    }
}
Console.WriteLine("че ты ввел.");

