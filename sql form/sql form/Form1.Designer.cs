namespace sql_form
{
    partial class SQLEditor
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.start = new System.Windows.Forms.Button();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_age = new System.Windows.Forms.TextBox();
            this.but_delete = new System.Windows.Forms.Button();
            this.but_add = new System.Windows.Forms.Button();
            this.lab_name = new System.Windows.Forms.Label();
            this.lab_Age = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_editName = new System.Windows.Forms.TextBox();
            this.txt_editAge = new System.Windows.Forms.TextBox();
            this.but_edit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_willName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_willAge = new System.Windows.Forms.TextBox();
            this.lab_editAge = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.age});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(240, 368);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // name
            // 
            this.name.HeaderText = "name";
            this.name.Name = "name";
            // 
            // age
            // 
            this.age.HeaderText = "age";
            this.age.Name = "age";
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.SystemColors.Control;
            this.start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.start.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.start.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.start.Font = new System.Drawing.Font("Zexo", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.ForeColor = System.Drawing.Color.Black;
            this.start.Location = new System.Drawing.Point(12, 386);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(127, 52);
            this.start.TabIndex = 1;
            this.start.Text = "리로드";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click_1);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(258, 78);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 21);
            this.txt_name.TabIndex = 2;
            // 
            // txt_age
            // 
            this.txt_age.Location = new System.Drawing.Point(368, 78);
            this.txt_age.Name = "txt_age";
            this.txt_age.Size = new System.Drawing.Size(100, 21);
            this.txt_age.TabIndex = 3;
            // 
            // but_delete
            // 
            this.but_delete.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.but_delete.Location = new System.Drawing.Point(258, 105);
            this.but_delete.Name = "but_delete";
            this.but_delete.Size = new System.Drawing.Size(96, 52);
            this.but_delete.TabIndex = 4;
            this.but_delete.Text = "삭제";
            this.but_delete.UseVisualStyleBackColor = true;
            this.but_delete.Click += new System.EventHandler(this.but_delete_Click);
            // 
            // but_add
            // 
            this.but_add.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.but_add.Location = new System.Drawing.Point(364, 105);
            this.but_add.Name = "but_add";
            this.but_add.Size = new System.Drawing.Size(92, 52);
            this.but_add.TabIndex = 5;
            this.but_add.Text = "추가";
            this.but_add.UseVisualStyleBackColor = true;
            this.but_add.Click += new System.EventHandler(this.but_add_Click);
            // 
            // lab_name
            // 
            this.lab_name.AutoSize = true;
            this.lab_name.BackColor = System.Drawing.Color.Transparent;
            this.lab_name.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lab_name.Location = new System.Drawing.Point(254, 54);
            this.lab_name.Name = "lab_name";
            this.lab_name.Size = new System.Drawing.Size(58, 21);
            this.lab_name.TabIndex = 6;
            this.lab_name.Text = "Name";
            // 
            // lab_Age
            // 
            this.lab_Age.AutoSize = true;
            this.lab_Age.BackColor = System.Drawing.Color.Transparent;
            this.lab_Age.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lab_Age.Location = new System.Drawing.Point(364, 54);
            this.lab_Age.Name = "lab_Age";
            this.lab_Age.Size = new System.Drawing.Size(43, 21);
            this.lab_Age.TabIndex = 7;
            this.lab_Age.Text = "Age";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(255, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Will Edit Name";
            // 
            // txt_editName
            // 
            this.txt_editName.Location = new System.Drawing.Point(262, 210);
            this.txt_editName.Name = "txt_editName";
            this.txt_editName.Size = new System.Drawing.Size(100, 21);
            this.txt_editName.TabIndex = 9;
            // 
            // txt_editAge
            // 
            this.txt_editAge.Location = new System.Drawing.Point(368, 210);
            this.txt_editAge.Name = "txt_editAge";
            this.txt_editAge.Size = new System.Drawing.Size(100, 21);
            this.txt_editAge.TabIndex = 11;
            // 
            // but_edit
            // 
            this.but_edit.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.but_edit.Location = new System.Drawing.Point(262, 328);
            this.but_edit.Name = "but_edit";
            this.but_edit.Size = new System.Drawing.Size(96, 52);
            this.but_edit.TabIndex = 12;
            this.but_edit.Text = "편집";
            this.but_edit.UseVisualStyleBackColor = true;
            this.but_edit.Click += new System.EventHandler(this.but_edit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(258, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "Name";
            // 
            // txt_willName
            // 
            this.txt_willName.Location = new System.Drawing.Point(262, 281);
            this.txt_willName.Name = "txt_willName";
            this.txt_willName.Size = new System.Drawing.Size(100, 21);
            this.txt_willName.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(368, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 21);
            this.label4.TabIndex = 15;
            this.label4.Text = "Age";
            // 
            // txt_willAge
            // 
            this.txt_willAge.Location = new System.Drawing.Point(368, 281);
            this.txt_willAge.Name = "txt_willAge";
            this.txt_willAge.Size = new System.Drawing.Size(100, 21);
            this.txt_willAge.TabIndex = 16;
            // 
            // lab_editAge
            // 
            this.lab_editAge.AutoSize = true;
            this.lab_editAge.BackColor = System.Drawing.Color.Transparent;
            this.lab_editAge.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lab_editAge.Location = new System.Drawing.Point(365, 191);
            this.lab_editAge.Name = "lab_editAge";
            this.lab_editAge.Size = new System.Drawing.Size(96, 16);
            this.lab_editAge.TabIndex = 17;
            this.lab_editAge.Text = "Will Edit Age";
            // 
            // SQLEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lab_editAge);
            this.Controls.Add(this.txt_willAge);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_willName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.but_edit);
            this.Controls.Add(this.txt_editAge);
            this.Controls.Add(this.txt_editName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lab_Age);
            this.Controls.Add(this.lab_name);
            this.Controls.Add(this.but_add);
            this.Controls.Add(this.but_delete);
            this.Controls.Add(this.txt_age);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.start);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SQLEditor";
            this.Text = "SQL Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_age;
        private System.Windows.Forms.Button but_delete;
        private System.Windows.Forms.Button but_add;
        private System.Windows.Forms.Label lab_name;
        private System.Windows.Forms.Label lab_Age;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_editName;
        private System.Windows.Forms.TextBox txt_editAge;
        private System.Windows.Forms.Button but_edit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_willName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_willAge;
        private System.Windows.Forms.Label lab_editAge;
    }
}

