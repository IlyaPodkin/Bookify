using Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder) 
        {
            builder.ToTable("users");
            ConfigureColumnTable(builder);
            ConfigureRelation(builder);
        }
        private void ConfigureColumnTable(EntityTypeBuilder<User> builder) 
        {
            builder.Property(u => u.Id).HasColumnName("id");
            builder.Property(u => u.Name).HasColumnName("name_user");
            builder.Property(u => u.Email).HasColumnName("user_email");
            builder.Property(u => u.Password).HasColumnName("name_password");
        }
        private void ConfigureRelation(EntityTypeBuilder<User> builder) 
        {
            builder.HasKey(u => u.Id);
            builder.Property(u => u.Id).HasDefaultValueSql("gen_random_uuid()");
            builder.Property(u => u.Name).IsRequired();
            builder.Property(u => u.Email).IsRequired();
            builder.Property(u => u.Password).IsRequired();
        }
        
    }
}
