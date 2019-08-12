namespace ClothBazar.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModelone : DbMigration
    {
        public override void Up()
        {

            Sql(@"
INSERT INTO [dbo].[Categories] ( [ImageURL], [isFeatured], [Name], [Description]) VALUES ( N'/content/images/000ff8fc-357f-467a-be9f-0ffe95b0593d.jpg', 1,N'For Men', N'Men')
INSERT INTO [dbo].[Categories] ([ImageURL], [isFeatured], [Name], [Description]) VALUES ( N'/content/images/ee00a0e4-7f07-486f-9aa1-eee79d57c98f.jpg', 1, N'FOR WOMEN', N'Women')
INSERT INTO [dbo].[Categories] ( [ImageURL], [isFeatured], [Name], [Description]) VALUES ( N'/content/images/92653537-c0bd-41d6-9575-96d8eb8ae4b7.jpg', 1, N'FOR CHILDREN', N'CHILDREN')

   
");


        }

        public override void Down()
        {
        }
    }
}
