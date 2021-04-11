using HomeWork.DL.Entities;
using HomeWork.DL.Enum;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.DL.Configuration
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.ToTable("Students");

            builder.HasKey(student => student.StudentID);

            builder.Property(student => student.StudentName)
                .IsUnicode()
                .IsRequired();

            builder.Property(student => student.Status)
               .HasDefaultValue(EnumStudentStatus.Study);

            builder.Property(student => student.CreatedDate)
               .HasDefaultValue(DateTime.Now);

            builder.HasOne(Student => Student.ClassRoom)
                .WithMany(classroom => classroom.Students)
                .HasForeignKey(student => student.ClassID);
        }
    }
}
