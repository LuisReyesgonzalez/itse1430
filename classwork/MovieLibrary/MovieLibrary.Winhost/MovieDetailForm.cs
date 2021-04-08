﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieLibrary.Winhost
{
    //Control
    //button
    //Checkbox
    //form
    //label
    //textbox

    //Form lifetime
    //Ctor()
    // Show/ShowDialog()
    /// </summary>
    //Onload()
    //Load event
    //OnPaint()
    //...close()
    //OnFormClosing()
    //  OnFormClosing event()(Before)
    //OnFormClosed()
    //FormClosed event (after

    public partial class MovieDetailForm : Form
    {
        public MovieDetailForm ()
        {
            InitializeComponent();
        }
        public Movie Movie { get ; set;}

        protected override void OnFormClosing ( FormClosingEventArgs e )
        {
            base.OnFormClosing(e);
            //Do any dirty detection
            if(false)
            e.Cancel=true;

        }
        //This is called just before the form is rendered the first time
        protected override void OnLoad ( EventArgs e )
        {
            //Call the base member
            base.OnLoad(e);

            //Load if movie is set
            if (Movie != null)
                LoadMovie(Movie);
        }

        private void OnSave ( object sender, EventArgs e )
        {
            //Validate UI
            if(ValidateChildren())
            {
                DialogResult=DialogResult.None;
                return;
            };
            //Creating movie
            var movie = SaveMovie();

            //Valdation
            if (!movie.Validate(out var error))
            {
                MessageBox.Show(this, error, "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult=DialogResult.None;
                return;
            };
            Movie= movie; 

            this.DialogResult=DialogResult.OK;
            Close();
        }

        private void OnCancel ( object sender, EventArgs e )
        {
            Close();
        }
        private int GetInt32(Control control)
        { var text = control.Text;
            if (Int32.TryParse(text, out var result))
                return result;

            return -1;
        }
        private void LoadMovie(Movie movie )
        {
            txtTitle.Text=movie.Title;
            txtDescription.Text=movie.Description;

            cbRating.SelectedItem=movie.Rating;
            
            txtRunLength.Text = movie.RunLength.ToString();
            txtReleaseYear.Text = movie.ReleaseYear.ToString();
           
            ckIsClassic.Checked= movie.IsClassic;

        }
        private Movie SaveMovie ( )
        {
            var movie = new Movie();
            movie.Title=txtTitle.Text;
            movie.Description=txtDescription.Text;

            movie.Rating=cbRating.SelectedItem as string;
            
            movie.RunLength=GetInt32(txtRunLength);
            movie.ReleaseYear=GetInt32(txtReleaseYear);
            
            movie.IsClassic= ckIsClassic.Checked;
            
            return movie;
            
        }

        private void OnValidatingTitle ( object sender, CancelEventArgs e )
        {
            var control = sender as TextBox;
            if (String.IsNullOrEmpty(control.Text))
            { //Invalid 
                _errors.SetError(control, "Title is required");
                e.Cancel=true;
            }else
            {
                _errors.SetError(control, "");
            };
        }

        private void OnValidatingRating ( object sender, CancelEventArgs e )
        {
            var control = sender as ComboBox;
            var rating = control.SelectedItem as string;

            if (String.IsNullOrEmpty(rating))
            { //Invalid 
                _errors.SetError(control, "Rating is required");
                e.Cancel=true;
            } else
            {
                _errors.SetError(control, "");
            };

        }

        private void OnValidatingReleaseYear ( object sender, CancelEventArgs e )
        {
            var control = sender as TextBox;
            
            
            var value = GetInt32(control);
            if (value<1900)
            { //Invalid 
                _errors.SetError(control, "Release Year must be least at 1900");
                e.Cancel=true;
            } else
            {
                _errors.SetError(control, "");
            };
        }

        private void OnValidatingRunLength( object sender, CancelEventArgs e )
        {
            var control = sender as TextBox;
            var value = GetInt32(control);
            if (value<0)
            { //Invalid 
                _errors.SetError(control, "Run Length must be least at 0");
                e.Cancel=true;
            } else
            {
                _errors.SetError(control, "");
            };
        }




    }
}
