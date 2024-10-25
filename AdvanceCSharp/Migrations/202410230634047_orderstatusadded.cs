﻿namespace AdvanceCSharp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class orderstatusadded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OrderStatus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.OrderStatus");
        }
    }
}
