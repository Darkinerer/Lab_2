namespace Sklad.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Cars : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Tovars", newName: "Avtoes");
            DropColumn("dbo.Avtoes", "Vlas");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Avtoes", "Vlas", c => c.String());
            RenameTable(name: "dbo.Avtoes", newName: "Tovars");
        }
    }
}
