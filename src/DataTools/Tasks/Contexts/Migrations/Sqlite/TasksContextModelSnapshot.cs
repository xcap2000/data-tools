﻿// <auto-generated />
using System;
using CarpeDiem.DataTools.Tasks.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CarpeDiem.DataTools.Tasks.Contexts.Migrations.Sqlite
{
    [DbContext(typeof(TasksContext))]
    partial class TasksContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.16");

            modelBuilder.Entity("CarpeDiem.DataTools.Tasks.Entities.Task", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Tasks", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("a1e5919e-623f-4093-bd4e-8b22bcc28259")
                        },
                        new
                        {
                            Id = new Guid("ff5f6afe-8d47-4e8b-bb98-4c855cf31f1a")
                        },
                        new
                        {
                            Id = new Guid("3830cbc7-4531-4586-abcb-ed6157e21e3f")
                        },
                        new
                        {
                            Id = new Guid("87b26def-8da9-4d93-b06a-3363329346f7")
                        },
                        new
                        {
                            Id = new Guid("52239b2a-2934-4acc-8352-d191ceeb5920")
                        },
                        new
                        {
                            Id = new Guid("fca6d9bf-0a69-459e-96d5-f2d2791e2464")
                        },
                        new
                        {
                            Id = new Guid("79d1bfd2-8650-4607-bc23-b3b04287c7ab")
                        },
                        new
                        {
                            Id = new Guid("00c764cc-321b-495c-83bf-5b1f58850b2c")
                        },
                        new
                        {
                            Id = new Guid("f9483f34-652a-4922-a24f-0d381fbaf5b1")
                        },
                        new
                        {
                            Id = new Guid("86c4d559-ea75-4191-bbe1-3be1aee003e9")
                        },
                        new
                        {
                            Id = new Guid("42f447e5-1645-4f90-bf85-0c5aff747c48")
                        },
                        new
                        {
                            Id = new Guid("ae1fdc97-90f9-4d8f-a811-4f55416df24e")
                        },
                        new
                        {
                            Id = new Guid("6c8fecd8-ebc2-47ba-b800-44088a126cd1")
                        },
                        new
                        {
                            Id = new Guid("cbfe9418-dab3-48a7-ba13-b30e6f6a0577")
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
