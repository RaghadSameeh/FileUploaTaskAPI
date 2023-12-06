using DataAccessLayer.Data;
using DataAccessLayer.Models;
using DataAccessLayer.Reposatories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Reposatries.DataFileReposatry
{
    public class FileReposatry : GenericReposatory<DataFile>, IFileReposatry
    {
        private readonly Context _context;
        public FileReposatry(Context context) : base(context)
        {
            _context = context;
        }

        public List<DataFile> DataBasedOnKeyword(string keyword)
        {
            return _context.Data.Where(d=> d.keyword == keyword).ToList();
        }
    }
}
