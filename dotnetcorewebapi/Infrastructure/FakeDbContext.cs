﻿using dotnetcorewebapi.Models;

namespace dotnetcorewebapi.Infrastructure
{
    public class FakeDbContext
    {
        public FakeDbContext()
        {
            Users = new List<User>();
            Heroes = new List<Hero>();
            Positions = new List<Position>();
        }
        public List<User> Users { get; set; }
        public List<Hero> Heroes { get; set; }
        public List<Position> Positions { get; set; }

        internal List<T> GetTable<T>()
        {
            return GetType()
                .GetProperties()
                .FirstOrDefault(p => p.GetValue(this, null) is List<T>)?
                .GetValue(this, null) as List<T>;
        }
    }
}
