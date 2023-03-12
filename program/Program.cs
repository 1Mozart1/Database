string[] InputArray() 
{
    System.Console.Write("Введите значения через пробел: ");
    return Console.ReadLine()!.Split(" ");
}

int CountLess(string[] input, int n) 
{
    int count = 0;

    for(int i = 0; i < input.Length; i++) {
        if(input[i].Length <= n) {
            count++;
        }
    }

    return count;
}

string[] OutputArray(string[] input, int n) 
{
    string[] output = new string[CountLess(input, n)];

    for(int i = 0, j = 0; i < input.Length; i++) {
        if(input[i].Length <= n) {
            output[j] = input[i];
            j++;
        }
    }

    return output;
}

string[] array = InputArray();
string[] result = OutputArray(array, 3);
System.Console.WriteLine($"[{string.Join(", ", array)}] -> [{string.Join(", ", result)}]");