namespace ClassLibrary
{
    public class Person
    {
        protected string LastName {  get; set; }
        protected string FirstName { get; set; }
        protected DateOnly Birthday { get; set; }
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
        virtual public string ShowInfo()
        {
            return $"{LastName} {FirstName} {Birthday}";
        }
    }
}