namespace codeFirst_tp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ajout : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MEDECINS",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TITRE = c.String(nullable: false, maxLength: 5),
                        NOM = c.String(nullable: false, maxLength: 20),
                        PRENOM = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.OPERATION",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Hdebut = c.Int(nullable: false),
                        Hfin = c.Int(nullable: false),
                        medecin_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.MEDECINS", t => t.medecin_ID, cascadeDelete: true)
                .Index(t => t.medecin_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OPERATION", "medecin_ID", "dbo.MEDECINS");
            DropIndex("dbo.OPERATION", new[] { "medecin_ID" });
            DropTable("dbo.OPERATION");
            DropTable("dbo.MEDECINS");
        }
    }
}
