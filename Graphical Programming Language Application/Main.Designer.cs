﻿namespace Graphical_Programming_Language_Application
{
     partial class Main
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
            this.lbl_appname = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbl_StartPosX = new System.Windows.Forms.Label();
            this.lbl_StartPosY = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_cursorx = new System.Windows.Forms.Label();
            this.lbl_cursory = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_canvasx = new System.Windows.Forms.Label();
            this.lbl_canvasy = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showcolorbox = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rtxt_console = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_consolerun = new System.Windows.Forms.Button();
            this.btn_console1clear = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.rtxt_errors = new System.Windows.Forms.RichTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.rtxt_history = new System.Windows.Forms.RichTextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.drawareapanel = new System.Windows.Forms.PictureBox();
            this.btn_Close = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showcolorbox)).BeginInit();
            this.panel4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drawareapanel)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_appname
            // 
            this.lbl_appname.AutoSize = true;
            this.lbl_appname.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_appname.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_appname.Location = new System.Drawing.Point(187, 3);
            this.lbl_appname.Name = "lbl_appname";
            this.lbl_appname.Size = new System.Drawing.Size(0, 26);
            this.lbl_appname.TabIndex = 2;
            this.lbl_appname.Click += new System.EventHandler(this.lbl_appname_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.lbl_appname);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.menuStrip2);
            this.panel2.Controls.Add(this.showcolorbox);
            this.panel2.Location = new System.Drawing.Point(-1, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(867, 42);
            this.panel2.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbl_StartPosX);
            this.groupBox3.Controls.Add(this.lbl_StartPosY);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(572, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(92, 33);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Start Position";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // lbl_StartPosX
            // 
            this.lbl_StartPosX.AutoSize = true;
            this.lbl_StartPosX.ForeColor = System.Drawing.Color.White;
            this.lbl_StartPosX.Location = new System.Drawing.Point(20, 16);
            this.lbl_StartPosX.Name = "lbl_StartPosX";
            this.lbl_StartPosX.Size = new System.Drawing.Size(25, 13);
            this.lbl_StartPosX.TabIndex = 9;
            this.lbl_StartPosX.Text = "000";
            // 
            // lbl_StartPosY
            // 
            this.lbl_StartPosY.AutoSize = true;
            this.lbl_StartPosY.ForeColor = System.Drawing.Color.White;
            this.lbl_StartPosY.Location = new System.Drawing.Point(61, 16);
            this.lbl_StartPosY.Name = "lbl_StartPosY";
            this.lbl_StartPosY.Size = new System.Drawing.Size(25, 13);
            this.lbl_StartPosY.TabIndex = 10;
            this.lbl_StartPosY.Text = "000";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label9.Location = new System.Drawing.Point(4, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "X:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label10.Location = new System.Drawing.Point(47, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 16);
            this.label10.TabIndex = 8;
            this.label10.Text = "Y:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_cursorx);
            this.groupBox2.Controls.Add(this.lbl_cursory);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(666, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(92, 37);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cursor Position";
            // 
            // lbl_cursorx
            // 
            this.lbl_cursorx.AutoSize = true;
            this.lbl_cursorx.ForeColor = System.Drawing.Color.White;
            this.lbl_cursorx.Location = new System.Drawing.Point(20, 16);
            this.lbl_cursorx.Name = "lbl_cursorx";
            this.lbl_cursorx.Size = new System.Drawing.Size(25, 13);
            this.lbl_cursorx.TabIndex = 9;
            this.lbl_cursorx.Text = "000";
            // 
            // lbl_cursory
            // 
            this.lbl_cursory.AutoSize = true;
            this.lbl_cursory.ForeColor = System.Drawing.Color.White;
            this.lbl_cursory.Location = new System.Drawing.Point(62, 16);
            this.lbl_cursory.Name = "lbl_cursory";
            this.lbl_cursory.Size = new System.Drawing.Size(25, 13);
            this.lbl_cursory.TabIndex = 10;
            this.lbl_cursory.Text = "000";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label7.Location = new System.Drawing.Point(4, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "X:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label8.Location = new System.Drawing.Point(48, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Y:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_canvasx);
            this.groupBox1.Controls.Add(this.lbl_canvasy);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(762, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(92, 37);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Canvas Center";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lbl_canvasx
            // 
            this.lbl_canvasx.AutoSize = true;
            this.lbl_canvasx.ForeColor = System.Drawing.Color.White;
            this.lbl_canvasx.Location = new System.Drawing.Point(20, 15);
            this.lbl_canvasx.Name = "lbl_canvasx";
            this.lbl_canvasx.Size = new System.Drawing.Size(25, 13);
            this.lbl_canvasx.TabIndex = 9;
            this.lbl_canvasx.Text = "000";
            this.lbl_canvasx.Click += new System.EventHandler(this.lbl_canvasx_Click);
            // 
            // lbl_canvasy
            // 
            this.lbl_canvasy.AutoSize = true;
            this.lbl_canvasy.ForeColor = System.Drawing.Color.White;
            this.lbl_canvasy.Location = new System.Drawing.Point(62, 15);
            this.lbl_canvasy.Name = "lbl_canvasy";
            this.lbl_canvasy.Size = new System.Drawing.Size(25, 13);
            this.lbl_canvasy.TabIndex = 10;
            this.lbl_canvasy.Text = "000";
            this.lbl_canvasy.Click += new System.EventHandler(this.lbl_canvasy_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(4, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "X:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Location = new System.Drawing.Point(48, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Y:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(11, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose Color :";
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.DarkOrange;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(867, 29);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            this.menuStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip2_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(49, 25);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.newToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(121, 26);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click_1);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openImageToolStripMenuItem,
            this.openTextToolStripMenuItem});
            this.openToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(121, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click_1);
            // 
            // openImageToolStripMenuItem
            // 
            this.openImageToolStripMenuItem.Name = "openImageToolStripMenuItem";
            this.openImageToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.openImageToolStripMenuItem.Text = "Open Image";
            this.openImageToolStripMenuItem.Click += new System.EventHandler(this.openImageToolStripMenuItem_Click);
            // 
            // openTextToolStripMenuItem
            // 
            this.openTextToolStripMenuItem.Name = "openTextToolStripMenuItem";
            this.openTextToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.openTextToolStripMenuItem.Text = "Open Text";
            this.openTextToolStripMenuItem.Click += new System.EventHandler(this.openTextToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveImageToolStripMenuItem,
            this.saveTextToolStripMenuItem});
            this.saveToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(121, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click_1);
            // 
            // saveImageToolStripMenuItem
            // 
            this.saveImageToolStripMenuItem.Name = "saveImageToolStripMenuItem";
            this.saveImageToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.saveImageToolStripMenuItem.Text = "Save Image";
            this.saveImageToolStripMenuItem.Click += new System.EventHandler(this.saveImageToolStripMenuItem_Click);
            // 
            // saveTextToolStripMenuItem
            // 
            this.saveTextToolStripMenuItem.Name = "saveTextToolStripMenuItem";
            this.saveTextToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.saveTextToolStripMenuItem.Text = "Save Text";
            this.saveTextToolStripMenuItem.Click += new System.EventHandler(this.saveTextToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(58, 25);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // showcolorbox
            // 
            this.showcolorbox.BackColor = System.Drawing.Color.Black;
            this.showcolorbox.Location = new System.Drawing.Point(118, 21);
            this.showcolorbox.Name = "showcolorbox";
            this.showcolorbox.Size = new System.Drawing.Size(21, 21);
            this.showcolorbox.TabIndex = 1;
            this.showcolorbox.TabStop = false;
            this.showcolorbox.Click += new System.EventHandler(this.showcolorbox_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.DarkOrange;
            this.panel4.Controls.Add(this.rtxt_console);
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.btn_consolerun);
            this.panel4.Controls.Add(this.btn_console1clear);
            this.panel4.Controls.Add(this.tabControl1);
            this.panel4.Location = new System.Drawing.Point(682, 81);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(204, 392);
            this.panel4.TabIndex = 4;
            // 
            // rtxt_console
            // 
            this.rtxt_console.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rtxt_console.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.rtxt_console.Location = new System.Drawing.Point(3, 3);
            this.rtxt_console.Name = "rtxt_console";
            this.rtxt_console.Size = new System.Drawing.Size(198, 116);
            this.rtxt_console.TabIndex = 1;
            this.rtxt_console.Text = "";
            this.rtxt_console.TextChanged += new System.EventHandler(this.rtxt_console_TextChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button2.Location = new System.Drawing.Point(3, 154);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 30);
            this.button2.TabIndex = 5;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_consolerun
            // 
            this.btn_consolerun.BackColor = System.Drawing.Color.Black;
            this.btn_consolerun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consolerun.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_consolerun.Location = new System.Drawing.Point(3, 183);
            this.btn_consolerun.Name = "btn_consolerun";
            this.btn_consolerun.Size = new System.Drawing.Size(97, 28);
            this.btn_consolerun.TabIndex = 4;
            this.btn_consolerun.Text = "Run";
            this.btn_consolerun.UseVisualStyleBackColor = false;
            this.btn_consolerun.Click += new System.EventHandler(this.btn_consolerun_Click);
            // 
            // btn_console1clear
            // 
            this.btn_console1clear.BackColor = System.Drawing.Color.Black;
            this.btn_console1clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_console1clear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_console1clear.Location = new System.Drawing.Point(3, 125);
            this.btn_console1clear.Name = "btn_console1clear";
            this.btn_console1clear.Size = new System.Drawing.Size(97, 33);
            this.btn_console1clear.TabIndex = 3;
            this.btn_console1clear.Text = "Clear";
            this.btn_console1clear.UseVisualStyleBackColor = false;
            this.btn_console1clear.Click += new System.EventHandler(this.btn_console1clear_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(3, 217);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(188, 137);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage4.Controls.Add(this.rtxt_errors);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(180, 111);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Errors";
            // 
            // rtxt_errors
            // 
            this.rtxt_errors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rtxt_errors.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rtxt_errors.Location = new System.Drawing.Point(3, 3);
            this.rtxt_errors.Name = "rtxt_errors";
            this.rtxt_errors.ReadOnly = true;
            this.rtxt_errors.Size = new System.Drawing.Size(174, 118);
            this.rtxt_errors.TabIndex = 2;
            this.rtxt_errors.Text = "";
            this.rtxt_errors.TextChanged += new System.EventHandler(this.rtxt_errors_TextChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage3.Controls.Add(this.rtxt_history);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(180, 111);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "History";
            // 
            // rtxt_history
            // 
            this.rtxt_history.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rtxt_history.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rtxt_history.Location = new System.Drawing.Point(3, 3);
            this.rtxt_history.Name = "rtxt_history";
            this.rtxt_history.ReadOnly = true;
            this.rtxt_history.Size = new System.Drawing.Size(174, 105);
            this.rtxt_history.TabIndex = 1;
            this.rtxt_history.Text = "";
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.drawareapanel);
            this.panel5.Location = new System.Drawing.Point(42, 81);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(634, 392);
            this.panel5.TabIndex = 5;
            // 
            // drawareapanel
            // 
            this.drawareapanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.drawareapanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drawareapanel.Location = new System.Drawing.Point(0, 0);
            this.drawareapanel.Name = "drawareapanel";
            this.drawareapanel.Size = new System.Drawing.Size(634, 392);
            this.drawareapanel.TabIndex = 0;
            this.drawareapanel.TabStop = false;
            this.drawareapanel.Click += new System.EventHandler(this.drawareapanel_Click);
            this.drawareapanel.Paint += new System.Windows.Forms.PaintEventHandler(this.draw);
            this.drawareapanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.drawareapanel_MouseClick);
            this.drawareapanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drawareapanel_MouseDown);
            this.drawareapanel.MouseLeave += new System.EventHandler(this.drawareapanel_MouseLeave);
            this.drawareapanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.drawareapanel_MouseMove);
            this.drawareapanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.drawareapanel_MouseUp);
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.BackColor = System.Drawing.Color.Gray;
            this.btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Close.ForeColor = System.Drawing.Color.Black;
            this.btn_Close.Location = new System.Drawing.Point(840, 2);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(43, 25);
            this.btn_Close.TabIndex = 0;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(885, 485);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Graphical Application";
            this.Load += new System.EventHandler(this.Main_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_MouseUp);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showcolorbox)).EndInit();
            this.panel4.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.drawareapanel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_appname;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox showcolorbox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button btn_console1clear;
        private System.Windows.Forms.ToolStripMenuItem openImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveTextToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_consolerun;
        private System.Windows.Forms.RichTextBox rtxt_console;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RichTextBox rtxt_history;
        private System.Windows.Forms.Label lbl_canvasy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_canvasx;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_cursorx;
        private System.Windows.Forms.Label lbl_cursory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbl_StartPosX;
        private System.Windows.Forms.Label lbl_StartPosY;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox drawareapanel;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.RichTextBox rtxt_errors;
        private System.Windows.Forms.Button btn_Close;
    }
}

