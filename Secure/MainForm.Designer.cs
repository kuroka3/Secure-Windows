namespace Secure;

partial class MainForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        EnDecryptButton = new System.Windows.Forms.Button();
        MainTextbox = new System.Windows.Forms.TextBox();
        OpenFileButton = new System.Windows.Forms.Button();
        PathBox = new System.Windows.Forms.TextBox();
        SuspendLayout();
        // 
        // EnDecryptButton
        // 
        EnDecryptButton.Location = new System.Drawing.Point(657, 358);
        EnDecryptButton.Name = "EnDecryptButton";
        EnDecryptButton.Size = new System.Drawing.Size(96, 31);
        EnDecryptButton.TabIndex = 0;
        EnDecryptButton.Text = "Encrypt";
        EnDecryptButton.UseVisualStyleBackColor = true;
        EnDecryptButton.Click += EnDecryptButtonClick;
        // 
        // MainTextbox
        // 
        MainTextbox.Location = new System.Drawing.Point(95, 75);
        MainTextbox.Multiline = true;
        MainTextbox.Name = "MainTextbox";
        MainTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        MainTextbox.Size = new System.Drawing.Size(556, 314);
        MainTextbox.TabIndex = 1;
        // 
        // OpenFileButton
        // 
        OpenFileButton.Location = new System.Drawing.Point(657, 35);
        OpenFileButton.Name = "OpenFileButton";
        OpenFileButton.Size = new System.Drawing.Size(96, 34);
        OpenFileButton.TabIndex = 2;
        OpenFileButton.Text = "Open";
        OpenFileButton.UseVisualStyleBackColor = true;
        OpenFileButton.Click += OpenFileButtonClick;
        // 
        // PathBox
        // 
        PathBox.Location = new System.Drawing.Point(95, 42);
        PathBox.Name = "PathBox";
        PathBox.Size = new System.Drawing.Size(556, 23);
        PathBox.TabIndex = 3;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(PathBox);
        Controls.Add(OpenFileButton);
        Controls.Add(MainTextbox);
        Controls.Add(EnDecryptButton);
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.TextBox PathBox;

    private System.Windows.Forms.Button OpenFileButton;

    private System.Windows.Forms.Button EnDecryptButton;
    private System.Windows.Forms.TextBox MainTextbox;

    #endregion
}