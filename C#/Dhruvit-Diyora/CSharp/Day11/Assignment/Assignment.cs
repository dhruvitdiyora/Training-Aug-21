using Day11.AssignModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day11
{
    class Assignment
    {
        static void Main(string[] args)
        {
            using (var context = new HealthCareContext())
            {
                //Insert a Doctor
                var doctor = new Doctor()
                {
                    DoctorFirstName="Dhruvit",
                    DoctorLastName="Diyora",
                    DocDepartmentId=1,
                    IsActive=true
                };
                context.Doctors.Add(doctor);
                //Update a Doctor
                var updateDoctor = context.Doctors.First<Doctor>();
                updateDoctor.DoctorFirstName = "Hello";

                //Delete a Doctor
                var delDoctor = context.Doctors.Find(1);
                context.Remove(delDoctor);

                context.SaveChanges();


                //Find a report of patient assigned to a particular doctor
                var reports = context.Treatments.Include(x => x.Patient).Include(x => x.Doctor).Where(x => x.DoctorId == 2);
                foreach (var item in reports)
                {
                    Console.WriteLine("Patient : " + item.Patient.PatientFirstName + ", Doctor : " +item.DoctorId);
                }


                //Display summary report of Doctor and patient (use Include method)
                var rep = context.Treatments.Include(x => x.Patient).Include(x => x.Doctor).Where(x => x.Doctor != null);
                foreach (var item in rep)
                {
                    Console.WriteLine("Patient : " + item.Patient.PatientFirstName + ", Doctor : " + item.Doctor.DoctorFirstName);
                }
            }
        }
    }
}
