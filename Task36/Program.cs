Console.Clear();

void FillArray(int[] collection){
    for(int i = 0; i < collection.Length; i++){
        collection[i] = new Random().Next(1, 100);
    }
}

void PrintArray(int[] col){
    for(int i = 0; i < col.Length; i++){
        Console.Write($"{col[i]} ");
    }
    Console.WriteLine();
}

int UnevenSum(int[] array){
    int sum = 0;
    for(int i = 1; i < array.Length; i++){
        if (i%2==1) sum += array[i];
    }
    return sum;
}

int[] array = new int[10];
FillArray(array);
PrintArray(array);

Console.WriteLine($"Сумма чисел стоящих на нечётных позициях в массиве = {UnevenSum(array)}.");