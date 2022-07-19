using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.Interfaces
{
    public interface ILibraryService
    {
        Library Create(Library library);
        Library Update(int id, Library library);
        void Delete(int id);
        Library GetById(int id);
        List<Library> GetAll();

    }
}
