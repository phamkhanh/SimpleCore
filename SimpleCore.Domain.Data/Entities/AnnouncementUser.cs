﻿using SimpleCore.Infrastructure.SharedKernel;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimpleCore.Domain.Data.Entities
{
    [Table("AnnouncementUsers")]
    public class AnnouncementUser : DomainEntity<int>
    {
        [Required]
        public string AnnouncementId { get; set; }

        public Guid UserId { get; set; }

        public bool? HasRead { get; set; }

        [ForeignKey("AnnouncementId")]
        public virtual Announcement Announcement { get; set; }
    }
}