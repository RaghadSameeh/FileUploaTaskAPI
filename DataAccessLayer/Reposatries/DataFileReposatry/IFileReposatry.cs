using DataAccessLayer.Models;
using DataAccessLayer.Reposatories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Reposatries.DataFileReposatry
{
    public interface IFileReposatry : IGenericReposatory<DataFile>
    {
        public List<DataFile> DataBasedOnKeyword(string keyword);

    }
}
