using MovieCatalog.Domain.Models;
using MovieCatalog.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;


namespace MovieCatalog.Mappers
{
    public static class UserMapper
    {
        public static User ToUser(this UserViewModel userModel)
        {
            return new User
            {
                Id = userModel.Id,
                FirstName = userModel.FirstName,
                LastName = userModel.LastName,
                Username = userModel.Username,
                Address = userModel.Address,
                Age = userModel.Age,
                FavoriteGenre = userModel.FavoriteGenre,
                Movies = new List<Movie>(),

            };
        }

        public static UserViewModel ToUserModel(this User user)
        {
            return new UserViewModel
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Username = user.Username,
                Address = user.Address,
                Age = user.Age,
                FavoriteGenre = user.FavoriteGenre,
                Movies = new List<Movie>()
            };
        }

        public static User MapUser(User user, UserViewModel userModel, Movie movie)
        {
            user.Id = userModel.Id;
            user.FirstName = userModel.FirstName;
            user.LastName = userModel.LastName;
            user.Username = userModel.Username;
            user.Address = userModel.Address;
            user.Age = userModel.Age;
            user.Movies = new List<Movie>();
            user.Movies.Add(movie);

            return user;

        }
    }
}

