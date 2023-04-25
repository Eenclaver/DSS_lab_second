namespace DSS_second
{
    partial class StartForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("tst1");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("tst2");
            this.bt_Create = new System.Windows.Forms.Button();
            this.tb_lines = new System.Windows.Forms.TextBox();
            this.cb_welcome = new System.Windows.Forms.CheckBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.tb_columns = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bt_Create
            // 
            this.bt_Create.Location = new System.Drawing.Point(242, 107);
            this.bt_Create.Name = "bt_Create";
            this.bt_Create.Size = new System.Drawing.Size(89, 47);
            this.bt_Create.TabIndex = 0;
            this.bt_Create.Text = "создать массив";
            this.bt_Create.UseVisualStyleBackColor = true;
            this.bt_Create.Click += new System.EventHandler(this.bt_Create_Click);
            // 
            // tb_lines
            // 
            this.tb_lines.Location = new System.Drawing.Point(99, 57);
            this.tb_lines.Name = "tb_lines";
            this.tb_lines.Size = new System.Drawing.Size(100, 22);
            this.tb_lines.TabIndex = 1;
            this.tb_lines.TextChanged += new System.EventHandler(this.tb_TextChanged);
            this.tb_lines.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputMask);
            // 
            // cb_welcome
            // 
            this.cb_welcome.AutoSize = true;
            this.cb_welcome.Location = new System.Drawing.Point(12, 12);
            this.cb_welcome.Name = "cb_welcome";
            this.cb_welcome.Size = new System.Drawing.Size(114, 20);
            this.cb_welcome.TabIndex = 2;
            this.cb_welcome.Text = "приветствие";
            this.cb_welcome.UseVisualStyleBackColor = true;
            this.cb_welcome.CheckedChanged += new System.EventHandler(this.cb_Welcome_CheckedChanged);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.listView1.Location = new System.Drawing.Point(395, 57);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(224, 120);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // tb_columns
            // 
            this.tb_columns.Location = new System.Drawing.Point(231, 57);
            this.tb_columns.Name = "tb_columns";
            this.tb_columns.Size = new System.Drawing.Size(100, 22);
            this.tb_columns.TabIndex = 4;
            this.tb_columns.TextChanged += new System.EventHandler(this.tb_TextChanged);
            this.tb_columns.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputMask);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 189);
            this.ControlBox = false;
            this.Controls.Add(this.tb_columns);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.cb_welcome);
            this.Controls.Add(this.tb_lines);
            this.Controls.Add(this.bt_Create);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "StartForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Create;
        private System.Windows.Forms.TextBox tb_lines;
        private System.Windows.Forms.CheckBox cb_welcome;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox tb_columns;
    }
}

