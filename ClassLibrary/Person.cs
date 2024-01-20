namespace ClassLibrary
{
    public class Person
    {
        public string LastName {  get; set; }
        public string FirstName { get; set; }
        public DateOnly Birthday { get; set; }
        public Person()
        {
            LastName = "Petrenko";
            FirstName = "Petro";
            Birthday = new DateOnly(2000,1,1);
        }
        public Person(string lastName, string firstName, DateOnly birthday)
        {
            LastName = lastName;
            FirstName = firstName;
            Birthday = birthday;
        }
        public string ShowInfo()
        {
            return $"{LastName} {FirstName} {Birthday}";
        }
    }
}