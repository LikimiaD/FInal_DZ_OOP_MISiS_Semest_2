namespace DZ
{
    partial class all_button
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.datagrid = new System.Windows.Forms.DataGridView();
            this.add_button = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.take = new System.Windows.Forms.Button();
            this.give = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Count_Button = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // datagrid
            // 
            this.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid.Location = new System.Drawing.Point(12, 12);
            this.datagrid.Name = "datagrid";
            this.datagrid.RowTemplate.Height = 25;
            this.datagrid.Size = new System.Drawing.Size(785, 383);
            this.datagrid.TabIndex = 0;
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(12, 401);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(121, 64);
            this.add_button.TabIndex = 1;
            this.add_button.Text = "Добавить";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(676, 401);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(121, 64);
            this.delete.TabIndex = 2;
            this.delete.Text = "Удалить";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // take
            // 
            this.take.Location = new System.Drawing.Point(139, 401);
            this.take.Name = "take";
            this.take.Size = new System.Drawing.Size(121, 64);
            this.take.TabIndex = 3;
            this.take.Text = "Взять книгу";
            this.take.UseVisualStyleBackColor = true;
            this.take.Click += new System.EventHandler(this.take_Click);
            // 
            // give
            // 
            this.give.Location = new System.Drawing.Point(266, 401);
            this.give.Name = "give";
            this.give.Size = new System.Drawing.Size(121, 64);
            this.give.TabIndex = 4;
            this.give.Text = "Отдать книгу";
            this.give.UseVisualStyleBackColor = true;
            this.give.Click += new System.EventHandler(this.give_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(393, 414);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "В наличии:";
            // 
            // Count_Button
            // 
            this.Count_Button.AutoSize = true;
            this.Count_Button.Location = new System.Drawing.Point(467, 416);
            this.Count_Button.Name = "Count_Button";
            this.Count_Button.Size = new System.Drawing.Size(14, 13);
            this.Count_Button.TabIndex = 6;
            this.Count_Button.TabStop = true;
            this.Count_Button.UseVisualStyleBackColor = true;
            this.Count_Button.CheckedChanged += new System.EventHandler(this.Count_Button_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(393, 438);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Все книги:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(467, 440);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(14, 13);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // all_button
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 473);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Count_Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.give);
            this.Controls.Add(this.take);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.datagrid);
            this.Name = "all_button";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView datagrid;
        private Button add_button;
        private Button delete;
        private Button take;
        private Button give;
        private Label label1;
        private RadioButton Count_Button;
        private Label label2;
        private RadioButton radioButton1;
    }
}