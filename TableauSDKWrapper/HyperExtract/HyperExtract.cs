using System;

namespace TableauSDKWrapper.Hyper
{
    /// <summary>
    /// Hyper Extract Class
    /// Represents a Tableau Data Engine database.
    /// </summary>
    public class Extract : IDisposable
    {
        private IntPtr m_Handle;
        internal IntPtr Handle
        {
            get { return m_Handle; }
        }
        private const string nameofTable = "Extract";

        /// <summary>
        /// Initializes an extract object using a file system path and file name.
        /// If the extract file already exists, this method opens the extract.
        /// If the file does not already exist, the method initializes a new extract.
        /// </summary>
        /// <param name="path">The path and file name of the extract file to create or open. The path must include the ".hyper" extension.</param>
        public Extract(String path)
        {
            Int32 result = HyperExtractNative.Create(out m_Handle, path);
            Util.CheckResult(result);
        }
        ~Extract()
        {
            Close();
        }
        public void Dispose()
        {
            Close();
        }

        /// <summary>
        /// Closes the extract and any open tables that it contains.
        /// You must call this method in order to save the extract to a .tde file and to release its resources.
        /// Note: This method is called from ~Extract() and Dispose().
        /// </summary>
        public void Close()
        {
            if (m_Handle != IntPtr.Zero)
            {
                Int32 result = HyperExtractNative.Close(m_Handle);
                m_Handle = IntPtr.Zero;
                Util.CheckResult(result);
            }
        }

        /// <summary>
        /// Adds a table to the extract.
        /// </summary>
        /// <param name="name">The name of the table to add. Currently, this method can only add a table named "Extract".</param>
        /// <param name="tableDefinition">The schema of the new table</param>
        /// <returns>A reference to the table</returns>
        public Table AddTable(String name, TableDefinition tableDefinition)
        {
            IntPtr retval = IntPtr.Zero;
            Int32 result = HyperExtractNative.AddTable(m_Handle, name, tableDefinition.Handle, out retval);
            Util.CheckResult(result);

            return new Table(retval);
        }

        /// <summary>
        /// Adds a table to the extract.
        /// The name of table is fixed to "Extract".
        /// </summary>
        /// <param name="tableDefinition">The schema of the new table</param>
        /// <returns>A reference to the table</returns>
        public Table AddTable(TableDefinition tableDefinition)
        {
            return AddTable(nameofTable, tableDefinition);
        }

        /// <summary>
        /// Opens the specified table in the extract.
        /// </summary>
        /// <param name="name">The name of the table to open. Currently, this method can only open a table named "Extract".</param>
        /// <returns>A reference to the table</returns>
        public Table OpenTable(String name)
        {
            IntPtr retval = IntPtr.Zero;
            Int32 result = HyperExtractNative.OpenTable(m_Handle, name, out retval);
            Util.CheckResult(result);

            return new Table(retval);
        }

        /// <summary>
        /// Opens the specified table in the extract.
        /// The name of table is fixed to "Extract".
        /// </summary>
        /// <returns>A reference to the table</returns>
        public Table OpenTable()
        {
            return OpenTable(nameofTable);
        }

        /// <summary>
        /// Deterrmines whether the specified table exists in the extract.
        /// </summary>
        /// <param name="name">The name of the table</param>
        /// <returns>True if the specified table exists; otherwise, false.</returns>
        public bool HasTable(String name)
        {
            Int32 retval;
            Int32 result = HyperExtractNative.HasTable(m_Handle, name, out retval);
            Util.CheckResult(result);

            return retval.ToBoolean();
        }

        /// <summary>
        /// Deterrmines whether the specified table exists in the extract.
        /// The name of table is fixed to "Extract".
        /// </summary>
        /// <returns>True if the specified table exists; otherwise, false.</returns>
        public bool HasTable()
        {
            return HasTable(nameofTable);
        }

    }
}
