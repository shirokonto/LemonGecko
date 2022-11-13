using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;

namespace Launcher.Forms
{
    public partial class Settings : Form
    {
        private JsonParser jsonParser;
        private Regex alphaNumRegex = new Regex("^[a-zA-Z][a-zA-Z0-9]*$");
        private List<ScreenReaderItem> allScreenReader;
        private ScreenReaderItem selectedScreenReader;

        public Settings()
        {
            InitializeComponent();
            jsonParser = new JsonParser();
            jsonParser.LoadJsonForKeyMapping();            
            LoadScreenReaderComboBox();
            LoadTableWithMapping();
        }

        private void LoadScreenReaderComboBox()
        {
            allScreenReader = jsonParser.GetAllScreenReader();
            foreach (ScreenReaderItem item in allScreenReader)
            {
                if (!ScreenReaderComboBox.Items.Contains(item.Name))
                {
                    ScreenReaderComboBox.Items.Add(item.Name);
                }
            }
            ScreenReaderComboBox.SelectedIndex = 0;
            selectedScreenReader = allScreenReader.Where(item => item.Name.Equals(ScreenReaderComboBox.SelectedItem.ToString())).First();
        }

        private void LoadTableWithMapping()
        {
            DataTable dataTable = ConvertToDataTable(allScreenReader);
            DataTable filteredResult = dataTable.Select(string.Format("Name='{0}'", 
                ScreenReaderComboBox.SelectedItem.ToString())).CopyToDataTable();
            KeyMappingDataGridView.DataSource = filteredResult;
            KeyMappingDataGridView.Columns["Name"].ReadOnly = true;
        }

        // from here https://stackoverflow.com/questions/65823788/convert-json-data-into-datagridview-c-sharp
        public static DataTable ConvertToDataTable<T>(IList<T> data)
        {
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            if (data != null)
            {
                foreach (T item in data)
                {
                    DataRow row = table.NewRow();
                    foreach (PropertyDescriptor prop in properties)
                        row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                    table.Rows.Add(row);
                }
            }
            return table;
        }

        private void ScreenReaderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedScreenReader = allScreenReader.Where(item => item.Name.Equals(ScreenReaderComboBox.SelectedItem.ToString())).First();
            LoadTableWithMapping();
        }

        private void BackToNavButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void KeyMappingDataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            DataGridViewTextBoxEditingControl tb = (DataGridViewTextBoxEditingControl)e.Control;
            tb.KeyDown += new KeyEventHandler(KeyMappingDataGridView_KeyDown);
            e.Control.KeyDown += new KeyEventHandler(KeyMappingDataGridView_KeyDown);
        }

        private void KeyMappingDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Tab)
            {          
                if (selectedScreenReader != null)
                {
                    string currentColumnName = KeyMappingDataGridView.Columns[KeyMappingDataGridView.CurrentCell.ColumnIndex].Name;
                    switch (currentColumnName)
                    {
                        case "ScreenTap":
                            selectedScreenReader.ScreenTap = SetNewKey(e.KeyCode.ToString());
                            break;
                        case "SwipeLeft":
                            selectedScreenReader.HandSwipeLeft = SetNewKey(e.KeyCode.ToString());
                            break;
                        case "SwipeRight":
                            selectedScreenReader.HandSwipeRight = SetNewKey(e.KeyCode.ToString());
                            break;
                        case "SwipeUp":
                            selectedScreenReader.HandSwipeUp = SetNewKey(e.KeyCode.ToString());
                            break;
                        case "SwipeDown":
                            selectedScreenReader.HandSwipeDown = SetNewKey(e.KeyCode.ToString());
                            break;
                        case "Fist":
                            selectedScreenReader.Fist = SetNewKey(e.KeyCode.ToString());
                            break;
                    }                    
                    jsonParser.SaveChangesToJson(selectedScreenReader);
                    LoadTableWithMapping();
                }
            }
        }

        private string SetNewKey(string keyCode)
        {            
            if (keyCode.Length > 1 || !alphaNumRegex.IsMatch(keyCode))
            {
                KeyCodeObj mapping = jsonParser.GetCodeForKey(keyCode.ToUpper());
                if (mapping != null)
                {
                    return mapping.Code;
                }
            }
            return keyCode;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            //see if the entries where changed
            //if yes
                //save changes

            jsonParser.SaveChangesToJson(selectedScreenReader);
            LoadTableWithMapping();

            //if no 
                //do nothing
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            //LoadTableWithMapping and remove all entries
        }
    }
}
