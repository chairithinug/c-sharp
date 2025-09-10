// // See https://aka.ms/new-console-template for more information
// using System.Drawing;
// using Pastel;

// Console.WriteLine("Hello, .NET!".Pastel(Color.Green));

// Method to divide two numbers with error handling
// using System;
// public class Program
// {
// public static double DivideNumbers(double numerator, double denominator)
// {
//     if (denominator == 0)
//     {
//         Console.WriteLine("Error: Division by zero is not allowed.");
//         return double.NaN; // Return "Not a Number" to indicate an error
//     }

//     double result = numerator / denominator;
//     return result;
// }

// public static void Main()
// {
//     // Attempt to divide 10 by 0
//     double result = DivideNumbers(10, 0);
//     Console.WriteLine("The result is: " + result);
// }
// }

// using System;
// public class Program
// {
// // Method to calculate the average of an array with error handling
// public static double CalculateAverage(int[] numbers)
// {
//     if (numbers.Length == 0)
//     {
//         Console.WriteLine("Error: Cannot calculate the average of an empty array.");
//         return double.NaN; // Return "Not a Number" to indicate an error
//     }

//     int sum = 0;
//     for (int i = 0; i < numbers.Length; i++)
//     {
//         sum += numbers[i];
//     }
//     return (double)sum / numbers.Length;
// }

// public static void Main()
// {
//     int[] numbers = {}; // Empty array
//     double average = CalculateAverage(numbers);
//     Console.WriteLine("The average is: " + average);
// }
// }

// public class Program
// {
//     // Method to calculate the final price after a discount
//     public static double ApplyDiscount(double price, double discountPercentage)
//     {
//         return price * (100 - discountPercentage) / 100;
//     }

//     public static void Main()
//     {
//         double finalPrice = ApplyDiscount(1000, 15);
//         Console.WriteLine("The final price is: " + finalPrice);
//     }
// }

// using System.Numerics;

// public class Program
// {
//     public static int FindMax(int[] numbers)
//     {
//         int max = int.MinValue;
//         for (int i = 0; i < numbers.Length; i++)
//         {
//             if (numbers[i] > max)
//             {
//                 max = numbers[i];
//             }
//         }
//         return max;
//     }

//     public static void Main()
//     {
//         int[] myNumbers = { -5, -10, -3, -8, -2 };
//         int maxNumber = FindMax(myNumbers);
//         Console.WriteLine("The maximum number is: " + maxNumber);
//     }
// }

// public class Calculator
// {
//     public static int number1; // init to 0
//     public static int number2;
//     public static int Add()
//     {
//         return number1 + number2;
//     }
//     static void Main(string[] args)
//     {
//         number1 = 5;
//         number2 = 10;
//         // int result = Add();
//         Console.WriteLine(result);
//     }
// }

// public class NumberDisplay
// {
//     public static void DisplayNumbers()
//     {
//         for (int i = 1; i <= 10; i++)
//         {
//             Console.WriteLine(i);
//         }
//     }
//     static void Main(string[] args)
//     {
//         DisplayNumbers();
//     }
// }

// public class UserInput
// {
//     static void GreetUser()
//     {
//         Console.WriteLine("Your name");
//         string name = Console.ReadLine(); // capture inputs
//         Console.WriteLine("Hello " + name);
//     }

//     static void Main(string[] args)
//     {
//         GreetUser();
//     }
// }

// public class ToDoList
// {
//     public static string[] tasks = new string[10];
//     public static int taskCount = 0;

//     public static void AddTask()
//     {
//         Console.WriteLine("Enter task");
//         if (taskCount + 1 <= tasks.Count())
//         {
//             tasks[taskCount] = Console.ReadLine();
//             taskCount++;
//             Console.WriteLine("Task" + taskCount + "of" + tasks.Count());
//         }
//         else
//         {
//             Console.WriteLine("Max number of tasks");
//         }

//     }

//     public static void ViewTasks()
//     {
//         Console.WriteLine("Tasks");
//         for (int i = 0; i < taskCount; i++)
//         {
//             Console.WriteLine((i + 1) + "." + tasks[i]);
//         }
//     }

