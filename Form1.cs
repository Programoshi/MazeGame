using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MazeGame
{
    public partial class Form1 : Form
    {
        System.Media.SoundPlayer startSoundPlayer = new System.Media.SoundPlayer(@"C:\HelloWorld\Console Applications\03.MazeGame\MazeGame\bin\Debug\2.wav"); // tworzenie obiektów dzwięku
        System.Media.SoundPlayer finishSoundPlayer = new System.Media.SoundPlayer(@"C:\HelloWorld\Console Applications\03.MazeGame\MazeGame\bin\Debug\1.wav");

        public Form1()
        {
            InitializeComponent();
            MoveToStart();
        }

        private void finishLabel_MouseEnter(object sender, EventArgs e) // meta 
        {
            startSoundPlayer.Play();
            MessageBox.Show("Congratulations ( ͡° ͜ʖ ͡°) ! :)");
            Close();
        }
        private void MoveToStart()
        {
        finishSoundPlayer.Play();
        Point startingPoint = panel1.Location; // pozycjonowanie kursora
        startingPoint.Offset(10,10);
        Cursor.Position = PointToScreen(startingPoint);
    }

        private void wall_MouseEnter(object sender, EventArgs e) // jeśli dotknie ściamy wraca do początku tzn.metody MoveToStart
        {
            MoveToStart();
        }
    }
}
