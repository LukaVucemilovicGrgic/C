﻿using OOpBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace OOpBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Console.WriteLine("Enter student info: ");
            Student firstStudent = new Student()
            { FirstName = "Luka", LastName = "VG" };
            //firstStudent.FirstName = "Luka";
            //firstStudent.LastName = "VG";

            //firstStudent.Address = new Address();
            //firstStudent.Address.City = "Osijek";
            //firstStudent.Address.State = "Croatia";
            //firstStudent.Address.Zip = 31000;

            firstStudent.Address = new Address()
            { City = "Osijek", State = "Croatia", Zip = 31000 };


            Console.WriteLine("First student information:\n " + firstStudent.FirstName  + firstStudent.LastName);
            Console.WriteLine(firstStudent.GetAddress());


            //---ENTERING DATA FROM CONSOLE---

            //Console.WriteLine("Let's create a new student!");
            //Student newStudent = new Student();

            //Console.WriteLine("Enter first name: ");
            //newStudent.FirstName = Console.ReadLine();

            //Console.WriteLine("Enter last name: ");
            //newStudent.LastName = Console.ReadLine();

            //Console.WriteLine("Enter cours: ");
            //string course = Console.ReadLine();
            //newStudent.Course = course;

            //Console.WriteLine("Enter index number: ");
            //long indexNumber  = Int64.Parse(Console.ReadLine());
            //newStudent.IndexNumber = indexNumber;

            //Console.WriteLine($"New student information :\nFirstName: {newStudent.FirstName}" +
            //    $"\nLastName: {newStudent.LastName} \nCourse: {newStudent.Course}" +
            //    $"\nIndexNumber: {newStudent.IndexNumber}");

            //Console.ReadLine();

            //---ADDRESS OVERRIDE---

            Professor professor = new Professor()
            { FirstName = "Petra", LastName = "Mitevski", DOB = new DateTime(1980-03-09)};

            professor.Address = new Address
            { State = "Croatia", City = "Zagreb", Zip = 10000 };

            Console.WriteLine($"\nProfessor data:\nFirstName: {professor.FirstName}" +
                $"\nLastName: {professor.LastName} \nDOB: {professor.DOB}");

            //  -----------------LISTE--------------------- 

            //List<Subject> listOfSubjects = new List<Subject>();
            //Subject subject = new Subject();
            //string escapeKey = "1";
            //do
            //{
            //    //Subject subject = new Subject();

            //    Console.WriteLine("Enter subject's name: ");
            //    subject.Name = Console.ReadLine();

            //    Console.WriteLine("Generate professor's id: ");
            //    subject.ProfesorId = Guid.NewGuid();
            //    Console.WriteLine(subject.ProfesorId);

            //    listOfSubjects.Add(subject);

            //    Console.WriteLine("To finish, press 1. To continue, press any key.");
            //    escapeKey = Console.ReadLine();

            //}
            //while (escapeKey != "1");

            //Console.WriteLine("---PRINTING OF THE LIST---");
            //Console.ReadLine();

            //foreach (Subject sub in listOfSubjects)
            //{
            //    Console.WriteLine($"Subject: {sub.Name} \nProfesorId: {sub.ProfesorId}\n");
            //}
            //Console.ReadLine();
        }
    }
}