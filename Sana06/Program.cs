using ClassLibrary;
using System.Text.RegularExpressions;

Person peoples = new Person();
peoples = new Person("Ivanov", "Ivan", new DateOnly(2005,10,10));
peoples = new Entrant("Antonenko", "Anton", new DateOnly(2006,06,08),189, 10.2, "ZSTU");
peoples = new Student();
peoples = new Teacher("Shevchenko","Taras",new DateOnly(1984,12,25), "rector", "Leadership", "KPI");
peoples = new LibraryUser("Stepanenko", "Stepan",new DateOnly(1997,04,21),246753,new DateOnly(2023,01,14),103.2);
Console.WriteLine(peoples.ShowInfo());