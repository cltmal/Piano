namespace Tutorial6
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
            this.label1 = new System.Windows.Forms.Label();
            this.sourceList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(321, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "Rec....";
            // 
            // sourceList
            // 
            this.sourceList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.sourceList.HideSelection = false;
            this.sourceList.Location = new System.Drawing.Point(12, 22);
            this.sourceList.MultiSelect = false;
            this.sourceList.Name = "sourceList";
            this.sourceList.Size = new System.Drawing.Size(274, 217);
            this.sourceList.TabIndex = 0;
            this.sourceList.UseCompatibleStateImageBehavior = false;
            this.sourceList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Device";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Channels";
            this.columnHeader2.Width = 97;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(309, 193);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(146, 19);
            this.button5.TabIndex = 4;
            this.button5.Text = "파일저장후녹음시작";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(309, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 21);
            this.button1.TabIndex = 0;
            this.button1.Text = "입력장치 가져오기";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(309, 166);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 21);
            this.button3.TabIndex = 2;
            this.button3.Text = "정지";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(309, 139);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 21);
            this.button2.TabIndex = 1;
            this.button2.Text = "시작";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Black;
            this.button10.Location = new System.Drawing.Point(225, 263);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(39, 152);
            this.button10.TabIndex = 107;
            this.button10.Text = "c";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.Black;
            this.button15.Location = new System.Drawing.Point(31, 263);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(39, 152);
            this.button15.TabIndex = 99;
            this.button15.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Black;
            this.button12.Location = new System.Drawing.Point(272, 263);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(39, 152);
            this.button12.TabIndex = 109;
            this.button12.Text = "c";
            this.button12.UseVisualStyleBackColor = false;
            // 
            // button25
            // 
            this.button25.BackColor = System.Drawing.Color.Black;
            this.button25.Location = new System.Drawing.Point(367, 263);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(39, 152);
            this.button25.TabIndex = 119;
            this.button25.Text = "c";
            this.button25.UseVisualStyleBackColor = false;
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.Color.White;
            this.button21.Location = new System.Drawing.Point(342, 263);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(42, 232);
            this.button21.TabIndex = 115;
            this.button21.UseVisualStyleBackColor = false;
            // 
            // button24
            // 
            this.button24.BackColor = System.Drawing.Color.Black;
            this.button24.Location = new System.Drawing.Point(416, 263);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(39, 152);
            this.button24.TabIndex = 118;
            this.button24.Text = "c";
            this.button24.UseVisualStyleBackColor = false;
            // 
            // button23
            // 
            this.button23.BackColor = System.Drawing.Color.Black;
            this.button23.Location = new System.Drawing.Point(464, 263);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(39, 152);
            this.button23.TabIndex = 117;
            this.button23.Text = "c";
            this.button23.UseVisualStyleBackColor = false;
            // 
            // button22
            // 
            this.button22.BackColor = System.Drawing.Color.Black;
            this.button22.Location = new System.Drawing.Point(560, 263);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(39, 152);
            this.button22.TabIndex = 116;
            this.button22.Text = "c";
            this.button22.UseVisualStyleBackColor = false;
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.Color.White;
            this.button20.Location = new System.Drawing.Point(390, 263);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(42, 232);
            this.button20.TabIndex = 114;
            this.button20.UseVisualStyleBackColor = false;
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.Black;
            this.button13.Location = new System.Drawing.Point(80, 263);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(39, 152);
            this.button13.TabIndex = 102;
            this.button13.UseVisualStyleBackColor = false;
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.White;
            this.button19.Location = new System.Drawing.Point(438, 263);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(42, 232);
            this.button19.TabIndex = 113;
            this.button19.UseVisualStyleBackColor = false;
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.White;
            this.button18.Location = new System.Drawing.Point(486, 263);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(42, 232);
            this.button18.TabIndex = 112;
            this.button18.UseVisualStyleBackColor = false;
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.White;
            this.button17.Location = new System.Drawing.Point(534, 263);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(42, 232);
            this.button17.TabIndex = 111;
            this.button17.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Black;
            this.button8.Location = new System.Drawing.Point(176, 263);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(39, 152);
            this.button8.TabIndex = 105;
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.White;
            this.button16.Location = new System.Drawing.Point(582, 263);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(42, 232);
            this.button16.TabIndex = 110;
            this.button16.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(246, 263);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(42, 232);
            this.button9.TabIndex = 106;
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.White;
            this.button11.Location = new System.Drawing.Point(294, 263);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(42, 232);
            this.button11.TabIndex = 108;
            this.button11.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(198, 263);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(42, 232);
            this.button7.TabIndex = 104;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(150, 263);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(42, 232);
            this.button6.TabIndex = 103;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.White;
            this.button14.Location = new System.Drawing.Point(102, 263);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(42, 232);
            this.button14.TabIndex = 101;
            this.button14.UseVisualStyleBackColor = false;
            // 
            // button26
            // 
            this.button26.BackColor = System.Drawing.Color.White;
            this.button26.Location = new System.Drawing.Point(54, 263);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(42, 232);
            this.button26.TabIndex = 100;
            this.button26.UseVisualStyleBackColor = false;
            // 
            // button27
            // 
            this.button27.BackColor = System.Drawing.Color.White;
            this.button27.Location = new System.Drawing.Point(6, 263);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(42, 232);
            this.button27.TabIndex = 98;
            this.button27.UseVisualStyleBackColor = false;
            this.button27.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Button27_KeyDown);
            this.button27.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Button27_KeyUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 507);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button25);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button26);
            this.Controls.Add(this.button27);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sourceList);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Audio Loopback";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView sourceList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button27;
    }
}

