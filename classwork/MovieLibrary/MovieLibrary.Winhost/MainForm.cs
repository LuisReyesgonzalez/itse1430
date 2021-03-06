﻿using System;
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
            do
            {
                if (form.ShowDialog(this)==DialogResult.Cancel)
                    return;


                //TODO: "Save" the movie
                _database.Add(form.Movie, out var error);
                if (string.IsNullOrEmpty(error))
                    break;

                    DisplayError("Add Failed", error);
            } while (true);

            UpdateUI();


        }

        private void DisplayError ( string title, string message )
        {
            MessageBox.Show(this, message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void OnMovieDelete ( object sender, EventArgs e )
        {
            //If a Movie exist then display conformation then delete
            var movie = GetSelectedMovie();
            if (movie==null)
                return;

            var result =   MessageBox.Show(this, $"Are you sure want to delete'{movie.Title}'?" , "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                return;

            //TODO: delete the movie
            _movie=null;

            UpdateUI();
        }

        //standard event signature -object sender,EventArgs (or devired)
        private void OnMovieEdit ( object sender, EventArgs e )
        {
            //If a Movie exist then display conformation then delete
            var movie = GetSelectedMovie();
            if (_movie==null)
                return;

            var form = new MovieDetailForm();
            form.Movie= movie;

            if (form.ShowDialog(this)==DialogResult.Cancel)
                return;


            //TODO: "Save" the movie
            _movie=form.Movie;

            //TODO: IF the movie exist then edit movie and update info
            UpdateUI();
        }
        private Movie GetSelectedMovie()
        {
            //Cast SelectedItem as movie
           return lstMovies.SelectedItem as Movie;
                   
        }
        private void UpdateUI()
        {
            var movies = _database.GetAll();
            //Can bind listbox using Items or DataSource
            //lstMovies.Items
            lstMovies.DataSource = movies;
            lstMovies.DisplayMember="Title";
            //lstMovies.ValueMember="id";
        }
        private Movie _movie;
        private readonly MovieDatabase _database = new MovieDatabase();
    
    
    }
}
