using SQLite;
using System;
using System.IO;
using Xamarin.Forms;
//using System.Net.Http;
//using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace App4
{
    public partial class Register : ContentPage
    {
        public StudentDB studentdb;
        public Student student;
        public SkuMaster _SkuMaster;
        //string name_reg, address_reg, phoneno;
        public Register()
        {
            InitializeComponent();
        }
        public async void adddata(Object o, EventArgs e)
        {
            //string folder = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            //var conn = new SQLiteConnection(System.IO.Path.Combine(folder, "stocks.db"));
            //conn.CreateTable<Student>();
            //conn.CreateTable<Valuation>();
            // string path = db.DatabasePath;
            await GetConferences().ConfigureAwait(false);
            studentdb = new StudentDB();
            student = new Student();
            _SkuMaster = new SkuMaster();
           
            // this result string should be something like: "{"token":"rgh2ghgdsfds"}"
            
            //student.Id =Convert.ToInt32(id1.Text);
            student.Name = name.Text;

            student.Address = address.Text;
            student.Phone = phone.Text;
            studentdb.AddStusent(student);
            //studentdb.UpdateStudent(student);
            //studentdb.DeleteStudent(Convert.ToInt32(student.Name));
        }
        public async Task GetConferences()
        {
           // var client = new HttpClient();
           // client.BaseAddress = new Uri("http://172.31.0.61/fleximaster/api/FlexiMasters");
            
           //// string jsonData = @"{""MasterNumber"" : ""12"", ""FromNo"" : ""1"", ""ToNo"" : ""500""}";

           //// var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
           // //var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
           // HttpResponseMessage response = await client.PostAsync("http://172.31.0.61/fleximaster/api/FlexiMasters", content);
           // //HttpResponseMessage response = await client.PostAsync("http://172.31.0.61/fleximaster/api/FlexiMasters", content);
           // var result = await response.Content.ReadAsStringAsync();

            //var result = await response.Content.ReadAsStringAsync();

        }
        public void updatedata(Object o, EventArgs e)
        {
            //string folder = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            //var conn = new SQLiteConnection(System.IO.Path.Combine(folder, "stocks.db"));
            //conn.CreateTable<Student>();
            //conn.CreateTable<Valuation>();
            // string path = db.DatabasePath;

            studentdb = new StudentDB();
            student = new Student();
            student.Id = Convert.ToInt32(id1.Text);
            student.Name = name.Text;

            student.Address = address.Text;
            //student.Phone = phone.Text;
            //studentdb.AddStusent(student);
            studentdb.UpdateStudent(student);
            //studentdb.DeleteStudent(Convert.ToInt32(student.Name));
        }
        public void Getdata(Object o, EventArgs e)
        {
            studentdb = new StudentDB();
            Student stu = studentdb.GetStudent(Convert.ToInt32(id1.Text));
            name.Text= stu.Name;
            address.Text= stu.Address;
            phone.Text= stu.Phone;            
        }
        public void showdata(Object o, EventArgs e)
        {
            Navigation.PushModalAsync(new Studentlist());//Studentlist(Convert.ToInt32(name.Text)));
        }

    }
}
