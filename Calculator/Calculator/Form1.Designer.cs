namespace Calculator
{
    partial class MAINFORM
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
            this.MainName = new System.Windows.Forms.Label();
            this.Start_bt = new System.Windows.Forms.Button();
            this.Load_bt = new System.Windows.Forms.Button();
            this.Quit_bt = new System.Windows.Forms.Button();
            this.Demand_lb = new System.Windows.Forms.Label();
            this.Expression_txtb = new System.Windows.Forms.TextBox();
            this.Cal_bt = new System.Windows.Forms.Button();
            this.Equal_lb = new System.Windows.Forms.Label();
            this.result_txtb = new System.Windows.Forms.TextBox();
            this.continue_bt = new System.Windows.Forms.Button();
            this.title_bt = new System.Windows.Forms.Button();
            this.preans_bt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MainName
            // 
            this.MainName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MainName.Font = new System.Drawing.Font("Consolas", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MainName.Location = new System.Drawing.Point(46, 32);
            this.MainName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MainName.Name = "MainName";
            this.MainName.Size = new System.Drawing.Size(503, 60);
            this.MainName.TabIndex = 0;
            this.MainName.Text = "BINARY TREE CALCULATOR";
            this.MainName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Start_bt
            // 
            this.Start_bt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Start_bt.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Start_bt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.Start_bt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Start_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Start_bt.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start_bt.Location = new System.Drawing.Point(227, 148);
            this.Start_bt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Start_bt.Name = "Start_bt";
            this.Start_bt.Size = new System.Drawing.Size(146, 38);
            this.Start_bt.TabIndex = 1;
            this.Start_bt.Text = "START";
            this.Start_bt.UseVisualStyleBackColor = false;
            this.Start_bt.Click += new System.EventHandler(this.Start_bt_Click);
            // 
            // Load_bt
            // 
            this.Load_bt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Load_bt.Enabled = false;
            this.Load_bt.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Load_bt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.Load_bt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Load_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Load_bt.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Load_bt.Location = new System.Drawing.Point(227, 201);
            this.Load_bt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Load_bt.Name = "Load_bt";
            this.Load_bt.Size = new System.Drawing.Size(146, 38);
            this.Load_bt.TabIndex = 2;
            this.Load_bt.Text = "LOAD";
            this.Load_bt.UseVisualStyleBackColor = false;
            this.Load_bt.Click += new System.EventHandler(this.Load_bt_Click);
            // 
            // Quit_bt
            // 
            this.Quit_bt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Quit_bt.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Quit_bt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.Quit_bt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Quit_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Quit_bt.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quit_bt.Location = new System.Drawing.Point(227, 253);
            this.Quit_bt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Quit_bt.Name = "Quit_bt";
            this.Quit_bt.Size = new System.Drawing.Size(146, 38);
            this.Quit_bt.TabIndex = 3;
            this.Quit_bt.Text = "QUIT";
            this.Quit_bt.UseVisualStyleBackColor = false;
            this.Quit_bt.Click += new System.EventHandler(this.Quit_bt_Click);
            // 
            // Demand_lb
            // 
            this.Demand_lb.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Demand_lb.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Demand_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Demand_lb.Location = new System.Drawing.Point(92, 123);
            this.Demand_lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Demand_lb.Name = "Demand_lb";
            this.Demand_lb.Size = new System.Drawing.Size(458, 54);
            this.Demand_lb.TabIndex = 4;
            this.Demand_lb.Text = "Nhập biểu thức cần tính toán";
            this.Demand_lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Demand_lb.Visible = false;
            // 
            // Expression_txtb
            // 
            this.Expression_txtb.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Expression_txtb.Location = new System.Drawing.Point(97, 180);
            this.Expression_txtb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Expression_txtb.Multiline = true;
            this.Expression_txtb.Name = "Expression_txtb";
            this.Expression_txtb.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Expression_txtb.Size = new System.Drawing.Size(278, 45);
            this.Expression_txtb.TabIndex = 5;
            this.Expression_txtb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Expression_txtb.Visible = false;
            // 
            // Cal_bt
            // 
            this.Cal_bt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Cal_bt.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Cal_bt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.Cal_bt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Cal_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cal_bt.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cal_bt.Location = new System.Drawing.Point(416, 180);
            this.Cal_bt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Cal_bt.Name = "Cal_bt";
            this.Cal_bt.Size = new System.Drawing.Size(87, 46);
            this.Cal_bt.TabIndex = 6;
            this.Cal_bt.Text = "CAL";
            this.Cal_bt.UseVisualStyleBackColor = false;
            this.Cal_bt.Visible = false;
            this.Cal_bt.Click += new System.EventHandler(this.Cal_bt_Click);
            // 
            // Equal_lb
            // 
            this.Equal_lb.Font = new System.Drawing.Font("Consolas", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Equal_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Equal_lb.Location = new System.Drawing.Point(378, 180);
            this.Equal_lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Equal_lb.Name = "Equal_lb";
            this.Equal_lb.Size = new System.Drawing.Size(34, 46);
            this.Equal_lb.TabIndex = 7;
            this.Equal_lb.Text = "=";
            this.Equal_lb.Visible = false;
            // 
            // result_txtb
            // 
            this.result_txtb.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result_txtb.Location = new System.Drawing.Point(416, 180);
            this.result_txtb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.result_txtb.Multiline = true;
            this.result_txtb.Name = "result_txtb";
            this.result_txtb.ReadOnly = true;
            this.result_txtb.Size = new System.Drawing.Size(107, 45);
            this.result_txtb.TabIndex = 8;
            this.result_txtb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.result_txtb.Visible = false;
            // 
            // continue_bt
            // 
            this.continue_bt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.continue_bt.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.continue_bt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.continue_bt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.continue_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.continue_bt.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continue_bt.Location = new System.Drawing.Point(182, 318);
            this.continue_bt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.continue_bt.Name = "continue_bt";
            this.continue_bt.Size = new System.Drawing.Size(147, 38);
            this.continue_bt.TabIndex = 9;
            this.continue_bt.Text = "CONTINUE";
            this.continue_bt.UseVisualStyleBackColor = false;
            this.continue_bt.Visible = false;
            this.continue_bt.Click += new System.EventHandler(this.continue_bt_Click);
            // 
            // title_bt
            // 
            this.title_bt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.title_bt.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.title_bt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.title_bt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.title_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.title_bt.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_bt.Location = new System.Drawing.Point(334, 318);
            this.title_bt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.title_bt.Name = "title_bt";
            this.title_bt.Size = new System.Drawing.Size(102, 38);
            this.title_bt.TabIndex = 10;
            this.title_bt.Text = "TITLE";
            this.title_bt.UseVisualStyleBackColor = false;
            this.title_bt.Visible = false;
            this.title_bt.Click += new System.EventHandler(this.title_bt_Click);
            // 
            // preans_bt
            // 
            this.preans_bt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.preans_bt.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.preans_bt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.preans_bt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.preans_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.preans_bt.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preans_bt.Location = new System.Drawing.Point(416, 244);
            this.preans_bt.Name = "preans_bt";
            this.preans_bt.Size = new System.Drawing.Size(133, 47);
            this.preans_bt.TabIndex = 11;
            this.preans_bt.Text = "PRE_ANS";
            this.preans_bt.UseVisualStyleBackColor = false;
            this.preans_bt.Visible = false;
            this.preans_bt.Click += new System.EventHandler(this.preans_bt_Click);
            // 
            // MAINFORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.preans_bt);
            this.Controls.Add(this.title_bt);
            this.Controls.Add(this.continue_bt);
            this.Controls.Add(this.result_txtb);
            this.Controls.Add(this.Equal_lb);
            this.Controls.Add(this.Cal_bt);
            this.Controls.Add(this.Expression_txtb);
            this.Controls.Add(this.Demand_lb);
            this.Controls.Add(this.Quit_bt);
            this.Controls.Add(this.Load_bt);
            this.Controls.Add(this.Start_bt);
            this.Controls.Add(this.MainName);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "MAINFORM";
            this.Text = "CALCULATOR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MainName;
        private System.Windows.Forms.Button Start_bt;
        private System.Windows.Forms.Button Load_bt;
        private System.Windows.Forms.Button Quit_bt;
        private System.Windows.Forms.Label Demand_lb;
        private System.Windows.Forms.TextBox Expression_txtb;
        private System.Windows.Forms.Button Cal_bt;
        private System.Windows.Forms.Label Equal_lb;
        private System.Windows.Forms.TextBox result_txtb;
        private System.Windows.Forms.Button continue_bt;
        private System.Windows.Forms.Button title_bt;
        private System.Windows.Forms.Button preans_bt;
    }
}

