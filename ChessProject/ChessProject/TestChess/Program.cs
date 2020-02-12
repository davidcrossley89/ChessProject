﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using GamePieces;

namespace TestChess
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]


        static void Main()
        {
            Console.WriteLine("This is  Output");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 view = new Form1();
            Application.Run(view);
            Board board = new Board();

            view.pictureBox1.Image = global::TestChess.Properties.Resources.WhiteRook;
            view.panel9.Invalidate();
            view.panel9.Controls.Add(view.pictureBox2);
            view.Update();
            

        }
    }
}