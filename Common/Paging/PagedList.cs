using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Common.Paging
{
    public class PagedList<T> : List<T>
    {
        public int CurrentPage { get; set; }
        public int PageSize { get; set; }
        public int TotalPages { get; set; }
        public int TotalCount { get; set; }
        public bool HasPrevious => CurrentPage > 1;
        public bool HasNext => CurrentPage < TotalPages;
        public PagedList(List<T> items, int count, int pageNumber, int pageSize)
        {
            CurrentPage = pageNumber;
            PageSize = pageSize;
            TotalCount = count;
            TotalPages = (int)Math.Ceiling(count / (double)pageSize);
            AddRange(items);
        }
        public static async Task<PagedList<T>> ToPagedListAsync(IOrderedQueryable<T> source, int pageNumber, int pageSize)
        {
            var count = source.Count();
            var items = await source.Skip((pageNumber - 1) * pageSize)
                                    .Take(pageSize)
                                    .ToListAsync();
            return new PagedList<T>(items, count, pageNumber, pageSize);
        }
        public static async Task<PagedList<T>> ToPagedListAsync(IOrderedQueryable<T> source, PagingParameters pagingParameters)
        {
            var count = source.Count();
            var items = await source.Skip((pagingParameters.PageNumber - 1) * pagingParameters.PageSize)
                                    .Take(pagingParameters.PageSize)
                                    .ToListAsync();
            return new PagedList<T>(items, count, pagingParameters.PageNumber, pagingParameters.PageSize);
        }
    }
}
