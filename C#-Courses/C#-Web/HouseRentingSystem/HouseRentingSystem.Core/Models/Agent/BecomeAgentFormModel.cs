using HouseRentingSystem.Infrastructure.Data;
using System.ComponentModel.DataAnnotations;

namespace HouseRentingSystem.Core.Models.Agent
{
    public class BecomeAgentFormModel
    {
        [Required]
        [StringLength(DataConstants.Agent.PhoneNumberMaxLenght,
            MinimumLength = DataConstants.Agent.PhoneNumberMinLenght)]
        [Display(Name = "Phone Number")]
        [Phone]
        public string PhoneNumber { get; init; } = null!;
    }
}
