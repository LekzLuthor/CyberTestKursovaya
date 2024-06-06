using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberTestKursovaya.DAL
{
    internal class SQLiteHelper
    {
        internal static object GetSections()
        {
            try
            {
                using(var connection = new SQLiteConnection("Data Source=db.sqlite;Version=3;"))
                {
                    connection.Open();
                    using(var cmd = new SQLiteCommand(@"SELECT id, section_name, section_text FROM Theory;", connection)) 
                    { 
                        using(var reader = cmd.ExecuteReader())
                        {
                            String[] sectionNames = new string[5];

                            int id;
                            string sectionName;
                            string sectionText;

                            while(reader.Read())
                            {
                                id = reader.GetInt32(0);
                                sectionName = reader.GetString(1);
                                sectionNames[id - 1] = sectionName;

                            }
                            return sectionNames;
                        }
                    }
                }
            }
            catch (Exception ex) 
            {  Console.WriteLine(ex.Message); }
            return null;
        }

        internal static object GetSectionsTexts()
        {
            try
            {
                using (var connection = new SQLiteConnection("Data Source=db.sqlite;Version=3;"))
                {
                    connection.Open();
                    using (var cmd = new SQLiteCommand(@"SELECT id, section_name, section_text FROM Theory;", connection))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            String[] sectionNames = new string[5];
                            String[] sectionTexts = new string[5];

                            int id;
                            string sectionName;
                            string sectionText;

                            while (reader.Read())
                            {
                                id = reader.GetInt32(0);
                                sectionText = reader.GetString(2);
                                sectionTexts[id - 1] = sectionText;

                            }

                            return sectionTexts;
                        }
                    }
                }
            }
            catch (Exception ex)
            { Console.WriteLine(ex.Message); }
            return null;
        }
    }
}
