﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

public partial class CellEntities : DbContext
{
    public CellEntities()
        : base("name=CellEntities")
    {
    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }

    public virtual DbSet<Comment> Comments { get; set; }
    public virtual DbSet<Content> Contents { get; set; }
    public virtual DbSet<Elective> Electives { get; set; }
    public virtual DbSet<ScenarioContent> ScenarioContents { get; set; }
    public virtual DbSet<SubContent> SubContents { get; set; }
    public virtual DbSet<Account> Accounts { get; set; }
    public virtual DbSet<Scenario> Scenarios { get; set; }
}
