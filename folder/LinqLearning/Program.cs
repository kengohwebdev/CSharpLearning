/*
 In-Memory: data/memory stored in collections List<>, Dictionary<>, Arrays<> can use linq on these
Output of linq on these is: IEnumerable

Out-memory: databases of outside sources: Linq can be used on these:
Output of Linq on these is IQueryable<>
 */

//Linq Providers: 
/*
 --LINQ to Objects: In memory sources
 --LINQ to entities: processing data stored in External databaes and modeled with ORMS
 --LINQ to XML: not that common practice anymore 
 */

//Object Relational mapping: connect the ASP.Net Application to SQL Server without any "impendance mismatch"
//ORMs need providers: they are the connections that will connect your LINQ to SQL server


//Extension methods: Where, Orderby, Select...
// Lambda functions/ Delegates
// LINQ Query Comprehensive Syntax (query syntax (optional)) it is similar to SQL queries in the fact it uses the same keywords 
// Select, From. Where, in. 

/*
 First: returns the first data when there is one or more matching values found; if there are no matching values throw excecption
 Single: returns a singluar matching record, if there is more than one or none found,throw execption
 FirstOrDefault: returns the first data when there is one or more matching found, if no match, return assigned default value
SingleOrDefault: returns a singluar matching record, if there is no matching, return default, if there is more than one, 
//throw exception

Quantifier Operators:
All(): Checks if all the elements satisfy the specific condition, if yes, return true, if no return false
Any(): Checks if any the elements satisfy the specific condition, if yes, return true, if no return false
 */

using LinqLearning;

ManageEmployees ManageEmployees = new ManageEmployees();
ManageEmployees.Run();

