using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ContactsService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class ContactService : IContactService
    {
        List<Contact> list = new List<Contact>()
        {
                new Contact() { Id = 1, FName = "Yuvraj", LName = "Dalvi", DOB = new DateTime(2005, 4, 3), Gender = Gender.Male, Hobbies = new List<Hobby>() { Hobby.Cricket, Hobby.Tennis }},
                new Contact() { Id = 2, FName = "Laxmi", LName = "Dalvi", DOB = new DateTime(1978, 6, 30), Gender = Gender.Female, Hobbies = new List<Hobby>() { Hobby.Cooking, Hobby.Movies }}
        };

        public void Delete(int id)
        {
            list.Remove(list.First(x => x.Id == id));
        }
        private Contact GetModel(int? id = null)
        {            
            var model = (id.HasValue) ? list.First(x => x.Id == id) : new Contact();
            return model;
        }

        public Contact Details(int id)
        {
            return GetModel(id);
        }

        public void Insert(Contact item)
        {
            list.Add(item);
        }

        public List<Contact> List()
        {
            return list;
        }

        public void Update(int id, Contact contact)
        {
            list.Remove(list.First(x => x.Id == contact.Id));
            list.Add(contact);
        }
    }
}
