using HomeWork.DL.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.DL.Entities
{
    public class Student : BaseEntity
    {
        #region property
        public Guid StudentID { get; set; }
        public string StudentName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public EnumStudentStatus Status { get; set; }
        #endregion property

        #region relationship
        public int ClassID { get; set; }
        public ClassRoom ClassRoom { get; set; }
        #endregion relationship
    }
}
