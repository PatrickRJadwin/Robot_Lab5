namespace Jadwin_Lab5
{
    partial class RobotController
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
            this.rbtBox = new System.Windows.Forms.TextBox();
            this.coord = new System.Windows.Forms.Label();
            this.mv1 = new System.Windows.Forms.Button();
            this.north = new System.Windows.Forms.Button();
            this.east = new System.Windows.Forms.Button();
            this.west = new System.Windows.Forms.Button();
            this.south = new System.Windows.Forms.Button();
            this.mv10 = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbtBox
            // 
            this.rbtBox.Location = new System.Drawing.Point(12, 30);
            this.rbtBox.MaxLength = 40000;
            this.rbtBox.Multiline = true;
            this.rbtBox.Name = "rbtBox";
            this.rbtBox.ReadOnly = true;
            this.rbtBox.Size = new System.Drawing.Size(200, 200);
            this.rbtBox.TabIndex = 0;
            // 
            // coord
            // 
            this.coord.AutoSize = true;
            this.coord.Location = new System.Drawing.Point(25, 9);
            this.coord.Name = "coord";
            this.coord.Size = new System.Drawing.Size(62, 13);
            this.coord.TabIndex = 1;
            this.coord.Text = "{X=0, Y=0} ";
            // 
            // mv1
            // 
            this.mv1.Location = new System.Drawing.Point(28, 278);
            this.mv1.Name = "mv1";
            this.mv1.Size = new System.Drawing.Size(42, 23);
            this.mv1.TabIndex = 2;
            this.mv1.Text = "Go 1";
            this.mv1.UseVisualStyleBackColor = true;
            this.mv1.Click += new System.EventHandler(this.mv1_Click);
            // 
            // north
            // 
            this.north.Location = new System.Drawing.Point(98, 249);
            this.north.Name = "north";
            this.north.Size = new System.Drawing.Size(23, 23);
            this.north.TabIndex = 3;
            this.north.Text = "N";
            this.north.UseVisualStyleBackColor = true;
            this.north.Click += new System.EventHandler(this.north_Click);
            // 
            // east
            // 
            this.east.Location = new System.Drawing.Point(120, 278);
            this.east.Name = "east";
            this.east.Size = new System.Drawing.Size(23, 23);
            this.east.TabIndex = 4;
            this.east.Text = "E";
            this.east.UseVisualStyleBackColor = true;
            this.east.Click += new System.EventHandler(this.east_Click);
            // 
            // west
            // 
            this.west.Location = new System.Drawing.Point(77, 278);
            this.west.Name = "west";
            this.west.Size = new System.Drawing.Size(22, 23);
            this.west.TabIndex = 5;
            this.west.Text = "W";
            this.west.UseVisualStyleBackColor = true;
            this.west.Click += new System.EventHandler(this.west_Click);
            // 
            // south
            // 
            this.south.Location = new System.Drawing.Point(98, 307);
            this.south.Name = "south";
            this.south.Size = new System.Drawing.Size(23, 23);
            this.south.TabIndex = 6;
            this.south.Text = "S";
            this.south.UseVisualStyleBackColor = true;
            this.south.Click += new System.EventHandler(this.south_Click);
            // 
            // mv10
            // 
            this.mv10.Location = new System.Drawing.Point(150, 278);
            this.mv10.Name = "mv10";
            this.mv10.Size = new System.Drawing.Size(47, 23);
            this.mv10.TabIndex = 7;
            this.mv10.Text = "Go 10";
            this.mv10.UseVisualStyleBackColor = true;
            this.mv10.Click += new System.EventHandler(this.mv10_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(165, 332);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(47, 23);
            this.exit.TabIndex = 8;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            // 
            // RobotController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 367);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.mv10);
            this.Controls.Add(this.south);
            this.Controls.Add(this.west);
            this.Controls.Add(this.east);
            this.Controls.Add(this.north);
            this.Controls.Add(this.mv1);
            this.Controls.Add(this.coord);
            this.Controls.Add(this.rbtBox);
            this.Name = "RobotController";
            this.Text = "Robot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox rbtBox;
        private System.Windows.Forms.Label coord;
        private System.Windows.Forms.Button mv1;
        private System.Windows.Forms.Button north;
        private System.Windows.Forms.Button east;
        private System.Windows.Forms.Button west;
        private System.Windows.Forms.Button south;
        private System.Windows.Forms.Button mv10;
        private System.Windows.Forms.Button exit;
    }
}

