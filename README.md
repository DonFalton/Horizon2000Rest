# Horizon2000Rest

Please undergo the following as discussed last with Antoine:

Dear Martin,

The the students must create a new Visual Studio Solution with the name Horizon2000Rest

The solution must have two projects with the following names:
Horizon2000Rest.Core
Horizon2000Rest.Entity
Horizon2000Rest


All projects must be .NET 6 (Core) but the Horizon2000Rest must be set as WebApi.

I recommend that after creating the solution and projects, they will start creating the database using code first. Note: The database must be exactly the same as done in my project (current application has the credentials to login within a testing environment of SQL).

Once the database is ready they can start creating repository classes for each table and set up all the required logic as done in my solution.


Antoine

1. Class names of tables must be named with a Dbo at the end. Example: UserDbo but within the database, the name must be User
2. After database is created, create exception class for Horizon application
