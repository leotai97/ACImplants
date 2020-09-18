namespace AOImplants
{
  partial class ShoppingDlg
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShoppingDlg));
      this.listImplants = new System.Windows.Forms.ListView();
      this.I1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.listShining = new System.Windows.Forms.ListView();
      this.s1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.listBright = new System.Windows.Forms.ListView();
      this.b1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.listFaded = new System.Windows.Forms.ListView();
      this.f1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.tool = new System.Windows.Forms.ToolStrip();
      this.btnClipboard = new System.Windows.Forms.ToolStripButton();
      this.tool.SuspendLayout();
      this.SuspendLayout();
      // 
      // listImplants
      // 
      this.listImplants.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.I1});
      this.listImplants.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.listImplants.FullRowSelect = true;
      this.listImplants.GridLines = true;
      this.listImplants.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
      this.listImplants.HideSelection = false;
      this.listImplants.Location = new System.Drawing.Point(12, 53);
      this.listImplants.Name = "listImplants";
      this.listImplants.Size = new System.Drawing.Size(157, 367);
      this.listImplants.TabIndex = 0;
      this.listImplants.UseCompatibleStateImageBehavior = false;
      this.listImplants.View = System.Windows.Forms.View.Details;
      // 
      // I1
      // 
      this.I1.Text = "Implants";
      this.I1.Width = 131;
      // 
      // listShining
      // 
      this.listShining.BackColor = System.Drawing.Color.White;
      this.listShining.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.s1});
      this.listShining.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.listShining.FullRowSelect = true;
      this.listShining.GridLines = true;
      this.listShining.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
      this.listShining.HideSelection = false;
      this.listShining.Location = new System.Drawing.Point(501, 53);
      this.listShining.Name = "listShining";
      this.listShining.Size = new System.Drawing.Size(157, 367);
      this.listShining.TabIndex = 1;
      this.listShining.UseCompatibleStateImageBehavior = false;
      this.listShining.View = System.Windows.Forms.View.Details;
      // 
      // s1
      // 
      this.s1.Text = "Shining Clusters";
      // 
      // listBright
      // 
      this.listBright.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
      this.listBright.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.b1});
      this.listBright.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.listBright.FullRowSelect = true;
      this.listBright.GridLines = true;
      this.listBright.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
      this.listBright.HideSelection = false;
      this.listBright.Location = new System.Drawing.Point(338, 53);
      this.listBright.Name = "listBright";
      this.listBright.Size = new System.Drawing.Size(157, 367);
      this.listBright.TabIndex = 2;
      this.listBright.UseCompatibleStateImageBehavior = false;
      this.listBright.View = System.Windows.Forms.View.Details;
      // 
      // b1
      // 
      this.b1.Text = "Bright Clusters";
      // 
      // listFaded
      // 
      this.listFaded.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
      this.listFaded.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.f1});
      this.listFaded.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.listFaded.FullRowSelect = true;
      this.listFaded.GridLines = true;
      this.listFaded.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
      this.listFaded.HideSelection = false;
      this.listFaded.Location = new System.Drawing.Point(175, 53);
      this.listFaded.Name = "listFaded";
      this.listFaded.Size = new System.Drawing.Size(157, 367);
      this.listFaded.TabIndex = 3;
      this.listFaded.UseCompatibleStateImageBehavior = false;
      this.listFaded.View = System.Windows.Forms.View.Details;
      // 
      // f1
      // 
      this.f1.Text = "Faded Clusters";
      // 
      // tool
      // 
      this.tool.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnClipboard});
      this.tool.Location = new System.Drawing.Point(0, 0);
      this.tool.Name = "tool";
      this.tool.Size = new System.Drawing.Size(684, 25);
      this.tool.TabIndex = 4;
      this.tool.Text = "toolStrip1";
      // 
      // btnClipboard
      // 
      this.btnClipboard.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.btnClipboard.Image = ((System.Drawing.Image)(resources.GetObject("btnClipboard.Image")));
      this.btnClipboard.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btnClipboard.Name = "btnClipboard";
      this.btnClipboard.Size = new System.Drawing.Size(39, 22);
      this.btnClipboard.Text = "Copy";
      this.btnClipboard.ToolTipText = "Copy implant information to copy/paste clipboard.\r\nUse a fixed font like \'Courier" +
    " New\' to fix alignment.";
      this.btnClipboard.Click += new System.EventHandler(this.btnClipboard_Click);
      // 
      // ShoppingDlg
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(684, 452);
      this.Controls.Add(this.tool);
      this.Controls.Add(this.listFaded);
      this.Controls.Add(this.listBright);
      this.Controls.Add(this.listShining);
      this.Controls.Add(this.listImplants);
      this.Name = "ShoppingDlg";
      this.Text = "Shopping List";
      this.tool.ResumeLayout(false);
      this.tool.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.ListView listImplants;
        private System.Windows.Forms.ListView listShining;
        private System.Windows.Forms.ListView listBright;
        private System.Windows.Forms.ListView listFaded;
        private System.Windows.Forms.ColumnHeader I1;
        private System.Windows.Forms.ColumnHeader s1;
        private System.Windows.Forms.ColumnHeader b1;
        private System.Windows.Forms.ColumnHeader f1;
        private System.Windows.Forms.ToolStrip tool;
        private System.Windows.Forms.ToolStripButton btnClipboard;
    }
}