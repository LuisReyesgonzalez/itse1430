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

        private void OnHelpAbout ( object sender, EventArgs e )
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

        private void MainForm_Load ( object sender, EventArgs e )
        {

        }

        private void OnCharacterAdd ( object sender, EventArgs e )
        {
            var form = new CharacterCreatorDetail();
            if (form.ShowDialog(this)== DialogResult.Cancel)
                return;

            _character=form.Character;

        }

        private void OnCharacterDelete ( object sender, EventArgs e )
        {
            //Charcter will delete if it exist
            if (_character==null) 
            return;
            var result = MessageBox.Show(this, $"Are you sure that you want to delete'{_character.Name}'?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result!=DialogResult.Yes)
                return;

            _character=null;
            UpdateUI();
        }

        private void OnCharacterEdit ( object sender, EventArgs e )
        {
            //reutrn if null
            if (_character==null)
                return;
            
            var form = new CharacterCreatorDetail();
            form.Character=_character;

            if (form.ShowDialog(this)== DialogResult.Cancel)
                return;

            _character=form.Character;
            UpdateUI();
        }
        //Updates th3e list ong the UI
        private void UpdateUI()
        {
            var count = (_character!=null)? 1 : 0 ;
            Character[] characters = new Character[count];
            if (_character!=null)
            characters[0]=_character;

            lstCharacter.DataSource=characters;
            lstCharacter.DisplayMember="Name";
        }
        private Character _character;
    }
}
