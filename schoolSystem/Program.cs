using schoolSystem;

public class Program
{
    public static void Main(string[] args)
    {
        Person student1 = new Person
        {
            Name = "Selena",
            Surname = "Gomez",
            DateOfBirth = new DateTime(1992, 7, 22)
        };

        Person student2 = new Person
        {
            Name = "Justin",
            Surname = "Bieber",
            DateOfBirth = new DateTime(1994, 3, 1)
        };

        Person teacher1 = new Person
        {
            Name = "Demi",
            Surname = "Lovato",
            DateOfBirth = new DateTime(1992, 8, 20)
        };

        Person teacher2 = new Person
        {
            Name = "Miley",
            Surname = "Cyrus",
            DateOfBirth = new DateTime(1992, 11, 23)
        };

        student1.Info();
        student2.Info();
        teacher1.Info();
        teacher2.Info();

    }
}