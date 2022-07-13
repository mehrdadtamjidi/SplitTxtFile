namespace SplitTxtFile
{
    partial class frmMain
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaxSplit = new System.Windows.Forms.TextBox();
            this.BtnSplit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._lblItemCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._lbItemList = new System.Windows.Forms.ListBox();
            this.btnClearContact = new System.Windows.Forms.Button();
            this.btnLoadContact = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 524);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Max Line each file :";
            // 
            // txtMaxSplit
            // 
            this.txtMaxSplit.Location = new System.Drawing.Point(129, 519);
            this.txtMaxSplit.Name = "txtMaxSplit";
            this.txtMaxSplit.Size = new System.Drawing.Size(100, 20);
            this.txtMaxSplit.TabIndex = 25;
            // 
            // BtnSplit
            // 
            this.BtnSplit.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSplit.ForeColor = System.Drawing.Color.Black;
            this.BtnSplit.Location = new System.Drawing.Point(129, 545);
            this.BtnSplit.Name = "BtnSplit";
            this.BtnSplit.Size = new System.Drawing.Size(100, 23);
            this.BtnSplit.TabIndex = 24;
            this.BtnSplit.Text = "Split";
            this.BtnSplit.UseVisualStyleBackColor = true;
            this.BtnSplit.Click += new System.EventHandler(this.BtnSplit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._lblItemCount);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this._lbItemList);
            this.groupBox1.Controls.Add(this.btnClearContact);
            this.groupBox1.Controls.Add(this.btnLoadContact);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 497);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // _lblItemCount
            // 
            this._lblItemCount.AutoSize = true;
            this._lblItemCount.Location = new System.Drawing.Point(59, 474);
            this._lblItemCount.Name = "_lblItemCount";
            this._lblItemCount.Size = new System.Drawing.Size(0, 13);
            this._lblItemCount.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 474);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Count :";
            // 
            // _lbItemList
            // 
            this._lbItemList.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this._lbItemList.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lbItemList.FormattingEnabled = true;
            this._lbItemList.ItemHeight = 16;
            this._lbItemList.Location = new System.Drawing.Point(12, 19);
            this._lbItemList.Name = "_lbItemList";
            this._lbItemList.Size = new System.Drawing.Size(274, 452);
            this._lbItemList.TabIndex = 20;
            // 
            // btnClearContact
            // 
            this.btnClearContact.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearContact.ForeColor = System.Drawing.Color.Black;
            this.btnClearContact.Location = new System.Drawing.Point(293, 48);
            this.btnClearContact.Name = "btnClearContact";
            this.btnClearContact.Size = new System.Drawing.Size(69, 23);
            this.btnClearContact.TabIndex = 19;
            this.btnClearContact.Text = "Clear";
            this.btnClearContact.UseVisualStyleBackColor = true;
            this.btnClearContact.Click += new System.EventHandler(this.btnClearContact_Click);
            // 
            // btnLoadContact
            // 
            this.btnLoadContact.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadContact.ForeColor = System.Drawing.Color.Black;
            this.btnLoadContact.Location = new System.Drawing.Point(293, 19);
            this.btnLoadContact.Name = "btnLoadContact";
            this.btnLoadContact.Size = new System.Drawing.Size(69, 23);
            this.btnLoadContact.TabIndex = 18;
            this.btnLoadContact.Text = "Load";
            this.btnLoadContact.UseVisualStyleBackColor = true;
            this.btnLoadContact.Click += new System.EventHandler(this.btnLoadContact_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 579);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaxSplit);
            this.Controls.Add(this.BtnSplit);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Split TxT File";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaxSplit;
        private System.Windows.Forms.Button BtnSplit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label _lblItemCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox _lbItemList;
        private System.Windows.Forms.Button btnClearContact;
        private System.Windows.Forms.Button btnLoadContact;
    }
}

