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
                            List<Sections> sections = new List<Sections>();

                            while(reader.Read())
                            {
                                sections.Add(new Sections
                                {
                                    Id = reader.GetInt32(0),      
                                    SectionName = reader.GetString(1),
                                    SectionText = reader.GetString(2)
                                });
                            }

                            return sections;
                        }
                    }
                }
            }
            catch (Exception ex) 
            {  Console.WriteLine(ex.Message); }

            return null;
        }
    }
    internal class SQLiteHelper2
    {
        internal static object GetQuestions()
        {
            try
            {
                using (var connection = new SQLiteConnection("@Data Source=db.sqlite;Version=3;"))
                {
                    connection.Open();
                    using (var cmd = new SQLiteCommand(@"SELECT id, question_text, first_option, second_option, third_option, right_option FROM Questions;", connection))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            List<Questions> questions = new List<Questions>();

                            while (reader.Read())
                            {
                                questions.Add(new Questions
                                {
                                    Id = reader.GetInt32(0),
                                    QuestionText = reader.GetString(1),
                                    FirstOption = reader.GetString(2),
                                    SecondOption = reader.GetString(3),
                                    ThirdOption = reader.GetString(4),
                                    RightOption = reader.GetInt64(5)
                                });
                            }

                            return questions;
                        }
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            { Console.WriteLine(ex.Message); }

            return null;
        }
    }
}
