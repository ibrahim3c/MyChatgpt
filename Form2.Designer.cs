namespace MyChatgpt
{
    partial class fADD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fADD));
            this.lbCode = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbError = new System.Windows.Forms.TextBox();
            this.lbNameoferror = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbPlanguage = new System.Windows.Forms.Label();
            this.btnPhoto = new System.Windows.Forms.Button();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbProcess = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbPL = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCode
            // 
            this.lbCode.AutoSize = true;
            this.lbCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(34)))), ((int)(((byte)(52)))));
            this.lbCode.Location = new System.Drawing.Point(2, 62);
            this.lbCode.Name = "lbCode";
            this.lbCode.Size = new System.Drawing.Size(70, 20);
            this.lbCode.TabIndex = 4;
            this.lbCode.Text = "CodeID";
            // 
            // tbID
            // 
            this.tbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(34)))), ((int)(((byte)(52)))));
            this.tbID.Location = new System.Drawing.Point(6, 85);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(335, 24);
            this.tbID.TabIndex = 5;
            // 
            // tbError
            // 
            this.tbError.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbError.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(34)))), ((int)(((byte)(52)))));
            this.tbError.Location = new System.Drawing.Point(6, 148);
            this.tbError.Name = "tbError";
            this.tbError.Size = new System.Drawing.Size(335, 24);
            this.tbError.TabIndex = 7;
            // 
            // lbNameoferror
            // 
            this.lbNameoferror.AutoSize = true;
            this.lbNameoferror.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameoferror.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(34)))), ((int)(((byte)(52)))));
            this.lbNameoferror.Location = new System.Drawing.Point(2, 125);
            this.lbNameoferror.Name = "lbNameoferror";
            this.lbNameoferror.Size = new System.Drawing.Size(150, 20);
            this.lbNameoferror.TabIndex = 6;
            this.lbNameoferror.Text = "Name of the error";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MyChatgpt.Properties.Resources.ask;
            this.pictureBox1.Location = new System.Drawing.Point(347, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(209, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // lbPlanguage
            // 
            this.lbPlanguage.AutoSize = true;
            this.lbPlanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlanguage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(34)))), ((int)(((byte)(52)))));
            this.lbPlanguage.Location = new System.Drawing.Point(2, 192);
            this.lbPlanguage.Name = "lbPlanguage";
            this.lbPlanguage.Size = new System.Drawing.Size(193, 20);
            this.lbPlanguage.TabIndex = 9;
            this.lbPlanguage.Text = "Programming language";
            // 
            // btnPhoto
            // 
            this.btnPhoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(87)))));
            this.btnPhoto.ForeColor = System.Drawing.Color.White;
            this.btnPhoto.Location = new System.Drawing.Point(347, 215);
            this.btnPhoto.Name = "btnPhoto";
            this.btnPhoto.Size = new System.Drawing.Size(209, 24);
            this.btnPhoto.TabIndex = 11;
            this.btnPhoto.Text = "Photo Update";
            this.btnPhoto.UseVisualStyleBackColor = false;
            this.btnPhoto.Click += new System.EventHandler(this.btnPhoto_Click);
            // 
            // tbDescription
            // 
            this.tbDescription.BackColor = System.Drawing.Color.Silver;
            this.tbDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(34)))), ((int)(((byte)(52)))));
            this.tbDescription.Location = new System.Drawing.Point(6, 297);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(550, 24);
            this.tbDescription.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(34)))), ((int)(((byte)(52)))));
            this.label2.Location = new System.Drawing.Point(2, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(34)))), ((int)(((byte)(52)))));
            this.label3.Location = new System.Drawing.Point(2, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Problem solving process";
            // 
            // tbProcess
            // 
            this.tbProcess.BackColor = System.Drawing.Color.Silver;
            this.tbProcess.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.tbProcess.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(34)))), ((int)(((byte)(52)))));
            this.tbProcess.Location = new System.Drawing.Point(6, 358);
            this.tbProcess.Name = "tbProcess";
            this.tbProcess.Size = new System.Drawing.Size(550, 116);
            this.tbProcess.TabIndex = 16;
            this.tbProcess.Text = "";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(87)))));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(6, 480);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(117, 50);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(87)))));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(439, 480);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(117, 50);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // tbPL
            // 
            this.tbPL.AllowDrop = true;
            this.tbPL.BackColor = System.Drawing.Color.White;
            this.tbPL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tbPL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.tbPL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(34)))), ((int)(((byte)(52)))));
            this.tbPL.FormattingEnabled = true;
            this.tbPL.Items.AddRange(new object[] {
            "c++",
            "c",
            "paython",
            "c#",
            "java"});
            this.tbPL.Location = new System.Drawing.Point(6, 215);
            this.tbPL.Name = "tbPL";
            this.tbPL.Size = new System.Drawing.Size(335, 26);
            this.tbPL.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(34)))), ((int)(((byte)(52)))));
            this.label1.Location = new System.Drawing.Point(160, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome to MyChatgpt";
            // 
            // fADD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(568, 537);
            this.Controls.Add(this.tbPL);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tbProcess);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPhoto);
            this.Controls.Add(this.lbPlanguage);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbError);
            this.Controls.Add(this.lbNameoferror);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.lbCode);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fADD";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbCode;
        private System.Windows.Forms.Label lbNameoferror;
        private System.Windows.Forms.Label lbPlanguage;
        private System.Windows.Forms.Button btnPhoto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tbID;
        public System.Windows.Forms.TextBox tbError;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox tbDescription;
        public System.Windows.Forms.RichTextBox tbProcess;
        public System.Windows.Forms.ComboBox tbPL;
    }
}