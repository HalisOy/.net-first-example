using Example;
using FirstExample.Class;
using FirstExample.Extensions;
using FirstExample.Models;
using Newtonsoft.Json;

var personalUsers = JsonConvert.DeserializeObject<IList<Personal>>(Datas.PersonalJson);
var studentUsers = JsonConvert.DeserializeObject<IList<Student>>(Datas.StudentJson);
var jobberUsers = JsonConvert.DeserializeObject<IList<Jobber>>(Datas.JobberJson);

IDictionary<string, IBaseUser> personalList = new Dictionary<string, IBaseUser>();
IDictionary<string, IBaseUser> studentList = new Dictionary<string, IBaseUser>();
IDictionary<string, IBaseUser> jobberList = new Dictionary<string, IBaseUser>();
IDictionary<string, IList<string>> search = new Dictionary<string, IList<string>>();

personalList.AddToDictionary(personalUsers.Select(user => user as IBaseUser).ToList(), search);
studentList.AddToDictionary(studentUsers.Select(user => user as IBaseUser).ToList(), search);
jobberList.AddToDictionary(jobberUsers.Select(user => user as IBaseUser).ToList(), search);

Console.Write("Lütfen Username giriniz:");
string getSearchValue = Console.ReadLine();
IList<IPersonal> GetPersonalsData = new List<IPersonal>();
IList<IStudent> GetStudentsData = new List<IStudent>();
IList<IJobber> GetJobbersData = new List<IJobber>();


if (search.ContainsKey(getSearchValue))
{
    search[getSearchValue].ToList().ForEach(userName =>
    {
        GetPersonalsData.FindandAddControl(personalUsers, user => user.UserName == userName);
        GetStudentsData.FindandAddControl(studentUsers, user => user.UserName == userName);
        GetJobbersData.FindandAddControl(jobberUsers, user => user.UserName == userName);

        //IPersonal personal = personalUsers.Find(user => user.UserName == userName);
        //IStudent student = studentUsers.Find(user => user.UserName == userName);
        //IJobber jobber = jobberUsers.Find(user => user.UserName == userName);

        //if (personal != null)
        //    GetPersonalsData.Add(personal);
        //if (student != null)
        //    GetStudentsData.Add(student);
        //if (jobber != null)
        //    GetJobbersData.Add(jobber);


        //GetStudentsData.Add(studentUsers.Where(item => item.Id == Convert.ToInt32(userId)));
        //Console.WriteLine(JsonConvert.SerializeObject(studentUsers.Where(item => item.Id == Convert.ToInt32(userId))));
    });
}
else
    Console.WriteLine("böyle bir kayıt yok");

Console.WriteLine("Personals");
GetPersonalsData.ToList().ForEach(item =>
{
    Console.WriteLine(JsonConvert.SerializeObject(item));
});
Console.WriteLine("------------------------------------");
Console.WriteLine("Students");
GetStudentsData.ToList().ForEach(item =>
{
    Console.WriteLine(JsonConvert.SerializeObject(item));
});
Console.WriteLine("------------------------------------");
Console.WriteLine("Jobbers");
GetJobbersData.ToList().ForEach(item =>
{
    Console.WriteLine(JsonConvert.SerializeObject(item));
});