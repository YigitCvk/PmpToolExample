using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dal.Concrete
{
    public class PmpContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(@"Server=127.0.0.1; Port=5432;Database=PmpTool;User Id=postgres;Password=283501;CommandTimeout=32767;Timeout=1024;");
        }
        public DbSet<Board> Board { get; set; }
        public DbSet<BoardTask> BoardTask { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<FailedTasks> FailedTasks { get; set; }
        public DbSet<MailSettings> MailSettings { get; set; }
        public DbSet<MailTemplates> MailTemplates { get; set; }
        public DbSet<Milestone> Milestone { get; set; }
        public DbSet<Person> Person { get; set; }
        public DbSet<Project> Project { get; set; }
        public DbSet<ProjectLeader> ProjectLeader { get; set; }
        public DbSet<ProjectPerson> ProjectPerson { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Sprint> Sprint { get; set; }
        public DbSet<Task> Task { get; set; }
        public DbSet<TaskBudget> TaskBudget { get; set; }
        public DbSet<TaskComment> TaskComment { get; set; }
        public DbSet<TaskFile> TaskFile { get; set; }
        public DbSet<TaskPerson> TaskPerson { get; set; }
        public DbSet<TaskPersonDetail> TaskPersonDetail { get; set; }
        public DbSet<Team> Team { get; set; }
        public DbSet<WaitingMails> WaitingMails { get; set; }

    }
}
