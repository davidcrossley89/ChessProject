using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GamePieces;

namespace TestChess
{
    public partial class Form1 : Form
    {
        public Board board = new Board();
        public int[][] moveArray = new int[2][];
        public PictureBox[] boxArray = new PictureBox[2];
        public bool startPos = true;
        Graphics g;
        public void UpdateBoard()
        {
            string startPos = board.coordConvertToAlg(this.moveArray[0]);
            string endPos = board.coordConvertToAlg(this.moveArray[1]);
            GamePiece startPiece = board.pieces[startPos];
            Console.WriteLine("{0},{1}, {2}", startPos, endPos, startPiece.getName());
            bool possible = startPiece.checkMove(moveArray[1]);
            if (possible)
            {
                board.pieces[endPos] = startPiece;
                startPiece.setPosition(moveArray[1]);
                board.pieces[startPos] = new Empty(moveArray[0]);
            }

            boxArray[0].Image = board.pieces[startPos].getImage();
            boxArray[1].Image = board.pieces[endPos].getImage();

            boxArray[0].BackColor = Color.FromArgb(0,0,0,0);
            boxArray[1].BackColor = Color.FromArgb(0, 0, 0, 0);
            board.populateBoard();
            board.printBoard();

        }
        public Form1()
        {
            InitializeComponent();

        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            UpdateBoard();
            startPos = true;
            moveArray = new int[2][];


        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.BackColor = System.Drawing.Color.Yellow;
            Console.WriteLine("Added to Array");
            int[] pos = new int[2] { 7, 7 };
            if (this.startPos) { this.moveArray[0] = pos;  this.boxArray[0] = pb; }
            else { this.moveArray[1] = pos; this.boxArray[1] = pb; }
            this.startPos = !this.startPos;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.BackColor = System.Drawing.Color.Yellow;
            int[] pos = new int[2] { 6,7 };
            if (this.startPos) { this.moveArray[0] = pos; this.boxArray[0] = pb; }
            else { this.moveArray[1] = pos; this.boxArray[1] = pb; }
            this.startPos = !this.startPos;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.BackColor = System.Drawing.Color.Yellow;
            int[] pos = new int[2] { 5,7 };
            if (this.startPos) { this.moveArray[0] = pos; this.boxArray[0] = pb; }
            else { this.moveArray[1] = pos; this.boxArray[1] = pb; }
            this.startPos = !this.startPos;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.BackColor = System.Drawing.Color.Yellow;
            int[] pos = new int[2] { 4,7 };
            if (this.startPos) { this.moveArray[0] = pos; this.boxArray[0] = pb; }
            else { this.moveArray[1] = pos; this.boxArray[1] = pb; }
            this.startPos = !this.startPos;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.BackColor = System.Drawing.Color.Yellow;
            int[] pos = new int[2] { 3,7 };
            if (this.startPos) { this.moveArray[0] = pos; this.boxArray[0] = pb; }
            else { this.moveArray[1] = pos; this.boxArray[1] = pb; }
            this.startPos = !this.startPos;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.BackColor = System.Drawing.Color.Yellow;
            int[] pos = new int[2] { 2,7 };
            if (this.startPos) { this.moveArray[0] = pos; this.boxArray[0] = pb; }
            else { this.moveArray[1] = pos; this.boxArray[1] = pb; }
            this.startPos = !this.startPos;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.BackColor = System.Drawing.Color.Yellow;
            int[] pos = new int[2] { 1,7 };
            if (this.startPos) { this.moveArray[0] = pos; this.boxArray[0] = pb; }
            else { this.moveArray[1] = pos; this.boxArray[1] = pb; }
            this.startPos = !this.startPos;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.BackColor = System.Drawing.Color.Yellow;
            int[] pos = new int[2] { 0,7};
            if (this.startPos) { this.moveArray[0] = pos; this.boxArray[0] = pb; }
            else { this.moveArray[1] = pos; this.boxArray[1] = pb; }
            this.startPos = !this.startPos;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.BackColor = System.Drawing.Color.Yellow;
            int[] pos = new int[2] { 7,6 };
            if (this.startPos) { this.moveArray[0] = pos; this.boxArray[0] = pb; }
            else { this.moveArray[1] = pos; this.boxArray[1] = pb; }
            this.startPos = !this.startPos;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.BackColor = System.Drawing.Color.Yellow;
            int[] pos = new int[2] { 6,6 };
            if (this.startPos) { this.moveArray[0] = pos; this.boxArray[0] = pb; }
            else { this.moveArray[1] = pos; this.boxArray[1] = pb; }
            this.startPos = !this.startPos;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.BackColor = System.Drawing.Color.Yellow;
            int[] pos = new int[2] { 5,6 };
            if (this.startPos) { this.moveArray[0] = pos; this.boxArray[0] = pb; }
            else { this.moveArray[1] = pos; this.boxArray[1] = pb; }
            this.startPos = !this.startPos;
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.BackColor = System.Drawing.Color.Yellow;
            int[] pos = new int[2] { 4,6 };
            if (this.startPos) { this.moveArray[0] = pos; this.boxArray[0] = pb; }
            else { this.moveArray[1] = pos; this.boxArray[1] = pb; }
            this.startPos = !this.startPos;
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.BackColor = System.Drawing.Color.Yellow;
            int[] pos = new int[2] { 3,6 };
            if (this.startPos) { this.moveArray[0] = pos; this.boxArray[0] = pb; }
            else { this.moveArray[1] = pos; this.boxArray[1] = pb; }
            this.startPos = !this.startPos;
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.BackColor = System.Drawing.Color.Yellow;
            int[] pos = new int[2] { 2,6 };
            if (this.startPos) { this.moveArray[0] = pos; this.boxArray[0] = pb; }
            else { this.moveArray[1] = pos; this.boxArray[1] = pb; }
            this.startPos = !this.startPos;
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.BackColor = System.Drawing.Color.Yellow;
            int[] pos = new int[2] { 1,6 };
            if (this.startPos) { this.moveArray[0] = pos; this.boxArray[0] = pb; }
            else { this.moveArray[1] = pos; this.boxArray[1] = pb; }
            this.startPos = !this.startPos;
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.BackColor = System.Drawing.Color.Yellow;
            int[] pos = new int[2] { 0,6 };
            if (this.startPos) { this.moveArray[0] = pos; this.boxArray[0] = pb; }
            else { this.moveArray[1] = pos; this.boxArray[1] = pb; }
            this.startPos = !this.startPos;
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.BackColor = System.Drawing.Color.Yellow;
            int[] pos = new int[2] { 7,5 };
            if (this.startPos) { this.moveArray[0] = pos; this.boxArray[0] = pb; }
            else { this.moveArray[1] = pos; this.boxArray[1] = pb; }
            this.startPos = !this.startPos;
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.BackColor = System.Drawing.Color.Yellow;
            int[] pos = new int[2] { 6,5 };
            if (this.startPos) { this.moveArray[0] = pos; this.boxArray[0] = pb; }
            else { this.moveArray[1] = pos; this.boxArray[1] = pb; }
            this.startPos = !this.startPos;
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.BackColor = System.Drawing.Color.Yellow;
            int[] pos = new int[2] { 5,5 };
            if (this.startPos) { this.moveArray[0] = pos; this.boxArray[0] = pb; }
            else { this.moveArray[1] = pos; this.boxArray[1] = pb; }
            this.startPos = !this.startPos;
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.BackColor = System.Drawing.Color.Yellow;
            int[] pos = new int[2] { 4,5 };
            if (this.startPos) { this.moveArray[0] = pos; this.boxArray[0] = pb; }
            else { this.moveArray[1] = pos; this.boxArray[1] = pb; }
            this.startPos = !this.startPos;
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.BackColor = System.Drawing.Color.Yellow;
            int[] pos = new int[2] { 3,5 };
            if (this.startPos) { this.moveArray[0] = pos; this.boxArray[0] = pb; }
            else { this.moveArray[1] = pos; this.boxArray[1] = pb; }
            this.startPos = !this.startPos;
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.BackColor = System.Drawing.Color.Yellow;
            int[] pos = new int[2] { 2,5 };
            if (this.startPos) { this.moveArray[0] = pos; this.boxArray[0] = pb; }
            else { this.moveArray[1] = pos; this.boxArray[1] = pb; }
            this.startPos = !this.startPos;
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.BackColor = System.Drawing.Color.Yellow;
            int[] pos = new int[2] { 1,5 };
            if (this.startPos) { this.moveArray[0] = pos; this.boxArray[0] = pb; }
            else { this.moveArray[1] = pos; this.boxArray[1] = pb; }
            this.startPos = !this.startPos;
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.BackColor = System.Drawing.Color.Yellow;
            int[] pos = new int[2] { 0,5 };
            if (this.startPos) { this.moveArray[0] = pos; this.boxArray[0] = pb; }
            else { this.moveArray[1] = pos; this.boxArray[1] = pb; }
            this.startPos = !this.startPos;
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.BackColor = System.Drawing.Color.Yellow;
            int[] pos = new int[2] { 7,4 };
            if (this.startPos) { this.moveArray[0] = pos; this.boxArray[0] = pb; }
            else { this.moveArray[1] = pos; this.boxArray[1] = pb; }
            this.startPos = !this.startPos;
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.BackColor = System.Drawing.Color.Yellow;
            int[] pos = new int[2] { 6,4 };
            if (this.startPos) { this.moveArray[0] = pos; this.boxArray[0] = pb; }
            else { this.moveArray[1] = pos; this.boxArray[1] = pb; }
            this.startPos = !this.startPos;
        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.BackColor = System.Drawing.Color.Yellow;
            int[] pos = new int[2] { 5,4 };
            if (this.startPos) { this.moveArray[0] = pos; this.boxArray[0] = pb; }
            else { this.moveArray[1] = pos; this.boxArray[1] = pb; }
            this.startPos = !this.startPos;
        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.BackColor = System.Drawing.Color.Yellow;
            int[] pos = new int[2] { 4,4 };
            if (this.startPos) { this.moveArray[0] = pos; this.boxArray[0] = pb; }
            else { this.moveArray[1] = pos; this.boxArray[1] = pb; }
            this.startPos = !this.startPos;
        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.BackColor = System.Drawing.Color.Yellow;
            int[] pos = new int[2] { 3,4 };
            if (this.startPos) { this.moveArray[0] = pos; this.boxArray[0] = pb; }
            else { this.moveArray[1] = pos; this.boxArray[1] = pb; }
            this.startPos = !this.startPos;
        }

