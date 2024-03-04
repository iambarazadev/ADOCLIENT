using ADOCLIENT.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace ADOCLIENT.ServicesRepos
{
    internal class ClientRepo : IClient
    {
        private readonly HttpClient _httpClient;
        private string _uri;
        public ClientRepo() 
        {
            this._uri = "https://localhost:7095/";
            this._httpClient = new HttpClient();
            this._httpClient.BaseAddress = new Uri(this._uri);
        }

        // api/Student/CreateStudent/
        public async Task<bool?> CreateAsync(StudentDto student)
        {
            bool? _feedback = null;

            if( student is not null )
            {
                HttpResponseMessage _message = await _httpClient.PostAsJsonAsync($"api/Student/CreateStudent/",student);
                if( _message.IsSuccessStatusCode )
                {
                    _feedback = await _message.Content.ReadFromJsonAsync<bool>();
                }
            }

            return _feedback;
        }

        // api/Student/GetAllStudents/
        public async Task<List<StudentDto>> GetAllStudentsAsync()
        {
            List<StudentDto> _students = new();

            HttpResponseMessage _message = await _httpClient.GetAsync($"api/Student/GetAllStudents/");
            if( _message.IsSuccessStatusCode )
            {
                _students = await _message.Content.ReadFromJsonAsync<List<StudentDto>>() ?? new();
            }

            return _students;
        }

        // api/Student/GetStudent/{Id}
        public async Task<StudentDto> GetStudentAsync(int Id)
        {
            StudentDto _student = new();

            if( Id > 0 )
            {
                HttpResponseMessage _message = await _httpClient.GetAsync($"api/Student/GetStudent/{Id}");
                if (_message.IsSuccessStatusCode)
                {
                    _student = await _message.Content.ReadFromJsonAsync<StudentDto>() ?? new();
                }
            }

            return _student;
        }
    }
}