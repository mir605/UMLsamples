using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLdiagramQuest5
{
    class Program
    {
     

        public class Transaction
        {
              protected int Id { get; set; }
            public string Name { get; set; }
            public string Date { get; set; }
             public string Address { get; set; }

            public void Update()
            {
               
                Console.WriteLine("İşlem yüklendi.");
            }
        }

      
        public class Reservation
        {
              protected int Id { get; set; }
            public string Details { get; set; }
            public List<string> Items { get; set; }

              public Reservation()
            {
                Items = new List<string>();
            }

            public void Confirmation()
            {
               
                Console.WriteLine("Rezervasyon yapıldı.");
            }
            }




       
        public class RentingOwner
        {
            protected int Id { get; set; }
            public string Name { get; set; }


            public int Age { get; set; }
              public string ContactNum { get; set; }
            private string Username { get; set; }
            private string Password { get; set; }

            public void VerifyAccount()
            {
                
                Console.WriteLine("Hesap onaylandı.");
            }
        }
        public class Car
        {
             protected int Id { get; set; }
            public string Details { get; set; }
            public string OrderType { get; set; }

            public void ProcessDebit()
            {
               
                Console.WriteLine("Para gönderildi.");
            }
        }

        public class Customer
        {
            protected int Id { get; set; }

             public string Name { get; set; }
            public string Contact { get; set; }
            public string Address { get; set; }
            protected int Payment { get; set; }



            protected void Update()
            {
                
                Console.WriteLine("Müşteri bilgileri yüklendi.");
            }
        }

        
        public class Payment
        {
            public int Id { get; set; }

            public int CardNumber { get; set; }
            public string Amount { get; set; }

            public void Add()
            {
               
                Console.WriteLine("Payment added.");
            }

            public void Update()
            {
                
                Console.WriteLine("Payment updated.");
            }
        }

      
         public class Rentals
     {
            protected int Id { get; set; }
            public string Name { get; set; }

            public string Price { get; set; }

            public void Add()
            {
              
                Console.WriteLine("Kiralık eklendi.");
            }

            public void Update()
            {
              
                Console.WriteLine("Kiralık yüklendi.");
            }
        }

        
        
          
        }

    }

