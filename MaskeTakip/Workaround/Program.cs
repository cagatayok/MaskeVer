using Business.Concrete;
using Entities.Concrete;
using System;

namespace Workaround
{
    class Program
    {
        static void Main(string[] args) 
        {
            Person person=new Person();
            person.FirstName = "Çağatay";
            person.LastName = "Ok";
            person.DateOfBirthDay = 2004;
            person.NationalIdentitiy = 123;

            PttManager pttManager =new PttManager(new PersonManager());
            pttManager.GiveMask(person);


        }
    }

    
}