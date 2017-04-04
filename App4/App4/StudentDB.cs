using System.Collections.Generic;
using System.Linq;
using SQLite.Net;
using Xamarin.Forms;

namespace App4
{
    public class StudentDB
    {
        private SQLiteConnection _sqlconnection;

        public StudentDB()
        {
            //Getting conection and Creating table  
            _sqlconnection = DependencyService.Get<ISQLite>().GetConnection();
            _sqlconnection.CreateTable<Student>();
            _sqlconnection.CreateTable<SkuMaster>();
        }

        //Get all students  
        public IEnumerable<Student> GetStudents()
        {
            return (from t in _sqlconnection.Table<Student>() select t).ToList();
        }
        public IEnumerable<SkuMaster> GetSkuMaster()
        {
            //return (from t in _sqlconnection.Table<Student>() select t).ToList();
            return (from t in _sqlconnection.Table<SkuMaster>() select t).ToList();
        }

        //Get specific student  
        public Student GetStudent(int id)
        {
            return _sqlconnection.Table<Student>().FirstOrDefault(t => t.Id == id);
            //return (from t in _sqlconnection.Table<Student>() select t).ToList();
        }
        //Delete specific student  
        public void DeleteStudent(int id)
        {
            _sqlconnection.Delete<Student>(id);

        }
        public void UpdateStudent(Student id)
        {
            // _sqlconnection.InsertOrReplace(id);
            _sqlconnection.Update(id);
        }
        //Add new student to DB  
        public void AddStusent(Student student)
        {
            _sqlconnection.Insert(student);
        }
    }
}