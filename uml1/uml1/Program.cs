using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class uml1
{
    class Program
    {

        static void Main(string[] args)
        {


        }

      
    }
      //main sınıfındaki kalabalığı azaltmak için metotlar

        //kullanıcıdan data alma metotları
        public static class Input
    {
        public static string StringInput(string input) {
            Console.WriteLine(input);
            return Console.ReadLine();
        }

        public static int IntInput(string input)
        {
            Console.WriteLine(input);
            return Convert.ToInt32(Console.ReadLine());

        }
    }
     private Student studentİnfos()
    {
        string name = Input.StringInput("Öğrencinin adı: ");
        string phoneNumber= Input.StringInput("Öğrencinin telefon numarası: ");
        string emailAddress = Input.StringInput("Öğrencinin e posta adresi: ");
        int studentNumber = Input.IntInput("öğrencinin okul numarası: ");
        int avarageMark = Input.IntInput("ortlama: ");

        return new Student
        {
            Name = name,
            PhoneNumber = phoneNumber,
            EmailAddress = emailAddress,
            StudentNumber = studentNumber,
            AvarageMark = avarageMark

        };
    }
}

 
public class Address
{
    public string Street { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public int PostalCode { get; set; }
    public string Country { get; set; }



    private bool Validate()
    {
        return !string.IsNullOrEmpty(Street) & !string.IsNullOrEmpty(Country) & !string.IsNullOrEmpty(City) & !string.IsNullOrEmpty(State);
    }

    public string OutPutLabel()
    {
        return $"{Street} {City} {State} {PostalCode} {Country}";
    }
}

public class Person
{
    public string Name { get; set; }
    public string PhoneNumber { get; set; }
     
    public string EmailAddress { get; set; }

    public void PurchaseParkingPass()
    {
        Console.WriteLine($"{Name} parka girebilir");

    }

}

public class Student : Person
{
    public int StudentNumber { get; set; }
    private int AvarageMark { get; set; }

   
    public bool isEligibleToEnroll(string courseName)
    {
        return AvarageMark > 60;
    }

    public int GetSeminarsTaken()
    {
        return 5;
    }

}
public class Professor: Person
{
    public int salary { get; set; }
    protected int studentNumber { get; set; }
    private int YearOfService { get; set; }
    public int numberOfClasses { get; set; }
}