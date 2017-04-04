using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net.Attributes;
namespace App4
{
    public class Student
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        public Student()
        {
        }
    }
    public class SkuMaster
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string SkuCode { get; set; }
        public string SkuDesc { get; set; }
        
    }
}
