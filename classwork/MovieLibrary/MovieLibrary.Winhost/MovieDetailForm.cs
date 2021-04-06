using System;
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
    public partial class MovieDetailForm : Form
    {
        public MovieDetailForm ()
        {
            InitializeComponent();
        }

        private void OnSave ( object sender, EventArgs e )
        {
            //Creating movie
            //Valdation
            this.DialogResult=DialogResult.OK;
            Close();
        }

        private void OnCancel ( object sender, EventArgs e )
        {
            Close();
        }
    }
}
