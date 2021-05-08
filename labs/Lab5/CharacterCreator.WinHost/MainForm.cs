//Luis Reyes
//ITSE1430
//Character Creator SQL Database
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
                try
                {//Save the Cahracter
                    _roster.Add(form.Character);
                        break;
                } catch(Exception ex)
                {
                    DisplayError("Add Failed", ex.Message);
                };
                   
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
            try
            {
                _roster.Delete(character.Id);
            }catch(Exception ex)
            {
                DisplayError("Delete Failed", ex.Message);
            };
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
                try
                {
                    //Save the Character
                    _roster.Update(character.Id, form.Character);
                    break;
                } catch (Exception ex)
                {
                    DisplayError("Update Failed", ex.Message);
                };
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
            lstCharacter.DisplayMember="Name";
            try
            {
                var characters = _roster.GetAll();
                lstCharacter.DataSource = characters;
                
            } catch(Exception e)
            {
                DisplayError("Error retreving characters", e.Message);
                lstCharacter.DataSource=new Character[0];
            }; 
        }
        private readonly ICharacterRoster _roster = new MemoryCharacterRoster(); 
    }
}
