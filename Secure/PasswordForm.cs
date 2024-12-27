namespace Secure;

public partial class PasswordForm : Form
{
    public PasswordForm()
    {
        InitializeComponent();
    }

    public string Password;

    private void Cancel_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.Cancel;
        Close();
    }

    private void Confirm_Click(object sender, EventArgs e)
    {
        if (textBox1.Text.Length == 0)
        {
            MessageBox.Show("Please enter a valid password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        Password = textBox1.Text;
        DialogResult = DialogResult.OK;
        Close();
    }

    private void textBox1_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode != Keys.Enter) return;
        if (textBox1.Text.Length == 0)
        {
            MessageBox.Show("Please enter a valid password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        Password = textBox1.Text;
        DialogResult = DialogResult.OK;
        Close();
        e.Handled = true;
    }
}