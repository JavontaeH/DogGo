using System.Collections.Generic;
using DogGo.Models;
using Microsoft.Data.SqlClient;

namespace DogGo.Repositories
{
    public interface IOwnerRepository
    {
        List<Owner> GetAllOwners();
        Owner GetOwnerById(int id);

        void AddOwner(Owner owner);

        Owner GetOwnerByEmail(string email);

        void UpdateOwner(Owner owner);

        void DeleteOwner(int id);
    }
}