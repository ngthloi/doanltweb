﻿namespace AppleWebsite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Id_AppUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Carts", "id_user", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Carts", "id_user");
        }
    }
}
