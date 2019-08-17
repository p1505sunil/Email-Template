using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DemoApp.Models.Student;
using System.Net;
using System.Net.Http;

namespace DemoApp.Controllers
{

    [Produces("application/json")]
    //[Route("api/StudentAPI")]
    public class StudentAPIController : Controller
    {
        // GET: api/StudentAPI/GetAllStudents
        //[HttpPost]
        [Route("api/StudentAPI/GetAllStudents")]
        public IEnumerable<PersonalDetail> GetAllStudents()
        {
            List<PersonalDetail> students = new List<PersonalDetail>
            {
            new PersonalDetail{
                               RegNo = "20454317-0001",
                               Name = "john",
                               Address = "texas",
                               PhoneNo = "454343",
                               AdmissionDate = DateTime.Now
                               },
            new PersonalDetail{
                               RegNo = "2015347-0002",
                               Name = "methal Rai",
                               Address = "gfield",
                               PhoneNo = "4353432532",
                               AdmissionDate = DateTime.Now
                              },
             new PersonalDetail{
                               RegNo = "20453417-0003",
                               Name = "sam",
                               Address = "gts",
                               PhoneNo = "45435326",
                               AdmissionDate = DateTime.Now
                              },

                             
              
                              
            };
            return students;
        }


        // GET: api/GetAll
        //[HttpPost]
        [Produces("application/json")]
        [Route("api/StudentAPI/GetAll")]
        public IList<PersonalDetail> GetAll()
        {
            List<PersonalDetail> students = new List<PersonalDetail>
            {
            new PersonalDetail{
                               RegNo = "20454317-0001",
                               Name = "john",
                               Address = "texas",
                               PhoneNo = "454343",
                               AdmissionDate = DateTime.Now
                               },
            new PersonalDetail{
                               RegNo = "2015347-0002",
                               Name = "methal Rai",
                               Address = "gfield",
                               PhoneNo = "4353432532",
                               AdmissionDate = DateTime.Now
                              },
             new PersonalDetail{
                               RegNo = "20453417-0003",
                               Name = "sam",
                               Address = "gts",
                               PhoneNo = "45435326",
                               AdmissionDate = DateTime.Now
                              },
              
            };
            return students;
        }
    }

}