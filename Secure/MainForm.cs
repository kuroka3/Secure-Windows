using Secure.API;

namespace Secure;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    private bool _isEncrypt = true;

    private void EnDecryptButtonClick(object sender, EventArgs e)
    {
        if (_isEncrypt)
        {
            using var passwordForm = new PasswordForm();
            if (passwordForm.ShowDialog() != DialogResult.OK) return;
            var password = passwordForm.Password;
            
            FileManager.SaveFile(PathBox.Text, MainTextbox.Text, password);
            PathBox.Text = string.Empty;
            MainTextbox.Text = string.Empty;
        }
        else
        {
            var result = MessageBox.Show("Really?", "Decrypt", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes) return;
            FileManager.SaveOriginalFile(PathBox.Text, MainTextbox.Text);
            PathBox.Text = string.Empty;
            MainTextbox.Text = string.Empty;
        }
    }

    private void OpenFileButtonClick(object sender, EventArgs e)
    {
        using var openFileDialog = new OpenFileDialog();
        openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
        openFileDialog.FilterIndex = 1;
        openFileDialog.RestoreDirectory = true;
        openFileDialog.Multiselect = false;

        if (openFileDialog.ShowDialog() != DialogResult.OK) return;
        var path = openFileDialog.FileName;
        _isEncrypt = !FileManager.IsEncrypted(path);

        if (_isEncrypt)
        {
            EnDecryptButton.Text = "Encrypt";
            MainTextbox.Text = File.ReadAllText(path);
            PathBox.Text = path;
        }
        else
        {
            var encryptedFile = FileManager.OpenFile(path);
            
            using var passwordForm = new PasswordForm();
            if (passwordForm.ShowDialog() != DialogResult.OK) return;
            var password = passwordForm.Password;

            try
            {
                var content = FileManager.DecryptFile(encryptedFile, password);
                MainTextbox.Text = content;
                EnDecryptButton.Text = "Decrypt";
                PathBox.Text = path;
            }
            catch (WrongPasswordException ex)
            {
                MessageBox.Show("Wrong Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}