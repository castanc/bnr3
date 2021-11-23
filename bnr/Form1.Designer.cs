namespace BlockedNewsReader
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
            this.txUrl = new System.Windows.Forms.TextBox();
            this.btnURL = new System.Windows.Forms.Button();
            this.txPage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chbRemoveJScript = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLoad = new System.Windows.Forms.Button();
            this.txInitialUrl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txFolder = new System.Windows.Forms.TextBox();
            this.txPrefix = new System.Windows.Forms.TextBox();
            this.txCount = new System.Windows.Forms.TextBox();
            this.btnFolder = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOpenMonitor
            // 
            this.btnOpenMonitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenMonitor.Location = new System.Drawing.Point(0, 164);
            this.btnOpenMonitor.Size = new System.Drawing.Size(790, 39);
            // 
            // txUrl
            // 
            this.txUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txUrl.Location = new System.Drawing.Point(26, 126);
            this.txUrl.Name = "txUrl";
            this.txUrl.Size = new System.Drawing.Size(640, 29);
            this.txUrl.TabIndex = 0;
            // 
            // btnURL
            // 
            this.btnURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnURL.Location = new System.Drawing.Point(683, 83);
            this.btnURL.Name = "btnURL";
            this.btnURL.Size = new System.Drawing.Size(90, 63);
            this.btnURL.TabIndex = 1;
            this.btnURL.Text = "open URL";
            this.btnURL.UseVisualStyleBackColor = true;
            // 
            // txPage
            // 
            this.txPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txPage.Location = new System.Drawing.Point(0, 0);
            this.txPage.Multiline = true;
            this.txPage.Name = "txPage";
            this.txPage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txPage.Size = new System.Drawing.Size(790, 337);
            this.txPage.TabIndex = 2;
            this.txPage.Visible = false;
            this.txPage.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Paste url here";
            // 
            // chbRemoveJScript
            // 
            this.chbRemoveJScript.AutoSize = true;
            this.chbRemoveJScript.Checked = true;
            this.chbRemoveJScript.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbRemoveJScript.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbRemoveJScript.Location = new System.Drawing.Point(476, 83);
            this.chbRemoveJScript.Name = "chbRemoveJScript";
            this.chbRemoveJScript.Size = new System.Drawing.Size(190, 28);
            this.chbRemoveJScript.TabIndex = 4;
            this.chbRemoveJScript.Text = "&Remove JavaScript";
            this.chbRemoveJScript.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLoad);
            this.panel1.Controls.Add(this.txInitialUrl);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.chbRemoveJScript);
            this.panel1.Controls.Add(this.txUrl);
            this.panel1.Controls.Add(this.btnURL);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(790, 164);
            this.panel1.TabIndex = 5;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(683, 33);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 7;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // txInitialUrl
            // 
            this.txInitialUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txInitialUrl.Location = new System.Drawing.Point(136, 27);
            this.txInitialUrl.Name = "txInitialUrl";
            this.txInitialUrl.Size = new System.Drawing.Size(530, 29);
            this.txInitialUrl.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Initial Url";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Folder";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Prefix";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Count";
            // 
            // txFolder
            // 
            this.txFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txFolder.Location = new System.Drawing.Point(106, 33);
            this.txFolder.Name = "txFolder";
            this.txFolder.Size = new System.Drawing.Size(530, 29);
            this.txFolder.TabIndex = 8;
            this.txFolder.TextChanged += new System.EventHandler(this.txFolder_TextChanged);
            // 
            // txPrefix
            // 
            this.txPrefix.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txPrefix.Location = new System.Drawing.Point(106, 70);
            this.txPrefix.Name = "txPrefix";
            this.txPrefix.Size = new System.Drawing.Size(530, 29);
            this.txPrefix.TabIndex = 9;
            this.txPrefix.TextChanged += new System.EventHandler(this.textBtxPrefixox2_TextChanged);
            // 
            // txCount
            // 
            this.txCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txCount.Location = new System.Drawing.Point(106, 105);
            this.txCount.Name = "txCount";
            this.txCount.Size = new System.Drawing.Size(530, 29);
            this.txCount.TabIndex = 10;
            this.txCount.TextChanged += new System.EventHandler(this.txCount_TextChanged);
            // 
            // btnFolder
            // 
            this.btnFolder.Location = new System.Drawing.Point(652, 34);
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.Size = new System.Drawing.Size(75, 23);
            this.btnFolder.TabIndex = 8;
            this.btnFolder.Text = "Folder";
            this.btnFolder.UseVisualStyleBackColor = true;
            this.btnFolder.Click += new System.EventHandler(this.btnFolder_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFolder);
            this.groupBox1.Controls.Add(this.txCount);
            this.groupBox1.Controls.Add(this.txPrefix);
            this.groupBox1.Controls.Add(this.txFolder);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(790, 173);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Print Screen to File";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnURL;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 337);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txPage);
            this.Name = "Form1";
            this.Text = "gETurl";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Controls.SetChildIndex(this.txPage, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.btnOpenMonitor, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txUrl;
        private System.Windows.Forms.Button btnURL;
        private System.Windows.Forms.TextBox txPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chbRemoveJScript;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txInitialUrl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txFolder;
        private System.Windows.Forms.TextBox txPrefix;
        private System.Windows.Forms.TextBox txCount;
        private System.Windows.Forms.Button btnFolder;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

