﻿
using GamePieces;
using System;

namespace TestChess
{
    partial class Form1
    {   
        Board board = new Board();
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel18 = new System.Windows.Forms.Panel();
            this.panel19 = new System.Windows.Forms.Panel();
            this.panel20 = new System.Windows.Forms.Panel();
            this.panel21 = new System.Windows.Forms.Panel();
            this.panel22 = new System.Windows.Forms.Panel();
            this.panel23 = new System.Windows.Forms.Panel();
            this.panel24 = new System.Windows.Forms.Panel();
            this.panel25 = new System.Windows.Forms.Panel();
            this.panel26 = new System.Windows.Forms.Panel();
            this.panel27 = new System.Windows.Forms.Panel();
            this.panel28 = new System.Windows.Forms.Panel();
            this.panel29 = new System.Windows.Forms.Panel();
            this.panel30 = new System.Windows.Forms.Panel();
            this.panel31 = new System.Windows.Forms.Panel();
            this.panel32 = new System.Windows.Forms.Panel();
            this.panel33 = new System.Windows.Forms.Panel();
            this.panel34 = new System.Windows.Forms.Panel();
            this.panel35 = new System.Windows.Forms.Panel();
            this.panel36 = new System.Windows.Forms.Panel();
            this.panel37 = new System.Windows.Forms.Panel();
            this.panel38 = new System.Windows.Forms.Panel();
            this.panel39 = new System.Windows.Forms.Panel();
            this.panel40 = new System.Windows.Forms.Panel();
            this.panel41 = new System.Windows.Forms.Panel();
            this.panel42 = new System.Windows.Forms.Panel();
            this.panel43 = new System.Windows.Forms.Panel();
            this.panel44 = new System.Windows.Forms.Panel();
            this.panel45 = new System.Windows.Forms.Panel();
            this.panel46 = new System.Windows.Forms.Panel();
            this.panel47 = new System.Windows.Forms.Panel();
            this.panel48 = new System.Windows.Forms.Panel();
            this.panel49 = new System.Windows.Forms.Panel();
            this.panel50 = new System.Windows.Forms.Panel();
            this.panel51 = new System.Windows.Forms.Panel();
            this.panel52 = new System.Windows.Forms.Panel();
            this.panel53 = new System.Windows.Forms.Panel();
            this.panel54 = new System.Windows.Forms.Panel();
            this.panel55 = new System.Windows.Forms.Panel();
            this.panel56 = new System.Windows.Forms.Panel();
            this.panel57 = new System.Windows.Forms.Panel();
            this.panel58 = new System.Windows.Forms.Panel();
            this.panel59 = new System.Windows.Forms.Panel();
            this.panel60 = new System.Windows.Forms.Panel();
            this.panel61 = new System.Windows.Forms.Panel();
            this.panel62 = new System.Windows.Forms.Panel();
            this.panel63 = new System.Windows.Forms.Panel();
            this.panel64 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 7, 7);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 6, 7);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 5, 7);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 4, 7);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.panel6, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.panel7, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.panel8, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.panel9, 7, 6);
            this.tableLayoutPanel1.Controls.Add(this.panel10, 6, 6);
            this.tableLayoutPanel1.Controls.Add(this.panel11, 5, 6);
            this.tableLayoutPanel1.Controls.Add(this.panel12, 4, 6);
            this.tableLayoutPanel1.Controls.Add(this.panel13, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.panel14, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.panel15, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.panel16, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.panel17, 7, 5);
            this.tableLayoutPanel1.Controls.Add(this.panel18, 6, 5);
            this.tableLayoutPanel1.Controls.Add(this.panel19, 5, 5);
            this.tableLayoutPanel1.Controls.Add(this.panel20, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.panel21, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.panel22, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.panel23, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.panel24, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.panel25, 7, 4);
            this.tableLayoutPanel1.Controls.Add(this.panel26, 6, 4);
            this.tableLayoutPanel1.Controls.Add(this.panel27, 5, 4);
            this.tableLayoutPanel1.Controls.Add(this.panel28, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.panel29, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.panel30, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.panel31, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.panel32, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.panel33, 7, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel34, 6, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel35, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel36, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel37, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel38, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel39, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel40, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel41, 7, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel42, 6, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel43, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel44, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel45, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel46, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel47, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel48, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel49, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel50, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel51, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel52, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel53, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel54, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel55, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel56, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel57, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel58, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel59, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel60, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel61, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel62, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel63, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel64, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 5);
            this.tableLayoutPanel1.MinimumSize = new System.Drawing.Size(50, 50);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(600, 600);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(533, 533);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(75, 75);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TestChess.Properties.Resources.BlackRook;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(457, 533);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(75, 75);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(381, 533);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(75, 75);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(305, 533);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(75, 75);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(229, 533);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(75, 75);
            this.panel5.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(153, 533);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(75, 75);
            this.panel6.TabIndex = 5;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Location = new System.Drawing.Point(77, 533);
            this.panel7.Margin = new System.Windows.Forms.Padding(0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(75, 75);
            this.panel7.TabIndex = 6;
            // 
            // panel8
            // 
            this.panel8.Location = new System.Drawing.Point(1, 533);
            this.panel8.Margin = new System.Windows.Forms.Padding(0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(75, 75);
            this.panel8.TabIndex = 7;
            // 
            // panel9
            // 
            this.panel9.Location = new System.Drawing.Point(533, 457);
            this.panel9.Margin = new System.Windows.Forms.Padding(0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(75, 75);
            this.panel9.TabIndex = 8;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.White;
            this.panel10.Location = new System.Drawing.Point(457, 457);
            this.panel10.Margin = new System.Windows.Forms.Padding(0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(75, 75);
            this.panel10.TabIndex = 9;
            // 
            // panel11
            // 
            this.panel11.Location = new System.Drawing.Point(381, 457);
            this.panel11.Margin = new System.Windows.Forms.Padding(0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(75, 75);
            this.panel11.TabIndex = 10;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.White;
            this.panel12.Location = new System.Drawing.Point(305, 457);
            this.panel12.Margin = new System.Windows.Forms.Padding(0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(75, 75);
            this.panel12.TabIndex = 11;
            // 
            // panel13
            // 
            this.panel13.Location = new System.Drawing.Point(229, 457);
            this.panel13.Margin = new System.Windows.Forms.Padding(0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(75, 75);
            this.panel13.TabIndex = 12;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.White;
            this.panel14.Location = new System.Drawing.Point(153, 457);
            this.panel14.Margin = new System.Windows.Forms.Padding(0);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(75, 75);
            this.panel14.TabIndex = 13;
            // 
            // panel15
            // 
            this.panel15.Location = new System.Drawing.Point(77, 457);
            this.panel15.Margin = new System.Windows.Forms.Padding(0);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(75, 75);
            this.panel15.TabIndex = 14;
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.White;
            this.panel16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel16.Location = new System.Drawing.Point(1, 457);
            this.panel16.Margin = new System.Windows.Forms.Padding(0);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(75, 75);
            this.panel16.TabIndex = 15;
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.White;
            this.panel17.Controls.Add(this.pictureBox3);
            this.panel17.Location = new System.Drawing.Point(533, 381);
            this.panel17.Margin = new System.Windows.Forms.Padding(0);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(75, 75);
            this.panel17.TabIndex = 16;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(3, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(68, 68);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // panel18
            // 
            this.panel18.Location = new System.Drawing.Point(457, 381);
            this.panel18.Margin = new System.Windows.Forms.Padding(0);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(75, 75);
            this.panel18.TabIndex = 17;
            // 
            // panel19
            // 
            this.panel19.BackColor = System.Drawing.Color.White;
            this.panel19.Location = new System.Drawing.Point(381, 381);
            this.panel19.Margin = new System.Windows.Forms.Padding(0);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(75, 75);
            this.panel19.TabIndex = 18;
            // 
            // panel20
            // 
            this.panel20.Location = new System.Drawing.Point(305, 381);
            this.panel20.Margin = new System.Windows.Forms.Padding(0);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(75, 75);
            this.panel20.TabIndex = 19;
            // 
            // panel21
            // 
            this.panel21.BackColor = System.Drawing.Color.White;
            this.panel21.Location = new System.Drawing.Point(229, 381);
            this.panel21.Margin = new System.Windows.Forms.Padding(0);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(75, 75);
            this.panel21.TabIndex = 20;
            // 
            // panel22
            // 
            this.panel22.Location = new System.Drawing.Point(153, 381);
            this.panel22.Margin = new System.Windows.Forms.Padding(0);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(75, 75);
            this.panel22.TabIndex = 21;
            // 
            // panel23
            // 
            this.panel23.BackColor = System.Drawing.Color.White;
            this.panel23.Location = new System.Drawing.Point(77, 381);
            this.panel23.Margin = new System.Windows.Forms.Padding(0);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(75, 75);
            this.panel23.TabIndex = 22;
            // 
            // panel24
            // 
            this.panel24.Location = new System.Drawing.Point(1, 381);
            this.panel24.Margin = new System.Windows.Forms.Padding(0);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(75, 75);
            this.panel24.TabIndex = 23;
            // 
            // panel25
            // 
            this.panel25.Location = new System.Drawing.Point(533, 305);
            this.panel25.Margin = new System.Windows.Forms.Padding(0);
            this.panel25.Name = "panel25";
            this.panel25.Size = new System.Drawing.Size(75, 75);
            this.panel25.TabIndex = 24;
            // 
            // panel26
            // 
            this.panel26.BackColor = System.Drawing.Color.White;
            this.panel26.Location = new System.Drawing.Point(457, 305);
            this.panel26.Margin = new System.Windows.Forms.Padding(0);
            this.panel26.Name = "panel26";
            this.panel26.Size = new System.Drawing.Size(75, 75);
            this.panel26.TabIndex = 25;
            // 
            // panel27
            // 
            this.panel27.Location = new System.Drawing.Point(381, 305);
            this.panel27.Margin = new System.Windows.Forms.Padding(0);
            this.panel27.Name = "panel27";
            this.panel27.Size = new System.Drawing.Size(75, 75);
            this.panel27.TabIndex = 26;
            // 
            // panel28
            // 
            this.panel28.BackColor = System.Drawing.Color.White;
            this.panel28.Location = new System.Drawing.Point(305, 305);
            this.panel28.Margin = new System.Windows.Forms.Padding(0);
            this.panel28.Name = "panel28";
            this.panel28.Size = new System.Drawing.Size(75, 75);
            this.panel28.TabIndex = 27;
            // 
            // panel29
            // 
            this.panel29.Location = new System.Drawing.Point(229, 305);
            this.panel29.Margin = new System.Windows.Forms.Padding(0);
            this.panel29.Name = "panel29";
            this.panel29.Size = new System.Drawing.Size(75, 75);
            this.panel29.TabIndex = 28;
            // 
            // panel30
            // 
            this.panel30.BackColor = System.Drawing.Color.White;
            this.panel30.Location = new System.Drawing.Point(153, 305);
            this.panel30.Margin = new System.Windows.Forms.Padding(0);
            this.panel30.Name = "panel30";
            this.panel30.Size = new System.Drawing.Size(75, 75);
            this.panel30.TabIndex = 29;
            // 
            // panel31
            // 
            this.panel31.Location = new System.Drawing.Point(77, 305);
            this.panel31.Margin = new System.Windows.Forms.Padding(0);
            this.panel31.Name = "panel31";
            this.panel31.Size = new System.Drawing.Size(75, 75);
            this.panel31.TabIndex = 30;
            // 
            // panel32
            // 
            this.panel32.BackColor = System.Drawing.Color.White;
            this.panel32.Location = new System.Drawing.Point(1, 305);
            this.panel32.Margin = new System.Windows.Forms.Padding(0);
            this.panel32.Name = "panel32";
            this.panel32.Size = new System.Drawing.Size(75, 75);
            this.panel32.TabIndex = 31;
            // 
            // panel33
            // 
            this.panel33.BackColor = System.Drawing.Color.White;
            this.panel33.Location = new System.Drawing.Point(533, 229);
            this.panel33.Margin = new System.Windows.Forms.Padding(0);
            this.panel33.Name = "panel33";
            this.panel33.Size = new System.Drawing.Size(75, 75);
            this.panel33.TabIndex = 32;
            // 
            // panel34
            // 
            this.panel34.Location = new System.Drawing.Point(457, 229);
            this.panel34.Margin = new System.Windows.Forms.Padding(0);
            this.panel34.Name = "panel34";
            this.panel34.Size = new System.Drawing.Size(75, 75);
            this.panel34.TabIndex = 33;
            // 
            // panel35
            // 
            this.panel35.BackColor = System.Drawing.Color.White;
            this.panel35.Location = new System.Drawing.Point(381, 229);
            this.panel35.Margin = new System.Windows.Forms.Padding(0);
            this.panel35.Name = "panel35";
            this.panel35.Size = new System.Drawing.Size(75, 75);
            this.panel35.TabIndex = 34;
            // 
            // panel36
            // 
            this.panel36.Location = new System.Drawing.Point(305, 229);
            this.panel36.Margin = new System.Windows.Forms.Padding(0);
            this.panel36.Name = "panel36";
            this.panel36.Size = new System.Drawing.Size(75, 75);
            this.panel36.TabIndex = 35;
            // 
            // panel37
            // 
            this.panel37.BackColor = System.Drawing.Color.White;
            this.panel37.Location = new System.Drawing.Point(229, 229);
            this.panel37.Margin = new System.Windows.Forms.Padding(0);
            this.panel37.Name = "panel37";
            this.panel37.Size = new System.Drawing.Size(75, 75);
            this.panel37.TabIndex = 36;
            // 
            // panel38
            // 
            this.panel38.Location = new System.Drawing.Point(153, 229);
            this.panel38.Margin = new System.Windows.Forms.Padding(0);
            this.panel38.Name = "panel38";
            this.panel38.Size = new System.Drawing.Size(75, 75);
            this.panel38.TabIndex = 37;
            // 
            // panel39
            // 
            this.panel39.BackColor = System.Drawing.Color.White;
            this.panel39.Location = new System.Drawing.Point(77, 229);
            this.panel39.Margin = new System.Windows.Forms.Padding(0);
            this.panel39.Name = "panel39";
            this.panel39.Size = new System.Drawing.Size(75, 75);
            this.panel39.TabIndex = 38;
            // 
            // panel40
            // 
            this.panel40.Location = new System.Drawing.Point(1, 229);
            this.panel40.Margin = new System.Windows.Forms.Padding(0);
            this.panel40.Name = "panel40";
            this.panel40.Size = new System.Drawing.Size(75, 75);
            this.panel40.TabIndex = 39;
            // 
            // panel41
            // 
            this.panel41.Location = new System.Drawing.Point(533, 153);
            this.panel41.Margin = new System.Windows.Forms.Padding(0);
            this.panel41.Name = "panel41";
            this.panel41.Size = new System.Drawing.Size(75, 75);
            this.panel41.TabIndex = 40;
            // 
            // panel42
            // 
            this.panel42.BackColor = System.Drawing.Color.White;
            this.panel42.Location = new System.Drawing.Point(457, 153);
            this.panel42.Margin = new System.Windows.Forms.Padding(0);
            this.panel42.Name = "panel42";
            this.panel42.Size = new System.Drawing.Size(75, 75);
            this.panel42.TabIndex = 41;
            // 
            // panel43
            // 
            this.panel43.Location = new System.Drawing.Point(381, 153);
            this.panel43.Margin = new System.Windows.Forms.Padding(0);
            this.panel43.Name = "panel43";
            this.panel43.Size = new System.Drawing.Size(75, 75);
            this.panel43.TabIndex = 42;
            // 
            // panel44
            // 
            this.panel44.BackColor = System.Drawing.Color.White;
            this.panel44.Location = new System.Drawing.Point(305, 153);
            this.panel44.Margin = new System.Windows.Forms.Padding(0);
            this.panel44.Name = "panel44";
            this.panel44.Size = new System.Drawing.Size(75, 75);
            this.panel44.TabIndex = 43;
            // 
            // panel45
            // 
            this.panel45.Location = new System.Drawing.Point(229, 153);
            this.panel45.Margin = new System.Windows.Forms.Padding(0);
            this.panel45.Name = "panel45";
            this.panel45.Size = new System.Drawing.Size(75, 75);
            this.panel45.TabIndex = 44;
            // 
            // panel46
            // 
            this.panel46.BackColor = System.Drawing.Color.White;
            this.panel46.Location = new System.Drawing.Point(153, 153);
            this.panel46.Margin = new System.Windows.Forms.Padding(0);
            this.panel46.Name = "panel46";
            this.panel46.Size = new System.Drawing.Size(75, 75);
            this.panel46.TabIndex = 45;
            // 
            // panel47
            // 
            this.panel47.Location = new System.Drawing.Point(77, 153);
            this.panel47.Margin = new System.Windows.Forms.Padding(0);
            this.panel47.Name = "panel47";
            this.panel47.Size = new System.Drawing.Size(75, 75);
            this.panel47.TabIndex = 46;
            // 
            // panel48
            // 
            this.panel48.BackColor = System.Drawing.Color.White;
            this.panel48.Location = new System.Drawing.Point(1, 153);
            this.panel48.Margin = new System.Windows.Forms.Padding(0);
            this.panel48.Name = "panel48";
            this.panel48.Size = new System.Drawing.Size(75, 75);
            this.panel48.TabIndex = 47;
            // 
            // panel49
            // 
            this.panel49.BackColor = System.Drawing.Color.White;
            this.panel49.Location = new System.Drawing.Point(533, 77);
            this.panel49.Margin = new System.Windows.Forms.Padding(0);
            this.panel49.Name = "panel49";
            this.panel49.Size = new System.Drawing.Size(75, 75);
            this.panel49.TabIndex = 48;
            // 
            // panel50
            // 
            this.panel50.Location = new System.Drawing.Point(457, 77);
            this.panel50.Margin = new System.Windows.Forms.Padding(0);
            this.panel50.Name = "panel50";
            this.panel50.Size = new System.Drawing.Size(75, 75);
            this.panel50.TabIndex = 49;
            // 
            // panel51
            // 
            this.panel51.BackColor = System.Drawing.Color.White;
            this.panel51.Location = new System.Drawing.Point(381, 77);
            this.panel51.Margin = new System.Windows.Forms.Padding(0);
            this.panel51.Name = "panel51";
            this.panel51.Size = new System.Drawing.Size(75, 75);
            this.panel51.TabIndex = 50;
            // 
            // panel52
            // 
            this.panel52.Location = new System.Drawing.Point(305, 77);
            this.panel52.Margin = new System.Windows.Forms.Padding(0);
            this.panel52.Name = "panel52";
            this.panel52.Size = new System.Drawing.Size(75, 75);
            this.panel52.TabIndex = 51;
            // 
            // panel53
            // 
            this.panel53.BackColor = System.Drawing.Color.White;
            this.panel53.Location = new System.Drawing.Point(229, 77);
            this.panel53.Margin = new System.Windows.Forms.Padding(0);
            this.panel53.Name = "panel53";
            this.panel53.Size = new System.Drawing.Size(75, 75);
            this.panel53.TabIndex = 52;
            // 
            // panel54
            // 
            this.panel54.Location = new System.Drawing.Point(153, 77);
            this.panel54.Margin = new System.Windows.Forms.Padding(0);
            this.panel54.Name = "panel54";
            this.panel54.Size = new System.Drawing.Size(75, 75);
            this.panel54.TabIndex = 53;
            // 
            // panel55
            // 
            this.panel55.BackColor = System.Drawing.Color.White;
            this.panel55.Location = new System.Drawing.Point(77, 77);
            this.panel55.Margin = new System.Windows.Forms.Padding(0);
            this.panel55.Name = "panel55";
            this.panel55.Size = new System.Drawing.Size(75, 75);
            this.panel55.TabIndex = 54;
            // 
            // panel56
            // 
            this.panel56.Location = new System.Drawing.Point(1, 77);
            this.panel56.Margin = new System.Windows.Forms.Padding(0);
            this.panel56.Name = "panel56";
            this.panel56.Size = new System.Drawing.Size(75, 75);
            this.panel56.TabIndex = 55;
            // 
            // panel57
            // 
            this.panel57.Location = new System.Drawing.Point(533, 1);
            this.panel57.Margin = new System.Windows.Forms.Padding(0);
            this.panel57.Name = "panel57";
            this.panel57.Size = new System.Drawing.Size(75, 75);
            this.panel57.TabIndex = 56;
            // 
            // panel58
            // 
            this.panel58.BackColor = System.Drawing.Color.White;
            this.panel58.Location = new System.Drawing.Point(457, 1);
            this.panel58.Margin = new System.Windows.Forms.Padding(0);
            this.panel58.Name = "panel58";
            this.panel58.Size = new System.Drawing.Size(75, 75);
            this.panel58.TabIndex = 57;
            // 
            // panel59
            // 
            this.panel59.Location = new System.Drawing.Point(381, 1);
            this.panel59.Margin = new System.Windows.Forms.Padding(0);
            this.panel59.Name = "panel59";
            this.panel59.Size = new System.Drawing.Size(75, 75);
            this.panel59.TabIndex = 58;
            // 
            // panel60
            // 
            this.panel60.BackColor = System.Drawing.Color.White;
            this.panel60.Location = new System.Drawing.Point(305, 1);
            this.panel60.Margin = new System.Windows.Forms.Padding(0);
            this.panel60.Name = "panel60";
            this.panel60.Size = new System.Drawing.Size(75, 75);
            this.panel60.TabIndex = 59;
            // 
            // panel61
            // 
            this.panel61.Location = new System.Drawing.Point(229, 1);
            this.panel61.Margin = new System.Windows.Forms.Padding(0);
            this.panel61.Name = "panel61";
            this.panel61.Size = new System.Drawing.Size(75, 75);
            this.panel61.TabIndex = 60;
            // 
            // panel62
            // 
            this.panel62.BackColor = System.Drawing.Color.White;
            this.panel62.Location = new System.Drawing.Point(153, 1);
            this.panel62.Margin = new System.Windows.Forms.Padding(0);
            this.panel62.Name = "panel62";
            this.panel62.Size = new System.Drawing.Size(75, 75);
            this.panel62.TabIndex = 61;
            // 
            // panel63
            // 
            this.panel63.Location = new System.Drawing.Point(77, 1);
            this.panel63.Margin = new System.Windows.Forms.Padding(0);
            this.panel63.Name = "panel63";
            this.panel63.Size = new System.Drawing.Size(75, 75);
            this.panel63.TabIndex = 62;
            // 
            // panel64
            // 
            this.panel64.BackColor = System.Drawing.Color.White;
            this.panel64.Location = new System.Drawing.Point(1, 1);
            this.panel64.Margin = new System.Windows.Forms.Padding(0);
            this.panel64.Name = "panel64";
            this.panel64.Size = new System.Drawing.Size(75, 75);
            this.panel64.TabIndex = 63;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TestChess.Properties.Resources.BlackPawn;
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(68, 68);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 609);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Chess";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel17.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        public System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.Panel panel23;
        private System.Windows.Forms.Panel panel24;
        private System.Windows.Forms.Panel panel25;
        private System.Windows.Forms.Panel panel26;
        private System.Windows.Forms.Panel panel27;
        private System.Windows.Forms.Panel panel28;
        private System.Windows.Forms.Panel panel29;
        private System.Windows.Forms.Panel panel30;
        private System.Windows.Forms.Panel panel31;
        private System.Windows.Forms.Panel panel32;
        private System.Windows.Forms.Panel panel33;
        private System.Windows.Forms.Panel panel34;
        private System.Windows.Forms.Panel panel35;
        private System.Windows.Forms.Panel panel36;
        private System.Windows.Forms.Panel panel37;
        private System.Windows.Forms.Panel panel38;
        private System.Windows.Forms.Panel panel39;
        private System.Windows.Forms.Panel panel40;
        private System.Windows.Forms.Panel panel41;
        private System.Windows.Forms.Panel panel42;
        private System.Windows.Forms.Panel panel43;
        private System.Windows.Forms.Panel panel44;
        private System.Windows.Forms.Panel panel45;
        private System.Windows.Forms.Panel panel46;
        private System.Windows.Forms.Panel panel47;
        private System.Windows.Forms.Panel panel48;
        private System.Windows.Forms.Panel panel49;
        private System.Windows.Forms.Panel panel50;
        private System.Windows.Forms.Panel panel51;
        private System.Windows.Forms.Panel panel52;
        private System.Windows.Forms.Panel panel53;
        private System.Windows.Forms.Panel panel54;
        private System.Windows.Forms.Panel panel55;
        private System.Windows.Forms.Panel panel56;
        private System.Windows.Forms.Panel panel57;
        private System.Windows.Forms.Panel panel58;
        private System.Windows.Forms.Panel panel59;
        private System.Windows.Forms.Panel panel60;
        private System.Windows.Forms.Panel panel61;
        private System.Windows.Forms.Panel panel62;
        private System.Windows.Forms.Panel panel63;
        private System.Windows.Forms.Panel panel64;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}
