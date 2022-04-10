using Microsoft.IdentityModel.Tokens;
using MovieCatalog.DataAccess.Interfaces;
using MovieCatalog.Domain.Models;
using MovieCatalog.Mappers;
using MovieCatalog.Services.Interfaces;
using MovieCatalog.ViewModels;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace MovieCatalog.Services.Implementations
{
    public class UserService : IUserInterface

    {

        private IRepository<Movie> _movieRepository;
        private IUserRepository _userRepository;

        public UserService(IRepository<Movie> movieRepository, IUserRepository userRepository)
        {
            _movieRepository = movieRepository;
            _userRepository = userRepository;
        }
        public void AddUser(UserViewModel userModel)
        {
            try
            {
                User userForDb = userModel.ToUser();
                _userRepository.Add(userForDb);

            }
            catch (Exception ex)
            {
                string message = ex.Message;
                throw new Exception(message);
            }

        }

        public void DeleteUser(int id)
        {
            try
            {
                User userDb = _userRepository.GetById(id);
                _userRepository.Delete(userDb);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                throw new Exception(message);
            }
        }

        public List<UserViewModel> GetAllUsers()
        {
            try
            {
                List<User> usersDb = _userRepository.GetAll();
                List<UserViewModel> userModels = new List<UserViewModel>();
                foreach (User user in usersDb)
                {
                    userModels.Add(user.ToUserModel());
                }
                return userModels;
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                throw new Exception(message);
            }
        }

        public UserViewModel GetUserById(int id)
        {
            try
            {
                User userDb = _userRepository.GetById(id);
                return userDb.ToUserModel();
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                throw new Exception(message);
            }
        }

        public string Login(LoginViewModel loginUserModel)
        {
            try
            {
                var md5 = new MD5CryptoServiceProvider();

                var md5Data = md5.ComputeHash(Encoding.ASCII.GetBytes(loginUserModel.Password));

                var hashedPassword = Encoding.ASCII.GetString(md5Data);

                User userDb = _userRepository.LoginUser(loginUserModel.Username, hashedPassword);


                JwtSecurityTokenHandler jwtSecurityTokenHandler = new JwtSecurityTokenHandler();

                byte[] secretKeyBytes = Encoding.ASCII.GetBytes("This is my secret key");

                SecurityTokenDescriptor securityTokenDescriptor = new SecurityTokenDescriptor
                {
                    Expires = DateTime.UtcNow.AddDays(7),

                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(secretKeyBytes),
                        SecurityAlgorithms.HmacSha256Signature),

                    Subject = new ClaimsIdentity(
                        new[]
                        {
                            new Claim(ClaimTypes.Name, userDb.Username),
                            new Claim(ClaimTypes.NameIdentifier, userDb.Id.ToString()),
                            new Claim("userFullName", $"{userDb.FirstName} {userDb.LastName}"),
                        }
                    )
                };
                SecurityToken token = jwtSecurityTokenHandler.CreateToken(securityTokenDescriptor);

                string tokenString = jwtSecurityTokenHandler.WriteToken(token);
                return tokenString;
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                throw new Exception(message);
            }
        }

        public void Register(RegisterViewModel registerUserModel)
        {
            try
            {

                ValidateUser(registerUserModel);

                var md5 = new MD5CryptoServiceProvider();

                var md5Data = md5.ComputeHash(Encoding.ASCII.GetBytes(registerUserModel.Password));

                var hashedPassword = Encoding.ASCII.GetString(md5Data);


                User newUser = new User ()

                {
                    FirstName = registerUserModel.FirstName,
                    LastName = registerUserModel.LastName,
                    Username = registerUserModel.Username,
                    Password = hashedPassword,
                    Address = registerUserModel.Address,
                    Email = registerUserModel.Email
                   
                };


                _userRepository.Add(newUser);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                throw new Exception(message);
            }
        }

        public void UpdateUser(UserViewModel userModel)
        {
            try
            {
                User userDb = _userRepository.GetById(userModel.Id);

                Movie movieDb = _movieRepository.GetById(userModel.Id);

                _userRepository.Update(UserMapper.MapUser(userDb, userModel, movieDb));
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                throw new Exception(message);
            }
        }

        private void ValidateUser(RegisterViewModel registerUserModel)
        {
            if (string.IsNullOrEmpty(registerUserModel.Username) || string.IsNullOrEmpty(registerUserModel.Password))
            {
                throw new Exception("Username and password are required fields");
            }
            if (registerUserModel.Username.Length > 30)
            {
                throw new Exception("Username can contain max 30 characters");
            }
            if (registerUserModel.FirstName.Length > 50 || registerUserModel.LastName.Length > 50)
            {
                throw new Exception("Firstname and Lastname can contain maximum 50 characters!");
            }
            if (!IsUserNameUnique(registerUserModel.Username))
            {
                throw new Exception("A user with this username already exists!");
            }
            if (registerUserModel.Password != registerUserModel.ConfirmPassword)
            {
                throw new Exception("The passwords do not match!");
            }
            if (!IsPasswordValid(registerUserModel.Password))
            {
                throw new Exception("The password is not complex enough!");
            }
        }

        private bool IsPasswordValid(string password)
        {
            Regex passwordRegex = new Regex("^(?=.*[0-9])(?=.*[a-z]).{6,20}$");
            return passwordRegex.Match(password).Success;
        }

        private bool IsUserNameUnique(string username)
        {
            return _userRepository.GetUserByUsername(username) == null;
        }


    }
}
