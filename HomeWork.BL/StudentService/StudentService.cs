using HomeWork.BL.Base;
using HomeWork.DL.EFContext;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using HomeWork.DL.Entities;

namespace HomeWork.BL.StudentService
{
    public class StudentService : IStudentService
    {
        private readonly HomeWorkDBContext _context;

        public StudentService(HomeWorkDBContext context)
        {
            _context = context;
        }

        public async Task<Student> Create(StudentRequest request)
        {
            var student = new Student();

            _context.Students.Add(student);
            await _context.SaveChangesAsync();

            return student;
        }

        public Task<Student> Delete(Guid studentID)
        {
            throw new NotImplementedException();
        }

        public Task<Student> GetStudentByStudentID(Guid studentID)
        {
            throw new NotImplementedException();
        }

        public Task<List<Student>> GetStudents()
        {
            throw new NotImplementedException();
        }

        public Task<PagingData<Student>> GetStudentsPaging(string where, int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public Task<Student> Update(StudentRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
