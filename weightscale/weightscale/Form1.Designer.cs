namespace weightscale
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
            this.calculate_btn = new System.Windows.Forms.Button();
            this.clear_btn = new System.Windows.Forms.Button();
            this.emptybox = new System.Windows.Forms.TextBox();
            this.total = new System.Windows.Forms.TextBox();
            this.boxandpcs = new System.Windows.Forms.TextBox();
            this.howmany = new System.Windows.Forms.TextBox();
            this.bw10 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calculate_btn
            // 
            this.calculate_btn.Location = new System.Drawing.Point(26, 315);
            this.calculate_btn.Name = "calculate_btn";
            this.calculate_btn.Size = new System.Drawing.Size(75, 23);
            this.calculate_btn.TabIndex = 0;
            this.calculate_btn.Text = "Calculate";
            this.calculate_btn.UseVisualStyleBackColor = true;
            this.calculate_btn.Click += new System.EventHandler(this.calculate_btn_Click);
            // 
            // clear_btn
            // 
            this.clear_btn.Location = new System.Drawing.Point(156, 315);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(75, 23);
            this.clear_btn.TabIndex = 1;
            this.clear_btn.Text = "Clear";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // emptybox
            // 
            this.emptybox.Location = new System.Drawing.Point(80, 48);
            this.emptybox.Name = "emptybox";
            this.emptybox.Size = new System.Drawing.Size(100, 20);
            this.emptybox.TabIndex = 2;
            // 
            // total
            // 
            this.total.Location = new System.Drawing.Point(80, 398);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(100, 20);
            this.total.TabIndex = 3;
            // 
            // boxandpcs
            // 
            this.boxandpcs.Location = new System.Drawing.Point(80, 267);
            this.boxandpcs.Name = "boxandpcs";
            this.boxandpcs.Size = new System.Drawing.Size(100, 20);
            this.boxandpcs.TabIndex = 4;
            // 
            // howmany
            // 
            this.howmany.Location = new System.Drawing.Point(80, 206);
            this.howmany.Name = "howmany";
            this.howmany.Size = new System.Drawing.Size(100, 20);
            this.howmany.TabIndex = 5;
            // 
            // bw10
            // 
            this.bw10.Location = new System.Drawing.Point(80, 127);
            this.bw10.Name = "bw10";
            this.bw10.Size = new System.Drawing.Size(100, 20);
            this.bw10.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Weight of Empty Box";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(75, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(333, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Weight of 10 Pieces (with box)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(581, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "How Many Identical Boxes are you Weighing Together";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(428, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Weight of Box/Boxes with Pieces Inside";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(75, 355);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Total PIeces";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 528);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bw10);
            this.Controls.Add(this.howmany);
            this.Controls.Add(this.boxandpcs);
            this.Controls.Add(this.total);
            this.Controls.Add(this.emptybox);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.calculate_btn);
            this.Name = "Form1";
            this.Text = "Weight Scale Counting";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculate_btn;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.TextBox emptybox;
        private System.Windows.Forms.TextBox total;
        private System.Windows.Forms.TextBox boxandpcs;
        private System.Windows.Forms.TextBox howmany;
        private System.Windows.Forms.TextBox bw10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

