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

        private void OnMovieAdd ( object sender, EventArgs e )
        {
            var form = new MovieDetailForm();
            if (form.ShowDialog(this)==DialogResult.Cancel)
                return;


            //TODO: "Save" the movie
            //_movie=;
            MessageBox.Show("saved the movie");
        }

        private void OnMovieDelete ( object sender, EventArgs e )
        {
            //If a Movie exist then display conformation then delete
            if (_movie==null)
                return;

            var result =   MessageBox.Show(this, $"Are you sure want to delete'{_movie.Title}'?" , "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                return;

            //TODO: delete
            MessageBox.Show("Deleted the movie");
            _movie=null;
        }

        private void OnMovieEdit ( object sender, EventArgs e )
        {
            //TODO: IF the movie exist then edit movie and update info
        }
        private Movie _movie;
    }
}
