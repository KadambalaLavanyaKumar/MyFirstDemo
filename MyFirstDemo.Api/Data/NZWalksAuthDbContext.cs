using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MyFirstDemo.Api.Data
{
    public class NZWalksAuthDbContext : IdentityDbContext
    {
        public NZWalksAuthDbContext(DbContextOptions<NZWalksAuthDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            var readerRoleId = "e9f22eac-eea6-4298-9fc0-8e6043ab42cd";
            var writerRoleId = "72967382-d0c4-4b5f-b57b-3c3857f0fa2d";
            var roles = new List<IdentityRole>
               {
                   new IdentityRole
                   {
                       Id = readerRoleId,
                       ConcurrencyStamp=readerRoleId,
                       Name="Reader",
                       NormalizedName="Reader".ToUpper()
                   },
                   new IdentityRole
                   { Id = writerRoleId,
                   ConcurrencyStamp = writerRoleId,
                   Name="Writer",
                   NormalizedName="Writer".ToUpper()
                   }

               };
            builder.Entity<IdentityRole>().HasData(roles);
       
        }
    }
   
}
