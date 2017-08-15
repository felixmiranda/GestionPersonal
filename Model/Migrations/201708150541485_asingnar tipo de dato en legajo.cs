namespace Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class asingnartipodedatoenlegajo : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Legajo", "Nombre", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Legajo", "Nombre", c => c.String());
        }
    }
}
