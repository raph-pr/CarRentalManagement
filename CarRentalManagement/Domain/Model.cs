namespace CarRentalManagement.Domain
{
    public class Model : BaseDomainModel
    {
        public string? Name { get; set; }
        public int Id { get; internal set; }
    }
}
