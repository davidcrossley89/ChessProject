
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            this.pictureBox20 = new System.Windows.Forms.PictureBox();
            this.pictureBox21 = new System.Windows.Forms.PictureBox();
            this.pictureBox22 = new System.Windows.Forms.PictureBox();
            this.pictureBox23 = new System.Windows.Forms.PictureBox();
            this.pictureBox24 = new System.Windows.Forms.PictureBox();
            this.pictureBox25 = new System.Windows.Forms.PictureBox();
            this.pictureBox26 = new System.Windows.Forms.PictureBox();
            this.pictureBox27 = new System.Windows.Forms.PictureBox();
            this.pictureBox28 = new System.Windows.Forms.PictureBox();
            this.pictureBox29 = new System.Windows.Forms.PictureBox();
            this.pictureBox30 = new System.Windows.Forms.PictureBox();
            this.pictureBox31 = new System.Windows.Forms.PictureBox();
            this.pictureBox32 = new System.Windows.Forms.PictureBox();
            this.pictureBox33 = new System.Windows.Forms.PictureBox();
            this.pictureBox34 = new System.Windows.Forms.PictureBox();
            this.pictureBox35 = new System.Windows.Forms.PictureBox();
            this.pictureBox36 = new System.Windows.Forms.PictureBox();
            this.pictureBox37 = new System.Windows.Forms.PictureBox();
            this.pictureBox38 = new System.Windows.Forms.PictureBox();
            this.pictureBox39 = new System.Windows.Forms.PictureBox();
            this.pictureBox40 = new System.Windows.Forms.PictureBox();
            this.pictureBox41 = new System.Windows.Forms.PictureBox();
            this.pictureBox42 = new System.Windows.Forms.PictureBox();
            this.pictureBox43 = new System.Windows.Forms.PictureBox();
            this.pictureBox44 = new System.Windows.Forms.PictureBox();
            this.pictureBox45 = new System.Windows.Forms.PictureBox();
            this.pictureBox46 = new System.Windows.Forms.PictureBox();
            this.pictureBox47 = new System.Windows.Forms.PictureBox();
            this.pictureBox48 = new System.Windows.Forms.PictureBox();
            this.pictureBox49 = new System.Windows.Forms.PictureBox();
            this.pictureBox50 = new System.Windows.Forms.PictureBox();
            this.pictureBox51 = new System.Windows.Forms.PictureBox();
            this.pictureBox52 = new System.Windows.Forms.PictureBox();
            this.pictureBox53 = new System.Windows.Forms.PictureBox();
            this.pictureBox54 = new System.Windows.Forms.PictureBox();
            this.pictureBox55 = new System.Windows.Forms.PictureBox();
            this.pictureBox56 = new System.Windows.Forms.PictureBox();
            this.pictureBox57 = new System.Windows.Forms.PictureBox();
            this.pictureBox58 = new System.Windows.Forms.PictureBox();
            this.pictureBox59 = new System.Windows.Forms.PictureBox();
            this.pictureBox60 = new System.Windows.Forms.PictureBox();
            this.pictureBox61 = new System.Windows.Forms.PictureBox();
            this.pictureBox62 = new System.Windows.Forms.PictureBox();
            this.pictureBox63 = new System.Windows.Forms.PictureBox();
            this.pictureBox64 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox29)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox34)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox35)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox36)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox37)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox38)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox39)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox40)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox41)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox42)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox43)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox44)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox45)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox46)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox47)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox48)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox49)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox50)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox51)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox52)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox53)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox54)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox55)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox56)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox57)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox58)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox59)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox60)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox61)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox62)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox63)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox64)).BeginInit();
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 83F));
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
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(457, 533);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(75, 75);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Location = new System.Drawing.Point(381, 533);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(75, 75);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pictureBox4);
            this.panel4.Location = new System.Drawing.Point(305, 533);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(75, 75);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.pictureBox5);
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(229, 533);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(75, 75);
            this.panel5.TabIndex = 4;
            // 
            // panel6
            // 

            this.panel6.Controls.Add(this.pictureBox6);
            this.panel6.Location = new System.Drawing.Point(153, 533);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(75, 75);
            this.panel6.TabIndex = 5;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.pictureBox7);
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Location = new System.Drawing.Point(77, 533);
            this.panel7.Margin = new System.Windows.Forms.Padding(0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(75, 75);
            this.panel7.TabIndex = 6;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.pictureBox8);
            this.panel8.Location = new System.Drawing.Point(1, 533);
            this.panel8.Margin = new System.Windows.Forms.Padding(0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(75, 75);
            this.panel8.TabIndex = 7;
            // 
            // panel9
            // 

            this.panel9.Controls.Add(this.pictureBox9);
            this.panel9.Location = new System.Drawing.Point(533, 457);
            this.panel9.Margin = new System.Windows.Forms.Padding(0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(75, 75);
            this.panel9.TabIndex = 8;
            // 
            // panel10
            // 

            this.panel10.Controls.Add(this.pictureBox10);
            this.panel10.BackColor = System.Drawing.Color.White;
            this.panel10.Location = new System.Drawing.Point(457, 457);
            this.panel10.Margin = new System.Windows.Forms.Padding(0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(75, 75);
            this.panel10.TabIndex = 9;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.pictureBox11);
            this.panel11.Location = new System.Drawing.Point(381, 457);
            this.panel11.Margin = new System.Windows.Forms.Padding(0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(75, 75);
            this.panel11.TabIndex = 10;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.pictureBox12);
            this.panel12.BackColor = System.Drawing.Color.White;
            this.panel12.Location = new System.Drawing.Point(305, 457);
            this.panel12.Margin = new System.Windows.Forms.Padding(0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(75, 75);
            this.panel12.TabIndex = 11;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.pictureBox13);
            this.panel13.Location = new System.Drawing.Point(229, 457);
            this.panel13.Margin = new System.Windows.Forms.Padding(0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(75, 75);
            this.panel13.TabIndex = 12;
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.pictureBox14);
            this.panel14.BackColor = System.Drawing.Color.White;
            this.panel14.Location = new System.Drawing.Point(153, 457);
            this.panel14.Margin = new System.Windows.Forms.Padding(0);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(75, 75);
            this.panel14.TabIndex = 13;
            // 
            // panel15
            //
            this.panel15.Controls.Add(this.pictureBox15);
            this.panel15.Location = new System.Drawing.Point(77, 457);
            this.panel15.Margin = new System.Windows.Forms.Padding(0);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(75, 75);
            this.panel15.TabIndex = 14;
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.pictureBox16);
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

            this.panel17.Controls.Add(this.pictureBox17);
            this.panel17.Location = new System.Drawing.Point(533, 381);
            this.panel17.Margin = new System.Windows.Forms.Padding(0);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(75, 75);
            this.panel17.TabIndex = 16;
            // 
            // panel18
            // 
            this.panel18.Controls.Add(this.pictureBox18);
            this.panel18.Location = new System.Drawing.Point(457, 381);
            this.panel18.Margin = new System.Windows.Forms.Padding(0);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(75, 75);
            this.panel18.TabIndex = 17;
            // 
            // panel19
            // 
            this.panel19.Controls.Add(this.pictureBox19);
            this.panel19.BackColor = System.Drawing.Color.White;
            this.panel19.Location = new System.Drawing.Point(381, 381);
            this.panel19.Margin = new System.Windows.Forms.Padding(0);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(75, 75);
            this.panel19.TabIndex = 18;
            // 
            // panel20
            // 
            this.panel20.Controls.Add(this.pictureBox20);
            this.panel20.Location = new System.Drawing.Point(305, 381);
            this.panel20.Margin = new System.Windows.Forms.Padding(0);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(75, 75);
            this.panel20.TabIndex = 19;
            // 
            // panel21
            // 
            this.panel21.Controls.Add(this.pictureBox21);
            this.panel21.BackColor = System.Drawing.Color.White;
            this.panel21.Location = new System.Drawing.Point(229, 381);
            this.panel21.Margin = new System.Windows.Forms.Padding(0);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(75, 75);
            this.panel21.TabIndex = 20;
            // 
            // panel22
            // 
            this.panel22.Controls.Add(this.pictureBox22);
            this.panel22.Location = new System.Drawing.Point(153, 381);
            this.panel22.Margin = new System.Windows.Forms.Padding(0);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(75, 75);
            this.panel22.TabIndex = 21;
            // 
            // panel23
            // 
            this.panel23.Controls.Add(this.pictureBox23);
            this.panel23.BackColor = System.Drawing.Color.White;
            this.panel23.Location = new System.Drawing.Point(77, 381);
            this.panel23.Margin = new System.Windows.Forms.Padding(0);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(75, 75);
            this.panel23.TabIndex = 22;
            // 
            // panel24
            // 
            this.panel24.Controls.Add(this.pictureBox24);
            this.panel24.Location = new System.Drawing.Point(1, 381);
            this.panel24.Margin = new System.Windows.Forms.Padding(0);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(75, 75);
            this.panel24.TabIndex = 23;
            // 
            // panel25
            // 
            this.panel25.Controls.Add(this.pictureBox25);
            this.panel25.Location = new System.Drawing.Point(533, 305);
            this.panel25.Margin = new System.Windows.Forms.Padding(0);
            this.panel25.Name = "panel25";
            this.panel25.Size = new System.Drawing.Size(75, 75);
            this.panel25.TabIndex = 24;
            // 
            // panel26
            // 
            this.panel26.Controls.Add(this.pictureBox26);
            this.panel26.BackColor = System.Drawing.Color.White;
            this.panel26.Location = new System.Drawing.Point(457, 305);
            this.panel26.Margin = new System.Windows.Forms.Padding(0);
            this.panel26.Name = "panel26";
            this.panel26.Size = new System.Drawing.Size(75, 75);
            this.panel26.TabIndex = 25;
            // 
            // panel27
            // 
            this.panel27.Controls.Add(this.pictureBox27);
            this.panel27.Location = new System.Drawing.Point(381, 305);
            this.panel27.Margin = new System.Windows.Forms.Padding(0);
            this.panel27.Name = "panel27";
            this.panel27.Size = new System.Drawing.Size(75, 75);
            this.panel27.TabIndex = 26;
            // 
            // panel28
            // 
            this.panel28.Controls.Add(this.pictureBox28);
            this.panel28.BackColor = System.Drawing.Color.White;
            this.panel28.Location = new System.Drawing.Point(305, 305);
            this.panel28.Margin = new System.Windows.Forms.Padding(0);
            this.panel28.Name = "panel28";
            this.panel28.Size = new System.Drawing.Size(75, 75);
            this.panel28.TabIndex = 27;
            // 
            // panel29
            // 
            this.panel29.Controls.Add(this.pictureBox29);
            this.panel29.Location = new System.Drawing.Point(229, 305);
            this.panel29.Margin = new System.Windows.Forms.Padding(0);
            this.panel29.Name = "panel29";
            this.panel29.Size = new System.Drawing.Size(75, 75);
            this.panel29.TabIndex = 28;
            // 
            // panel30
            // 
            this.panel30.Controls.Add(this.pictureBox30);
            this.panel30.BackColor = System.Drawing.Color.White;
            this.panel30.Location = new System.Drawing.Point(153, 305);
            this.panel30.Margin = new System.Windows.Forms.Padding(0);
            this.panel30.Name = "panel30";
            this.panel30.Size = new System.Drawing.Size(75, 75);
            this.panel30.TabIndex = 29;
            // 
            // panel31
            // 
            this.panel31.Controls.Add(this.pictureBox31);
            this.panel31.Location = new System.Drawing.Point(77, 305);
            this.panel31.Margin = new System.Windows.Forms.Padding(0);
            this.panel31.Name = "panel31";
            this.panel31.Size = new System.Drawing.Size(75, 75);
            this.panel31.TabIndex = 30;
            // 
            // panel32
            // 
            this.panel32.Controls.Add(this.pictureBox32);
            this.panel32.BackColor = System.Drawing.Color.White;
            this.panel32.Location = new System.Drawing.Point(1, 305);
            this.panel32.Margin = new System.Windows.Forms.Padding(0);
            this.panel32.Name = "panel32";
            this.panel32.Size = new System.Drawing.Size(75, 75);
            this.panel32.TabIndex = 31;
            // 
            // panel33
            // 
            this.panel33.Controls.Add(this.pictureBox33);
            this.panel33.BackColor = System.Drawing.Color.White;
            this.panel33.Location = new System.Drawing.Point(533, 229);
            this.panel33.Margin = new System.Windows.Forms.Padding(0);
            this.panel33.Name = "panel33";
            this.panel33.Size = new System.Drawing.Size(75, 75);
            this.panel33.TabIndex = 32;
            // 
            // panel34
            // 
            this.panel34.Controls.Add(this.pictureBox34);
            this.panel34.Location = new System.Drawing.Point(457, 229);
            this.panel34.Margin = new System.Windows.Forms.Padding(0);
            this.panel34.Name = "panel34";
            this.panel34.Size = new System.Drawing.Size(75, 75);
            this.panel34.TabIndex = 33;
            // 
            // panel35
            // 
            this.panel35.Controls.Add(this.pictureBox35);
            this.panel35.BackColor = System.Drawing.Color.White;
            this.panel35.Location = new System.Drawing.Point(381, 229);
            this.panel35.Margin = new System.Windows.Forms.Padding(0);
            this.panel35.Name = "panel35";
            this.panel35.Size = new System.Drawing.Size(75, 75);
            this.panel35.TabIndex = 34;
            // 
            // panel36
            // 
            this.panel36.Controls.Add(this.pictureBox36);
            this.panel36.Location = new System.Drawing.Point(305, 229);
            this.panel36.Margin = new System.Windows.Forms.Padding(0);
            this.panel36.Name = "panel36";
            this.panel36.Size = new System.Drawing.Size(75, 75);
            this.panel36.TabIndex = 35;
            // 
            // panel37
            // 
            this.panel37.Controls.Add(this.pictureBox37);
            this.panel37.BackColor = System.Drawing.Color.White;
            this.panel37.Location = new System.Drawing.Point(229, 229);
            this.panel37.Margin = new System.Windows.Forms.Padding(0);
            this.panel37.Name = "panel37";
            this.panel37.Size = new System.Drawing.Size(75, 75);
            this.panel37.TabIndex = 36;
            // 
            // panel38
            // 
            this.panel38.Controls.Add(this.pictureBox38);
            this.panel38.Location = new System.Drawing.Point(153, 229);
            this.panel38.Margin = new System.Windows.Forms.Padding(0);
            this.panel38.Name = "panel38";
            this.panel38.Size = new System.Drawing.Size(75, 75);
            this.panel38.TabIndex = 37;
            // 
            // panel39
            // 
            this.panel39.Controls.Add(this.pictureBox39);
            this.panel39.BackColor = System.Drawing.Color.White;
            this.panel39.Location = new System.Drawing.Point(77, 229);
            this.panel39.Margin = new System.Windows.Forms.Padding(0);
            this.panel39.Name = "panel39";
            this.panel39.Size = new System.Drawing.Size(75, 75);
            this.panel39.TabIndex = 38;
            // 
            // panel40
            // 
            this.panel40.Controls.Add(this.pictureBox40);
            this.panel40.Location = new System.Drawing.Point(1, 229);
            this.panel40.Margin = new System.Windows.Forms.Padding(0);
            this.panel40.Name = "panel40";
            this.panel40.Size = new System.Drawing.Size(75, 75);
            this.panel40.TabIndex = 39;
            // 
            // panel41
            // 
            this.panel41.Controls.Add(this.pictureBox41);
            this.panel41.Location = new System.Drawing.Point(533, 153);
            this.panel41.Margin = new System.Windows.Forms.Padding(0);
            this.panel41.Name = "panel41";
            this.panel41.Size = new System.Drawing.Size(75, 75);
            this.panel41.TabIndex = 40;
            // 
            // panel42
            // 
            this.panel42.Controls.Add(this.pictureBox42);
            this.panel42.BackColor = System.Drawing.Color.White;
            this.panel42.Location = new System.Drawing.Point(457, 153);
            this.panel42.Margin = new System.Windows.Forms.Padding(0);
            this.panel42.Name = "panel42";
            this.panel42.Size = new System.Drawing.Size(75, 75);
            this.panel42.TabIndex = 41;
            // 
            // panel43
            // 
            this.panel43.Controls.Add(this.pictureBox43);
            this.panel43.Location = new System.Drawing.Point(381, 153);
            this.panel43.Margin = new System.Windows.Forms.Padding(0);
            this.panel43.Name = "panel43";
            this.panel43.Size = new System.Drawing.Size(75, 75);
            this.panel43.TabIndex = 42;
            // 
            // panel44
            // 
            this.panel44.Controls.Add(this.pictureBox44);
            this.panel44.BackColor = System.Drawing.Color.White;
            this.panel44.Location = new System.Drawing.Point(305, 153);
            this.panel44.Margin = new System.Windows.Forms.Padding(0);
            this.panel44.Name = "panel44";
            this.panel44.Size = new System.Drawing.Size(75, 75);
            this.panel44.TabIndex = 43;
            // 
            // panel45
            // 
            this.panel45.Controls.Add(this.pictureBox45);
            this.panel45.Location = new System.Drawing.Point(229, 153);
            this.panel45.Margin = new System.Windows.Forms.Padding(0);
            this.panel45.Name = "panel45";
            this.panel45.Size = new System.Drawing.Size(75, 75);
            this.panel45.TabIndex = 44;
            // 
            // panel46
            // 
            this.panel46.Controls.Add(this.pictureBox46);
            this.panel46.BackColor = System.Drawing.Color.White;
            this.panel46.Location = new System.Drawing.Point(153, 153);
            this.panel46.Margin = new System.Windows.Forms.Padding(0);
            this.panel46.Name = "panel46";
            this.panel46.Size = new System.Drawing.Size(75, 75);
            this.panel46.TabIndex = 45;
            // 
            // panel47
            // 
            this.panel47.Controls.Add(this.pictureBox47);
            this.panel47.Location = new System.Drawing.Point(77, 153);
            this.panel47.Margin = new System.Windows.Forms.Padding(0);
            this.panel47.Name = "panel47";
            this.panel47.Size = new System.Drawing.Size(75, 75);
            this.panel47.TabIndex = 46;
            // 
            // panel48
            // 
            this.panel48.Controls.Add(this.pictureBox48);
            this.panel48.BackColor = System.Drawing.Color.White;
            this.panel48.Location = new System.Drawing.Point(1, 153);
            this.panel48.Margin = new System.Windows.Forms.Padding(0);
            this.panel48.Name = "panel48";
            this.panel48.Size = new System.Drawing.Size(75, 75);
            this.panel48.TabIndex = 47;
            // 
            // panel49
            // 
            this.panel49.Controls.Add(this.pictureBox49);
            this.panel49.BackColor = System.Drawing.Color.White;
            this.panel49.Location = new System.Drawing.Point(533, 77);
            this.panel49.Margin = new System.Windows.Forms.Padding(0);
            this.panel49.Name = "panel49";
            this.panel49.Size = new System.Drawing.Size(75, 75);
            this.panel49.TabIndex = 48;
            // 
            // panel50
            // 
            this.panel50.Controls.Add(this.pictureBox50);
            this.panel50.Location = new System.Drawing.Point(457, 77);
            this.panel50.Margin = new System.Windows.Forms.Padding(0);
            this.panel50.Name = "panel50";
            this.panel50.Size = new System.Drawing.Size(75, 75);
            this.panel50.TabIndex = 49;
            // 
            // panel51
            // 
            this.panel51.Controls.Add(this.pictureBox51);
            this.panel51.BackColor = System.Drawing.Color.White;
            this.panel51.Location = new System.Drawing.Point(381, 77);
            this.panel51.Margin = new System.Windows.Forms.Padding(0);
            this.panel51.Name = "panel51";
            this.panel51.Size = new System.Drawing.Size(75, 75);
            this.panel51.TabIndex = 50;
            // 
            // panel52
            // 
            this.panel52.Controls.Add(this.pictureBox52);
            this.panel52.Location = new System.Drawing.Point(305, 77);
            this.panel52.Margin = new System.Windows.Forms.Padding(0);
            this.panel52.Name = "panel52";
            this.panel52.Size = new System.Drawing.Size(75, 75);
            this.panel52.TabIndex = 51;
            // 
            // panel53
            // 
            this.panel53.Controls.Add(this.pictureBox53);
            this.panel53.BackColor = System.Drawing.Color.White;
            this.panel53.Location = new System.Drawing.Point(229, 77);
            this.panel53.Margin = new System.Windows.Forms.Padding(0);
            this.panel53.Name = "panel53";
            this.panel53.Size = new System.Drawing.Size(75, 75);
            this.panel53.TabIndex = 52;
            // 
            // panel54
            // 
            this.panel54.Controls.Add(this.pictureBox54);
            this.panel54.Location = new System.Drawing.Point(153, 77);
            this.panel54.Margin = new System.Windows.Forms.Padding(0);
            this.panel54.Name = "panel54";
            this.panel54.Size = new System.Drawing.Size(75, 75);
            this.panel54.TabIndex = 53;
            // 
            // panel55
            // 
            this.panel55.Controls.Add(this.pictureBox55);
            this.panel55.BackColor = System.Drawing.Color.White;
            this.panel55.Location = new System.Drawing.Point(77, 77);
            this.panel55.Margin = new System.Windows.Forms.Padding(0);
            this.panel55.Name = "panel55";
            this.panel55.Size = new System.Drawing.Size(75, 75);
            this.panel55.TabIndex = 54;
            // 
            // panel56
            // 
            this.panel56.Controls.Add(this.pictureBox56);
            this.panel56.Location = new System.Drawing.Point(1, 77);
            this.panel56.Margin = new System.Windows.Forms.Padding(0);
            this.panel56.Name = "panel56";
            this.panel56.Size = new System.Drawing.Size(75, 75);
            this.panel56.TabIndex = 55;
            // 
            // panel57
            // 
            this.panel57.Controls.Add(this.pictureBox57);
            this.panel57.Location = new System.Drawing.Point(533, 1);
            this.panel57.Margin = new System.Windows.Forms.Padding(0);
            this.panel57.Name = "panel57";
            this.panel57.Size = new System.Drawing.Size(75, 75);
            this.panel57.TabIndex = 56;
            // 
            // panel58
            // 
            this.panel58.Controls.Add(this.pictureBox58);
            this.panel58.BackColor = System.Drawing.Color.White;
            this.panel58.Location = new System.Drawing.Point(457, 1);
            this.panel58.Margin = new System.Windows.Forms.Padding(0);
            this.panel58.Name = "panel58";
            this.panel58.Size = new System.Drawing.Size(75, 75);
            this.panel58.TabIndex = 57;
            // 
            // panel59
            // 
            this.panel59.Controls.Add(this.pictureBox59);
            this.panel59.Location = new System.Drawing.Point(381, 1);
            this.panel59.Margin = new System.Windows.Forms.Padding(0);
            this.panel59.Name = "panel59";
            this.panel59.Size = new System.Drawing.Size(75, 75);
            this.panel59.TabIndex = 58;
            // 
            // panel60
            // 
            this.panel60.Controls.Add(this.pictureBox60);
            this.panel60.BackColor = System.Drawing.Color.White;
            this.panel60.Location = new System.Drawing.Point(305, 1);
            this.panel60.Margin = new System.Windows.Forms.Padding(0);
            this.panel60.Name = "panel60";
            this.panel60.Size = new System.Drawing.Size(75, 75);
            this.panel60.TabIndex = 59;
            // 
            // panel61
            // 
            this.panel61.Controls.Add(this.pictureBox61);
            this.panel61.Location = new System.Drawing.Point(229, 1);
            this.panel61.Margin = new System.Windows.Forms.Padding(0);
            this.panel61.Name = "panel61";
            this.panel61.Size = new System.Drawing.Size(75, 75);
            this.panel61.TabIndex = 60;
            // 
            // panel62
            // 
            this.panel62.Controls.Add(this.pictureBox62);
            this.panel62.BackColor = System.Drawing.Color.White;
            this.panel62.Location = new System.Drawing.Point(153, 1);
            this.panel62.Margin = new System.Windows.Forms.Padding(0);
            this.panel62.Name = "panel62";
            this.panel62.Size = new System.Drawing.Size(75, 75);
            this.panel62.TabIndex = 61;
            // 
            // panel63
            // 
            this.panel63.Controls.Add(this.pictureBox63);
            this.panel63.Location = new System.Drawing.Point(77, 1);
            this.panel63.Margin = new System.Windows.Forms.Padding(0);
            this.panel63.Name = "panel63";
            this.panel63.Size = new System.Drawing.Size(75, 75);
            this.panel63.TabIndex = 62;
            // 
            // panel64
            // 
            this.panel64.Controls.Add(this.pictureBox64);
            this.panel64.BackColor = System.Drawing.Color.White;
            this.panel64.Location = new System.Drawing.Point(1, 1);
            this.panel64.Margin = new System.Windows.Forms.Padding(0);
            this.panel64.Name = "panel64";
            this.panel64.Size = new System.Drawing.Size(75, 75);
            this.panel64.TabIndex = 63;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TestChess.Properties.Resources.BlackRook;
            this.pictureBox1.Image = null;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 

            this.pictureBox2.Image = null;
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(68, 68);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;

            this.pictureBox3.Image = null;
            this.pictureBox3.Location = new System.Drawing.Point(3, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(68, 68);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;

            this.pictureBox4.Image = null;
            this.pictureBox4.Location = new System.Drawing.Point(3, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(68, 68);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;

            this.pictureBox5.Image = null;
            this.pictureBox5.Location = new System.Drawing.Point(3, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(68, 68);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;

            this.pictureBox6.Image = null;
            this.pictureBox6.Location = new System.Drawing.Point(3, 3);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(68, 68);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 0;
            this.pictureBox6.TabStop = false;

            this.pictureBox7.Image = null;
            this.pictureBox7.Location = new System.Drawing.Point(3, 3);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(68, 68);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 0;
            this.pictureBox7.TabStop = false;

            this.pictureBox8.Image = null;
            this.pictureBox8.Location = new System.Drawing.Point(3, 3);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(68, 68);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 0;
            this.pictureBox8.TabStop = false;

            this.pictureBox9.Image = null;
            this.pictureBox9.Location = new System.Drawing.Point(3, 3);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(68, 68);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 0;
            this.pictureBox9.TabStop = false;

            this.pictureBox10.Image = null;
            this.pictureBox10.Location = new System.Drawing.Point(3, 3);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(68, 68);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 0;
            this.pictureBox10.TabStop = false;

            this.pictureBox11.Image = null;
            this.pictureBox11.Location = new System.Drawing.Point(3, 3);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(68, 68);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox11.TabIndex = 0;
            this.pictureBox11.TabStop = false;

            this.pictureBox12.Image = null;
            this.pictureBox12.Location = new System.Drawing.Point(3, 3);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(68, 68);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox12.TabIndex = 0;
            this.pictureBox12.TabStop = false;

            this.pictureBox13.Image = null;
            this.pictureBox13.Location = new System.Drawing.Point(3, 3);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(68, 68);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox13.TabIndex = 0;
            this.pictureBox13.TabStop = false;

            this.pictureBox14.Image = null;
            this.pictureBox14.Location = new System.Drawing.Point(3, 3);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(68, 68);
            this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox14.TabIndex = 0;
            this.pictureBox14.TabStop = false;

            this.pictureBox15.Image = null;
            this.pictureBox15.Location = new System.Drawing.Point(3, 3);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(68, 68);
            this.pictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox15.TabIndex = 0;
            this.pictureBox15.TabStop = false;

            this.pictureBox16.Image = null;
            this.pictureBox16.Location = new System.Drawing.Point(3, 3);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(68, 68);
            this.pictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox16.TabIndex = 0;
            this.pictureBox16.TabStop = false;

            this.pictureBox17.Image = null;
            this.pictureBox17.Location = new System.Drawing.Point(3, 3);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(68, 68);
            this.pictureBox17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox17.TabIndex = 0;
            this.pictureBox17.TabStop = false;

            this.pictureBox18.Image = null;
            this.pictureBox18.Location = new System.Drawing.Point(3, 3);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(68, 68);
            this.pictureBox18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox18.TabIndex = 0;
            this.pictureBox18.TabStop = false;

            this.pictureBox19.Image = null;
            this.pictureBox19.Location = new System.Drawing.Point(3, 3);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.Size = new System.Drawing.Size(68, 68);
            this.pictureBox19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox19.TabIndex = 0;
            this.pictureBox19.TabStop = false;

            this.pictureBox20.Image = null;
            this.pictureBox20.Location = new System.Drawing.Point(3, 3);
            this.pictureBox20.Name = "pictureBox20";
            this.pictureBox20.Size = new System.Drawing.Size(68, 68);
            this.pictureBox20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox20.TabIndex = 0;
            this.pictureBox20.TabStop = false;

            this.pictureBox21.Image = null;
            this.pictureBox21.Location = new System.Drawing.Point(3, 3);
            this.pictureBox21.Name = "pictureBox21";
            this.pictureBox21.Size = new System.Drawing.Size(68, 68);
            this.pictureBox21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox21.TabIndex = 0;
            this.pictureBox21.TabStop = false;

            this.pictureBox22.Image = null;
            this.pictureBox22.Location = new System.Drawing.Point(3, 3);
            this.pictureBox22.Name = "pictureBox22";
            this.pictureBox22.Size = new System.Drawing.Size(68, 68);
            this.pictureBox22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox22.TabIndex = 0;
            this.pictureBox22.TabStop = false;

            this.pictureBox23.Image = null;
            this.pictureBox23.Location = new System.Drawing.Point(3, 3);
            this.pictureBox23.Name = "pictureBox23";
            this.pictureBox23.Size = new System.Drawing.Size(68, 68);
            this.pictureBox23.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox23.TabIndex = 0;
            this.pictureBox23.TabStop = false;

            this.pictureBox24.Image = null;
            this.pictureBox24.Location = new System.Drawing.Point(3, 3);
            this.pictureBox24.Name = "pictureBox24";
            this.pictureBox24.Size = new System.Drawing.Size(68, 68);
            this.pictureBox24.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox24.TabIndex = 0;
            this.pictureBox24.TabStop = false;

            this.pictureBox25.Image = null;
            this.pictureBox25.Location = new System.Drawing.Point(3, 3);
            this.pictureBox25.Name = "pictureBox25";
            this.pictureBox25.Size = new System.Drawing.Size(68, 68);
            this.pictureBox25.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox25.TabIndex = 0;
            this.pictureBox25.TabStop = false;

            this.pictureBox26.Image = null;
            this.pictureBox26.Location = new System.Drawing.Point(3, 3);
            this.pictureBox26.Name = "pictureBox26";
            this.pictureBox26.Size = new System.Drawing.Size(68, 68);
            this.pictureBox26.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox26.TabIndex = 0;
            this.pictureBox26.TabStop = false;

            this.pictureBox27.Image = null;
            this.pictureBox27.Location = new System.Drawing.Point(3, 3);
            this.pictureBox27.Name = "pictureBox27";
            this.pictureBox27.Size = new System.Drawing.Size(68, 68);
            this.pictureBox27.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox27.TabIndex = 0;
            this.pictureBox27.TabStop = false;

            this.pictureBox28.Image = null;
            this.pictureBox28.Location = new System.Drawing.Point(3, 3);
            this.pictureBox28.Name = "pictureBox28";
            this.pictureBox28.Size = new System.Drawing.Size(68, 68);
            this.pictureBox28.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox28.TabIndex = 0;
            this.pictureBox28.TabStop = false;

            this.pictureBox29.Image = null;
            this.pictureBox29.Location = new System.Drawing.Point(3, 3);
            this.pictureBox29.Name = "pictureBox29";
            this.pictureBox29.Size = new System.Drawing.Size(68, 68);
            this.pictureBox29.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox29.TabIndex = 0;
            this.pictureBox29.TabStop = false;

            this.pictureBox30.Image = null;
            this.pictureBox30.Location = new System.Drawing.Point(3, 3);
            this.pictureBox30.Name = "pictureBox30";
            this.pictureBox30.Size = new System.Drawing.Size(68, 68);
            this.pictureBox30.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox30.TabIndex = 0;
            this.pictureBox30.TabStop = false;

            this.pictureBox31.Image = null;
            this.pictureBox31.Location = new System.Drawing.Point(3, 3);
            this.pictureBox31.Name = "pictureBox31";
            this.pictureBox31.Size = new System.Drawing.Size(68, 68);
            this.pictureBox31.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox31.TabIndex = 0;
            this.pictureBox31.TabStop = false;

            this.pictureBox32.Image = null;
            this.pictureBox32.Location = new System.Drawing.Point(3, 3);
            this.pictureBox32.Name = "pictureBox32";
            this.pictureBox32.Size = new System.Drawing.Size(68, 68);
            this.pictureBox32.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox32.TabIndex = 0;
            this.pictureBox32.TabStop = false;

            this.pictureBox33.Image = null;
            this.pictureBox33.Location = new System.Drawing.Point(3, 3);
            this.pictureBox33.Name = "pictureBox33";
            this.pictureBox33.Size = new System.Drawing.Size(68, 68);
            this.pictureBox33.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox33.TabIndex = 0;
            this.pictureBox33.TabStop = false;

            this.pictureBox34.Image = null;
            this.pictureBox34.Location = new System.Drawing.Point(3, 3);
            this.pictureBox34.Name = "pictureBox34";
            this.pictureBox34.Size = new System.Drawing.Size(68, 68);
            this.pictureBox34.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox34.TabIndex = 0;
            this.pictureBox34.TabStop = false;

            this.pictureBox35.Image = null;
            this.pictureBox35.Location = new System.Drawing.Point(3, 3);
            this.pictureBox35.Name = "pictureBox35";
            this.pictureBox35.Size = new System.Drawing.Size(68, 68);
            this.pictureBox35.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox35.TabIndex = 0;
            this.pictureBox35.TabStop = false;

            this.pictureBox36.Image = null;
            this.pictureBox36.Location = new System.Drawing.Point(3, 3);
            this.pictureBox36.Name = "pictureBox36";
            this.pictureBox36.Size = new System.Drawing.Size(68, 68);
            this.pictureBox36.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox36.TabIndex = 0;
            this.pictureBox36.TabStop = false;

            this.pictureBox37.Image = null;
            this.pictureBox37.Location = new System.Drawing.Point(3, 3);
            this.pictureBox37.Name = "pictureBox37";
            this.pictureBox37.Size = new System.Drawing.Size(68, 68);
            this.pictureBox37.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox37.TabIndex = 0;
            this.pictureBox37.TabStop = false;

            this.pictureBox38.Image = null;
            this.pictureBox38.Location = new System.Drawing.Point(3, 3);
            this.pictureBox38.Name = "pictureBox38";
            this.pictureBox38.Size = new System.Drawing.Size(68, 68);
            this.pictureBox38.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox38.TabIndex = 0;
            this.pictureBox38.TabStop = false;

            this.pictureBox39.Image = null;
            this.pictureBox39.Location = new System.Drawing.Point(3, 3);
            this.pictureBox39.Name = "pictureBox39";
            this.pictureBox39.Size = new System.Drawing.Size(68, 68);
            this.pictureBox39.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox39.TabIndex = 0;
            this.pictureBox39.TabStop = false;

            this.pictureBox40.Image = null;
            this.pictureBox40.Location = new System.Drawing.Point(3, 3);
            this.pictureBox40.Name = "pictureBox40";
            this.pictureBox40.Size = new System.Drawing.Size(68, 68);
            this.pictureBox40.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox40.TabIndex = 0;
            this.pictureBox40.TabStop = false;

            this.pictureBox41.Image = null;
            this.pictureBox41.Location = new System.Drawing.Point(3, 3);
            this.pictureBox41.Name = "pictureBox41";
            this.pictureBox41.Size = new System.Drawing.Size(68, 68);
            this.pictureBox41.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox41.TabIndex = 0;
            this.pictureBox41.TabStop = false;

            this.pictureBox42.Image = null;
            this.pictureBox42.Location = new System.Drawing.Point(3, 3);
            this.pictureBox42.Name = "pictureBox42";
            this.pictureBox42.Size = new System.Drawing.Size(68, 68);
            this.pictureBox42.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox42.TabIndex = 0;
            this.pictureBox42.TabStop = false;

            this.pictureBox43.Image = null;
            this.pictureBox43.Location = new System.Drawing.Point(3, 3);
            this.pictureBox43.Name = "pictureBox43";
            this.pictureBox43.Size = new System.Drawing.Size(68, 68);
            this.pictureBox43.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox43.TabIndex = 0;
            this.pictureBox43.TabStop = false;

            this.pictureBox44.Image = null;
            this.pictureBox44.Location = new System.Drawing.Point(3, 3);
            this.pictureBox44.Name = "pictureBox44";
            this.pictureBox44.Size = new System.Drawing.Size(68, 68);
            this.pictureBox44.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox44.TabIndex = 0;
            this.pictureBox44.TabStop = false;

            this.pictureBox45.Image = null;
            this.pictureBox45.Location = new System.Drawing.Point(3, 3);
            this.pictureBox45.Name = "pictureBox45";
            this.pictureBox45.Size = new System.Drawing.Size(68, 68);
            this.pictureBox45.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox45.TabIndex = 0;
            this.pictureBox45.TabStop = false;

            this.pictureBox46.Image = null;
            this.pictureBox46.Location = new System.Drawing.Point(3, 3);
            this.pictureBox46.Name = "pictureBox46";
            this.pictureBox46.Size = new System.Drawing.Size(68, 68);
            this.pictureBox46.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox46.TabIndex = 0;
            this.pictureBox46.TabStop = false;

            this.pictureBox47.Image = null;
            this.pictureBox47.Location = new System.Drawing.Point(3, 3);
            this.pictureBox47.Name = "pictureBox47";
            this.pictureBox47.Size = new System.Drawing.Size(68, 68);
            this.pictureBox47.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox47.TabIndex = 0;
            this.pictureBox47.TabStop = false;

            this.pictureBox48.Image = null;
            this.pictureBox48.Location = new System.Drawing.Point(3, 3);
            this.pictureBox48.Name = "pictureBox48";
            this.pictureBox48.Size = new System.Drawing.Size(68, 68);
            this.pictureBox48.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox48.TabIndex = 0;
            this.pictureBox48.TabStop = false;

            this.pictureBox49.Image = null;
            this.pictureBox49.Location = new System.Drawing.Point(3, 3);
            this.pictureBox49.Name = "pictureBox49";
            this.pictureBox49.Size = new System.Drawing.Size(68, 68);
            this.pictureBox49.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox49.TabIndex = 0;
            this.pictureBox49.TabStop = false;

            this.pictureBox50.Image = null;
            this.pictureBox50.Location = new System.Drawing.Point(3, 3);
            this.pictureBox50.Name = "pictureBox50";
            this.pictureBox50.Size = new System.Drawing.Size(68, 68);
            this.pictureBox50.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox50.TabIndex = 0;
            this.pictureBox50.TabStop = false;

            this.pictureBox51.Image = null;
            this.pictureBox51.Location = new System.Drawing.Point(3, 3);
            this.pictureBox51.Name = "pictureBox51";
            this.pictureBox51.Size = new System.Drawing.Size(68, 68);
            this.pictureBox51.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox51.TabIndex = 0;
            this.pictureBox51.TabStop = false;

            this.pictureBox52.Image = null;
            this.pictureBox52.Location = new System.Drawing.Point(3, 3);
            this.pictureBox52.Name = "pictureBox52";
            this.pictureBox52.Size = new System.Drawing.Size(68, 68);
            this.pictureBox52.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox52.TabIndex = 0;
            this.pictureBox52.TabStop = false;

            this.pictureBox53.Image = null;
            this.pictureBox53.Location = new System.Drawing.Point(3, 3);
            this.pictureBox53.Name = "pictureBox53";
            this.pictureBox53.Size = new System.Drawing.Size(68, 68);
            this.pictureBox53.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox53.TabIndex = 0;
            this.pictureBox53.TabStop = false;

            this.pictureBox54.Image = null;
            this.pictureBox54.Location = new System.Drawing.Point(3, 3);
            this.pictureBox54.Name = "pictureBox54";
            this.pictureBox54.Size = new System.Drawing.Size(68, 68);
            this.pictureBox54.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox54.TabIndex = 0;
            this.pictureBox54.TabStop = false;

            this.pictureBox55.Image = null;
            this.pictureBox55.Location = new System.Drawing.Point(3, 3);
            this.pictureBox55.Name = "pictureBox55";
            this.pictureBox55.Size = new System.Drawing.Size(68, 68);
            this.pictureBox55.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox55.TabIndex = 0;
            this.pictureBox55.TabStop = false;

            this.pictureBox56.Image = null;
            this.pictureBox56.Location = new System.Drawing.Point(3, 3);
            this.pictureBox56.Name = "pictureBox56";
            this.pictureBox56.Size = new System.Drawing.Size(68, 68);
            this.pictureBox56.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox56.TabIndex = 0;
            this.pictureBox56.TabStop = false;

            this.pictureBox57.Image = null;
            this.pictureBox57.Location = new System.Drawing.Point(3, 3);
            this.pictureBox57.Name = "pictureBox57";
            this.pictureBox57.Size = new System.Drawing.Size(68, 68);
            this.pictureBox57.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox57.TabIndex = 0;
            this.pictureBox57.TabStop = false;

            this.pictureBox58.Image = null;
            this.pictureBox58.Location = new System.Drawing.Point(3, 3);
            this.pictureBox58.Name = "pictureBox58";
            this.pictureBox58.Size = new System.Drawing.Size(68, 68);
            this.pictureBox58.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox58.TabIndex = 0;
            this.pictureBox58.TabStop = false;

            this.pictureBox59.Image = null;
            this.pictureBox59.Location = new System.Drawing.Point(3, 3);
            this.pictureBox59.Name = "pictureBox59";
            this.pictureBox59.Size = new System.Drawing.Size(68, 68);
            this.pictureBox59.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox59.TabIndex = 0;
            this.pictureBox59.TabStop = false;

            this.pictureBox60.Image = null;
            this.pictureBox60.Location = new System.Drawing.Point(3, 3);
            this.pictureBox60.Name = "pictureBox60";
            this.pictureBox60.Size = new System.Drawing.Size(68, 68);
            this.pictureBox60.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox60.TabIndex = 0;
            this.pictureBox60.TabStop = false;

            this.pictureBox61.Image = null;
            this.pictureBox61.Location = new System.Drawing.Point(3, 3);
            this.pictureBox61.Name = "pictureBox61";
            this.pictureBox61.Size = new System.Drawing.Size(68, 68);
            this.pictureBox61.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox61.TabIndex = 0;
            this.pictureBox61.TabStop = false;

            this.pictureBox62.Image = null;
            this.pictureBox62.Location = new System.Drawing.Point(3, 3);
            this.pictureBox62.Name = "pictureBox62";
            this.pictureBox62.Size = new System.Drawing.Size(68, 68);
            this.pictureBox62.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox62.TabIndex = 0;
            this.pictureBox62.TabStop = false;

            this.pictureBox63.Image = null;
            this.pictureBox63.Location = new System.Drawing.Point(3, 3);
            this.pictureBox63.Name = "pictureBox63";
            this.pictureBox63.Size = new System.Drawing.Size(68, 68);
            this.pictureBox63.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox63.TabIndex = 0;
            this.pictureBox63.TabStop = false;

            this.pictureBox64.Image = null;
            this.pictureBox64.Location = new System.Drawing.Point(3, 3);
            this.pictureBox64.Name = "pictureBox64";
            this.pictureBox64.Size = new System.Drawing.Size(68, 68);
            this.pictureBox64.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox64.TabIndex = 0;
            this.pictureBox64.TabStop = false;

            this.pictureBox1.Image = global::TestChess.Properties.Resources.BlackRook;
            this.pictureBox2.Image = global::TestChess.Properties.Resources.BlackKnight;
            this.pictureBox3.Image = global::TestChess.Properties.Resources.BlackBishop;
            this.pictureBox4.Image = global::TestChess.Properties.Resources.BlackQueen;
            this.pictureBox5.Image = global::TestChess.Properties.Resources.BlackKing;
            this.pictureBox6.Image = global::TestChess.Properties.Resources.BlackBishop;
            this.pictureBox7.Image = global::TestChess.Properties.Resources.BlackKnight;
            this.pictureBox8.Image = global::TestChess.Properties.Resources.BlackRook;
            this.pictureBox9.Image = global::TestChess.Properties.Resources.BlackPawn;
            this.pictureBox10.Image = global::TestChess.Properties.Resources.BlackPawn;
            this.pictureBox11.Image = global::TestChess.Properties.Resources.BlackPawn;
            this.pictureBox12.Image = global::TestChess.Properties.Resources.BlackPawn;
            this.pictureBox13.Image = global::TestChess.Properties.Resources.BlackPawn;
            this.pictureBox14.Image = global::TestChess.Properties.Resources.BlackPawn;
            this.pictureBox15.Image = global::TestChess.Properties.Resources.BlackPawn;
            this.pictureBox16.Image = global::TestChess.Properties.Resources.BlackPawn;

            this.pictureBox64.Image = global::TestChess.Properties.Resources.WhiteRook;
            this.pictureBox63.Image = global::TestChess.Properties.Resources.WhiteKnight;
            this.pictureBox62.Image = global::TestChess.Properties.Resources.WhiteBishop;
            this.pictureBox61.Image = global::TestChess.Properties.Resources.WhiteQueen;
            this.pictureBox60.Image = global::TestChess.Properties.Resources.WhiteKing;
            this.pictureBox59.Image = global::TestChess.Properties.Resources.WhiteBishop;
            this.pictureBox58.Image = global::TestChess.Properties.Resources.WhiteKnight;
            this.pictureBox57.Image = global::TestChess.Properties.Resources.WhiteRook;
            this.pictureBox56.Image = global::TestChess.Properties.Resources.WhitePawn;
            this.pictureBox55.Image = global::TestChess.Properties.Resources.WhitePawn;
            this.pictureBox54.Image = global::TestChess.Properties.Resources.WhitePawn;
            this.pictureBox53.Image = global::TestChess.Properties.Resources.WhitePawn;
            this.pictureBox52.Image = global::TestChess.Properties.Resources.WhitePawn;
            this.pictureBox51.Image = global::TestChess.Properties.Resources.WhitePawn;
            this.pictureBox50.Image = global::TestChess.Properties.Resources.WhitePawn;
            this.pictureBox49.Image = global::TestChess.Properties.Resources.WhitePawn;
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
            this.panel2.ResumeLayout(false);
            this.panel17.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox29)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox34)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox35)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox36)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox37)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox38)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox39)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox40)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox41)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox42)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox43)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox44)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox45)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox46)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox47)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox48)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox49)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox50)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox51)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox52)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox53)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox54)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox55)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox56)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox57)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox58)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox59)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox60)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox61)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox62)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox63)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox64)).EndInit();
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
        public System.Windows.Forms.PictureBox pictureBox3;
        public System.Windows.Forms.PictureBox pictureBox4;
        public System.Windows.Forms.PictureBox pictureBox5;
        public System.Windows.Forms.PictureBox pictureBox6;
        public System.Windows.Forms.PictureBox pictureBox7;
        public System.Windows.Forms.PictureBox pictureBox8;
        public System.Windows.Forms.PictureBox pictureBox9;
        public System.Windows.Forms.PictureBox pictureBox10;
        public System.Windows.Forms.PictureBox pictureBox11;
        public System.Windows.Forms.PictureBox pictureBox12;
        public System.Windows.Forms.PictureBox pictureBox13;
        public System.Windows.Forms.PictureBox pictureBox14;
        public System.Windows.Forms.PictureBox pictureBox15;
        public System.Windows.Forms.PictureBox pictureBox16;
        public System.Windows.Forms.PictureBox pictureBox17;
        public System.Windows.Forms.PictureBox pictureBox18;
        public System.Windows.Forms.PictureBox pictureBox19;
        public System.Windows.Forms.PictureBox pictureBox20;
        public System.Windows.Forms.PictureBox pictureBox21;
        public System.Windows.Forms.PictureBox pictureBox22;
        public System.Windows.Forms.PictureBox pictureBox23;
        public System.Windows.Forms.PictureBox pictureBox24;
        public System.Windows.Forms.PictureBox pictureBox25;
        public System.Windows.Forms.PictureBox pictureBox26;
        public System.Windows.Forms.PictureBox pictureBox27;
        public System.Windows.Forms.PictureBox pictureBox28;
        public System.Windows.Forms.PictureBox pictureBox29;
        public System.Windows.Forms.PictureBox pictureBox30;
        public System.Windows.Forms.PictureBox pictureBox31;
        public System.Windows.Forms.PictureBox pictureBox32;
        public System.Windows.Forms.PictureBox pictureBox33;
        public System.Windows.Forms.PictureBox pictureBox34;
        public System.Windows.Forms.PictureBox pictureBox35;
        public System.Windows.Forms.PictureBox pictureBox36;
        public System.Windows.Forms.PictureBox pictureBox37;
        public System.Windows.Forms.PictureBox pictureBox38;
        public System.Windows.Forms.PictureBox pictureBox39;
        public System.Windows.Forms.PictureBox pictureBox40;
        public System.Windows.Forms.PictureBox pictureBox41;
        public System.Windows.Forms.PictureBox pictureBox42;
        public System.Windows.Forms.PictureBox pictureBox43;
        public System.Windows.Forms.PictureBox pictureBox44;
        public System.Windows.Forms.PictureBox pictureBox45;
        public System.Windows.Forms.PictureBox pictureBox46;
        public System.Windows.Forms.PictureBox pictureBox47;
        public System.Windows.Forms.PictureBox pictureBox48;
        public System.Windows.Forms.PictureBox pictureBox49;
        public System.Windows.Forms.PictureBox pictureBox50;
        public System.Windows.Forms.PictureBox pictureBox51;
        public System.Windows.Forms.PictureBox pictureBox52;
        public System.Windows.Forms.PictureBox pictureBox53;
        public System.Windows.Forms.PictureBox pictureBox54;
        public System.Windows.Forms.PictureBox pictureBox55;
        public System.Windows.Forms.PictureBox pictureBox56;
        public System.Windows.Forms.PictureBox pictureBox57;
        public System.Windows.Forms.PictureBox pictureBox58;
        public System.Windows.Forms.PictureBox pictureBox59;
        public System.Windows.Forms.PictureBox pictureBox60;
        public System.Windows.Forms.PictureBox pictureBox61;
        public System.Windows.Forms.PictureBox pictureBox62;
        public System.Windows.Forms.PictureBox pictureBox63;
        public System.Windows.Forms.PictureBox pictureBox64;
    }
}

