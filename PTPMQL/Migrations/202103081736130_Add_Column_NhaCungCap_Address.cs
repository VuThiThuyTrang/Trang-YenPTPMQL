namespace PTPMQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Column_NhaCungCap_Address : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.NhaCungCaps", "Address", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.NhaCungCaps", "Address");
        }
    }
}
