using System;

namespace TableauSDKWrapper.Extract
{
    /// <summary>
    /// TableDefinition Class
    /// Represents the schema for a table in a Tableau data extract.
    /// The schema consists of a collection of column definitions, or more specifically name/type pairs.
    /// </summary>
    public class TableDefinition : IDisposable
    {
        private IntPtr m_Handle;
        internal IntPtr Handle
        {
            get { return m_Handle; }
        }

        /// <summary>
        /// Instance of TableDefinition class with using handle.
        /// </summary>
        /// <param name="handle">handle</param>
        public TableDefinition(IntPtr handle)
        {
            m_Handle = handle;
        }

        /// <summary>
        /// Initializes a new instance of the TableDefinition class.
        /// </summary>
        public TableDefinition()
        {
            Int32 result = TableDefinitionNative.Create(out m_Handle);
            Util.CheckResult(result);
        }

        ~TableDefinition()
        {
            Close();
        }
        public void Dispose()
        {
            Close();
        }

        /// <summary>
        /// Closes the TableDefinition object and frees associated memory.
        /// </summary>
        public void Close()
        {
            if (m_Handle != IntPtr.Zero)
            {
                Int32 result = TableDefinitionNative.Close(m_Handle);
                m_Handle = IntPtr.Zero;
                Util.CheckResult(result);
            }
        }

        /// <summary>
        /// Returns the default collation for the table definition. The default is Collation.BINARY (0). 
        /// You can change the default collation by calling SetDefaultCollaction.
        /// </summary>
        /// <returns>The default collation</returns>
        public Collation GetDefaultCollation()
        {
            Int32 retval;
            Int32 result = TableDefinitionNative.GetDefaultCollation(m_Handle, out retval);
            Util.CheckResult(result);

            return retval.ToCollation();
        }

        /// <summary>
        /// Sets the default collation for new string columns.
        /// </summary>
        /// <param name="collation">The default collation for new string columns</param>
        public void SetDefaultCollation(Collation collation)
        {
            Int32 result = TableDefinitionNative.SetDefaultCollation(m_Handle, collation.ToInt());
            Util.CheckResult(result);
        }

        /// <summary>
        /// Adds a column to the table definition. 
        /// The order in which columns are added specifies their column number. 
        /// String columns are defined with the current default collation. 
        /// Note: A couple of phrases are reserved in Tableau, ':Measure Names', 'Multiple Values', and 'Number of Records'. 
        /// Please avoid using them as the column names.
        /// </summary>
        /// <param name="name">The name of the column to add</param>
        /// <param name="type">The data type of the column to add</param>
        public void AddColumn(String name, Type type)
        {
            Int32 result = TableDefinitionNative.AddColumn(m_Handle, name, type.ToInt());
            Util.CheckResult(result);
        }

        /// <summary>
        /// Adds a column that has the specified collation.
        /// </summary>
        /// <param name="name">The name of the column to add</param>
        /// <param name="type">The data type of the column to add</param>
        /// <param name="collation">For string columns, the collation to use. For other types of columns, this value is ignored.</param>
        public void AddColumnWithCollation(String name, Type type, Collation collation)
        {
            Int32 result = TableDefinitionNative.AddColumnWithCollation(m_Handle, name, type.ToInt(), collation.ToInt());
            Util.CheckResult(result);
        }

        /// <summary>
        /// Returns the number of columns in the table definition.
        /// </summary>
        /// <returns>The number of columns</returns>
        public Int32 GetColumnCount()
        {
            Int32 retval;
            Int32 result = TableDefinitionNative.GetColumnCount(m_Handle, out retval);
            Util.CheckResult(result);

            return retval;
        }

        /// <summary>
        /// Returns the name of the specified column.
        /// </summary>
        /// <param name="columnNumber">The column number (zero-based) to return the name for</param>
        /// <returns>The column name</returns>
        public string GetColumnName(Int32 columnNumber)
        {
            IntPtr namePtr;
            Int32 result = TableDefinitionNative.GetColumnName(m_Handle, columnNumber, out namePtr);
            Util.CheckResult(result);

            return namePtr.ToString();
        }

        /// <summary>
        /// Returns the data type of the specified column.
        /// </summary>
        /// <param name="columnNumber">The column number (zero-based) to return the name for</param>
        /// <returns>The column data type</returns>
        public Type GetColumnType(Int32 columnNumber)
        {
            Int32 retval;
            Int32 result = TableDefinitionNative.GetColumnType(m_Handle, columnNumber, out retval);
            Util.CheckResult(result);

            return retval.ToType();
        }

        /// <summary>
        /// Returns the collation of the specified column.
        /// </summary>
        /// <param name="columnNumber">The column number (zero-based) to return the collation for</param>
        /// <returns>The column collation</returns>
        public Collation GetColumnCollation(Int32 columnNumber)
        {
            Int32 retval;
            Int32 result = TableDefinitionNative.GetColumnCollation(m_Handle, columnNumber, out retval);
            Util.CheckResult(result);

            return retval.ToCollation();
        }
    }
}
