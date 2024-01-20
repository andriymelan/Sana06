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
            if (lastName == "" || firstName == "")
                throw new Exception("Incorrectly entered data");
            LastName = lastName;
            FirstName = firstName;
            Birthday = birthday;
        }
        public virtual string ShowInfo()
        {
            return $"{LastName} {FirstName} {Birthday}";
        }
    }
}