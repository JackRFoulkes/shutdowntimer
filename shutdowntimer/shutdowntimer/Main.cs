using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static shutdowntimer.Classes.ShutdownOptions;

namespace shutdowntimer
{
    public partial class Main : Form
    {

        #region Private Variables
        private DateTime dtShutdown;
        private int selectedOption;
        #endregion

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            try
            {
                // Load Data (Comboboxes etc...)
                LoadData();
            }
            catch (Exception ex)
            {
                // Show error message
                MessageBox.Show("Application failed to load, please try again due to the following reason:" + Environment.NewLine + ex.Message);
            }

            //TimerPickerShutdownIn.Value = DateTime.Today;

            //TimerPickerShutdownAtTime.Value = DateTime.Now;

            //DateTimePickerShutdownOnDateTime.Value = DateTime.Today.AddDays(1);
            //DateTimePickerShutdownOnDateTime.MinDate = DateTimePickerShutdownOnDateTime.Value;

            //RadioShutdownIn.Checked = true;

            lblVersion.Text = "Version " + Application.ProductVersion;
        }

        private void LoadData()
        {
            cmbAction.DataSource = Enum.GetValues(typeof(Actions));
            cmbAction.SelectedItem = Actions.Shutdown;
        }
    }
}