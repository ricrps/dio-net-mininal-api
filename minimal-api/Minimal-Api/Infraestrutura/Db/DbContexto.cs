using Microsoft.EntityFrameworkCore;
using Minimal_Api.Dominio.Entidades;

namespace Minimal_Api.Infraestrutura.Db
{
    public class DbContexto : DbContext
    {
        private readonly IConfiguration _configuracaoAppSetting;

        public DbContexto(IConfiguration configuracaoAppSetting)
        {
            _configuracaoAppSetting = configuracaoAppSetting;
        }

        public DbSet<Administrador> Administradores { get; set; } = default!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var stringConexao = _configuracaoAppSetting.GetConnectionString("SqlServer");
                optionsBuilder.UseSqlServer(stringConexao); 
            }
        }
    }
}
