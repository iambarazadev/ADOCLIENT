using ADOCLIENT.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOCLIENT.ServicesRepos
{
    internal interface IClient
    {
        Task<bool?> CreateAsync(StudentDto student);
        Task<StudentDto> GetStudentAsync(int Id);
        Task<List<StudentDto>> GetAllStudentsAsync();
    }
}
