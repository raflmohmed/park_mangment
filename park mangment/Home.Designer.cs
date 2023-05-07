namespace park_mangment
{
    partial class Home
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
            this.btnusers = new System.Windows.Forms.Button();
            this.btnworker = new System.Windows.Forms.Button();
            this.btncar = new System.Windows.Forms.Button();
            this.btnpark = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnusers
            // 
            this.btnusers.BackColor = System.Drawing.Color.Transparent;
            this.btnusers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnusers.FlatAppearance.BorderSize = 0;
            this.btnusers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnusers.Image = global::park_mangment.Properties.Resources.icons8_users_50;
            this.btnusers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnusers.Location = new System.Drawing.Point(529, 269);
            this.btnusers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnusers.Name = "btnusers";
            this.btnusers.Size = new System.Drawing.Size(251, 151);
            this.btnusers.TabIndex = 14;
            this.btnusers.Text = "USERS";
            this.btnusers.UseVisualStyleBackColor = false;
            this.btnusers.Click += new System.EventHandler(this.btnusers_Click);
            // 
            // btnworker
            // 
            this.btnworker.BackColor = System.Drawing.Color.Transparent;
            this.btnworker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnworker.FlatAppearance.BorderSize = 0;
            this.btnworker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnworker.Image = global::park_mangment.Properties.Resources.icons8_worker_50;
            this.btnworker.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnworker.Location = new System.Drawing.Point(57, 269);
            this.btnworker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnworker.Name = "btnworker";
            this.btnworker.Size = new System.Drawing.Size(272, 151);
            this.btnworker.TabIndex = 13;
            this.btnworker.Text = "WORKER PARK";
            this.btnworker.UseVisualStyleBackColor = false;
            this.btnworker.Click += new System.EventHandler(this.btnworker_Click);
            // 
            // btncar
            // 
            this.btncar.BackColor = System.Drawing.Color.Transparent;
            this.btncar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncar.FlatAppearance.BorderSize = 0;
            this.btncar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncar.Image = global::park_mangment.Properties.Resources.icons8_traffic_jam_40;
            this.btncar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncar.Location = new System.Drawing.Point(517, 31);
            this.btncar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btncar.Name = "btncar";
            this.btncar.Size = new System.Drawing.Size(251, 154);
            this.btncar.TabIndex = 12;
            this.btncar.Text = "CARS";
            this.btncar.UseVisualStyleBackColor = false;
            this.btncar.Click += new System.EventHandler(this.btncar_Click);
            // 
            // btnpark
            // 
            this.btnpark.BackColor = System.Drawing.Color.Transparent;
            this.btnpark.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnpark.FlatAppearance.BorderSize = 0;
            this.btnpark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpark.Image = global::park_mangment.Properties.Resources.icons8_park_50;
            this.btnpark.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnpark.Location = new System.Drawing.Point(57, 31);
            this.btnpark.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnpark.Name = "btnpark";
            this.btnpark.Size = new System.Drawing.Size(251, 154);
            this.btnpark.TabIndex = 11;
            this.btnpark.Text = "PARKING";
            this.btnpark.UseVisualStyleBackColor = false;
            this.btnpark.Click += new System.EventHandler(this.btnpark_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(826, 485);
            this.Controls.Add(this.btnusers);
            this.Controls.Add(this.btnworker);
            this.Controls.Add(this.btncar);
            this.Controls.Add(this.btnpark);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnusers;
        private System.Windows.Forms.Button btnworker;
        private System.Windows.Forms.Button btncar;
        private System.Windows.Forms.Button btnpark;
    }
}