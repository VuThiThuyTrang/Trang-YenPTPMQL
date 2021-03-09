using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace PTPMQL.Models
{
    public partial class DemoDbContext : DbContext
    {
        public DemoDbContext()
            : base("name=DemoDbContext")
        {
        }
        //public virtual Dbset<Table> Tables { get; set;}
        public virtual DbSet<KhachHang> KhachHangs { get;set;}
        public virtual DbSet<NhaCungCap> NhaCungCaps { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KhachHang>()
                .Property(e => e.MaKhachHang)
                .IsRequired()
                .IsUnicode(false);
        }
    }
}
