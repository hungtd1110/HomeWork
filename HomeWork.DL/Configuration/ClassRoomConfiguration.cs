using HomeWork.DL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.DL.Configuration
{
    class ClassRoomConfiguration : IEntityTypeConfiguration<ClassRoom>
    {
        public void Configure(EntityTypeBuilder<ClassRoom> builder)
        {
            builder.ToTable("ClassRooms");

            builder.HasKey(classroom => classroom.ClassID);

            builder.Property(classroom => classroom.ClassID)
                .UseIdentityColumn();

            builder.Property(classroom => classroom.ClassName)
                .IsRequired();

            builder.Property(student => student.CreatedDate)
               .HasDefaultValue(DateTime.Now);

            builder.HasMany(classroom => classroom.Students)
                .WithOne(classroom => classroom.ClassRoom);
        }
    }
}
