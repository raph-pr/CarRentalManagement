namespace CarRentalManagement.Domain
{
    public class Make : BaseDomainModel
    {
        public string? Name { get; set; }
        public int Id { get; internal set; }
    }
}
