namespace WindowsFormsApp1
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
            this.button1 = new System.Windows.Forms.Button();
            this.stumbutton = new System.Windows.Forms.Button();
            this.crbutton = new System.Windows.Forms.Button();
            this.textbutton = new System.Windows.Forms.Button();
            this.Welcom_textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button1.Location = new System.Drawing.Point(1123, 586);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "返回上一级";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // stumbutton
            // 
            this.stumbutton.Font = new System.Drawing.Font("宋体", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.stumbutton.ForeColor = System.Drawing.Color.Blue;
            this.stumbutton.Location = new System.Drawing.Point(47, 141);
            this.stumbutton.Name = "stumbutton";
            this.stumbutton.Size = new System.Drawing.Size(216, 100);
            this.stumbutton.TabIndex = 3;
            this.stumbutton.Text = "学生管理";
            this.stumbutton.UseVisualStyleBackColor = true;
            this.stumbutton.Click += new System.EventHandler(this.stumbutton_Click);
            // 
            // crbutton
            // 
            this.crbutton.Font = new System.Drawing.Font("宋体", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.crbutton.ForeColor = System.Drawing.Color.Blue;
            this.crbutton.Location = new System.Drawing.Point(436, 141);
            this.crbutton.Name = "crbutton";
            this.crbutton.Size = new System.Drawing.Size(216, 100);
            this.crbutton.TabIndex = 5;
            this.crbutton.Text = "教室管理";
            this.crbutton.UseVisualStyleBackColor = true;
            this.crbutton.Click += new System.EventHandler(this.crbutton_Click);
            // 
            // textbutton
            // 
            this.textbutton.Font = new System.Drawing.Font("宋体", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textbutton.ForeColor = System.Drawing.Color.Blue;
            this.textbutton.Location = new System.Drawing.Point(840, 141);
            this.textbutton.Name = "textbutton";
            this.textbutton.Size = new System.Drawing.Size(216, 100);
            this.textbutton.TabIndex = 6;
            this.textbutton.Text = "成绩查询";
            this.textbutton.UseVisualStyleBackColor = true;
            this.textbutton.Click += new System.EventHandler(this.textbutton_Click);
            // 
            // Welcom_textbox
            // 
            this.Welcom_textbox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Welcom_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Welcom_textbox.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Welcom_textbox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Welcom_textbox.Location = new System.Drawing.Point(29, 12);
            this.Welcom_textbox.Name = "Welcom_textbox";
            this.Welcom_textbox.ReadOnly = true;
            this.Welcom_textbox.Size = new System.Drawing.Size(443, 23);
            this.Welcom_textbox.TabIndex = 2;
            this.Welcom_textbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1245, 616);
            this.Controls.Add(this.textbutton);
            this.Controls.Add(this.crbutton);
            this.Controls.Add(this.stumbutton);
            this.Controls.Add(this.Welcom_textbox);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button stumbutton;
        private System.Windows.Forms.Button crbutton;
        private System.Windows.Forms.Button textbutton;
        private System.Windows.Forms.TextBox Welcom_textbox;
    }
}