using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using static HouseRentingSystem.Infrastructure.Constants.DataConstants;

namespace HouseRentingSystem.Infrastructure.Data.Models
{
    [Comment("House agent")]
	public class Agent
	{
        [Key]
        [Comment("Agent identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(PhoneNumberMaxLength)]
        [Comment("Agent phone number")]
        public string PhoneNumber { get; set; } = string.Empty;

        [Required]
        [Comment("User identifier")]
        public string UserId { get; set; } = string.Empty;

        [ForeignKey(nameof(UserId))]
        public IdentityUser User { get; set; } = null!;

        public List<House> Houses { get; set; } = new List<House>();

    }
}

