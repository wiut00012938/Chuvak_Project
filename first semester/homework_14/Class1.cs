﻿using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_14
{
    public class Applicant
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Address { get; set; }

        public DateTime DoB { get; set; }

        public bool IsMarried { get; set; }

        public string PassportNo { get; set; }

        public Course Course { get; set; }

        public Applicant()
        {
            IsMarried = false;
        }

        public Applicant(string name, string surname, string address, DateTime doB, bool isMarried, string passportNo, Course course)
        {
            Name = name;
            Surname = surname;
            Address = address;
            DoB = doB;
            IsMarried = isMarried;
            PassportNo = passportNo;
            Course = course;
        }
    }
}
