
void showstring(string [] str){ //function to show the massive
     Console.Write($" the new massive is [{str[1]}");
     for (int i = 1; i < str.Length - 1; i++){
       if (str[i] == null) ;
       else Console.Write($", {str[i]}");
        }
    if (str[str.Length -1] != null) Console.Write($", {str[str.Length - 1]} ];");    // I could fix the problem with empty spaces,
    else Console.Write("]");                                                       // but it's fiction, empty spaces are 
    }                                                                              //still into the massive

string[]  sort(string[] massive){ //function of sorting
    string[] stock = new string[massive.Length];
    int line = 0;
    for (int i = 0; i < massive.Length; i++){
        if (massive[i].Length >= 3) {
           
           stock[line] = massive[i];
           line++;
        }
    }
    return stock;
}

Console.WriteLine("Введите количество символов");
int N = int.Parse(Console.ReadLine());     //create a massive
string[] column = new string[N];
for (int i = 0; i < N; i++){
     column[i] = Console.ReadLine();
}


string[] st = sort(column);

showstring(st);

//we need smt to delete empty spaces, but we have to delete empty spaces at the end of massive, last plurals of cells from the massive





// Console.Write("M = ");
// int M = int.Parse(Console.ReadLine());
// Console.Write("N = ");
// int N = int.Parse(Console.ReadLine());
// Console.WriteLine($"Result, S = {SumNumbers(M, N)}");
// Console.ReadLine();
    