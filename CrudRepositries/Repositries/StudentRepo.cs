using CrudRepositries.Models;
using CrudRepositries.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CrudRepositries.Repositries
{
    public class StudentRepo
    {
        private readonly StudentContext serr;
        public StudentRepo(StudentContext ser)
        {

        this.serr = ser;

        }
        public void AddData(Student formdata)
        {
            serr.Student.Add(formdata);
            serr.SaveChanges();
        }

        public List<Student> Viewdetails()
        {
            List<Student> allstudents = new List<Student>();   
            foreach (Student item in serr.Student)
            {
                    allstudents.Add(item);
            }
            return allstudents;

        }
        public void DeleteRecord(int id)
        {
          var obj = serr.Student.Where(item=>item.id == id).FirstOrDefault();
          serr.Student.Remove(obj);
          serr.SaveChanges();
        }
        public Student ViewAllDetails(int id )
        {
            Student obj = serr.Student.Find(id);
            serr.SaveChanges();
            return obj;
        }
        public Student Editt(int id)
        {
            Student obj = serr.Student.Find(id);
            serr.SaveChanges();
            return obj;
        }
        public void Update(Student formdata)
        {
            Student obj=serr.Student.Where(item=> item.id  == formdata.id).FirstOrDefault();
            
            obj.standard=formdata.standard;
            obj.rollno=formdata.rollno;
            obj.name=formdata.name;
            obj.DOB = formdata.DOB;

            serr.SaveChanges();
        }
    }
}
