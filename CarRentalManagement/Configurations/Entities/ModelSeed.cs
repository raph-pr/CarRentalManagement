using CarRentalManagement.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentalManagement.Configurations.Entities
{
    public class ModelSeed : IEntityTypeConfiguration<Model>
    {
        public void Configure(EntityTypeBuilder<Model> builder)
        {
            builder.HasData(
                new Model
                {
                    ID = 1,
                    Name = "i4",
                    DateCreated = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                    DateUpdated = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Model
                {
                    ID = 2,
                    Name = "X5",
                    DateCreated = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                    DateUpdated = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Model
                {
                    ID = 3,
                    Name = "Prius",
                    DateCreated = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                    DateUpdated = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Model
                {
                    ID = 4,
                    Name = "C-HR",
                    DateCreated = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                    DateUpdated = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
             );
        }
    }
}
