using CarRentalManagement.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentalManagement.Configurations.Entities
{
    public class MakeSeed : IEntityTypeConfiguration<Make>
    {
        public void Configure(EntityTypeBuilder<Make> builder)
        {
            builder.HasData(
                 new Make
                 {
                     ID = 1,
                     Name = "BMW",
                     DateCreated = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                     DateUpdated = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                     CreatedBy = "System",
                     UpdatedBy = "System"
                 },
                 new Make
                 {
                     ID = 2,
                     Name = "Toyota",
                     DateCreated = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                     DateUpdated = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                     CreatedBy = "System",
                     UpdatedBy = "System"
                 }
              );
        }
    }
}
