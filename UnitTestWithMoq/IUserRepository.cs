using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestWithMoq
{
    public interface IUserRepository
    {
        IList<User> GetAll();
        User GetById(int userId);
        void Insert(User user);
        void Update(User user);
        void Delete(int Id);
    }
}
