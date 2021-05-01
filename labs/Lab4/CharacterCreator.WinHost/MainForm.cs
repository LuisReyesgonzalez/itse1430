//Luis Reyes
//ITSE 1430
//Lab 4: Character Creator
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

            do
            {
                if (form.ShowDialog(this)== DialogResult.Cancel)
                    return;

                //Save the Cahracter
                _roster.Add(form.Character, out var error);
                if (String.IsNullOrEmpty(error))
                    break;
                    DisplayError("Add Failed", error);
            }while (true) ;
            UpdateUI();

        }
        private void DisplayError (string name , string message)
        {
            MessageBox.Show(this, message, name, MessageBoxButtons.OK, MessageBoxIcon.Error);

         }

        private void OnCharacterDelete ( object sender, EventArgs e )
        {
            var character = GetSelectedCharacter();
            //Charcter will delete if it exist
            if (character==null)
                return;
            var result = MessageBox.Show(this, $"Are you sure that you want to delete'{character.Name}'?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result!=DialogResult.Yes)
                return;
            _roster.Delete(character.Id,out var error);
          
            UpdateUI();
        }

        private void OnCharacterEdit ( object sender, EventArgs e )
        {
            //reutrn if null
            var character = GetSelectedCharacter();
            if (character==null)
                return;
            
            var form = new CharacterCreatorDetail();
            form.Character= character;

            do
            {
                if (form.ShowDialog(this)== DialogResult.Cancel)
                    return;

                //Save the Character
                _roster.Update(character.Id,form.Character, out var error);
                if (String.IsNullOrEmpty(error))
                    break;
                DisplayError("Update Failed", error);
            } while (true);

            UpdateUI();
        }
        //Updates th3e list ong the UI
       
        private Character GetSelectedCharacter ()
        {
            return lstCharacter.SelectedItem as Character;
            
        }
        private void UpdateUI ()
        {
            var characters = _roster.GetAll();
            lstCharacter.DataSource = characters;
            lstCharacter.DisplayMember="Name";
        }
        private readonly ICharacterRoster _roster = new MemoryCharacterRoster(); 
    }
}
