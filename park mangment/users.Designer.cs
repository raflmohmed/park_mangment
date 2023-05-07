namespace park_mangment
{
    partial class users
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
            this.Label5 = new System.Windows.Forms.Label();
            this.textusername = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.textname = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.textpassword = new System.Windows.Forms.TextBox();
            this.btnserach = new System.Windows.Forms.Button();
            this.textserah = new System.Windows.Forms.TextBox();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnrefrsh = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btninsert = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.textid = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Label5
            // 
            this.Label5.BackColor = System.Drawing.Color.Indigo;
            this.Label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.Color.White;
            this.Label5.Location = new System.Drawing.Point(3, 72);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(100, 21);
            this.Label5.TabIndex = 172;
            this.Label5.Text = "Username";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textusername
            // 
            this.textusername.Location = new System.Drawing.Point(109, 73);
            this.textusername.Name = "textusername";
            this.textusername.Size = new System.Drawing.Size(133, 22);
            this.textusername.TabIndex = 171;
            // 
            // Label7
            // 
            this.Label7.BackColor = System.Drawing.Color.Indigo;
            this.Label7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.ForeColor = System.Drawing.Color.White;
            this.Label7.Location = new System.Drawing.Point(3, 40);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(100, 21);
            this.Label7.TabIndex = 170;
            this.Label7.Text = "Name";
            this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textname
            // 
            this.textname.Location = new System.Drawing.Point(109, 41);
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(133, 22);
            this.textname.TabIndex = 169;
            // 
            // Label6
            // 
            this.Label6.BackColor = System.Drawing.Color.Indigo;
            this.Label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.ForeColor = System.Drawing.Color.White;
            this.Label6.Location = new System.Drawing.Point(3, 108);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(100, 21);
            this.Label6.TabIndex = 168;
            this.Label6.Text = "Password";
            this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textpassword
            // 
            this.textpassword.Location = new System.Drawing.Point(109, 109);
            this.textpassword.Name = "textpassword";
            this.textpassword.Size = new System.Drawing.Size(133, 22);
            this.textpassword.TabIndex = 167;
            // 
            // btnserach
            // 
            this.btnserach.BackColor = System.Drawing.Color.Indigo;
            this.btnserach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnserach.FlatAppearance.BorderSize = 0;
            this.btnserach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnserach.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnserach.ForeColor = System.Drawing.Color.White;
            this.btnserach.Location = new System.Drawing.Point(248, 9);
            this.btnserach.Name = "btnserach";
            this.btnserach.Size = new System.Drawing.Size(101, 30);
            this.btnserach.TabIndex = 166;
            this.btnserach.Text = "Serach";
            this.btnserach.UseVisualStyleBackColor = false;
            this.btnserach.Click += new System.EventHandler(this.btnserach_Click);
            // 
            // textserah
            // 
            this.textserah.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textserah.Location = new System.Drawing.Point(355, 11);
            this.textserah.Name = "textserah";
            this.textserah.Size = new System.Drawing.Size(513, 28);
            this.textserah.TabIndex = 165;
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Location = new System.Drawing.Point(248, 43);
            this.DataGridView1.MultiSelect = false;
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.ReadOnly = true;
            this.DataGridView1.RowHeadersVisible = false;
            this.DataGridView1.RowHeadersWidth = 51;
            this.DataGridView1.RowTemplate.Height = 24;
            this.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView1.Size = new System.Drawing.Size(620, 339);
            this.DataGridView1.TabIndex = 164;
            this.DataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            // 
            // btnrefrsh
            // 
            this.btnrefrsh.BackColor = System.Drawing.Color.Indigo;
            this.btnrefrsh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnrefrsh.FlatAppearance.BorderSize = 0;
            this.btnrefrsh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrefrsh.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrefrsh.ForeColor = System.Drawing.Color.White;
            this.btnrefrsh.Location = new System.Drawing.Point(3, 341);
            this.btnrefrsh.Name = "btnrefrsh";
            this.btnrefrsh.Size = new System.Drawing.Size(239, 41);
            this.btnrefrsh.TabIndex = 163;
            this.btnrefrsh.Text = "Refresh";
            this.btnrefrsh.UseVisualStyleBackColor = false;
            this.btnrefrsh.Click += new System.EventHandler(this.btnrefrsh_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.Indigo;
            this.btnupdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnupdate.FlatAppearance.BorderSize = 0;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdate.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.White;
            this.btnupdate.Location = new System.Drawing.Point(3, 291);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(239, 41);
            this.btnupdate.TabIndex = 162;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Indigo;
            this.btndelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndelete.FlatAppearance.BorderSize = 0;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.White;
            this.btndelete.Location = new System.Drawing.Point(3, 242);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(239, 41);
            this.btndelete.TabIndex = 161;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btninsert
            // 
            this.btninsert.BackColor = System.Drawing.Color.Indigo;
            this.btninsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btninsert.FlatAppearance.BorderSize = 0;
            this.btninsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninsert.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninsert.ForeColor = System.Drawing.Color.White;
            this.btninsert.Location = new System.Drawing.Point(2, 191);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(240, 41);
            this.btninsert.TabIndex = 160;
            this.btninsert.Text = "Insert";
            this.btninsert.UseVisualStyleBackColor = false;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.Indigo;
            this.btnadd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnadd.FlatAppearance.BorderSize = 0;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.White;
            this.btnadd.Location = new System.Drawing.Point(2, 144);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(240, 41);
            this.btnadd.TabIndex = 159;
            this.btnadd.Text = "Add new";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.Indigo;
            this.Label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(3, 8);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(100, 23);
            this.Label1.TabIndex = 158;
            this.Label1.Text = "ID";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textid
            // 
            this.textid.Enabled = false;
            this.textid.Location = new System.Drawing.Point(109, 9);
            this.textid.Name = "textid";
            this.textid.Size = new System.Drawing.Size(133, 22);
            this.textid.TabIndex = 157;
            // 
            // users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(879, 388);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.textusername);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.textname);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.textpassword);
            this.Controls.Add(this.btnserach);
            this.Controls.Add(this.textserah);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.btnrefrsh);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btninsert);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.textid);
            this.Name = "users";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "users";
            this.Load += new System.EventHandler(this.users_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox textusername;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.TextBox textname;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox textpassword;
        internal System.Windows.Forms.Button btnserach;
        internal System.Windows.Forms.TextBox textserah;
        internal System.Windows.Forms.DataGridView DataGridView1;
        internal System.Windows.Forms.Button btnrefrsh;
        internal System.Windows.Forms.Button btnupdate;
        internal System.Windows.Forms.Button btndelete;
        internal System.Windows.Forms.Button btninsert;
        internal System.Windows.Forms.Button btnadd;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox textid;
    }
}