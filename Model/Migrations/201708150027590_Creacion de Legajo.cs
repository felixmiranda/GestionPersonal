namespace Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreaciondeLegajo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Legajo",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Legajo");
        }
    }
}