        private void pictureBox30_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.BackColor = System.Drawing.Color.Yellow;
            int[] pos = new int[2] { 2,4 };
            if (this.startPos) { this.moveArray[0] = pos; this.boxArray[0] = pb; }
            else { this.moveArray[1] = pos; this.boxArray[1] = pb; }
            this.startPos = !this.startPos;
        }

        private void pictureBox31_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.BackColor = System.Drawing.Color.Yellow;
            int[] pos = new int[2] { 1,4 };
            if (this.startPos) { this.moveArray[0] = pos; this.boxArray[0] = pb; }
            else { this.moveArray[1] = pos; this.boxArray[1] = pb; }
            this.startPos = !this.startPos;
        }

        private void pictureBox32_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.BackColor = System.Drawing.Color.Yellow;
            int[] pos = new int[2] { 0,4 };
            if (this.startPos) { this.moveArray[0] = pos; this.boxArray[0] = pb; }
            else { this.moveArray[1] = pos; this.boxArray[1] = pb; }
            this.startPos = !this.startPos;
        }

        private void pictureBox33_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.BackColor = System.Drawing.Color.Yellow;
            int[] pos = new int[2] { 7,3 };
            if (this.startPos) { this.moveArray[0] = pos; this.boxArray[0] = pb; }
            else { this.moveArray[1] = pos; this.boxArray[1] = pb; }
            this.startPos = !this.startPos;
        }

        private void pictureBox34_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.BackColor = System.Drawing.Color.Yellow;
            int[] pos = new int[2] { 6,3 };
            if (this.startPos) { this.moveArray[0] = pos; this.boxArray[0] = pb; }
            else { this.moveArray[1] = pos; this.boxArray[1] = pb; }
            this.startPos = !this.startPos;
        }

        private void pictureBox35_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.BackColor = System.Drawing.Color.Yellow;
            int[] pos = new int[2] { 5,3 };
            if (this.startPos) { this.moveArray[0] = pos; this.boxArray[0] = pb; }
            else { this.moveArray[1] = pos; this.boxArray[1] = pb; }
            this.startPos = !this.startPos;
        }

        private void pictureBox36_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.BackColor = System.Drawing.Color.Yellow;
            int[] pos = new int[2] { 4,3 };
            if (this.startPos) { this.moveArray[0] = pos; this.boxArray[0] = pb; }
            else { this.moveArray[1] = pos; this.boxArray[1] = pb; }
            this.startPos = !this.startPos;
        }

        private void pictureBox37_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.BackColor = System.Drawing.Color.Yellow;
            int[] pos = new int[2] { 3,3 };
            if (this.startPos) { this.moveArray[0] = pos; this.boxArray[0] = pb; }
            else { this.moveArray[1] = pos; this.boxArray[1] = pb; }
            this.startPos = !this.startPos;
        }

        private void pictureBox38_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.BackColor = System.Drawing.Color.Yellow;
            int[] pos = new int[2] { 2,3 };
            if (this.startPos) { this.moveArray[0] = pos; this.boxArray[0] = pb; }
            else { this.moveArray[1] = pos; this.boxArray[1] = pb; }
            this.startPos = !this.startPos;
        }

        private void pictureBox39_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.BackColor = System.Drawing.Color.Yellow;
            int[] pos = new int[2] { 1,3 };
            if (this.startPos) { this.moveArray[0] = pos; this.boxArray[0] = pb; }
            else { this.moveArray[1] = pos; this.boxArray[1] = pb; }
            this.startPos = !this.startPos;
        }

        private void pictureBox40_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.BackColor = System.Drawing.Color.Yellow;
            int[] pos = new int[2] { 0,3 };
            if (this.startPos) { this.moveArray[0] = pos; this.boxArray[0] = pb; }
            else { this.moveArray[1] = pos; this.boxArray[1] = pb; }
            this.startPos = !this.startPos;
        }

        private void pictureBox41_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.BackColor = System.Drawing.Color.Yellow;
            int[] pos = new int[2] { 7,2 };
            if (this.startPos) { this.moveArray[0] = pos; this.boxArray[0] = pb; }
            else { this.moveArray[1] = pos; this.boxArray[1] = pb; }
            this.startPos = !this.startPos;
        }

        private void pictureBox42_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.BackColor = System.Drawing.Color.Yellow;
            int[] pos = new int[2] { 6,2 };
            if (this.startPos) { this.moveArray[0] = pos; this.boxArray[0] = pb; }
            else { this.moveArray[1] = pos; this.boxArray[1] = pb; }
            this.startPos = !this.startPos;
        }

        private void pictureBox43_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.BackColor = System.Drawing.Color.Yellow;
            int[] pos = new int[2] {5,2 };
            if (this.startPos) { this.moveArray[0] = pos; this.boxArray[0] = pb; }
            else { this.moveArray[1] = pos; this.boxArray[1] = pb; }
            this.startPos = !this.startPos;
        }

        private void pictureBox44_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.BackColor = System.Drawing.Color.Yellow;
            int[] pos = new int[2] { 4,2 };
            if (this.startPos) { this.moveArray[0] = pos; this.boxArray[0] = pb; }
            else { this.moveArray[1] = pos; this.boxArray[1] = pb; }
            this.startPos = !this.startPos;
        }

        private void pictureBox45_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.BackColor = System.Drawing.Color.Yellow;
            int[] pos = new int[2] { 3,2 };
            if (this.startPos) { this.moveArray[0] = pos; this.boxArray[0] = pb; }
            else { this.moveArray[1] = pos; this.boxArray[1] = pb; }
            this.startPos = !this.startPos;
        }

        private void pictureBox46_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.BackColor = System.Drawing.Color.Yellow;
            int[] pos = new int[2] { 2,2 };
            if (this.startPos) { this.moveArray[0] = pos; this.boxArray[0] = pb; }
            else { this.moveArray[1] = pos; this.boxArray[1] = pb; }
            this.startPos = !this.startPos;
        }

        private void pictureBox47_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.BackColor = System.Drawing.Color.Yellow;
            int[] pos = new int[2] { 1,2 };
            if (this.startPos) { this.moveArray[0] = pos; this.boxArray[0] = pb; }
            else { this.moveArray[1] = pos; this.boxArray[1] = pb; }
            this.startPos = !this.startPos;
        }

        private void pictureBox48_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.BackColor = System.Drawing.Color.Yellow;
            int[] pos = new int[2] { 0,2 };
            if (this.startPos) { this.moveArray[0] = pos; this.boxArray[0] = pb; }
            else { this.moveArray[1] = pos; this.boxArray[1] = pb; }
            this.startPos = !this.startPos;
        }

        private void pictureBox49_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.BackColor = System.Drawing.Color.Yellow;
            int[] pos = new int[2] { 7,1 };
            if (this.startPos) { this.moveArray[0] = pos; this.boxArray[0] = pb; }
            else { this.moveArray[1] = pos; this.boxArray[1] = pb; }
            this.startPos = !this.startPos;
        }

        private void pictureBox50_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.BackColor = System.Drawing.Color.Yellow;
            int[] pos = new int[2] {6,1 };
            if (this.startPos) { this.moveArray[0] = pos; this.boxArray[0] = pb; }
            else { this.moveArray[1] = pos; this.boxArray[1] = pb; }
            this.startPos = !this.startPos;
        }

        private void pictureBox51_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.BackColor = System.Drawing.Color.Yellow;
            int[] pos = new int[2] { 5,1 };
            if (this.startPos) { this.moveArray[0] = pos; this.boxArray[0] = pb; }
            else { this.moveArray[1] = pos; this.boxArray[1] = pb; }
            this.startPos = !this.startPos;
        }

        private void pictureBox52_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.BackColor = System.Drawing.Color.Yellow;
            int[] pos = new int[2] { 4,1 };
            if (this.startPos) { this.moveArray[0] = pos; this.boxArray[0] = pb; }
            else { this.moveArray[1] = pos; this.boxArray[1] = pb; }
            this.startPos = !this.startPos;
        }

        private void pictureBox53_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.BackColor = System.Drawing.Color.Yellow;
            int[] pos = new int[2] { 3,1 };
            if (this.startPos) { this.moveArray[0] = pos; this.boxArray[0] = pb; }
            else { this.moveArray[1] = pos; this.boxArray[1] = pb; }
            this.startPos = !this.startPos;
        }

        private void pictureBox54_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.BackColor = System.Drawing.Color.Yellow;
            int[] pos = new int[2] { 2,1 };
            if (this.startPos) { this.moveArray[0] = pos; this.boxArray[0] = pb; }
            else { this.moveArray[1] = pos; this.boxArray[1] = pb; }
            this.startPos = !this.startPos;
        }

        private void pictureBox55_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.BackColor = System.Drawing.Color.Yellow;
            int[] pos = new int[2] { 1,1 };
            if (this.startPos) { this.moveArray[0] = pos; this.boxArray[0] = pb; }
            else { this.moveArray[1] = pos; this.boxArray[1] = pb; }
            this.startPos = !this.startPos;
        }

        private void pictureBox56_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.BackColor = System.Drawing.Color.Yellow;
            int[] pos = new int[2] {0,1 };
            if (this.startPos) { this.moveArray[0] = pos; this.boxArray[0] = pb; }
            else { this.moveArray[1] = pos; this.boxArray[1] = pb; }
            this.startPos = !this.startPos;
        }

        private void pictureBox57_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.BackColor = System.Drawing.Color.Yellow;
            int[] pos = new int[2] { 7, 0 };
            if (this.startPos) { this.moveArray[0] = pos; this.boxArray[0] = pb; }
            else { this.moveArray[1] = pos; this.boxArray[1] = pb; }
            this.startPos = !this.startPos;
        }

        private void pictureBox58_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.BackColor = System.Drawing.Color.Yellow;
            int[] pos = new int[2] { 6, 0 };
            if (this.startPos) { this.moveArray[0] = pos; this.boxArray[0] = pb; }
            else { this.moveArray[1] = pos; this.boxArray[1] = pb; }
            this.startPos = !this.startPos;
        }

        private void pictureBox59_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.BackColor = System.Drawing.Color.Yellow;
            int[] pos = new int[2] { 5, 0 };
            if (this.startPos) { this.moveArray[0] = pos; this.boxArray[0] = pb; }
            else { this.moveArray[1] = pos; this.boxArray[1] = pb; }
            this.startPos = !this.startPos;
        }

        private void pictureBox60_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.BackColor = System.Drawing.Color.Yellow;
            int[] pos = new int[2] { 4, 0 };
            if (this.startPos) { this.moveArray[0] = pos; this.boxArray[0] = pb; }
            else { this.moveArray[1] = pos; this.boxArray[1] = pb; }
            this.startPos = !this.startPos;
        }

        private void pictureBox61_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.BackColor = System.Drawing.Color.Yellow;
            int[] pos = new int[2] { 3, 0 };
            if (this.startPos) { this.moveArray[0] = pos; this.boxArray[0] = pb; }
            else { this.moveArray[1] = pos; this.boxArray[1] = pb; }
            this.startPos = !this.startPos;
        }

        private void pictureBox62_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.BackColor = System.Drawing.Color.Yellow;
            int[] pos = new int[2] { 2, 0 };
            if (this.startPos) { this.moveArray[0] = pos; this.boxArray[0] = pb; }
            else { this.moveArray[1] = pos; this.boxArray[1] = pb; }
            this.startPos = !this.startPos;
        }

        private void pictureBox63_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.BackColor = System.Drawing.Color.Yellow;
            int[] pos = new int[2] { 1, 0 };
            if (this.startPos) { this.moveArray[0] = pos; this.boxArray[0] = pb; }
            else { this.moveArray[1] = pos; this.boxArray[1] = pb; }
            this.startPos = !this.startPos;
        }

        private void pictureBox64_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.BackColor = System.Drawing.Color.Yellow;
            int[] pos = new int[2] { 0, 0 };
            if (this.startPos) { this.moveArray[0] = pos; this.boxArray[0] = pb; }
            else { this.moveArray[1] = pos; this.boxArray[1] = pb; }
            this.startPos = !this.startPos;
        }

        
    }
}
