
namespace ChallangeApp
{
    public abstract class Person
    {
        public Person()
        {
            this.Name = "No name";
            this.Surname = "No name";
            this.Age = 0;
            this.Gender = "None";
        }
        public Person(string name, string surname, int age, string gender) 
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
            if (gender == "K" || gender == "k" || gender == "M" || gender == "m")
            {
                this.Gender = gender;
            }
            else
                throw new Exception("Invalid Gender Name, You should use 'M' or 'K'");
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }
        public string Gender { get; private set; }
    }
}
