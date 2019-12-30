﻿using core.data.Model;
using core.data.Model.Person;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace core.data
{
    public class VirtualCollegeContext : DbContext
    {
        public VirtualCollegeContext(DbContextOptions<VirtualCollegeContext> options) : base(options)
        {

        }

        public DbSet<Person>? People { get; set; }
        public DbSet<Contact>? Contacts { get; set; }
    }
}
