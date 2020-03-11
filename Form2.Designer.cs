namespace GIT_APPLICATION
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label6 = new System.Windows.Forms.Label();
            this.lstRepos = new System.Windows.Forms.ListBox();
            this.lstProjects = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 439);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "VIEW EXISTING PROJECT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 381);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "CREATE PROJECT FOR REPOSITARIES";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 533);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "PUSH FILE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 481);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "COMMIT FILE";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(269, 432);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "CHECK PROJECT LIST";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button2.Location = new System.Drawing.Point(269, 381);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "CREATE NEW PROJECT";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(269, 481);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 28);
            this.button3.TabIndex = 7;
            this.button3.Text = "COMMIT PROJECT";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(269, 533);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(134, 28);
            this.button4.TabIndex = 8;
            this.button4.Text = "PUSH PROJECT";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "Repos";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(577, 63);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(439, 534);
            this.treeView1.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(573, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 24);
            this.label6.TabIndex = 16;
            this.label6.Text = "Directories Structure";
            // 
            // lstRepos
            // 
            this.lstRepos.FormattingEnabled = true;
            this.lstRepos.Location = new System.Drawing.Point(12, 65);
            this.lstRepos.Name = "lstRepos";
            this.lstRepos.Size = new System.Drawing.Size(167, 238);
            this.lstRepos.TabIndex = 17;
            this.lstRepos.SelectedIndexChanged += new System.EventHandler(this.lstRepos_SelectedIndexChanged);
            // 
            // lstProjects
            // 
            this.lstProjects.FormattingEnabled = true;
            this.lstProjects.Location = new System.Drawing.Point(216, 65);
            this.lstProjects.Name = "lstProjects";
            this.lstProjects.Size = new System.Drawing.Size(167, 238);
            this.lstProjects.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(216, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 24);
            this.label7.TabIndex = 18;
            this.label7.Text = "Projects";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "git.png");
            this.imageList1.Images.SetKeyName(1, "1.png");
            this.imageList1.Images.SetKeyName(2, "2.jpg");
            this.imageList1.Images.SetKeyName(3, "3.png");
            this.imageList1.Images.SetKeyName(4, "delete.png");
            this.imageList1.Images.SetKeyName(5, "se2.png");
            this.imageList1.Images.SetKeyName(6, "se.png");
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(574, 600);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "NO FILES FOUND";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 321);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "NO FILES FOUND";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 762);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lstProjects);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lstRepos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "s";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lstRepos;
        private System.Windows.Forms.ListBox lstProjects;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}