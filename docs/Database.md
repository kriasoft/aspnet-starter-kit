## How to deploy SQL Database project?

1. Double-click `Local.publish.xml` file in the database project

   ![Publish SQL Database](https://dl.dropboxusercontent.com/u/16006521/Screens/aspnet-server-database-publishing.png)

2. Edit target database settings if needed

   ![SQL Database Publishing Dialog](https://dl.dropboxusercontent.com/u/16006521/Screens/aspnet-server-database-publishing-dialog.png)

3. Hit [Publish]

**Note**: You may want to add more publishing profiles, e.g. `Test.publish.xml`, `Production.publish.xml`

Alternatively you can handle `App.Database.dacpac` file (generated during a build)
to your DBA and he or she will deploy or update the database for you.