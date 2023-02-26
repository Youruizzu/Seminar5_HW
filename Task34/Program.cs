Console.Clear();

void FillArray(int[] collection){
    for(int i = 0; i < collection.Length; i++){
        collection[i] = new Random().Next(100, 1000);
    }
}

void PrintArray(int[] col){
    for(int i = 0; i < col.Length; i++){
        Console.Write($"{col[i]} ");
    }
    Console.WriteLine();
}

int EvenNums(int[] array){
    int count = 0;
    for(int i = 0; i < array.Length; i++){
        if (array[i]%2==0) count++;
    }
    return count;
}

int[] array = new int[20];
FillArray(array);
PrintArray(array);

Console.WriteLine($"Количество чётных чисел в массиве = {EvenNums(array)}.");