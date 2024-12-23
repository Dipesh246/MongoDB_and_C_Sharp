namespace UtilityApp
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
            this.databaselist = new System.Windows.Forms.ListBox();
            this.showdbbtn = new System.Windows.Forms.Button();
            this.collectionList = new System.Windows.Forms.ListBox();
            this.createcolbtn = new System.Windows.Forms.Button();
            this.deletecolbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // databaselist
            // 
            this.databaselist.FormattingEnabled = true;
            this.databaselist.ItemHeight = 16;
            this.databaselist.Location = new System.Drawing.Point(12, 19);
            this.databaselist.Name = "databaselist";
            this.databaselist.Size = new System.Drawing.Size(137, 164);
            this.databaselist.TabIndex = 0;
            this.databaselist.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // showdbbtn
            // 
            this.showdbbtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.showdbbtn.Location = new System.Drawing.Point(12, 189);
            this.showdbbtn.Name = "showdbbtn";
            this.showdbbtn.Size = new System.Drawing.Size(108, 50);
            this.showdbbtn.TabIndex = 1;
            this.showdbbtn.Text = "Show Database";
            this.showdbbtn.UseVisualStyleBackColor = true;
            this.showdbbtn.Click += new System.EventHandler(this.showdbbtn_Click);
            // 
            // collectionList
            // 
            this.collectionList.FormattingEnabled = true;
            this.collectionList.ItemHeight = 16;
            this.collectionList.Location = new System.Drawing.Point(155, 19);
            this.collectionList.Name = "collectionList";
            this.collectionList.Size = new System.Drawing.Size(195, 164);
            this.collectionList.TabIndex = 2;
            this.collectionList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            // 
            // createcolbtn
            // 
            this.createcolbtn.Location = new System.Drawing.Point(165, 189);
            this.createcolbtn.Name = "createcolbtn";
            this.createcolbtn.Size = new System.Drawing.Size(81, 50);
            this.createcolbtn.TabIndex = 3;
            this.createcolbtn.Text = "Create Collection";
            this.createcolbtn.UseVisualStyleBackColor = true;
            this.createcolbtn.Click += new System.EventHandler(this.createcolbtn_Click);
            // 
            // deletecolbtn
            // 
            this.deletecolbtn.Location = new System.Drawing.Point(269, 190);
            this.deletecolbtn.Name = "deletecolbtn";
            this.deletecolbtn.Size = new System.Drawing.Size(81, 50);
            this.deletecolbtn.TabIndex = 4;
            this.deletecolbtn.Text = "Delete Collection";
            this.deletecolbtn.UseVisualStyleBackColor = true;
            this.deletecolbtn.Click += new System.EventHandler(this.deletecolbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 360);
            this.Controls.Add(this.deletecolbtn);
            this.Controls.Add(this.createcolbtn);
            this.Controls.Add(this.collectionList);
            this.Controls.Add(this.showdbbtn);
            this.Controls.Add(this.databaselist);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox databaselist;
        private System.Windows.Forms.Button showdbbtn;
        private System.Windows.Forms.ListBox collectionList;
        private System.Windows.Forms.Button createcolbtn;
        private System.Windows.Forms.Button deletecolbtn;
    }
}

