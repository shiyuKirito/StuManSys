namespace WindowsFormsApp1
{
    partial class student
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.stuid_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.stuname_text = new System.Windows.Forms.TextBox();
            this.stusex_text = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.stuclass_text = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.stuage_text = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.stucall_text = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.Clear_button = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Location = new System.Drawing.Point(760, 520);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Select_button);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.ForeColor = System.Drawing.Color.DarkGreen;
            this.button2.Location = new System.Drawing.Point(1041, 520);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 50);
            this.button2.TabIndex = 2;
            this.button2.Text = "添加";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Insert_button);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.ForeColor = System.Drawing.Color.Orange;
            this.button3.Location = new System.Drawing.Point(904, 520);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 50);
            this.button3.TabIndex = 3;
            this.button3.Text = "删除";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Delete_button);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(8, 405);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "学号：";
            // 
            // stuid_text
            // 
            this.stuid_text.Location = new System.Drawing.Point(70, 405);
            this.stuid_text.Name = "stuid_text";
            this.stuid_text.Size = new System.Drawing.Size(115, 21);
            this.stuid_text.TabIndex = 5;
            this.stuid_text.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(191, 405);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "姓名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(570, 405);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "班级：";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // stuname_text
            // 
            this.stuname_text.Location = new System.Drawing.Point(252, 405);
            this.stuname_text.Name = "stuname_text";
            this.stuname_text.Size = new System.Drawing.Size(87, 21);
            this.stuname_text.TabIndex = 8;
            this.stuname_text.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // stusex_text
            // 
            this.stusex_text.Location = new System.Drawing.Point(423, 405);
            this.stusex_text.Name = "stusex_text";
            this.stusex_text.Size = new System.Drawing.Size(25, 21);
            this.stusex_text.TabIndex = 9;
            this.stusex_text.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(354, 405);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "性别:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // stuclass_text
            // 
            this.stuclass_text.Location = new System.Drawing.Point(630, 405);
            this.stuclass_text.Name = "stuclass_text";
            this.stuclass_text.Size = new System.Drawing.Size(127, 21);
            this.stuclass_text.TabIndex = 11;
            this.stuclass_text.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(454, 405);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 21);
            this.label5.TabIndex = 12;
            this.label5.Text = "年龄：";
            // 
            // stuage_text
            // 
            this.stuage_text.Location = new System.Drawing.Point(520, 405);
            this.stuage_text.Name = "stuage_text";
            this.stuage_text.Size = new System.Drawing.Size(33, 21);
            this.stuage_text.TabIndex = 13;
            this.stuage_text.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(763, 405);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 21);
            this.label6.TabIndex = 14;
            this.label6.Text = "联系方式：";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // stucall_text
            // 
            this.stucall_text.Location = new System.Drawing.Point(870, 405);
            this.stucall_text.Name = "stucall_text";
            this.stucall_text.Size = new System.Drawing.Size(168, 21);
            this.stucall_text.TabIndex = 15;
            this.stucall_text.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // button4
            // 
            this.button4.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button4.Location = new System.Drawing.Point(1076, 601);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 28);
            this.button4.TabIndex = 16;
            this.button4.Text = "返回上一级";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Clear_button
            // 
            this.Clear_button.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Clear_button.ForeColor = System.Drawing.Color.OrangeRed;
            this.Clear_button.Location = new System.Drawing.Point(343, 495);
            this.Clear_button.Name = "Clear_button";
            this.Clear_button.Size = new System.Drawing.Size(74, 38);
            this.Clear_button.TabIndex = 18;
            this.Clear_button.Text = "重置";
            this.Clear_button.UseVisualStyleBackColor = true;
            this.Clear_button.Click += new System.EventHandler(this.Clear_button_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button5.Location = new System.Drawing.Point(1041, 456);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(111, 58);
            this.button5.TabIndex = 19;
            this.button5.Text = "显示所有学生";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 60;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.Size = new System.Drawing.Size(1199, 387);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 631);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.Clear_button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.stucall_text);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.stuage_text);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.stuclass_text);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.stusex_text);
            this.Controls.Add(this.stuname_text);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.stuid_text);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "student";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.student_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox stuid_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox stuname_text;
        private System.Windows.Forms.TextBox stusex_text;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox stuclass_text;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox stuage_text;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox stucall_text;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button Clear_button;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}