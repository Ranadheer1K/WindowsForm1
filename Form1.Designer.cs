namespace WindowsForm1
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chkListHobbies = new System.Windows.Forms.CheckedListBox();
            this.btnHobbies = new System.Windows.Forms.Button();
            this.txtHobbies = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(171, 75);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(94, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Enter Name";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(171, 146);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(86, 20);
            this.lblYear.TabIndex = 1;
            this.lblYear.Text = "Enter Year";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(318, 72);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(156, 26);
            this.txtName.TabIndex = 2;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(318, 140);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(156, 26);
            this.txtYear.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(331, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 43);
            this.button1.TabIndex = 4;
            this.button1.Text = "Get Age";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(271, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Age Calculator";
            // 
            // chkListHobbies
            // 
            this.chkListHobbies.FormattingEnabled = true;
            this.chkListHobbies.Items.AddRange(new object[] {
            "Playing Cricket",
            "Reading Books",
            "Listening Songs"});
            this.chkListHobbies.Location = new System.Drawing.Point(707, 89);
            this.chkListHobbies.Name = "chkListHobbies";
            this.chkListHobbies.Size = new System.Drawing.Size(318, 119);
            this.chkListHobbies.TabIndex = 9;
            // 
            // btnHobbies
            // 
            this.btnHobbies.Location = new System.Drawing.Point(768, 244);
            this.btnHobbies.Name = "btnHobbies";
            this.btnHobbies.Size = new System.Drawing.Size(169, 46);
            this.btnHobbies.TabIndex = 10;
            this.btnHobbies.Text = "Submit";
            this.btnHobbies.UseVisualStyleBackColor = true;
            this.btnHobbies.Click += new System.EventHandler(this.btnHobbies_Click);
            // 
            // txtHobbies
            // 
            this.txtHobbies.Location = new System.Drawing.Point(724, 349);
            this.txtHobbies.Multiline = true;
            this.txtHobbies.Name = "txtHobbies";
            this.txtHobbies.Size = new System.Drawing.Size(301, 144);
            this.txtHobbies.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(754, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 29);
            this.label2.TabIndex = 12;
            this.label2.Text = "Hobbies List";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 602);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHobbies);
            this.Controls.Add(this.btnHobbies);
            this.Controls.Add(this.chkListHobbies);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox chkListHobbies;
        private System.Windows.Forms.Button btnHobbies;
        private System.Windows.Forms.TextBox txtHobbies;
        private System.Windows.Forms.Label label2;
    }
}