//     public static void CompleteTask()
//     {
//         Console.WriteLine("Enter task number");
//         int taskNumber = int.Parse(Console.ReadLine()) - 1;
//         if (taskNumber >= 0 && taskNumber < taskCount)
//         {
//             tasks[taskNumber] = "";
//             Console.WriteLine("Completed");
//         }
//         else
//         {
//             Console.WriteLine("Invalid task");
//         }
//     }

//     public static void Main(string[] args)
//     {
//         bool running = true;
//         while (running)
//         {
//             Console.WriteLine("Options");
//             Console.WriteLine("1. Add");
//             Console.WriteLine("2. View");
//             Console.WriteLine("3. Mark");
//             Console.WriteLine("4. Exit");
//             string choice = Console.ReadLine();
//             switch (choice)
//             {
//                 case "1":
//                     AddTask();
//                     break;
//                 case "2":
//                     ViewTasks();
//                     break;
//                 case "3":
//                     CompleteTask();
//                     break;
//                 case "4":
//                     running = false;
//                     break;
//                 default:
//                     Console.WriteLine("Invalid");
//                     break;
//             }
//         }
//     }
// }

public class Pool
{
    public int chlorineLevel;
    public int waterLevel;
    public Pool(int chlorine, int waterlevel)
    {
        chlorineLevel = chlorine;
        waterLevel = waterlevel;
    }
    public void PoolInfo()
    {
        Console.WriteLine($"Pool: {chlorineLevel} {waterLevel}");
    }
}

public class Spa : Pool // inheritance
{
    public int heatLevel;
    public Spa(int chlorine, int waterlevel, int heatlevel) : base(chlorine, waterlevel)
    {
        heatLevel = heatlevel;
    }
    public void SpaInfo()
    {
        Console.WriteLine($"Pool: {chlorineLevel} {waterLevel} {heatLevel}");
    }
}

public class Instrument
{
    // use virtual if want to include implementation detail for the subclasses
    public virtual void Play() // polymorphism (same name, different bevahiors depending on data type, etc)
    {
        Console.WriteLine("Playing");
    }
}

public class Piano : Instrument
{
    public override void Play()
    {
        Console.WriteLine("Piano playing");
    }
}

public interface IPlayable // interface (provide set of must implemented without details)
{
    void Play();
}

public class Guitar : IPlayable
{
    public void Play()
    {
        Console.WriteLine("Guitar playing");
    }
}
public interface IAnimal
{
    void Eat();
}

public class Animal : IAnimal
{
    public void Eat()
    {
        Console.WriteLine("Eat");
    }

    public virtual void MakeSound()
    {
        Console.WriteLine("Animal generic sound");
    }
}

public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Dog sound");
    }
}
public class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Cat sound");
    }
}

// polymorphism treat different objects as if they are instances of the same class or interface
// write code that works with any class that shares a common base class or interface

// public class Program
// {
//     public static void Main(string[] args)
//     {
//         List<Animal> animals = new List<Animal>();
//         animals.Add(new Dog());
//         animals.Add(new Cat());
//         foreach (Animal animal in animals)
//         {
//             animal.MakeSound();
//         }
//     }
// }

// design pattern
// Singleton pattern (creational)
// only one instance
// provide a point of access from anywhere
// useful for managing shared resources
public class Database
{
    // must be private
    private static Database _instance; // prevent other from creating a new instance
    private Database()
    {
        Console.WriteLine("cx est.");
    }
    public static Database GetInstance()
    {
        if (_instance == null) // ensure one instance of db
        {
            _instance = new Database();
        }
        return _instance;
    }
}

// Factory pattern (creational)
// requesting code does not directly create objects
// factory method or class handles requests
// maintains code flexibility
// interface
public interface INotification
{
    void Send(string message);
}

public class EmailNotification : INotification
{
    public void Send(string message)
    {
        Console.WriteLine("sending email"+message);
    }
}

public class SMSNotification : INotification
{
    public void Send(string message)
    {
        Console.WriteLine("sending sms" + message);
    }
}

