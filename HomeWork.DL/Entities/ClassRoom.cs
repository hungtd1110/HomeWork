using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.DL.Entities
{
    public class ClassRoom : BaseEntity
    {
        #region property
        public int ClassID { get; set; }
        public string ClassName { get; set; }
        public string GradeApply { get; set; }
        public int SchoolYear { get; set; }
        #endregion property

        #region relationship
        public List<Student> Students { get; set; }
        #endregion relationship
    }
}
