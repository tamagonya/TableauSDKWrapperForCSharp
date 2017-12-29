using System;

namespace TableauSDKWrapper.Extract
{
    /// <summary>
    /// Table Class
    /// Represents a data table in the extract.
    /// </summary>
    public class Table
    {
        private IntPtr m_Handle;
        public Table(IntPtr handle)
        {
            m_Handle = handle;
        }

        /// <summary>
        /// Queues a row for insertion into the table.
        /// This method might insert a set of buffered rows.
        /// </summary>
        /// <param name="row">The row to insert</param>
        public void Insert(Row row)
        {
            Int32 result = TableNative.Insert(m_Handle, row.Handle);
            Util.CheckResult(result);
        }

        /// <summary>
        /// Gets the table's schema.
        /// </summary>
        /// <returns>The TableDefinition</returns>
        public TableDefinition GetTableDefinition()
        {
            IntPtr retval = IntPtr.Zero;
            Int32 result = TableNative.GetTableDefinition(m_Handle, out retval);
            Util.CheckResult(result);

            return new TableDefinition(retval);
        }
    }
}
