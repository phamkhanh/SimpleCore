﻿using Microsoft.AspNetCore.Identity;
using SimpleCore.Domain.Data.Interfaces;
using SimpleCore.Infrastructure.Enums;
using SimpleCore.Infrastructure.Interfaces;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimpleCore.Domain.Data.Entities
{
    [Table("AppUsers")]
    public class AppUser : IdentityUser<Guid>, IDateTracking, ISwitchable
    {
        public string FullName { get; set; }

        public DateTime? BirthDay { set; get; }

        public decimal Balance { get; set; }

        public string Avatar { get; set; }

        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public Status Status { get; set; }
    }
}