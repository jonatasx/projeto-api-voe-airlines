using VoeAirlines.Entities; //é o modelo do projeto (model-dados)
using Microsoft.EntityFrameworkCore; //ORM
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VoeAirlines.EntityConfigurations;

public class LoginConfiguration : IEntityTypeConfiguration<Login>
{
    public void Configure(EntityTypeBuilder<Login> builder)
    {
        builder.ToTable("Logins");

        builder.HasKey(l => l.Id);
        //Definir usuário
        builder.Property(l => l.Usuario)
               .IsRequired()
               .HasMaxLength(40);
        //Definir senha
        builder.Property(l => l.Senha)
               .IsRequired()
               .HasMaxLength(12);
        builder.Property(l => l.DataCriacao)
               .IsRequired();


    }
}