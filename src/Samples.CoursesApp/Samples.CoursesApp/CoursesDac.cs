using System;
using System.Data;
using System.Data.SqlClient;

namespace Samples.CoursesApp
{
    internal sealed class CoursesDac
    {
        static SqlDataAdapter categoriesAdapter = CreateCategoriesAdapter();
        static SqlDataAdapter coursesAdapter = CreateCoursesAdapter();

        private static SqlDataAdapter CreateCategoriesAdapter()
        {
            SqlConnection connection = ConnectionManager.GetConnection();
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            //SelectCommand
            dataAdapter.SelectCommand = new SqlCommand("uspGetCategories", connection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            //InsertCommand
            dataAdapter.InsertCommand = new SqlCommand("usp_add_category", connection);
            dataAdapter.InsertCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.InsertCommand.Parameters.Add("@prmcategory", SqlDbType.VarChar,128).SourceColumn = "Category";
            dataAdapter.InsertCommand.Parameters.Add("@prmresultid", SqlDbType.Int).Direction = ParameterDirection.Output;
            dataAdapter.InsertCommand.Parameters.Add("@prmmsgerror", SqlDbType.VarChar,256).Direction = ParameterDirection.Output;            
            //UpdateCommand
            dataAdapter.UpdateCommand = new SqlCommand("usp_update_category", connection);
            dataAdapter.UpdateCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.UpdateCommand.Parameters.Add("@prmCategoryId", SqlDbType.Int).SourceColumn = "Id";
            dataAdapter.UpdateCommand.Parameters.Add("@prmCategory", SqlDbType.VarChar,128).SourceColumn = "Category";
            dataAdapter.UpdateCommand.Parameters.Add("@prmResult", SqlDbType.Bit).Direction = ParameterDirection.Output;
            dataAdapter.UpdateCommand.Parameters.Add("@prmmsgerror", SqlDbType.VarChar,256).Direction = ParameterDirection.Output;
            //deleteCommand
            dataAdapter.DeleteCommand = new SqlCommand("usp_delete_category", connection);
            dataAdapter.DeleteCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.DeleteCommand.Parameters.Add("@prmCategoryId", SqlDbType.Int).SourceColumn = "Id";
            dataAdapter.DeleteCommand.Parameters.Add("@prmResult", SqlDbType.Bit).Direction = ParameterDirection.Output;
            dataAdapter.DeleteCommand.Parameters.Add("@prmmsgerror", SqlDbType.VarChar,256).Direction = ParameterDirection.Output;

            return dataAdapter;
        }

        private static SqlDataAdapter CreateCoursesAdapter()
        {
            SqlConnection connection = ConnectionManager.GetConnection();
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            //SelectCommand
            dataAdapter.SelectCommand = new SqlCommand("uspGetCourses", connection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            //InsertCommand
            dataAdapter.InsertCommand = new SqlCommand("usp_add_course", connection);
            dataAdapter.InsertCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.InsertCommand.Parameters.Add("@prmtitle", SqlDbType.VarChar,128).SourceColumn = "Title";
            dataAdapter.InsertCommand.Parameters.Add("@prmcourseyear", SqlDbType.SmallInt).SourceColumn = "CourseYear";
            dataAdapter.InsertCommand.Parameters.Add("@prmcategoryid", SqlDbType.Int).SourceColumn = "CategoryId";
            dataAdapter.InsertCommand.Parameters.Add("@prmresultid", SqlDbType.Int).Direction = ParameterDirection.Output;
            dataAdapter.InsertCommand.Parameters.Add("@prmmsgerror", SqlDbType.VarChar,256).Direction = ParameterDirection.Output;
            //UpdateCommand
            dataAdapter.UpdateCommand = new SqlCommand("usp_update_course", connection);
            dataAdapter.UpdateCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.UpdateCommand.Parameters.Add("@prmcourseid", SqlDbType.Int).SourceColumn = "CourseId";
            dataAdapter.UpdateCommand.Parameters.Add("@prmtitle", SqlDbType.VarChar,128).SourceColumn = "Title";
            dataAdapter.UpdateCommand.Parameters.Add("@prmyear", SqlDbType.SmallInt).SourceColumn = "CourseYear";
            dataAdapter.UpdateCommand.Parameters.Add("@prmcategoryid", SqlDbType.Int).SourceColumn = "CategoryId";
            dataAdapter.UpdateCommand.Parameters.Add("@prmResult", SqlDbType.Bit).Direction = ParameterDirection.Output;
            dataAdapter.UpdateCommand.Parameters.Add("@prmmsgerror", SqlDbType.VarChar,256).Direction = ParameterDirection.Output;
            //deleteCommand
            dataAdapter.DeleteCommand = new SqlCommand("usp_delete_course", connection);
            dataAdapter.DeleteCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.DeleteCommand.Parameters.Add("@prmcourseid", SqlDbType.Int).SourceColumn = "CourseId";
            return dataAdapter;
        }

        static DataSet CreateCoursesDataSet()
        {
            DataSet coursesDataSet = new DataSet();
            //Add DataTables to the DataSet
            DataTable coursesTable = coursesDataSet.Tables.Add("Courses");
            DataTable categoriesTable = coursesDataSet.Tables.Add("Categories");
            DefineCourseTableSchema(coursesTable);
            DefineCategoriesTableSchema(categoriesTable);
            return coursesDataSet;
        }

        private static void DefineCourseTableSchema(DataTable table)
        {
            //Primary key
            DataColumn coursesIdColumn = table.Columns.Add("CourseId", typeof(int));
            coursesIdColumn.ReadOnly = true;
            coursesIdColumn.AutoIncrement = true;
            table.PrimaryKey = new DataColumn[] {  coursesIdColumn };
            //Columns
            DataColumn coursesTitleColumn = table.Columns.Add("Title", typeof(string));
            coursesTitleColumn.AllowDBNull = false;
            DataColumn coursesYearColumn = table.Columns.Add("CourseYear", typeof(short));
            coursesYearColumn.AllowDBNull = true;
            DataColumn coursesCategoryIdColumn = table.Columns.Add("CategoryId",typeof(int));
            coursesCategoryIdColumn.AllowDBNull = true;

        }

        private static void DefineCategoriesTableSchema(DataTable table)
        {
            //Primary key
            DataColumn categoryIdColumn = table.Columns.Add("Id", typeof(int));
            categoryIdColumn.ReadOnly = true;
            categoryIdColumn.AutoIncrement = true;
            table.PrimaryKey = new DataColumn[] { categoryIdColumn };

            //Columns
            DataColumn categoryColumn = table.Columns.Add("Category",typeof(string));
            categoryColumn.AllowDBNull = false;
            categoryColumn.MaxLength = 128;
            categoryColumn.Unique = true;
        }

        static void DefineConstraintsAndRelations(DataSet coursesDataSet)
        {
            DataColumn parentColumn = coursesDataSet.Tables["Categories"].Columns["Id"];
            DataColumn childColumn = coursesDataSet.Tables["Courses"].Columns["CategoryId"];
            ForeignKeyConstraint constraint = new ForeignKeyConstraint("fk_Courses_Categories", parentColumn, childColumn);
            constraint.DeleteRule = Rule.Cascade;
            constraint.UpdateRule = Rule.Cascade;
            constraint.AcceptRejectRule = AcceptRejectRule.Cascade;
            DataRelation relation = new DataRelation("Courses_Categories_Relation",parentColumn,childColumn);
            coursesDataSet.Relations.Add(relation);
        }

        public static DataSet GetData()
        {
            DataSet coursesDataSet = CreateCoursesDataSet();
            
            coursesDataSet.EnforceConstraints = false;
            categoriesAdapter.Fill(coursesDataSet.Tables["Categories"]);
            coursesAdapter.Fill(coursesDataSet.Tables["Courses"]);
            coursesDataSet.EnforceConstraints = true;
            return coursesDataSet;
        }


        internal static void SaveData(ref DataSet changeDataSet)
        {
            //First Process delete
            //Get the deleted rows
            DataSet deletedDataSet = changeDataSet.GetChanges(DataRowState.Deleted);
            if (deletedDataSet != null)
            {
                //Save the deleted records
                categoriesAdapter.Update(deletedDataSet.Tables["Categories"]);
                coursesAdapter.Update(deletedDataSet.Tables["Courses"]);
                deletedDataSet.Merge(deletedDataSet);
            }
            //Next process updates
            //Get the modified rows
            DataSet modifiedDataSet = changeDataSet.GetChanges(DataRowState.Modified);
            if (modifiedDataSet != null)
            {
                //Save the modified records to database
                categoriesAdapter.Update(modifiedDataSet.Tables["Categories"]);
                coursesAdapter.Update(modifiedDataSet.Tables["Courses"]);
                changeDataSet.Merge(modifiedDataSet);
            }
            //Finally process inserts.
            DataSet addedDataSet = changeDataSet.GetChanges(DataRowState.Added);
            if (addedDataSet != null)
            {
                //Save the changes to database
                categoriesAdapter.Update(addedDataSet.Tables["Categories"]);
                coursesAdapter.Update(addedDataSet.Tables["Courses"]);
                changeDataSet.Merge(addedDataSet);
            }
        }
    }
}
