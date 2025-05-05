using System.ComponentModel.DataAnnotations;

namespace FireArmsInventoryManagementSystem.Models
{
    public abstract class LongGun : Firearm
    {
        [Range(10, 60)]
        public decimal BarrelLengthInches { get; set; }

        [Range(20, 120)]
        public decimal OverallLengthInches { get; set; }
    }
}