public class NotificationFactory
{
    public static INotification CreateNotification(string channel)
    {
        if (channel == "Email")
        {
            return new EmailNotification();
        }
        else // (channel == "SMS")
        {
            return new SMSNotification();
        }
    }
}

// Adapter pattern (structural)
// allow incompatible interfaces work together
// useful when integrating third-party libraries that do not match the expected interface.

// Observer pattern (behavioral)
// one object notifies other objects about changes
// useful for event notifications
// user interface changes when data changes
public interface IObserver
{
    void Update(float temperature);
}

public class WeatherStation
{
    private List<IObserver> observers = new List<IObserver>();
    private float temperature;
    public void RegisterObserver(IObserver observer)
    {
        observers.Add(observer);
    }
    public void RemoveObserver(IObserver observer)
    {
        observers.Remove(observer);
    }
    public void NotifyObservers()
    {
        foreach (var observer in observers)
        {
            observer.Update(temperature);
        }
    }
    public void SetTemperature(float newTemperature)
    {
        temperature = newTemperature;
        NotifyObservers();
    }
}

public class PhoneDisplay : IObserver
{
    public void Update(float temperature)
    {
        Console.WriteLine("Phone: updated to" + temperature);
    }
}

public class DesktopDisplay : IObserver
{
    public void Update(float temperature)
    {
        Console.WriteLine("Desktop: updated to" + temperature);
    }
}

// public class Program
// {
//     public static void Main(string[] args)
//     {
//         WeatherStation weatherstation = new WeatherStation();
//         PhoneDisplay phoneDisplay = new PhoneDisplay();
//         DesktopDisplay desktopDisplay = new DesktopDisplay();
//         weatherstation.RegisterObserver(phoneDisplay);
//         weatherstation.RegisterObserver(desktopDisplay);
//         weatherstation.SetTemperature(25.0f);
//     }
// }


// Another singleton
// public class Database
// {
//     private static Database instance;
//     private static readonly object lockObject = new object();

//     // Private constructor prevents instantiation from other classes
//     private Database() { }

//     public static Database GetInstance()
//     {
//         if (instance == null)
//         {
//             lock (lockObject)
//             {
//                 if (instance == null)
//                 {
//                     instance = new Database();
//                 }
//             }
//         }
//         return instance;
//     }

//     public void Connect()
//     {
//         Console.WriteLine("Database connected.");
//     }
// }

// public class Program
// {
//     public static void Main()
//     {
//         Database db1 = Database.GetInstance();
//         Database db2 = Database.GetInstance();

//         db1.Connect();
//         Console.WriteLine(object.ReferenceEquals(db1, db2)); // Outputs: True
//     }
// }

// Another adapter
// Target interface
// public interface ITarget
// {
//     void Request();
// }

// // Adaptee class
// public class Adaptee
// {
//     public void SpecificRequest()
//     {
//         Console.WriteLine("Specific request is called.");
//     }
// }

// // Adapter class
// public class Adapter : ITarget
// {
//     private Adaptee adaptee;

//     public Adapter(Adaptee adaptee)
//     {
//         this.adaptee = adaptee;
//     }

//     public void Request()
//     {
//         // Convert the interface of Adaptee to the Target interface
//         adaptee.SpecificRequest();
//     }
// }

// public class Program
// {
//     public static void Main()
//     {
//         Adaptee adaptee = new Adaptee();
//         ITarget target = new Adapter(adaptee);

//         target.Request(); // Outputs: Specific request is called.
//     }
// }


public class Person
{
    public string Name { get; set; } // property
    public int Age { get; set; }
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Name {Name} {Age}");
    }
}

// public class Program
// {
//     public static void Main(string[] args)
//     {
//         Person neighbor = new Person("John Doe", 30);
//         neighbor.Age = 31;
//         neighbor.DisplayInfo();
//     }
// }



// Async keyword
// set up a separate worker for time-consuming tasks (IO, network)
// Does not disturb the main flow of the application

// public async Task GetDataAsync() { // Task for void, Task<string> for returned type string (return data)
//     try
//     {
//         var data = await GetDataFromApi();
//     }
//     catch (Exception ex)
//     {
//         Console.WriteLine(data);
//     }
// }

