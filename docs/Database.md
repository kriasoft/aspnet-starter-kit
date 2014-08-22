## How to deploy SQL Database project?

1. Double-click `Local.publish.xml` file in the database project

   ![Publish SQL Database](https://dl.dropboxusercontent.com/u/16006521/Screens/aspnet-server-database-publishing.png)

2. Edit target database settings if needed

   ![SQL Database Publishing Dialog](https://dl.dropboxusercontent.com/u/16006521/Screens/aspnet-server-database-publishing-dialog.png)

3. Hit [Publish]

**Note**: You may want to add more publishing profiles, e.g.
`Test.publish.xml`, `Production.publish.xml`

Alternatively you can send `App.Database.dacpac` file (generated during
a build) to your DBA and he or she will deploy or update the database for you.

## Naming conventions

The naming conventions in this project are the same used in the
[AdventureWorks](https://msftdbprodsamples.codeplex.com/) sample database
created by Microsoft database professionals and demonstrate many best practices
in terms of style.

To summarize:

 * Object names are easily understood
 * Table names are not pluralized (`User` table not `Users`)
 * Abbreviations are few, but allowed (i.e. `Qty`, `Amt`, etc.)
 * PascalCase used exclusively with the exception of certain column names
   (i.e. `rowguid`)
 * No underscores
 * Certain keywords are allowed (i.e. `Name`)
 * Stored procedures are prefaced with `usp`
 * Functions are prefaced with `ufn`
 * Constraints are prefixed with `DF`, `FK`, `UK`, `IX` based on their types
 * Constraints contain table's name as well as a list of columns used in the constraint
   (i.e. `PK_User_UserID`, `UK_User_UserName`, `DF_User_CreatedDate`)

Each rule has a good reasoning behind it. For example, why table names should
be singular? Because this way there is less noise, such tables are easier
to map to entity models using ORM tools, tables are more accurately sorted
alphabetically in your IDE, table names describe the data type rather than how
much data it contains, it's easier to come up with singular names, than with
plural ones (with a few exceptions like News), easier to spell correctly
(especially for a non-native English language programmer).

For more info visit [AdventureWorks OLTP Database](http://msdn.microsoft.com/en-us/library/ms124659.aspx)
on MSDN.

## Learn more about SSDT

 * [SQL Server Data Tools Home Page](http://msdn.microsoft.com/en-us/data/tools.aspx) on Dev Center
 * [SQL Server Data Tools Documentation](http://msdn.microsoft.com/en-us/library/hh272686.aspx) on MSDN.
 * [SQL Server Data Tools Team Blog](http://blogs.msdn.com/b/ssdt/)
 * [SQL Server Data Tools Forums](http://social.msdn.microsoft.com/Forums/en-US/ssdt/threads)
 * [SQL Server Data Tools Questions](http://stackoverflow.com/questions/tagged/ssdt) on StackOverflow