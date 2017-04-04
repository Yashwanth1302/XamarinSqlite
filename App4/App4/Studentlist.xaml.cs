using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace App4
{
    public partial class Studentlist : ContentPage
    {
      public  StudentDB studentdb;

        public Studentlist()
        {
            InitializeComponent();

            studentdb = new StudentDB();
            var stu = studentdb.GetStudents();
            
            listviewstudentlist.ItemsSource = stu;
            
        }
        public Studentlist(int id)
        {            
            studentdb = new StudentDB();
            Student stu = studentdb.GetStudent(id);
            List<Student> sb=new List<Student>();
            sb.Add(new Student { Address = stu.Address });
           //sb.Add(new Student { Phone = stu.Phone });
            listviewstudentlist.ItemsSource = sb;
        }


    }
}
