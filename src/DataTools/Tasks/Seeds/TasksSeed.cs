using CarpeDiem.DataTools.Tasks.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarpeDiem.DataTools.Tasks.Seeds;

public class TasksSeed : IEntityTypeConfiguration<Task>
{
    public void Configure(EntityTypeBuilder<Task> builder)
    {
        builder.HasData(new Task(Guid.Parse("a1e5919e-623f-4093-bd4e-8b22bcc28259")));
        builder.HasData(new Task(Guid.Parse("ff5f6afe-8d47-4e8b-bb98-4c855cf31f1a")));
        builder.HasData(new Task(Guid.Parse("3830cbc7-4531-4586-abcb-ed6157e21e3f")));
        builder.HasData(new Task(Guid.Parse("87b26def-8da9-4d93-b06a-3363329346f7")));
        builder.HasData(new Task(Guid.Parse("52239b2a-2934-4acc-8352-d191ceeb5920")));
        builder.HasData(new Task(Guid.Parse("fca6d9bf-0a69-459e-96d5-f2d2791e2464")));
        builder.HasData(new Task(Guid.Parse("79d1bfd2-8650-4607-bc23-b3b04287c7ab")));
        builder.HasData(new Task(Guid.Parse("00c764cc-321b-495c-83bf-5b1f58850b2c")));
        builder.HasData(new Task(Guid.Parse("f9483f34-652a-4922-a24f-0d381fbaf5b1")));
        builder.HasData(new Task(Guid.Parse("86c4d559-ea75-4191-bbe1-3be1aee003e9")));
        builder.HasData(new Task(Guid.Parse("42f447e5-1645-4f90-bf85-0c5aff747c48")));
        builder.HasData(new Task(Guid.Parse("ae1fdc97-90f9-4d8f-a811-4f55416df24e")));
        builder.HasData(new Task(Guid.Parse("6c8fecd8-ebc2-47ba-b800-44088a126cd1")));
        builder.HasData(new Task(Guid.Parse("cbfe9418-dab3-48a7-ba13-b30e6f6a0577")));
    }
}