using JsonToPdf.Model.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonToPdf.Model
{
    /// <summary>
    ///  Определяем контекст данных, используемый для взаимодействия с базой данных.
    /// </summary>
    public class DataContext : DbContext
    {
        public DbSet<BaseDocumentEntity> BaseDocumentsEntity { get; set; }
     
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        /// <summary>
        ///  Сопоставление классов с сущностями в базе данных.
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ActOfReconciliationEntity>().ToTable("ActsOfReconciliation");
            modelBuilder.Entity<ConsignmentNoteEntity>().ToTable("ConsignmentsNotes");
            modelBuilder.Entity<ContractEntity>().ToTable("Contracts");
            modelBuilder.Entity<GeneratedPdfEntity>().ToTable("GeneratedPdfs");
        }
        /// <summary>
        /// Асинхронное сохранение получаемых JSON в БД
        /// </summary>
        /// <returns></returns>
        public async Task<int> SaveChangesAsync()
        {
            return await base.SaveChangesAsync();
        }
    }
}
