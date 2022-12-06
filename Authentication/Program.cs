using Authentication.Abstract;
using Authentication.Adapters;
using Authentication.Concrete;
using Authentication.Entities;

BaseCustomerManager customerManager = new NeroCustomerManager(new MernisServiceAdapter());
customerManager.Save(new Customer { DateOfBirth = new DateTime(1998,11,8), FirstName = "Rümeysa", LastName = "ÖZDEMİR", NationalityId = "1114456998"} );
Console.ReadLine();