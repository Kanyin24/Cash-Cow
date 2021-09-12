using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

//Kanyinsola Adejola 
////Thursday Janurary 28, 2021
//The purpose of this class is to create, add properties and actions to each square within the grid for the game

namespace CashCow
{
    class Brick
    {
        //fields
        private int mSize;
        private Color mFillColour;
        private Color mBorderColour;
        private bool mMatched;
        private bool mSpecialBrick;

        //properties 
        public int Size
        {
            get { return mSize; }
            set { mSize = value; }
        }
        public Color FillColour
        {
            get { return mFillColour; }
            set { mFillColour = value; }
        }
        public Color BorderColour
        {
            get { return mBorderColour; }
            set { mBorderColour = value; }
        }
        public bool Matched
        {
            get { return mMatched; }
            set { mMatched = value; }
        }
        public bool SpecialBrick
        {
            get { return mSpecialBrick; }
            set { mSpecialBrick = value; }
        }

        //constructors 
        public Brick()
        {
            mSize = 25;
            mFillColour = Color.White;
            mBorderColour = Color.Black;
        }
        public Brick(int Size, Color FillColour, Color BorderColour, bool Matched)
        {
            mSize = Size;
            mFillColour = FillColour;
            mBorderColour = BorderColour;
            mMatched = Matched;
        }

        //methods
        public void Draw(Graphics g, int X, int Y)
        {
            //create Pen and Brush
            Pen BorderPen = new Pen(mBorderColour);
            SolidBrush BackBrush = new SolidBrush(mFillColour);

            //draw cell 
            g.FillRectangle(BackBrush, X, Y, mSize, mSize);
            g.DrawRectangle(BorderPen, X, Y, mSize, mSize);

            //dispose 
            BorderPen.Dispose();
            BackBrush.Dispose();

        }


    }
}
