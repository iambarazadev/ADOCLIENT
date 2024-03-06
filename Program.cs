using ADOCLIENT.DTO;
using ADOCLIENT.ServicesRepos;

class App
{
    public static async Task Main(string[] args)
    {
        StudentDto student = new();
        ClientRepo client = new();

        Console.WriteLine("\n STUDENT MENU \n");


        //var _student = await client.GetStudentAsync(2);
        //var _students = await client.GetAllStudentsAsync();
        //var _feedback = await client.CreateAsync(student);

        Console.WriteLine("\n");
        Console.ReadKey();
    }
}