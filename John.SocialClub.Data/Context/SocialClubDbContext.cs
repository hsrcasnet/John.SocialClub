using John.SocialClub.Data.Entities;
using John.SocialClub.Data.Initializer;
using System.Data.Entity;

namespace John.SocialClub.Data.Context
{
    public class SocialClubDbContext : DbContext
    {
        public SocialClubDbContext()
            : base("SocialClub.DbConnection")
        {
            // HACK: This needs to be refactored asap.
            Database.SetInitializer<SocialClubDbContext>(new SocialClubInitializer());
            Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<ClubMember> ClubMembers { get; set; }
    }
}
