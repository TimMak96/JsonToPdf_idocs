using JsonToPdf.Model.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonToPdf.Model
{
    public class DataContext : DbContext
    {
        public DbSet<BaseDocumentEntity> BaseDocumentsEntity { get; set; }
     
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ActOfReconciliation>().ToTable("ActsOfReconciliation");
            modelBuilder.Entity<ConsignmentNote>().ToTable("ConsignmentsNotes");
            modelBuilder.Entity<Contract>().ToTable("Contracts");
            modelBuilder.Entity<GeneratedPdf>().ToTable("GeneratedPdfs");
        }

        public async Task<int> SaveChangesAsync()
        {
            return await base.SaveChangesAsync();
        }
    }
}
