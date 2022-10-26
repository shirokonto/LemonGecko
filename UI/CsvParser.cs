using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;
using System.IO;
using System.Data;

namespace Launcher
{
    class CsvParser
    {
        private string[] rows = null;
        private DataTable mappingTable;
        public CsvParser()
        {
            mappingTable = new DataTable();
            using (TextFieldParser parser = new TextFieldParser(Properties.Settings.Default.GestureKeystrokeMapping))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");
                while (!parser.EndOfData)
                {
                    string[] rows = parser.ReadFields();
                    foreach(var row in rows)
                    {
                        Console.WriteLine(row);
                    }
                    
                }
            }
        }



        /*
         * Name         ScreenTap   HandSwipeRight  HandSwipeLeft
         * Narrator     {ENTER}     {TAB}       +{TAB}
         */

        public string[] GetKeyStroke(string gesture, string screenReader)
        {
            foreach(string row in rows)
            {
                if (row.Contains(screenReader))
                {
                    return rows;
                }
            }
            return rows;
        }

        public void SetKeyStroke()
        {

        }
    }
}
