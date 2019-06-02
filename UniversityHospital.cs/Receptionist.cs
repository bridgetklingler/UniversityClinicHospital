﻿using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityHospital.cs
{
    class Receptionist : Employee
    {

        public string OnPhone { get; set; }

        public Receptionist(string name, int number, string phone, string patientNumber) : base()
        {
            Name = name;
            EmployeeNumber = number;
            Salary = "$45,000";
            OnPhone = phone;
            Position = "Receptionist";
            NumberOfPatients = patientNumber;
        }

        //static function in this class

    }
}
