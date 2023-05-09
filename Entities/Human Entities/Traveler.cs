using Entities.Non_Human_Entities;

namespace Entities
{
    public class Traveler : BaseEntity
    {
        public string? CountryOfChoice { get; set; }
        public bool IsEnrolled { get; set; }
        public DateTime? DateEnrolled { get; set; }
        public IEnumerable<Chat>? Messages { get; set; }
        public IEnumerable<Tasks>? Tasks { get; set; }
        public TravelConsultant? ConsultantInCharge { get; set; }

    }
}
