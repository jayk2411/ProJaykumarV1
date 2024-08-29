using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace ProJaykumarV1.EntityFrameworkCore
{
    public static class ProJaykumarV1DbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ProJaykumarV1DbContext> builder, string connectionString)
        {
            builder.UseNpgsql(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ProJaykumarV1DbContext> builder, DbConnection connection)
        {
            builder.UseNpgsql(connection);
        }
    }
}
