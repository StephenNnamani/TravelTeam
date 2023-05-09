namespace Entities
{
    public class FinancialConsultant : BaseEntity
    {
        public string? Officialduty { get; set; }
        IEnumerable<Chat>? Messages { get; set; }

    }
}
