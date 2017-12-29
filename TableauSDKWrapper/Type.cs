namespace TableauSDKWrapper
{
    /// <summary>
    /// Type
    /// </summary>
    public enum Type
    {
        Type_Integer = 0x0007,          // TDE_DT_SINT64
        Type_Double = 0x000A,           // TDE_DT_DOUBLE
        Type_Boolean = 0x000B,          // TDE_DT_BOOL
        Type_Date = 0x000C,             // TDE_DT_DATE
        Type_DateTime = 0x000D,         // TDE_DT_DATETIME
        Type_Duration = 0x000E,         // TDE_DT_DURATION
        Type_CharString = 0x000F,       // TDE_DT_STR
        Type_UnicodeString = 0x0010,    // TDE_DT_WSTR
        Type_Spatial = 0x0011,          // TDE_DT_SPATIAL
    }
}
