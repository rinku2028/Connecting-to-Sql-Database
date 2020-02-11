# Connecting-to-Sql-Database
Connecting to Sql Database from c#


Accessing Data from a database is one of the important aspects of any programming language. It is an absolute necessity for any programming language to have the ability to work with databases. C# is no different.

It can work with different types of databases. It can work with the most common databases such as Oracle and Microsoft SQL Server.

Fundamentals of Database connectivity
C# and .Net can work with a majority of databases, the most common being Oracle and Microsoft SQL Server. But with every database, the logic behind working with all of them is mostly the same.

In our examples, we will look at working the Microsoft SQL Server as our database. For learning purposes, one can download and use the Microsoft SQL Server Express Edition, which is a free database software provided by Microsoft.

In working with databases, the following are the concepts which are common to all databases.

Connection – To work with the data in a database, the first obvious step is the connection. The connection to a database normally consists of the below-mentioned parameters.
Database name or Data Source – The first important parameter is the database name to which the connection needs to be established. Each connection can only work with one database at a time.
Credentials – The next important aspect is the username and password which needs to be used to establish a connection to the database. It ensures that the username and password have the necessary privileges to connect to the database.
Optional parameters - For each database type, you can specify optional parameters to provide more information on how .net should handle the connection to the database. For example, one can specify a parameter for how long the connection should stay active. If no operation is performed for a specific period of time, then the parameter would determine if the connection has to be closed.
Selecting data from the database – Once the connection has been established, the next important aspect is to fetch the data from the database. C# can execute 'SQL' select command against the database. The 'SQL' statement can be used to fetch data from a specific table in the database.
Inserting data into the database – C# can also be used to insert records into the database. Values can be specified in C# for each row that needs to be inserted into the database.
Updating data into the database – C# can also be used to update existing records into the database. New values can be specified in C# for each row that needs to be updated into the database.
Deleting data from a database – C# can also be used to delete records into the database. Select commands to specify which rows need to be deleted can be specified in C#.
Ok, now that we have seen the theory of each operation, let's jump into the further sections to look at how we can perform database operations in C#.


How to connect C# to Database
Let's now look at the code, which needs to be kept in place to create a connection to a database. In our example, we will connect to a database which has the name of Demodb. The credentials used to connect to the database are given below

Username – sa
Password – demo123
