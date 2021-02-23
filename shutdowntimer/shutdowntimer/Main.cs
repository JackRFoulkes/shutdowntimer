using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        private bool onStopImage;
        #endregion

        #region Form Load
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            try
            {
                // Load Data (Comboboxes, default dates etc...)
                LoadData();

                // Set version text
                lblVersion.Text = "Version: " + Application.ProductVersion;

                // lblAction has starting focus
                this.ActiveControl = lblAction;

                // Start Button
                btnStart.Image = (Image)(new Bitmap(Properties.Resources.Shutdown_Timer_Logo_128_x_128_Opacity_30, new Size(60, 60)));
            }
            catch (Exception ex)
            {
                // Show error message
                MessageBox.Show("Application failed to load, please try again due to the following reason:" + Environment.NewLine + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Private Methods
        private void LoadData()
        {
            try
            {
                // Actions data source
                cmbAction.DataSource = Enum.GetValues(typeof(Actions));
                cmbAction.SelectedItem = Actions.Shutdown;

                // Set datatime pickers
                dtShutDownIn.Value = DateTime.Today;

                dtShutDownAt.Value = DateTime.Now;

                dtShutDownOn.Value = DateTime.Today.AddDays(1);
                dtShutDownOn.MinDate = dtShutDownOn.Value;

                // Default radio button checked
                radioShutdownIn.Checked = true;
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void Shutdown()
        {
            // Stop Timer
            timer.Stop();

            StringBuilder args = new StringBuilder();

            // Set args based on selected items
            switch (cmbAction.SelectedItem)
            {
                case Actions.Shutdown:
                    args.Append("/s /t 0");
                    break;

                case Actions.Restart:
                    args.Append("/r /t 0");
                    break;

                case Actions.Logout:
                    args.Append("/l");
                    break;

                default:
                    args.Append("/s");
                    break;
            }

            // Force close?
            if (chkForceClose.Checked)
            {
                args.Append(" /f");
            }

            // Start the process
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = false;
            startInfo.UseShellExecute = false;
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.FileName = "shutdown.exe";
            startInfo.Arguments = args.ToString();
            Process.Start(startInfo);
        }
        private bool CheckOption()
        {
            // Shutdown In
            if (radioShutdownIn.Checked && dtShutDownIn.Value.TimeOfDay != TimeSpan.Zero)
            {
                dtShutdown = dtShutDownIn.Value;
                selectedOption = (int)Options.ShutdownIn;
                return true;
            }
            // Shutdown At
            else if (radioShutdownAt.Checked && dtShutDownAt.Value.TimeOfDay != TimeSpan.Zero)
            {
                if (dtShutDownAt.Value.TimeOfDay < DateTime.Today.TimeOfDay)
                {
                    return false;
                }
                else
                {
                    dtShutdown = dtShutDownAt.Value;
                    selectedOption = (int)Options.ShutdownAt;
                    return true;
                }
            }
            // Shutdown On
            else if (radioShutdownOn.Checked && dtShutDownOn.Value.Date != DateTime.Now.Date)
            {
                dtShutdown = dtShutDownOn.Value;
                selectedOption = (int)Options.ShutdownOn;
                return true;
            }
            else
            {
                return false;
            }
        }
        private void SwapEnabledControls()
        {
            try
            {
                // Switch control states
                cmbAction.Enabled = !cmbAction.Enabled;

                chkForceClose.AutoCheck = !chkForceClose.AutoCheck;

                radioShutdownIn.AutoCheck = !radioShutdownIn.AutoCheck;
                dtShutDownIn.Enabled = !dtShutDownIn.Enabled;

                radioShutdownAt.AutoCheck = !radioShutdownAt.AutoCheck;
                dtShutDownAt.Enabled = !dtShutDownAt.Enabled;

                radioShutdownOn.AutoCheck = !radioShutdownOn.AutoCheck;
                dtShutDownOn.Enabled = !dtShutDownOn.Enabled;
            }
            catch (Exception)
            {
            }
        }
        #endregion

        #region Timer
        private void timer_Tick(object sender, EventArgs e)
        {
            // Every second ...
            try
            {
                // Shutdown In
                if (selectedOption == (int)Options.ShutdownIn)
                {
                    if (dtShutdown.TimeOfDay != TimeSpan.Zero)
                    {
                        dtShutdown = dtShutdown.AddSeconds(-1);
                        dtShutDownIn.Value = dtShutdown;
                    }
                    else
                    {
                        Shutdown();
                    }
                }
                // Shutdown At
                else if (selectedOption == (int)Options.ShutdownAt)
                {
                    if (DateTime.Now.ToString("T") == dtShutdown.ToString("T"))
                    {
                        Shutdown();
                    }
                }
                // Shutdown On
                else if (selectedOption == (int)Options.ShutdownOn)
                {
                    if (DateTime.Today.Date == dtShutdown.Date)
                    {
                        Shutdown();
                    }
                }
            }
            catch (Exception)
            {
            }
        }
        #endregion

        #region Date Timer Picker Events
        private void dtShutDownOn_ValueChanged(object sender, EventArgs e)
        {
            // Shutdown On
            if (dtShutDownOn.Value.TimeOfDay != TimeSpan.Zero)
            {
                dtShutDownOn.Value = dtShutDownOn.Value.Date;
            }
        }
        #endregion

        #region Start Button
        private void btnStart_MouseEnter(object sender, EventArgs e)
        {
            try
            {
                if (timer.Enabled)
                {
                    // Show stop image
                    btnStart.Image = Properties.Resources.Shutdown_Timer_Logo_Stop_60_x_60;
                    onStopImage = true;
                }
                else
                {
                    btnStart.Image = (Image)(new Bitmap(Properties.Resources.Shutdown_Timer_Logo_128_x_128, new Size(60, 60)));
                }
            }
            catch (Exception)
            {
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                if (timer.Enabled)
                {
                    timer.Stop();
                    SwapEnabledControls();
                    btnStart.Image = (Image)(new Bitmap(Properties.Resources.Shutdown_Timer_Logo_128_x_128_Opacity_30, new Size(60, 60)));
                }
                else
                {
                    if (CheckOption())
                    {
                        timer.Enabled = true;
                        btnStart.Image = Properties.Resources.Shutdown_Timer_Logo_Animated_60_x_60;
                        SwapEnabledControls();
                    }
                    else
                    {
                        MessageBox.Show("Please set an appropiate timer option", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
            catch (Exception)
            {
            }
        }

        private void btnStart_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                if (timer.Enabled)
                {
                    if(onStopImage)
                    {
                        btnStart.Image = Properties.Resources.Shutdown_Timer_Logo_Animated_60_x_60;
                    }
                }
                else
                {
                    btnStart.Image = (Image)(new Bitmap(Properties.Resources.Shutdown_Timer_Logo_128_x_128_Opacity_30, new Size(60, 60)));
                }
            }
            catch (Exception)
            {
            }
        }
        #endregion
    }
}