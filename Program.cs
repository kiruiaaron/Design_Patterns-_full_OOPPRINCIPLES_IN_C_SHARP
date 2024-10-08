//Encapsulation

using ConsoleApp1.src.OOPprinciples.Abstraction;
using ConsoleApp1.src.OOPprinciples.Coupling;
using ConsoleApp1.src.OOPprinciples.Encapsulation;
using ConsoleApp1.src.OOPprinciples.Inheritance;
using ConsoleApp1.src.OOPprinciples.Polymorphism;
using Car = ConsoleApp1.src.OOPprinciples.Polymorphism.Car;
using Vehicle = ConsoleApp1.src.OOPprinciples.Polymorphism.Vehicle;

BankAccount bankAccount = new BankAccount(100);
System.Console.WriteLine(bankAccount.GetBalance());

bankAccount.Deposit(50);

System.Console.WriteLine(bankAccount.GetBalance());

bankAccount.withdraw(100);
System.Console.WriteLine(bankAccount.GetBalance());

//Abstraction
//Reduce complexity by hiding unnecessary details

EmailService emailService = new EmailService();

emailService.SendEmail();

//Inheritance
//Inheritance involves creating new classes {subclasses or derived classes} based an existing classes {superclasses or base classes}. Subclasses inherit properties and behaviours from their superclasses and can also add new features or override existing ones. Inheritance is often described in term of an "is-a" relationship

//var car = new Car();

//shared
//car.Brand = "ford";
// car.Start();
// car.Stop();

//Unique
//car.NumberOfDoors = 4;


//polymorphism

List<Vehicle> vehicles = new List<Vehicle>();
vehicles.Add(new Car {Brand = "Toyota", Model = "Canry", Year = 2020, NumberOfDoors = 4});
vehicles.Add(new Motorcycle{Brand = "Marley Davidson", Model = "Sportster", Year = 2021});

//vehicle inspection

// foreach (var vehicle in vehicles){
//     if(vehicle is Car){
//         var car = (Car)vehicle;
//         car.Start();

//     }
//     else if (vehicle is Motorcycle)
//     {
//         var motorcycle = (Motorcycle)vehicle;
//         motorcycle.Start();
//     }
// }

//implementing polymorphism
foreach (var vehicle in vehicles)
{
    vehicle.Start();
}

//Coupling

//The degree of dependency different classes

var order = new Order();
order.PlaceOrder();