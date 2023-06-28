using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace oniovosa_classAssignment
{
    internal class Student
    {
        public string FullName { get; set; }
        public string Course { get; set; }
        public string Subjet { get; set; }
        public string University { get; set; }
        public  string EMail { get; set; }  
        public int PhoneNumber { get; set; }
        public static int count;

        public Student (string name, string course, string subject, string university, string email, int phonenumber)
        {
            FullName = name;
            Course = course;
            Subjet = subject;
            University = university;
            EMail = email;
            PhoneNumber = phonenumber;
            count++;
        }

        public Student (string name, string course, string subject)
        {
            FullName= name;
            Course = course;
            Subjet = subject;
            University= null;
            EMail = null;
            PhoneNumber = null;
            count++;

        }

        public Student (string name)
        {
            FullName = name;
            Course= null;
            Subjet = null;
            EMail= null;
            PhoneNumber = 0;
            count++;
        }

        public void StudentInformation ()
        {
            Console.WriteLine($"Full Name: {FullName}");
            Console.WriteLine($"Course: {Course}");
            Console.WriteLine($"Subject: {Subjet}");
            Console.WriteLine($"University: {University}");
            Console.WriteLine($"E-mail: {EMail}");
            Console.WriteLine($"Phone Number: {PhoneNumber}");
        }


    }
}
