﻿namespace Dictonary
{
    partial class ucSearch
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblEdit = new System.Windows.Forms.Label();
            this.lblWord = new System.Windows.Forms.Label();
            this.txtWord = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblWordHere = new System.Windows.Forms.Label();
            this.lblW = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblMeaningHere = new System.Windows.Forms.Label();
            this.lblM = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEdit
            // 
            this.lblEdit.AutoSize = true;
            this.lblEdit.BackColor = System.Drawing.Color.Transparent;
            this.lblEdit.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold);
            this.lblEdit.ForeColor = System.Drawing.Color.Purple;
            this.lblEdit.Location = new System.Drawing.Point(126, 38);
            this.lblEdit.Name = "lblEdit";
            this.lblEdit.Size = new System.Drawing.Size(452, 46);
            this.lblEdit.TabIndex = 13;
            this.lblEdit.Text = "SEARCH YOUR WORD";
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.BackColor = System.Drawing.Color.Transparent;
            this.lblWord.Font = new System.Drawing.Font("Arial", 25F);
            this.lblWord.ForeColor = System.Drawing.Color.Purple;
            this.lblWord.Location = new System.Drawing.Point(28, 95);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(204, 39);
            this.lblWord.TabIndex = 40;
            this.lblWord.Text = "Type a word:";
            // 
            // txtWord
            // 
            this.txtWord.AutoCompleteCustomSource.AddRange(new string[] {
            "awake",
            "bad",
            "count",
            "dream",
            "error",
            "fail",
            "girl",
            "hurry",
            "kite",
            "long",
            "mother",
            "my",
            "miss",
            "now",
            "object",
            "present",
            "queen",
            "river",
            "soon",
            "table",
            "umbrella",
            "var",
            "world",
            "x-ray",
            "year",
            "zoo",
            "information"});
            this.txtWord.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtWord.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtWord.Font = new System.Drawing.Font("Arial", 20F);
            this.txtWord.Location = new System.Drawing.Point(238, 96);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(402, 38);
            this.txtWord.TabIndex = 39;
            this.txtWord.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWord_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.lblWordHere);
            this.panel1.Controls.Add(this.lblW);
            this.panel1.Location = new System.Drawing.Point(40, 173);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 237);
            this.panel1.TabIndex = 41;
            // 
            // lblWordHere
            // 
            this.lblWordHere.AutoSize = true;
            this.lblWordHere.BackColor = System.Drawing.Color.Transparent;
            this.lblWordHere.Font = new System.Drawing.Font("Arial", 18F);
            this.lblWordHere.ForeColor = System.Drawing.Color.Black;
            this.lblWordHere.Location = new System.Drawing.Point(16, 50);
            this.lblWordHere.Name = "lblWordHere";
            this.lblWordHere.Size = new System.Drawing.Size(0, 27);
            this.lblWordHere.TabIndex = 44;
            // 
            // lblW
            // 
            this.lblW.AutoSize = true;
            this.lblW.BackColor = System.Drawing.Color.Transparent;
            this.lblW.Font = new System.Drawing.Font("Arial", 20F);
            this.lblW.ForeColor = System.Drawing.Color.Indigo;
            this.lblW.Location = new System.Drawing.Point(3, 5);
            this.lblW.Name = "lblW";
            this.lblW.Size = new System.Drawing.Size(90, 32);
            this.lblW.TabIndex = 43;
            this.lblW.Text = "Word:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.lblMeaningHere);
            this.panel2.Controls.Add(this.lblM);
            this.panel2.Location = new System.Drawing.Point(354, 173);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(291, 237);
            this.panel2.TabIndex = 42;
            // 
            // lblMeaningHere
            // 
            this.lblMeaningHere.AutoSize = true;
            this.lblMeaningHere.BackColor = System.Drawing.Color.Transparent;
            this.lblMeaningHere.Font = new System.Drawing.Font("Arial", 18F);
            this.lblMeaningHere.ForeColor = System.Drawing.Color.Black;
            this.lblMeaningHere.Location = new System.Drawing.Point(19, 50);
            this.lblMeaningHere.Name = "lblMeaningHere";
            this.lblMeaningHere.Size = new System.Drawing.Size(0, 27);
            this.lblMeaningHere.TabIndex = 45;
            // 
            // lblM
            // 
            this.lblM.AutoSize = true;
            this.lblM.BackColor = System.Drawing.Color.Transparent;
            this.lblM.Font = new System.Drawing.Font("Arial", 20F);
            this.lblM.ForeColor = System.Drawing.Color.Indigo;
            this.lblM.Location = new System.Drawing.Point(3, 5);
            this.lblM.Name = "lblM";
            this.lblM.Size = new System.Drawing.Size(127, 32);
            this.lblM.TabIndex = 44;
            this.lblM.Text = "Meaning:";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = global::Dictonary.Properties.Resources.close_24_purple1;
            this.btnClose.Location = new System.Drawing.Point(621, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(62, 27);
            this.btnClose.TabIndex = 45;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseEnter += new System.EventHandler(this.btnClose_MouseEnter);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.Purple;
            this.btnFind.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.btnFind.FlatAppearance.BorderSize = 2;
            this.btnFind.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnFind.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnFind.ForeColor = System.Drawing.Color.Purple;
            this.btnFind.Image = global::Dictonary.Properties.Resources.Find_241;
            this.btnFind.Location = new System.Drawing.Point(556, 96);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(84, 38);
            this.btnFind.TabIndex = 44;
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // ucSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblWord);
            this.Controls.Add(this.txtWord);
            this.Controls.Add(this.lblEdit);
            this.Name = "ucSearch";
            this.Size = new System.Drawing.Size(683, 444);
            this.Load += new System.EventHandler(this.ucSearch_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEdit;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblW;
        private System.Windows.Forms.Label lblM;
        private System.Windows.Forms.Label lblWordHere;
        private System.Windows.Forms.Label lblMeaningHere;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnClose;
    }
}