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

int MinMaxDiff(int[] array){
    int max = array[0];
    int min = array[1];
    for(int i = 1; i < array.Length; i++){
        if (array[i]>max) max = array[i];
        if (array[i]<min) min = array[i];
    }
    return max - min;
}

int[] array = new int[10];
FillArray(array);
PrintArray(array);

Console.WriteLine($"Разница между минимальним и максимальным элементами массива = {MinMaxDiff(array)}.");