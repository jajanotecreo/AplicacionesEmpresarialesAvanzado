﻿namespace APITecsup.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChanginTotaltodouble : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Invoices", "Total", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Invoices", "Total", c => c.Int(nullable: false));
        }
    }
}
