using System;
using System.Windows.Forms;

namespace MovieLibrary.Winhost
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load ( object sender, EventArgs e )
        {

        }

        private void mainMenu_ItemClicked ( object sender, ToolStripItemClickedEventArgs e )
        {

        }

        private void OnHelpAbout ( object sender, EventArgs e )
        {
            // MessageBox.Show("Help - About");
            var form = new AboutBox();

            //show the form modally
            form.ShowDialog();
            //form.Show(); //modeless



        }

        private void OnFileExit ( object sender, EventArgs e )
        {
            //display a conformation and quit if yes
            var result = MessageBox.Show(this,"Are you sure if you want to exit)", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                return;
            //Close the form
            Close();

        }
    }
}
