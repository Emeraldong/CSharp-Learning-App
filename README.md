This is a learning project for me to familiarize myself with C#; nothing fancy.

Might be improved in the future to use actual databases.


MONGODB LOCAL STARTUP GUIDE:
1. Navigate to directory where mongod.exe is located in CLI.
2. Run `mongod` in CLI
3. Done
4. In another CLI instance, run `mongosh` to start inputting commands.

MONGODB DB CREATION GUIDE:
1. After running `mongosh`, simply run `use <DATABASE NAME>` to create a new database if <DATABASE NAME> does not exist.

MONGODB COLLECTION (TABLE) CREATION GUIDE:
1a. After running `mongosh`, a collection can be explicitly created by running `db.createCollection("<DATABASE NAME>")`.
1b. Alternatively, a collection can be created by inserting a document (row) into it via:
    `db.<DATABASE NAME>.insertOne({
        <FIELD 1>: <DATA 1>,
        <FIELD 2>: <DATA 2>
    })`

CONNECTING TO MONGODB DATABASE:
1. Install MongoDB.Driver by running `dotnet add package MongoDB.Driver` in project directory.
2. Create a client to connect with using `new MongoClient("mongodb://127.0.0.1:27017")` for the default local connection.