
Console.WriteLine("Введите количество символов");
int N = int.Parse(Console.ReadLine());
string[] column = new string[N];
for (int i = 0; i < N; i++){
     column[i] = Console.ReadLine();
}

string[]  sort(string[] massive){
    string[] stock = new string[massive.Length];
    int line = 0;
    for (int i = 0; i < massive.Length; i++){
        if (massive[i].Length >= 3) {
           stock[line] = massive[i];
           line++;
        }
        else ;
    }
    return stock;

}
string[] st = sort(column);

void showstring(string [] str){
     Console.Write(" the new massive is [");
     for (int i = 0; i < str.Length - 1; i++){
        Console.Write($" {str[i]},");
        }
    Console.Write($"{str[str.Length - 1]} ];");
    }

showstring(st);

// Console.Write("M = ");
// int M = int.Parse(Console.ReadLine());
// Console.Write("N = ");
// int N = int.Parse(Console.ReadLine());
// Console.WriteLine($"Result, S = {SumNumbers(M, N)}");
// Console.ReadLine();
    