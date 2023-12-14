using ExemploFundamentos.Models;
using Newtonsoft.Json;
using System;

/*double x = 30.0;
double y = 10.0;
CalculatorType calculatorType = CalculatorType.MakeAdd;
Calculator.PerformCalculations(calculatorType, x, y);*/

/*try{
    string[] lines = File.ReadAllLines("Files/ReadFile.txt");
    foreach(string line in lines){
        Console.WriteLine(line);
    }
} catch (Exception ex){
    Console.WriteLine(ex.Message);
}*/

/*Queue<int> queue = new();
queue.Enqueue(2);
queue.Enqueue(4);
queue.Enqueue(6);
queue.Enqueue(8);

foreach (int i in queue){
    Console.WriteLine(i);
}

Console.WriteLine($"Removing elemet {queue.Dequeue()}");
queue.Enqueue(10);

foreach (int i in queue){
    Console.WriteLine(i);
}*/

/*Stack<int> stack = new();
stack.Push(2);
stack.Push(4);
stack.Push(6);
stack.Push(8);

foreach (int i in stack){
    Console.WriteLine(i);
}

Console.WriteLine($"Removing elemet {stack.Pop()}");
stack.Push(10);

foreach (int i in stack){
    Console.WriteLine(i);
}*/

/*FileReader fileReader = new();
var (success, fileLines, _) = fileReader.ReadFile("Files/ReadFile.txt");
if(success){
    //Console.WriteLine("Lines Count: " + linesCount);
    foreach(string line in fileLines){
        Console.WriteLine(line);
    }
}
else{
    Console.WriteLine("Error on file reader");
}*/

/*DateTime actualDate = DateTime.Now;

List<Sale> sales = [];

Sale sale1 = new(1, "Book", 25.00M, actualDate);
Sale sale2 = new(2, "Pen", 1.00M, actualDate);

sales.Add(sale1);
sales.Add(sale2);

string serialized = JsonConvert.SerializeObject(sales, Formatting.Indented);

File.WriteAllText("Files/Sales.json", serialized);

Console.WriteLine(serialized);*/

string content = File.ReadAllText("Files/Sales.json");

List<Sale> sales = JsonConvert.DeserializeObject<List<Sale>>(content);

foreach(Sale sale in sales){
    Console.WriteLine(
        $"ID: {sale.ID}, Product: {sale.Product}, Price: {sale.Price}, Date: {sale.SaleDate:dd/MM/yyyy HH:mm}");
}