using System.ComponentModel;

namespace Secure;

partial class PasswordForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
        textBox1 = new System.Windows.Forms.TextBox();
        Confirm = new System.Windows.Forms.Button();
        Cancel = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // textBox1
        // 
        textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        textBox1.Location = new System.Drawing.Point(12, 12);
        textBox1.Name = "textBox1";
        textBox1.PasswordChar = '*';
        textBox1.Size = new System.Drawing.Size(180, 23);
        textBox1.TabIndex = 0;
        textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        textBox1.KeyDown += textBox1_KeyDown;
        // 
        // Confirm
        // 
        Confirm.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left));
        Confirm.Location = new System.Drawing.Point(12, 41);
        Confirm.Name = "Confirm";
        Confirm.Size = new System.Drawing.Size(83, 27);
        Confirm.TabIndex = 1;
        Confirm.Text = "Confirm";
        Confirm.UseVisualStyleBackColor = true;
        Confirm.Click += Confirm_Click;
        // 
        // Cancel
        // 
        Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
        Cancel.Location = new System.Drawing.Point(109, 41);
        Cancel.Name = "Cancel";
        Cancel.Size = new System.Drawing.Size(83, 27);
        Cancel.TabIndex = 2;
        Cancel.Text = "Cancel";
        Cancel.UseVisualStyleBackColor = true;
        Cancel.Click += Cancel_Click;
        // 
        // PasswordForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(204, 77);
        Controls.Add(Cancel);
        Controls.Add(Confirm);
        Controls.Add(textBox1);
        Text = "PasswordForm";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button Confirm;
    private System.Windows.Forms.Button Cancel;

    private System.Windows.Forms.TextBox textBox1;

    #endregion
}