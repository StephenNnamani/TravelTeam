namespace Entities
{
    public class TravelConsultant : BaseEntity
    {
        IEnumerable<Traveler>? ListOfTravelers { get; set; }
    }
}
