namespace WindowsFormsHost_Test
{
  partial class Form1
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

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
            this.listViewControlHost = new WpfControls.ListViewControl_WinFormsHost();
            this.listViewControl = new WpfControls.ListViewControl();
            this.SuspendLayout();
            // 
            // listViewControlHost
            // 
            this.listViewControlHost.Location = new System.Drawing.Point(12, 12);
            this.listViewControlHost.Name = "listViewControlHost";
            this.listViewControlHost.Size = new System.Drawing.Size(200, 56);
            this.listViewControlHost.TabIndex = 0;
            this.listViewControlHost.Text = "elementHost1";
            this.listViewControlHost.Child = this.listViewControl;

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listViewControlHost);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

    }

    #endregion

    private WpfControls.ListViewControl_WinFormsHost listViewControlHost;
    private WpfControls.ListViewControl listViewControl;
  }
}

