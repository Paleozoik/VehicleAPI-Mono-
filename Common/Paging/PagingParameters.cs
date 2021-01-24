using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Paging
{
    public class PagingParameters
    {
        public const int maxPageSize = 10; //hardcoded (Možda treba promjena)
        public int PageNumber { get; set; } = 1;
        private int _pageSize = 5;
        public int PageSize
        {
            get { return _pageSize; }
            set { _pageSize = (value > maxPageSize) ? maxPageSize : value; }
        }
    }
}
