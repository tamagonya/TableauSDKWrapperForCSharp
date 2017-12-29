using System;

namespace TableauSDKWrapper.Hyper
{
    /// <summary>
    /// Hyper Row Class
    /// Defines a row to be inserted into a table in an extract. 
    /// The row is structured as a tuple.
    /// </summary>
    public class Row : IDisposable
    {
        private IntPtr m_Handle;
        internal IntPtr Handle
        {
            get { return m_Handle; }
        }

        /// <summary>
        /// Initializes a new instance of the Row class.
        /// This method creates an empty row that has the specified schema.
        /// </summary>
        /// <param name="tableDefinition">The schema to use</param>
        public Row(TableDefinition tableDefinition)
        {
            Int32 result = HyperRowNative.Create(out m_Handle, tableDefinition.Handle);
            Util.CheckResult(result);
        }
        ~Row()
        {
            Close();
        }
        public void Dispose()
        {
            Close();
        }

        /// <summary>
        /// Closes the row and frees associated resources.
        /// </summary>
        public void Close()
        {
            if (m_Handle != IntPtr.Zero)
            {
                Int32 result = HyperRowNative.Close(m_Handle);
                m_Handle = IntPtr.Zero;
                Util.CheckResult(result);
            }
        }

        /// <summary>
        /// Sets the specified column in the row to null.
        /// </summary>
        /// <param name="columnNumber">The column number (zero-based) to set a value for</param>
        public void SetNull(Int32 columnNumber)
        {
            Int32 result = HyperRowNative.SetNull(m_Handle, columnNumber);
            Util.CheckResult(result);
        }

        /// <summary>
        /// Sets the specified column in the row to a 32-bit unsigned integer value.
        /// </summary>
        /// <param name="columnNumber">The column number (zero-based) to set a value for</param>
        /// <param name="value">The 32-bit integer value</param>
        public void SetInteger(Int32 columnNumber, Int32 value)
        {
            Int32 result = HyperRowNative.SetInteger(m_Handle, columnNumber, value);
            Util.CheckResult(result);
        }

        /// <summary>
        /// Sets the specified column in the row to a 64-bit unsigned integer value.
        /// </summary>
        /// <param name="columnNumber">The column number (zero-based) to set a value for</param>
        /// <param name="value">The 64-bit integer value</param>
        public void SetLongInteger(Int32 columnNumber, Int64 value)
        {
            Int32 result = HyperRowNative.SetLongInteger(m_Handle, columnNumber, value);
            Util.CheckResult(result);
        }

        /// <summary>
        /// Sets the specified column in the row to a double value.
        /// </summary>
        /// <param name="columnNumber">The column number (zero-based) to set a value for</param>
        /// <param name="value">The double value</param>
        public void SetDouble(Int32 columnNumber, double value)
        {
            Int32 result = HyperRowNative.SetDouble(m_Handle, columnNumber, value);
            Util.CheckResult(result);
        }

        /// <summary>
        /// Sets the specified column in the row to a Boolean value.
        /// </summary>
        /// <param name="columnNumber">The column number (zero-based) to set a value for</param>
        /// <param name="value">True or false</param>
        public void SetBoolean(Int32 columnNumber, bool value)
        {
            Int32 result = HyperRowNative.SetBoolean(m_Handle, columnNumber, value ? 1 : 0);
            Util.CheckResult(result);
        }

        /// <summary>
        /// Sets the specified column in the row to a string value.
        /// </summary>
        /// <param name="columnNumber"The column number (zero-based) to set a value for></param>
        /// <param name="value">The string value</param>
        public void SetString(Int32 columnNumber, String value)
        {
            Int32 result = HyperRowNative.SetString(m_Handle, columnNumber, value);
            Util.CheckResult(result);
        }

        /// <summary>
        /// Sets the specified column in the row to a string value.
        /// </summary>
        /// <param name="columnNumber">The column number (zero-based) to set a value for</param>
        /// <param name="value">The string value</param>
        public void SetCharString(Int32 columnNumber, String value)
        {
            Int32 result = HyperRowNative.SetCharString(m_Handle, columnNumber, value.ToStringBuilder());
            Util.CheckResult(result);
        }

        /// <summary>
        /// Sets the specified column in the row to a date value.
        /// </summary>
        /// <param name="columnNumber">The column number (zero-based) to set a value for</param>
        /// <param name="year">The year</param>
        /// <param name="month">The month</param>
        /// <param name="day">The day</param>
        public void SetDate(Int32 columnNumber, Int32 year, Int32 month, Int32 day)
        {
            Int32 result = HyperRowNative.SetDate(m_Handle, columnNumber, year, month, day);
            Util.CheckResult(result);
        }

        /// <summary>
        /// Sets the specified column in the row to a date-time value.
        /// </summary>
        /// <param name="columnNumber">The column number (zero-based) to set a value for</param>
        /// <param name="year">The year</param>
        /// <param name="month">The month</param>
        /// <param name="day">The day</param>
        /// <param name="hour">The hour</param>
        /// <param name="min">The minute</param>
        /// <param name="sec">The second</param>
        /// <param name="frac">The fraction of a second as one tenth of a millisecond (1/10000)</param>
        public void SetDateTime(Int32 columnNumber, Int32 year, Int32 month, Int32 day, Int32 hour, Int32 min, Int32 sec, Int32 frac)
        {
            Int32 result = HyperRowNative.SetDateTime(m_Handle, columnNumber, year, month, day, hour, min, sec, frac);
            Util.CheckResult(result);
        }

        /// <summary>
        /// Sets the specified column in the row to a duration value (time span)
        /// </summary>
        /// <param name="columnNumber">The column number (zero-based) to set a value for</param>
        /// <param name="day">The day</param>
        /// <param name="hour">The hour</param>
        /// <param name="min">The minute</param>
        /// <param name="sec">The second</param>
        /// <param name="frac">The fraction of a second as one tenth of a millisecond (1/10000)</param>
        public void SetDuration(Int32 columnNumber, Int32 day, Int32 hour, Int32 min, Int32 sec, Int32 frac)
        {
            Int32 result = HyperRowNative.SetDuration(m_Handle, columnNumber, day, hour, min, sec, frac);
            Util.CheckResult(result);
        }

        /// <summary>
        /// Sets the specified column in the row to a geospatial value.
        /// </summary>
        /// <param name="columnNumber">The column number (zero-based) to set a value for</param>
        /// <param name="value">The spatial value in string</param>
        public void SetSpatial(Int32 columnNumber, String value)
        {
            Int32 result = HyperRowNative.SetSpatial(m_Handle, columnNumber, value.ToStringBuilder());
            Util.CheckResult(result);
        }
    }
}
