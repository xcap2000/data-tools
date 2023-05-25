using CarpeDiem.DataTools.Tasks.Configurations;
using CarpeDiem.DataTools.Tasks.Seeds;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace CarpeDiem.DataTools.Tasks.Contexts;

public class ContextsModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder
            .Register
            (
                //SqliteConnection sqliteConnection = new SqliteConnection("DataSource=:memory:");
                _ => new SqliteConnection("DataSource=DataTools.db")
            );

        builder
            .Register
            (
                c =>
                {
                    var convention = SqliteConventionSetBuilder.Build();
                    var modelBuilder = new ModelBuilder(convention);

                    modelBuilder.ApplyConfiguration(new TaskConfiguration());

                    modelBuilder.ApplyConfiguration(new TasksSeed());

                    var builder = new DbContextOptionsBuilder<TasksContext>();
                    builder.UseSqlite
                    (
                        c.Resolve<SqliteConnection>(),
                        sqliteOptionsAction => sqliteOptionsAction.MigrationsHistoryTable("_Tasks")
                    );
                    builder.UseModel(modelBuilder.FinalizeModel());

                    return builder.Options;
                }
            );

        builder
            .RegisterType<TasksContext>()
            .As<ITasksContext>()
            .AsSelf()
            .SingleInstance();
    }
}