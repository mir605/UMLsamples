using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLdiagramQuestion1
{
    class Program
    {
        

        public class Person
        {
            public string Name { get; set; }
            public string PhoneNumber { get; set; }
            public string EmailAddress { get; set; }

            public void PurchaseParkingPass()
            {
               
                Console.WriteLine("Park etme bileti satın aldınız");
            }
        }

        
        public class Address
        {
            public string Street { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public string Country { get; set; }
            public string PostalCode { get; set; }

            public bool Validate()
            {
               
                return true;
            }

            public string OutputAsLabel()
            {
                // Output address as a label format
                return $"{Street}, {City}, {State}, {Country}, {PostalCode}";
            }
        }

       
        public class Student : Person
        {
            public int StudentNumber { get; set; }
            public int AverageMark { get; set; }

            public bool IsEligibleToEnroll(string course)
            {
                
                return true;
            }

            public int GetSeminarsTaken()
            {
               
                return 0; 
            }
        }

        
        public class Professor : Person
        {
            protected int Salary { get; set; }
            protected int StaffNumber { get; set; }
            private int YearsOfService { get; set; }
            public int NumberOfClasses { get; set; }
        }
    }
    }


