using HomeWork.BL.Base;
using HomeWork.DL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.BL.StudentService
{
    interface IStudentService
    {
        Task<Student> Create(StudentRequest request);
        Task<Student> Update(StudentRequest request);
        Task<Student> Delete(Guid studentID);
        Task<List<Student>> GetStudents();
        Task<PagingData<Student>> GetStudentsPaging(string where, int pageIndex, int pageSize);
        Task<Student> GetStudentByStudentID(Guid studentID);
    }
}
