using System;
using System.Windows.Forms;

namespace CharacterCreator.WinHost
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void miHelpAbout_Click ( object sender, EventArgs e )
        {
            var form = new AboutBox();
            form.ShowDialog();
        }

        //Exit 
        private void OnFileExit ( object sender, EventArgs e )
        {
            //Display of confirmation to exit
            var result =MessageBox.Show(this, "Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result!=DialogResult.Yes)
                return;

            //Close the form
            Close();
        }
    }
}
