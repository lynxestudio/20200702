# Performing Disconnected Operations: Programming with DataSets and Datatables with C#

DataSets and DataTables
You create an instance of a DataSet by calling the DataSet constructor. Specify an optional name argument. If you do not specify a name for the DataSet, the name is set to "NewDataSet". ADO.NET enables you to create DataTable objects and add them to an existing DataSet. You can add DataColumn objects to the Columns collection of the DataTable. You can set constraint information for a DataTable by using the Primary Key property of the DataTable and the Unique property of the DataColumn objects.

The schema, or structure, of a table is represented by columns and constraints. You define the schema of a DataTable by using DataColumn objects as well as ForeignKeyConstraint and UniqueConstraint objects. The columns in a table can map to columns in a data source, contain calculated values from expressions, automatically increment their values, or contain primary key values. DataTable objects are not specific to any data source, that's why .NET Framework types are used when specifying the data type of a DataColumn.

To ensure that the values in a column are unique, you can set the column values to increment automatically when new rows are added to the table. To create an auto-incrementing DataColumn, set the AutoIncrement property of the column to true. The DataColumn will then start with the value defined in the AutoIncrementSeed property, and with each row added the value of the AutoIncrement column will increase by the value held in the AutoIncrementStep property of the column. For AutoIncrement columns, it is recommended that the ReadOnly property of the DataColumn be set to true.

When you identify a single DataColumn as the Primary Key for a DataTable, the table automatically sets the AllowDBNull property of the column to false and the Unique property to True. For multiple-column primary keys, the AllowDBNull property is automatically set to false, but the Unique property is not set to true. However, a UniqueConstraint corresponding to the primary key is added to the Constraints collection of the DataTable.

You can use Constraints to enforce restrictions on the data in a DataTable to maintain the integrity of the data. Constraints are enforced when the EnforceConstraints property of the DataSet is true. There are two kinds of constraints in ADO.NET: the ForeignKeyConstraint and the UniqueConstraint. By default, both constraints are created automatically when you create a relationship between two or more tables by adding a DataRelation to the DataSet.

		DataSet ds = new DataSet("CoursesDb");
		DataTable categoryTable = ds.Tables.Add("Category");
		DataColumn pkCol = categoryTable.Columns.Add("CategoryId",typeof(Int32));
		pkCol.AutoIncrement = True;
		pkCol.AutoIncrementSeed = 200;
		pkCol.AutoIncrementStep = 3;
		categoryTable.PrimaryKey = new DataColumn[] { pkCol };
		DataColumn categoryCol = categoryTable.Columns.Add("Category",typeof(String));
		categoryCol.AllowDBNull = false;
		categoryCol.Unique = true;
		categoryTable.Columns.Add(categoryCol);
		
Understanding DataAdapters
Because the DataSet is independent of the data source, a DataSet can include data local to the application, as well as data from multiple data sources, so the interaction with existing data sources is controlled through the DataAdapter. Each ADO.NET provider has a DataAdapter object. A DataAdapter is used to retrieve data from a data source and populate tables within a DataSet. The DataAdapter also persists changes made to the DataSet back to the data source.

The DataAdapter has four properties that are used to retrieve data from and persist data to the data source. The SelectCommand returns data from the data source. The InsertCommand,UpdateCommand, and DeleteCommand are used to manage changes at the data source.

The following example demonstrates how to use Datasets, DataAdapters, Datatables,Constraints and Relations for performing disconnected operations on a database, also shows how to use the properties of a SqlDataAdapter with Store procedures. This example uses the following database to manage a collection of courses and one category per course.

Fig 1. The structure of the sample database.

Fig 2. Running the example, showing the courses.

Fig 3. Adding a new category.

Fig 4. Deleting a row.

Fig 5. Adding a new course on the DataTable.

Fig 6. Save changes of the DataSet back to the Data Source.

 Download the visual studio project for this example.
 Download the database and store procedures scripts for this example.
