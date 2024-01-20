using ClassLibrary;
using System.Text.RegularExpressions;

Person[] peoples = new Person[5];
peoples[0] = new Person("Ivanov", "Ivan", new DateOnly(2005,10,10));
peoples[1] = new Entrant("Antonenko", "Anton", new DateOnly(2006,06,08),189, 10.2, "ZSTU");
peoples[2] = new Student();
peoples[3] = new Teacher("Shevchenko","Taras",new DateOnly(1984,12,25), "rector", "Leadership", "KPI");
peoples[4] = new LibraryUser("Stepanenko", "Stepan",new DateOnly(1997,04,21),246753,new DateOnly(2023,01,14),103.2);
for (int i = 0; i < peoples.Length; i++)
{
    Console.WriteLine(peoples[i].ShowInfo());
}