using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes__Structs__and_Records
{
    public interface IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        public int Id { get; set; }
        
        public Age Age { get; set; }
    }


    // class - reference types.
    public class Employee : IPerson
    {
        public Employee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        public int Id { get; set; }

        public Age Age { get; set; }

        // Employee specific properties.
        public int EmployeeId { get; set; }
        public DateOnly StartDate { get; set; }
        public TimeOnly ShiftStartTime { get; set; }

    }

    public class Manager : Employee, IPerson
    {
        public Manager(string firstName, string lastName) : base(firstName, lastName)
        {
        }

        public int NumberOfDirectReports { get; set; }

    }

    // ----------------- Structs in C# ------------------------------- //

    // structs can't have base classes. 
    public struct Age
    {
        public DateTime BirthDate { get; set; }
        public int YearsOld { get; set; }
    }

    // structs can implement interface.
    public struct VendorContact : IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int Id { get; set; }

        public Age Age { get; set; }
    }

    // records in C#.
    /*
     * 1. records in C# are used for scenarios where you need immutable objects.
     * 2. records behave almost like classes.
     * 3. One of the use cases might be transferring data between different micro-services.
     **/
    public record class Customer : IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int Id { get; set; }

        public Age Age { get; set; }
    }

    public record class PremiereCustomer : Customer
    {
        public byte CustomerLevel { get; init; }
    }

    // In C# 10, now you can create record struct too.
    public record struct Order
    {
        public int OrderId { get; set; }
        public DateOnly OrderDate { get; set; }

    }

    public record struct RecurringOrder
    {

    }
}
