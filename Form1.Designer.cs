namespace _34669205_SU2_Act2
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDisplayGood = new System.Windows.Forms.Button();
            this.btnDisplayAll = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gbxGenres = new System.Windows.Forms.GroupBox();
            this.lbxViewGenres = new System.Windows.Forms.ListBox();
            this.cbxGenreList = new System.Windows.Forms.ComboBox();
            this.lblSelect = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.gbxGenres.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(794, 444);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnExit);
            this.tabPage1.Controls.Add(this.btnDisplayGood);
            this.tabPage1.Controls.Add(this.btnDisplayAll);
            this.tabPage1.Controls.Add(this.btnConnect);
            this.tabPage1.Controls.Add(this.dataGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(786, 418);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(634, 355);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(133, 34);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDisplayGood
            // 
            this.btnDisplayGood.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayGood.Location = new System.Drawing.Point(634, 118);
            this.btnDisplayGood.Name = "btnDisplayGood";
            this.btnDisplayGood.Size = new System.Drawing.Size(133, 31);
            this.btnDisplayGood.TabIndex = 3;
            this.btnDisplayGood.Text = "Display Good Movies";
            this.btnDisplayGood.UseVisualStyleBackColor = true;
            this.btnDisplayGood.Click += new System.EventHandler(this.btnDisplayGood_Click);
            // 
            // btnDisplayAll
            // 
            this.btnDisplayAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayAll.Location = new System.Drawing.Point(634, 71);
            this.btnDisplayAll.Name = "btnDisplayAll";
            this.btnDisplayAll.Size = new System.Drawing.Size(133, 31);
            this.btnDisplayAll.TabIndex = 2;
            this.btnDisplayAll.Text = "Display All";
            this.btnDisplayAll.UseVisualStyleBackColor = true;
            this.btnDisplayAll.Click += new System.EventHandler(this.btnDisplayAll_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Location = new System.Drawing.Point(634, 24);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(133, 31);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(6, 6);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(609, 406);
            this.dataGridView.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gbxGenres);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(786, 418);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gbxGenres
            // 
            this.gbxGenres.Controls.Add(this.lbxViewGenres);
            this.gbxGenres.Controls.Add(this.cbxGenreList);
            this.gbxGenres.Controls.Add(this.lblSelect);
            this.gbxGenres.Location = new System.Drawing.Point(6, 6);
            this.gbxGenres.Name = "gbxGenres";
            this.gbxGenres.Size = new System.Drawing.Size(774, 406);
            this.gbxGenres.TabIndex = 0;
            this.gbxGenres.TabStop = false;
            this.gbxGenres.Text = "View the Genres:";
            // 
            // lbxViewGenres
            // 
            this.lbxViewGenres.FormattingEnabled = true;
            this.lbxViewGenres.Location = new System.Drawing.Point(103, 71);
            this.lbxViewGenres.Name = "lbxViewGenres";
            this.lbxViewGenres.Size = new System.Drawing.Size(577, 329);
            this.lbxViewGenres.TabIndex = 3;
            // 
            // cbxGenreList
            // 
            this.cbxGenreList.FormattingEnabled = true;
            this.cbxGenreList.Location = new System.Drawing.Point(103, 30);
            this.cbxGenreList.Name = "cbxGenreList";
            this.cbxGenreList.Size = new System.Drawing.Size(121, 21);
            this.cbxGenreList.TabIndex = 2;
            this.cbxGenreList.SelectedIndexChanged += new System.EventHandler(this.cbxGenreList_SelectedIndexChanged);
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Location = new System.Drawing.Point(19, 33);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(78, 13);
            this.lblSelect.TabIndex = 0;
            this.lblSelect.Text = "Select a Genre";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.gbxGenres.ResumeLayout(false);
            this.gbxGenres.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDisplayGood;
        private System.Windows.Forms.Button btnDisplayAll;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.GroupBox gbxGenres;
        private System.Windows.Forms.ListBox lbxViewGenres;
        private System.Windows.Forms.ComboBox cbxGenreList;
        private System.Windows.Forms.Label lblSelect;
    }
}

