namespace AOImplants
{
  partial class SpecificDlg
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
      this.list = new System.Windows.Forms.ListView();
      this.c1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.btnOK = new System.Windows.Forms.Button();
      this.btnCancel = new System.Windows.Forms.Button();
      this.btnAbil = new System.Windows.Forms.Button();
      this.btnBody = new System.Windows.Forms.Button();
      this.btnMelee = new System.Windows.Forms.Button();
      this.btnMeleeSpec = new System.Windows.Forms.Button();
      this.btnRange = new System.Windows.Forms.Button();
      this.btnRangeSpec = new System.Windows.Forms.Button();
      this.btnNano = new System.Windows.Forms.Button();
      this.btnExplore = new System.Windows.Forms.Button();
      this.btnCombatHeal = new System.Windows.Forms.Button();
      this.btnTrade = new System.Windows.Forms.Button();
      this.btnAC = new System.Windows.Forms.Button();
      this.btnMax = new System.Windows.Forms.Button();
      this.btnLegacy = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // list
      // 
      this.list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.c1});
      this.list.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.list.FullRowSelect = true;
      this.list.GridLines = true;
      this.list.HideSelection = false;
      this.list.Location = new System.Drawing.Point(168, 12);
      this.list.MultiSelect = false;
      this.list.Name = "list";
      this.list.Size = new System.Drawing.Size(200, 492);
      this.list.TabIndex = 0;
      this.list.UseCompatibleStateImageBehavior = false;
      this.list.View = System.Windows.Forms.View.Details;
      // 
      // c1
      // 
      this.c1.Text = "Cluster Name";
      // 
      // btnOK
      // 
      this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnOK.Location = new System.Drawing.Point(374, 12);
      this.btnOK.Name = "btnOK";
      this.btnOK.Size = new System.Drawing.Size(76, 32);
      this.btnOK.TabIndex = 1;
      this.btnOK.Text = "OK";
      this.btnOK.UseVisualStyleBackColor = true;
      this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
      // 
      // btnCancel
      // 
      this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnCancel.Location = new System.Drawing.Point(374, 50);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(76, 32);
      this.btnCancel.TabIndex = 2;
      this.btnCancel.Text = "Cancel";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // btnAbil
      // 
      this.btnAbil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnAbil.Location = new System.Drawing.Point(12, 12);
      this.btnAbil.Name = "btnAbil";
      this.btnAbil.Size = new System.Drawing.Size(139, 32);
      this.btnAbil.TabIndex = 3;
      this.btnAbil.Text = "Abilities";
      this.btnAbil.UseVisualStyleBackColor = true;
      // 
      // btnBody
      // 
      this.btnBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnBody.Location = new System.Drawing.Point(12, 50);
      this.btnBody.Name = "btnBody";
      this.btnBody.Size = new System.Drawing.Size(139, 32);
      this.btnBody.TabIndex = 4;
      this.btnBody.Text = "Body && Defense";
      this.btnBody.UseVisualStyleBackColor = true;
      // 
      // btnMelee
      // 
      this.btnMelee.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnMelee.Location = new System.Drawing.Point(12, 88);
      this.btnMelee.Name = "btnMelee";
      this.btnMelee.Size = new System.Drawing.Size(139, 32);
      this.btnMelee.TabIndex = 5;
      this.btnMelee.Text = "Melee Weapons";
      this.btnMelee.UseVisualStyleBackColor = true;
      // 
      // btnMeleeSpec
      // 
      this.btnMeleeSpec.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnMeleeSpec.Location = new System.Drawing.Point(12, 126);
      this.btnMeleeSpec.Name = "btnMeleeSpec";
      this.btnMeleeSpec.Size = new System.Drawing.Size(139, 32);
      this.btnMeleeSpec.TabIndex = 6;
      this.btnMeleeSpec.Text = "Melee Specials";
      this.btnMeleeSpec.UseVisualStyleBackColor = true;
      // 
      // btnRange
      // 
      this.btnRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnRange.Location = new System.Drawing.Point(12, 168);
      this.btnRange.Name = "btnRange";
      this.btnRange.Size = new System.Drawing.Size(139, 32);
      this.btnRange.TabIndex = 7;
      this.btnRange.Text = "Ranged Weapons";
      this.btnRange.UseVisualStyleBackColor = true;
      // 
      // btnRangeSpec
      // 
      this.btnRangeSpec.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnRangeSpec.Location = new System.Drawing.Point(12, 206);
      this.btnRangeSpec.Name = "btnRangeSpec";
      this.btnRangeSpec.Size = new System.Drawing.Size(139, 32);
      this.btnRangeSpec.TabIndex = 8;
      this.btnRangeSpec.Text = "Ranged Specials";
      this.btnRangeSpec.UseVisualStyleBackColor = true;
      // 
      // btnNano
      // 
      this.btnNano.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnNano.Location = new System.Drawing.Point(12, 244);
      this.btnNano.Name = "btnNano";
      this.btnNano.Size = new System.Drawing.Size(139, 32);
      this.btnNano.TabIndex = 9;
      this.btnNano.Text = "Nanos && Casting";
      this.btnNano.UseVisualStyleBackColor = true;
      // 
      // btnExplore
      // 
      this.btnExplore.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnExplore.Location = new System.Drawing.Point(12, 282);
      this.btnExplore.Name = "btnExplore";
      this.btnExplore.Size = new System.Drawing.Size(139, 32);
      this.btnExplore.TabIndex = 10;
      this.btnExplore.Text = "Exploring";
      this.btnExplore.UseVisualStyleBackColor = true;
      // 
      // btnCombatHeal
      // 
      this.btnCombatHeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnCombatHeal.Location = new System.Drawing.Point(12, 320);
      this.btnCombatHeal.Name = "btnCombatHeal";
      this.btnCombatHeal.Size = new System.Drawing.Size(139, 32);
      this.btnCombatHeal.TabIndex = 11;
      this.btnCombatHeal.Text = "Combat && Healing";
      this.btnCombatHeal.UseVisualStyleBackColor = true;
      // 
      // btnTrade
      // 
      this.btnTrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnTrade.Location = new System.Drawing.Point(12, 358);
      this.btnTrade.Name = "btnTrade";
      this.btnTrade.Size = new System.Drawing.Size(139, 32);
      this.btnTrade.TabIndex = 12;
      this.btnTrade.Text = "Trade && Repair";
      this.btnTrade.UseVisualStyleBackColor = true;
      // 
      // btnAC
      // 
      this.btnAC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnAC.Location = new System.Drawing.Point(12, 396);
      this.btnAC.Name = "btnAC";
      this.btnAC.Size = new System.Drawing.Size(139, 32);
      this.btnAC.TabIndex = 13;
      this.btnAC.Text = "AC";
      this.btnAC.UseVisualStyleBackColor = true;
      // 
      // btnMax
      // 
      this.btnMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnMax.Location = new System.Drawing.Point(12, 434);
      this.btnMax.Name = "btnMax";
      this.btnMax.Size = new System.Drawing.Size(139, 32);
      this.btnMax.TabIndex = 14;
      this.btnMax.Text = "Max";
      this.btnMax.UseVisualStyleBackColor = true;
      // 
      // btnLegacy
      // 
      this.btnLegacy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnLegacy.Location = new System.Drawing.Point(12, 472);
      this.btnLegacy.Name = "btnLegacy";
      this.btnLegacy.Size = new System.Drawing.Size(139, 32);
      this.btnLegacy.TabIndex = 15;
      this.btnLegacy.Text = "Legacy";
      this.btnLegacy.UseVisualStyleBackColor = true;
      // 
      // SpecificDlg
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(461, 530);
      this.Controls.Add(this.btnLegacy);
      this.Controls.Add(this.btnMax);
      this.Controls.Add(this.btnAC);
      this.Controls.Add(this.btnTrade);
      this.Controls.Add(this.btnCombatHeal);
      this.Controls.Add(this.btnExplore);
      this.Controls.Add(this.btnNano);
      this.Controls.Add(this.btnRangeSpec);
      this.Controls.Add(this.btnRange);
      this.Controls.Add(this.btnMeleeSpec);
      this.Controls.Add(this.btnMelee);
      this.Controls.Add(this.btnBody);
      this.Controls.Add(this.btnAbil);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.btnOK);
      this.Controls.Add(this.list);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Name = "SpecificDlg";
      this.Text = "Set Specifc Clusters";
      this.ResumeLayout(false);

    }

        #endregion

        private System.Windows.Forms.ListView list;
        private System.Windows.Forms.ColumnHeader c1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAbil;
        private System.Windows.Forms.Button btnBody;
        private System.Windows.Forms.Button btnMelee;
        private System.Windows.Forms.Button btnMeleeSpec;
        private System.Windows.Forms.Button btnRange;
        private System.Windows.Forms.Button btnRangeSpec;
        private System.Windows.Forms.Button btnNano;
        private System.Windows.Forms.Button btnExplore;
        private System.Windows.Forms.Button btnCombatHeal;
        private System.Windows.Forms.Button btnTrade;
        private System.Windows.Forms.Button btnAC;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnLegacy;
    }
}