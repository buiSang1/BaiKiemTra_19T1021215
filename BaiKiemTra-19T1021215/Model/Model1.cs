using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace BaiKiemTra_19T1021215.Model
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Nguoi> Nguois { get; set; }
        public virtual DbSet<Nhom> Nhoms { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Nhom>()
                .HasMany(e => e.Nguois)
                .WithOptional(e => e.Nhom)
                .HasForeignKey(e => e.IDNhom);
        }
    }
}
