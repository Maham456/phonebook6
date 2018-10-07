using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PhonBook2.Controllers
{
    public class HomeController : Controller
    {
        //static int num = 0;
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [Authorize]
        public ViewResult PersonDetails()
        {
            // Person dbObj = new Person();
            // dbObj.PersonId = ICollection. ;
          /*  PhoneBookDbEntities1 db = new PhoneBookDbEntities1();
            List<Person> list = db.People.ToList();
            List<Person> viewlist = new List<Person>();
            Person obj = new Person();
            Person 
            
                s.PersonId = s.PersonId;
                obj.FirstName = s.FirstName;
                obj.MiddleName = s.MiddleName;
                obj.LastName = s.LastName;
                obj.HomeAddress = s.HomeAddress;
                obj.HomeCity = s.HomeCity;
                obj.LinkedInId = s.LinkedInId;
                obj.TwitterId = s.TwitterId;
                obj.FaceBookAccountId = s.FaceBookAccountId;
                obj.EmailId = s.EmailId;
                obj.AddedBy = s.AddedBy;
                obj.AddedOn = DateTime.Now;


            
            db.People.Add(obj);
            db.SaveChanges();*/

            return View();
        }
        [Authorize]
        public ViewResult add_contacts()
        {
            /*PhoneBookDbEntities1 db = new PhoneBookDbEntities1();
            List<Contact> list = db.Contacts.ToList();
            List<Contact> viewlist = new List<Contact>();
            Contact obj = new Contact();
            foreach (Contact s in list)
            {
                obj.ContactNumber = s.ContactNumber;
                obj.ContactId = s.ContactId;
                obj.Type = s.Type;
                obj.PersonId = s.PersonId;
            }
            db.Contacts.Add(obj);
            db.SaveChanges();*/
            return View();
        }
        [Authorize]
        public ActionResult Dashboard()
        {
            // var people = db.People.Include(p => p.AspNetUser);
           
           // PhoneBookDbEntities1 db = new PhoneBookDbEntities1();
          //  foreach (Person p in PhoneBookDbEntities1.People)
           //     List<Person> list = db.People.ToList();

             
            return View();
        }

    }
}