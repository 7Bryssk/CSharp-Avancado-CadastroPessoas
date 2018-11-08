namespace Persistencia.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Criacao_Tabela : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pessoas",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nome = c.String(unicode: false),
                        idade = c.Int(nullable: false),
                        endereco = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Pessoas");
        }
    }
}
