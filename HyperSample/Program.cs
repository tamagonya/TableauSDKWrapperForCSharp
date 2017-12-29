using System;
using TableauSDKWrapper;
using TableauSDKWrapper.Hyper;
using TDEType = TableauSDKWrapper.Type;

namespace HyperSample
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "sample.hyper";
            using (ExtractAPI extract = new ExtractAPI())
            {
                PopulateExtract(fileName, true);
            }
            Console.WriteLine("Fin");
        }

        static bool PopulateExtract(string fileName, bool useSpatial)
        {
            bool succeeded = false;
            try
            {
                string tableName = "Extract";
                using (Extract extract = new Extract(fileName))
                {
                    if (!extract.HasTable(tableName))
                    {
                        using (TableDefinition schema = new TableDefinition())
                        {
                            schema.AddColumn("Purchased", TDEType.Type_DateTime);
                            schema.AddColumn("Product", TDEType.Type_CharString);
                            schema.AddColumn("uProduct", TDEType.Type_UnicodeString);
                            schema.AddColumn("Price", TDEType.Type_Double);
                            schema.AddColumn("Quantity", TDEType.Type_Integer);
                            schema.AddColumn("Taxed", TDEType.Type_Boolean);
                            schema.AddColumn("Expiration Date", TDEType.Type_Date);
                            if (useSpatial)
                            {
                                schema.AddColumn("Destination", TDEType.Type_Spatial);
                            }

                            Table table = extract.AddTable(tableName, schema);
                            Row row = new Row(schema);
                            row.SetDateTime(0, 2012, 7, 3, 11, 40, 12, 4550);   // Purchased
                            row.SetCharString(1, "Beans");                      // Product
                            row.SetString(2, "uniBeans");                       // unicode Product
                            row.SetDouble(3, 1.08);                             // Price
                            row.SetDate(6, 2029, 1, 1);                         // Expiration date
                            if (useSpatial)
                            {
                                row.SetSpatial(7, "POINT (30 10)");             // Destination
                            }

                            for (int i = 0; i < 10; ++i)
                            {
                                row.SetInteger(4, i * 10);                      // Quantity
                                row.SetBoolean(5, i % 2 == 1);                  // Taxed
                                table.Insert(row);
                            }
                        }
                        succeeded = true;
                    }
                    else
                    {
                        Console.WriteLine("Table exists. Skipping operation.");
                    }
                }
            }
            catch (TableauException ex)
            {
                Console.WriteLine("PopulateExtract Error: [{0}] {1}", ex.GetResultCode(), ex.GetMessage());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return succeeded;
        }

    }
}
