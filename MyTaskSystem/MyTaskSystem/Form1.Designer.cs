namespace MyTaskSystem
{
    partial class frmMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRun = new System.Windows.Forms.Button();
            this.chbxDone = new System.Windows.Forms.CheckBox();
            this.myTXTDate1 = new MyUserControls.MyTXTDate();
            this.rchtxtTasks = new System.Windows.Forms.RichTextBox();
            this.txtCustomers = new System.Windows.Forms.TextBox();
            this.txtPrivoty = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelEdit = new System.Windows.Forms.Panel();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.myTXTDate2 = new MyUserControls.MyTXTDate();
            this.rcheditdescriptions = new System.Windows.Forms.RichTextBox();
            this.txteditNameCustoemrs = new System.Windows.Forms.TextBox();
            this.txteditProvity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.done = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1.SuspendLayout();
            this.panelEdit.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRun);
            this.panel1.Controls.Add(this.chbxDone);
            this.panel1.Controls.Add(this.myTXTDate1);
            this.panel1.Controls.Add(this.rchtxtTasks);
            this.panel1.Controls.Add(this.txtCustomers);
            this.panel1.Controls.Add(this.txtPrivoty);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("B Yekan", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(1158, 179);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            this.panel1.Enter += new System.EventHandler(this.panel1_Enter);
            // 
            // btnRun
            // 
            this.btnRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRun.Location = new System.Drawing.Point(36, 104);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 34);
            this.btnRun.TabIndex = 5;
            this.btnRun.Text = "ثبت";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // chbxDone
            // 
            this.chbxDone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chbxDone.AutoSize = true;
            this.chbxDone.Location = new System.Drawing.Point(127, 105);
            this.chbxDone.Name = "chbxDone";
            this.chbxDone.Size = new System.Drawing.Size(103, 33);
            this.chbxDone.TabIndex = 4;
            this.chbxDone.Text = "انجام شده";
            this.chbxDone.UseVisualStyleBackColor = true;
            this.chbxDone.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            this.chbxDone.Click += new System.EventHandler(this.panel1_Click);
            // 
            // myTXTDate1
            // 
            this.myTXTDate1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.myTXTDate1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.myTXTDate1.Location = new System.Drawing.Point(15, 37);
            this.myTXTDate1.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.myTXTDate1.Mouseclick = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(174)))), ((int)(((byte)(0)))));
            this.myTXTDate1.MouseClickLeave = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.myTXTDate1.Name = "myTXTDate1";
            this.myTXTDate1.SendMessage = null;
            this.myTXTDate1.Size = new System.Drawing.Size(177, 37);
            this.myTXTDate1.TabIndex = 3;
            this.myTXTDate1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // rchtxtTasks
            // 
            this.rchtxtTasks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rchtxtTasks.Location = new System.Drawing.Point(326, 31);
            this.rchtxtTasks.Name = "rchtxtTasks";
            this.rchtxtTasks.Size = new System.Drawing.Size(448, 113);
            this.rchtxtTasks.TabIndex = 2;
            this.rchtxtTasks.Text = "";
            this.rchtxtTasks.Click += new System.EventHandler(this.panel1_Click);
            this.rchtxtTasks.Enter += new System.EventHandler(this.panel1_Enter);
            this.rchtxtTasks.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // txtCustomers
            // 
            this.txtCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCustomers.Location = new System.Drawing.Point(888, 107);
            this.txtCustomers.Name = "txtCustomers";
            this.txtCustomers.Size = new System.Drawing.Size(175, 37);
            this.txtCustomers.TabIndex = 1;
            this.txtCustomers.Click += new System.EventHandler(this.panel1_Click);
            this.txtCustomers.Enter += new System.EventHandler(this.panel1_Enter);
            this.txtCustomers.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // txtPrivoty
            // 
            this.txtPrivoty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrivoty.Location = new System.Drawing.Point(888, 28);
            this.txtPrivoty.Name = "txtPrivoty";
            this.txtPrivoty.Size = new System.Drawing.Size(175, 37);
            this.txtPrivoty.TabIndex = 0;
            this.txtPrivoty.Click += new System.EventHandler(this.panel1_Click);
            this.txtPrivoty.Enter += new System.EventHandler(this.panel1_Enter);
            this.txtPrivoty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(196, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "تاريخ";
            this.label5.Click += new System.EventHandler(this.panel1_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1069, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "اولويت";
            this.label3.Click += new System.EventHandler(this.panel1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1069, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "مشتري ";
            this.label2.Click += new System.EventHandler(this.panel1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(774, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "شرح وظيفه";
            this.label1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // panelEdit
            // 
            this.panelEdit.Controls.Add(this.checkBox2);
            this.panelEdit.Controls.Add(this.label10);
            this.panelEdit.Controls.Add(this.btnEdit);
            this.panelEdit.Controls.Add(this.myTXTDate2);
            this.panelEdit.Controls.Add(this.rcheditdescriptions);
            this.panelEdit.Controls.Add(this.txteditNameCustoemrs);
            this.panelEdit.Controls.Add(this.txteditProvity);
            this.panelEdit.Controls.Add(this.label7);
            this.panelEdit.Controls.Add(this.label8);
            this.panelEdit.Controls.Add(this.label9);
            this.panelEdit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelEdit.Font = new System.Drawing.Font("B Yekan", 14.25F);
            this.panelEdit.Location = new System.Drawing.Point(0, 549);
            this.panelEdit.Name = "panelEdit";
            this.panelEdit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panelEdit.Size = new System.Drawing.Size(1158, 195);
            this.panelEdit.TabIndex = 1;
            this.panelEdit.Visible = false;
            // 
            // checkBox2
            // 
            this.checkBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(124, 104);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(103, 33);
            this.checkBox2.TabIndex = 17;
            this.checkBox2.Text = "انجام شده";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(775, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 29);
            this.label10.TabIndex = 16;
            this.label10.Text = "شرح وظيفه";
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Location = new System.Drawing.Point(36, 102);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 34);
            this.btnEdit.TabIndex = 15;
            this.btnEdit.Text = "ويرايش";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // myTXTDate2
            // 
            this.myTXTDate2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.myTXTDate2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.myTXTDate2.Location = new System.Drawing.Point(15, 31);
            this.myTXTDate2.Margin = new System.Windows.Forms.Padding(11, 16, 11, 16);
            this.myTXTDate2.Mouseclick = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(174)))), ((int)(((byte)(0)))));
            this.myTXTDate2.MouseClickLeave = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.myTXTDate2.Name = "myTXTDate2";
            this.myTXTDate2.SendMessage = null;
            this.myTXTDate2.Size = new System.Drawing.Size(181, 33);
            this.myTXTDate2.TabIndex = 12;
            // 
            // rcheditdescriptions
            // 
            this.rcheditdescriptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rcheditdescriptions.Location = new System.Drawing.Point(324, 31);
            this.rcheditdescriptions.Name = "rcheditdescriptions";
            this.rcheditdescriptions.Size = new System.Drawing.Size(448, 113);
            this.rcheditdescriptions.TabIndex = 11;
            this.rcheditdescriptions.Text = "";
            // 
            // txteditNameCustoemrs
            // 
            this.txteditNameCustoemrs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txteditNameCustoemrs.Location = new System.Drawing.Point(886, 107);
            this.txteditNameCustoemrs.Name = "txteditNameCustoemrs";
            this.txteditNameCustoemrs.Size = new System.Drawing.Size(175, 37);
            this.txteditNameCustoemrs.TabIndex = 10;
            // 
            // txteditProvity
            // 
            this.txteditProvity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txteditProvity.Location = new System.Drawing.Point(886, 28);
            this.txteditProvity.Name = "txteditProvity";
            this.txteditProvity.Size = new System.Drawing.Size(175, 37);
            this.txteditProvity.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(200, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 29);
            this.label7.TabIndex = 6;
            this.label7.Text = "تاريخ";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1067, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 29);
            this.label8.TabIndex = 7;
            this.label8.Text = "اولويت";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1067, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 29);
            this.label9.TabIndex = 8;
            this.label9.Text = "مشتري ";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 179);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1158, 370);
            this.panel3.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("B Yekan", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.done});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("B Yekan", 15.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(1158, 370);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseClick);
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "id";
            this.Column6.HeaderText = "id";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "رديف";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "priority";
            this.Column2.HeaderText = "اولويت";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "nameCustomer";
            this.Column3.HeaderText = "مشتري";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 250;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "description";
            this.Column4.HeaderText = "شرح وظيفه";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "dateDone";
            this.Column5.HeaderText = "تاريخ ثبت";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // done
            // 
            this.done.DataPropertyName = "done";
            this.done.HeaderText = "انجام شده";
            this.done.Name = "done";
            this.done.ReadOnly = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 744);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelEdit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelEdit.ResumeLayout(false);
            this.panelEdit.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelEdit;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrivoty;
        private System.Windows.Forms.TextBox txtCustomers;
        private System.Windows.Forms.RichTextBox rchtxtTasks;
        private MyUserControls.MyTXTDate myTXTDate1;
        private System.Windows.Forms.CheckBox chbxDone;
        private MyUserControls.MyTXTDate myTXTDate2;
        private System.Windows.Forms.RichTextBox rcheditdescriptions;
        private System.Windows.Forms.TextBox txteditNameCustoemrs;
        private System.Windows.Forms.TextBox txteditProvity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn done;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}