// await to wait for the BG task to happen before the main flow moving on 
// pauses the execution of the method until the awaited task completes
// await method is suspended
// control given to the method you are calling
// resume after completion

// public async Task SimulateDelay() {
//     await Task.Delay(5000);
//     Console.WriteLine("Done after 5 sec");
// }

// public async Task ReadFileAsync(string filePath) {
//     using (StreamReader reader = new StreamReader(filePath))
//     {
//         string content = await reader.ReadToEndAsync();
//         Console.WriteLine(content);
//     }
// }

// public async Task GetDataFromMultipleSources() {
//     Task<string> data1 = GetDataFromApiAsync("https://api.example.com/data1");
//     Task<string> data2 = GetDataFromApiAsync("https://api.example.com/data2");
//     await Task.WhenAll(data1, data2);
//     Console.WriteLine(data1.Result);
//     Console.WriteLine(data2.Result);
// }

// public async Task GetDataWithHandling() {
//     try
//     {
//         HttpClient client = new HttpClient();
//         string data = await client.GetStringAsync("https://api.example.com/data");
//         Console.WriteLine(data);
//     }
//     catch (HttpRequestException ex)
//     {
//         Console.WriteLine($"Request error {ex.Message}");
//     }
// }

// public class Program {
//     public async Task DownloadDataAsync()
//     {
//         Console.WriteLine("Download started");
//         await Task.Delay(5000);
//         Console.WriteLine("Download completed");
//     }

//     public async Task DownloadDataAsync2()
//     {
//         Console.WriteLine("Download 2 started");
//         await Task.Delay(2000);
//         Console.WriteLine("Download 2 completed");
//     }

//     public static async Task Main(string[] args)
//     {
//         try
//         {
//             Program program = new Program();
//             await program.DownloadDataAsync();
//             Console.WriteLine("Main completed");

//             Task task1 = program.DownloadDataAsync();
//             Task task2 = program.DownloadDataAsync2();
//             await Task.WhenAll(task1, task2);
//             Console.WriteLine("All tasks completed");
//             // throw new InvalidOperationException("download error");
//         }
//         catch (Exception ex)
//         {
//             Console.WriteLine($"crashed {ex.Message}");
//         }

//     }
// }

// public async Task<List<Product>> FetchProductsAsync() {
//     try
//     {
//         await Task.Delay(2000);
//         return new List<Product> { new Product("EBag"), new Product("Resuable Straw") };
//     }
//     catch (Exception ex)
//     {
//         Console.WriteLine($"Error fetching products {ex.Message}");
//         return new List<Product>();
//     }
// }

// public async Task DisplayProductsAsync() {
//     var products = await FetchProductsAsync();
//     foreach (var product in products)
//     {
//         Console.WriteLine(product.Name);
//     }
// }

// public async Task FetchDataAsync() {
//     var productTask = FetchProductsAsync();
//     var reviewsTask = FetchReviewsAsync();
//     await Task.WhenAll(productTask, reviewsTask);
// }

// public class Program
// {
//     public static async Task PerformLongOperationAsync()
//     {
//         Console.WriteLine("Task started");
//         await Task.Delay(2000);
//         Console.WriteLine("Task done");
//     }
//     public static async Task PerformLongOperationAsync2()
//     {
//         try
//         {
//             Console.WriteLine("Task started");
//             await Task.Delay(2000);
//             throw new Exception("Sim error");
//             Console.WriteLine("Task done");
//         }
//         catch (Exception ex)
//         {
//             Console.WriteLine($"{ex.Message}");
//         }
//     }
//     public static void Main(string[] args)
//     {
//         Task.Run(async () => await PerformLongOperationAsync2()).Wait();
//         Console.WriteLine("Main done");
//     }

// }


// public class Product
// {
//     public static void Main(string[] args)
//     {
//         int number;
//         Console.WriteLine("Enter a non-negative integer:");
//         while (!int.TryParse(Console.ReadLine(), out number) || number < 0)
//         {
//             Console.WriteLine("Invalid input. Please enter a non-negative integer.");
//         }
//         double result = Math.Sqrt(number);
//         Console.WriteLine("The square root is: " + result);
//     }
// }
