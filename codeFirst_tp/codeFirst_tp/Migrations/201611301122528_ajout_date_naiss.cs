namespace codeFirst_tp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ajout_date_naiss : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MEDECINS", "DATENAISS", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.MEDECINS", "DATENAISS");
        }
    }
}
