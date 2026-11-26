namespace CarRentalManagement.Domain
{
    public class Colour : BaseDomainModel
    {
        public string? Name { get; set; }
        public int Id { get; internal set; }
    }
}
