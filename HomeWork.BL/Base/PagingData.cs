using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.BL.Base
{
    public class PagingData<T>
    {
        List<T> Items { get; set; }
        public int TotalItem { get; set; }
    }
}
