using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static HouseRentingSystem.Infrastructure.Data.DataConstants.House;

namespace HouseRentingSystem.Infrastructure.Data.Entities
{
    public class House
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(TitleMaxLenght)]
        public string Title { get; set; } = null!;

        [Required]
        [MaxLength(AdressMaxLenght)]
        public string Address { get; set; } = null!;

        [Required]
        [MaxLength(DescriptionMaxLenght)]
        public string Description { get; set; } = null!;

        [Required]
        [MaxLength(ImageUrlMaxLenght)]
        public string ImageUrl { get; set; } = null!;

        [Required]
        [Precision(18, 2)]
        [Column(TypeName = "money")]
        public decimal PricePerMonth { get; set; }

        [Required]
        [ForeignKey(nameof(Category))]
        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(Agent))]
        public int AgentId { get; set; }
        public Agent Agent { get; set; } = null!;

        [ForeignKey(nameof(RenterId))]
        public string? RenterId { get; set; }
        public IdentityUser? Renter { get; set; }
    }
}
