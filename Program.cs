using System;

namespace classMetotDem
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.Name = "Aslıhan";
            customer1.LastName = "Derin";
            customer1.City = "Elazığ";
            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.Name = "Şeydanur";
            customer2.LastName = "Derin";
            customer2.City = "Balıkesir";
            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.Name = "Sevim";
            customer3.LastName = "Gül";
            customer3.City = "Ankara";
            Customer customer4 = new Customer();
            customer4.Id = 4;
            customer4.Name = "Abidin";
            customer4.LastName = "Hekim";
            customer4.City = "Çorum";

            Customer[] customers = new Customer[] { customer1, customer4, customer2, customer3 };

            Console.WriteLine("Adınız ? ");
            string name = Console.ReadLine();

            foreach (var customer in customers)
            {
                if (name == "Aslıhan")
                {
                    Console.WriteLine(name + " hanım bankamıza hoşgeldiniz ");
                    Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz ");
                    Console.WriteLine("Yeni Hesap : 1 \n" + "Hesap Silme : 2 " );
                    int secim = Convert.ToInt32(Console.ReadLine());
                    CustomerManager manager = new CustomerManager();
                    if (secim ==1)
                    {
                        manager.Add(customer1);
                    }
                    else
                    {
                        manager.Delete(customer1);
                    }
                    break;                 
                    
                }
                if (name == "Şeydanur")
                {
                    Console.WriteLine(name +" hanım bankamıza hoşgeldiniz ");
                    Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz ");
                    Console.WriteLine("Yeni Hesap : 1 \n" + "Hesap Silme : 2 ");
                    int secim = Convert.ToInt32(Console.ReadLine());
                    CustomerManager manager = new CustomerManager();
                    if (secim == 1)
                    {
                        manager.Add(customer2);
                    }
                    else
                    {
                        manager.Delete(customer2);
                    }
                    break;

                }
                if (name == "Sevim")
                {
                    Console.WriteLine(name + " hanım bankamıza hoşgeldiniz ");
                    Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz ");
                    Console.WriteLine("Yeni Hesap : 1 \n" + "Hesap Silme : 2 ");
                    int secim = Convert.ToInt32(Console.ReadLine());
                    CustomerManager manager = new CustomerManager();
                    if (secim == 1)
                    {
                        manager.Add(customer3);
                    }
                    else
                    {
                        manager.Delete(customer3);
                    }
                    break;

                }
                if (name == "Abidin")
                {
                    Console.WriteLine(name + " hanım bankamıza hoşgeldiniz ");
                    Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz ");
                    Console.WriteLine("Yeni Hesap : 1 \n" + "Hesap Silme : 2 ");
                    int secim = Convert.ToInt32(Console.ReadLine());
                    CustomerManager manager = new CustomerManager();
                    if (secim == 1)
                    {
                        manager.Add(customer4);
                    }
                    else
                    {
                        manager.Delete(customer4);
                    }
                    break;

                }
                else
                {
                    Console.WriteLine(name + " yeni hesap işlemine hoşgeldiniz.");                                      
                    Console.WriteLine("Soyadınız :");
                    string LastName = Console.ReadLine();
                    Console.WriteLine("Şehir :");
                    string City = Console.ReadLine();
                    customer.Name = name;
                    customer.LastName = LastName;
                    customer.City = City;
                    Console.WriteLine("Yeni hesabınız oluşturuldu.Teşekkürler");
                    break;
                }
            }           
            Console.ReadLine();

        }
    }
}
