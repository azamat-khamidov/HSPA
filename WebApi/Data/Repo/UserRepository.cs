﻿using Microsoft.EntityFrameworkCore;
using WebApi.Interfaces;
using WebApi.Models;

namespace WebApi.Data.Repo
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext dc;

        public UserRepository(DataContext dc)
        {
            this.dc = dc;
        }
        public async Task<User> Authenticate(string username, string password)
        {
            return await dc.Users.FirstOrDefaultAsync(x => x.Username == username && x.Password == password);
        }
    }
}
