using MovieCatalog.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieCatalog.Services.Interfaces
{
    public interface IUserInterface
    {
        List<UserViewModel> GetAllUsers();
        UserViewModel GetUserById(int id);
        void AddUser(UserViewModel userModel);
        void UpdateUser(UserViewModel userModel);
        void DeleteUser(int id);
        void Register(RegisterViewModel registerUserModel);
        string Login(LoginViewModel loginUserModel);
    }
}
