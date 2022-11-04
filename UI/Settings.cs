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

namespace Launcher
{
    public partial class Settings : Form
    {
        private JsonParser jsonParser;
        private Regex alphaNumRegex = new Regex("^[a-zA-Z][a-zA-Z0-9]*$");
        private List<ScreenReaderItem> allScreenReader;
        private bool controllerConnected;
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);
        private const int CB_SETCUEBANNER = 0x1703;

        public Settings()
        {
            InitializeComponent();
            jsonParser = new JsonParser();
            jsonParser.LoadJsonForKeyMapping();            
            LoadScreenReaders();
            SetKeyMappings();

        }

        private void LoadScreenReaders()
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
        }

        private void SetKeyMappings()
        {
            // for selected item
            int currentIndex = ScreenReaderComboBox.SelectedIndex;
            // if current selection is not null: if (currentScreenReader != null)
            // TODO only take one row
            //DataTable dataTable = ConvertToDataTable(allScreenReader[currentIndex]);
            KeyMappingDataGridView.DataSource = dataTable;
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
    }
}
