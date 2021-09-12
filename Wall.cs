using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

//Kanyinsola Adejola
//Thursday Janurary 28, 2021
//The purpose of this code is to create a wall class with properties and actions in order to interact with main form and create a cash cow game 

namespace CashCow
{
    class Wall: frmMainGame
    {
        //fields
        private Brick[,] mWall;
        private int mRows;
        private int mColumns;
        private int mSize;
        private Color mBackColour;

        private int mCountSingleBrick;
        private bool mDoubleScore;
        private int mDoublePoints;
        private int mDoublePointsTrack;

        private int mCount;
        
        private int mCountTransparent0;
        private int mCountTransparent1;
        private int mCountTransparent2;
        private int mCountTransparent3;
        private int mCountTransparent4;
        private int mCountTransparent5;
        private int mCountTransparent6;
        private int mCountTransparent7;
        private int mCountTransparent8;
        private int mCountTransparent9;
        private int mCountTransparent10;
        private int mCountTransparent11;
        private int mCountTransparent12;
        private int mCountTransparent13;
        private int mCountTransparent14;
        private int mCountTransparent15;

        private int mBrickRow;
        private int mBrickColumn;
        private int mMatchedBricks;
        private int mCountFill = 0;

        private int mPoints;
        private int mScore;
        private bool mWandState;
        private int mTrack;
        private int mTileCount;
        private bool mCheckOutsideTiles = false;
        private bool mContinueGame = false;
        private int mOldHighScore;
        private int mCountAllTransparentBricks;
        private bool mEndGame;

        //properties
        public Color BackColour
        {
            get { return mBackColour; }
            set { mBackColour = value; }
        }
        public int CountSingleBrick
        {
            get { return mCountSingleBrick; }
            set { mCountSingleBrick = value; }
        }
        public bool DoubleScore
        {
            get { return mDoubleScore; }
            set { mDoubleScore = value; }
        }

        public int DoublePoints
        {
            get { return mDoublePoints; }
            set { mDoublePoints = value; }
        }
        public int DoublePointsTrack
        {
            get { return mDoublePointsTrack; }
            set { mDoublePointsTrack = value; }
        }
        public int Count
        {
            get { return mCount; }
            set { mCount = value; }
        }

        public int CountTransparent0
        {
            get { return mCountTransparent0; }
            set { mCountTransparent0 = value; }
        }
        public int CountTransparent1
        {
            get { return mCountTransparent1; }
            set { mCountTransparent1 = value; }
        }
        public int CountTransparent2
        {
            get { return mCountTransparent2; }
            set { mCountTransparent2 = value; }
        }
        public int CountTransparent3
        {
            get { return mCountTransparent3; }
            set { mCountTransparent3 = value; }
        }
        public int CountTransparent4
        {
            get { return mCountTransparent4; }
            set { mCountTransparent4 = value; }
        }
        public int CountTransparent5
        {
            get { return mCountTransparent5; }
            set { mCountTransparent5 = value; }
        }
        public int CountTransparent6
        {
            get { return mCountTransparent6; }
            set { mCountTransparent6 = value; }
        }
        public int CountTransparent7
        {
            get { return mCountTransparent7; }
            set { mCountTransparent7 = value; }
        }
        public int CountTransparent8
        {
            get { return mCountTransparent8; }
            set { mCountTransparent8 = value; }
        }
        public int CountTransparent9
        {
            get { return mCountTransparent9; }
            set { mCountTransparent9 = value; }
        }
        public int CountTransparent10
        {
            get { return mCountTransparent10; }
            set { mCountTransparent10 = value; }
        }
        public int CountTransparent11
        {
            get { return mCountTransparent11; }
            set { mCountTransparent11 = value; }
        }
        public int CountTransparent12
        {
            get { return mCountTransparent12; }
            set { mCountTransparent12 = value; }
        }
        public int CountTransparent13
        {
            get { return mCountTransparent13; }
            set { mCountTransparent13 = value; }
        }
        public int CountTransparent14
        {
            get { return mCountTransparent14; }
            set { mCountTransparent14 = value; }
        }
        public int CountTransparent15
        {
            get { return mCountTransparent15; }
            set { mCountTransparent15 = value; }
        }

        public int BrickRow
        {
            get { return mBrickRow; }
            set { mBrickRow = value; }
        }
        public int BrickColumn
        {
            get { return mBrickColumn; }
            set { mBrickColumn = value; }
        }
        public int MatchedBricks
        {
            get { return mMatchedBricks; }
            set { mMatchedBricks = value; }
        }
        public int Points
        {
            get { return mPoints; }
            set { mPoints = value; }
        }
        public int Score
        {
            get { return mScore; }
            set { mScore = value; }
        }
        public bool WandState
        {
            get { return mWandState; }
            set { mWandState = value; }
        }
        public int Track
        {
            get { return mTrack; }
            set { mTrack = value; }
        }
        public int TileCount
        {
            get { return mTileCount; }
            set { mTileCount = value; }
        }
        public bool CheckOutsideTiles
        {
            get { return mCheckOutsideTiles; }
            set { mCheckOutsideTiles = value; }
        }
        public int CountFill
        {
            get { return mCountFill; }
            set { mCountFill = value; }
        }
        public bool ContinueGame
        {
            get { return mContinueGame; }
            set { mContinueGame = value; }
        }
        public int OldHighScore
        {
            get { return mOldHighScore; }
            set { mOldHighScore = value; }
        }
        public int CountAllTransparentBricks
        {
            get { return mCountAllTransparentBricks; }
            set { mCountAllTransparentBricks = value; }
        }
        public bool EndGame
        {
            get { return mEndGame; }
            set { mEndGame = value; }
        }

        //constructors 
        public Wall(int Rows, int Columns)
        {
            Random Rand = new Random();
            Rand = new Random();

            int RandomRow = Rand.Next(0, 15);
            int RandomColumn = Rand.Next(0, 15);
            int BrickPlayStatus = Rand.Next(0, 2);

            mRows = Rows;
            mColumns = Columns;
            mWall = new Brick[mRows, mColumns];

            //create each cell in the grid 
            mSize = 25;
            for (int i = 0; i < mRows; i++)
            {
                for (int j = 0; j < mColumns; j++)
                {
                    if (i == 0 || i == 1 || i == 6 || i == 7)
                    {
                        mWall[i, j] = new Brick(mSize, Color.Red, Color.Black, false);
                    }
                    else if (i == 2 || i == 3 || i == 8 || i == 9)
                    {
                        mWall[i, j] = new Brick(mSize, Color.Green, Color.Black, false);
                    }
                    else if (i == 4 || i == 5 || i == 12 || i == 13)
                    {
                        mWall[i, j] = new Brick(mSize, Color.Yellow, Color.Black, false);
                    }
                    else if (i == 10 || i == 11 || i == 14 || i == 15)
                    {
                        mWall[i, j] = new Brick(mSize, Color.Blue, Color.Black, false);
                    }
                    //special brick 
                    if (i == RandomRow && j == RandomColumn)
                    {
                        if (BrickPlayStatus == 1)
                        {
                            mWall[i, j] = new Brick(24, Color.Blue, Color.Beige, false);
                            mWall[i, j].SpecialBrick = true;
                        }
                    }
                }
            }

        }

        //methods
        public Brick GetBrick(int RowIndex, int ColumnIndex)
        {
            return mWall[RowIndex, ColumnIndex];
        }

        public void Draw(Graphics g, int X, int Y)
        {
            //co-ordinate values for looping
            int pX = X;
            int pY = Y;

            for (int i = 0; i < mRows; i++)
            {
                for (int j = 0; j < mColumns; j++)
                {
                    mWall[i, j].Draw(g, pX, pY);
                    pX += mSize;
                }
                pX = X;
                pY += mSize;
            }
        }

        public (int R, int C) FirstBrickClick;
        public (int R, int C) SingleBrick;

        public void Shuffle()
        {
            //shuffle colours of squares
            Color Temp;
            Random Rand = new Random();
            Rand = new Random();

            int RandomRows = Rand.Next(0, mRows);
            int RandomColumns = Rand.Next(0, mColumns);

            for (int i = 0; i < mRows; i++)
            {
                for (int j = 0; j < mColumns; j++)
                {
                    Temp = mWall[i, j].FillColour;
                    mWall[i, j].FillColour = mWall[RandomRows, RandomColumns].FillColour;
                    mWall[RandomRows, RandomColumns].FillColour = Temp;
                }
            }
        }

        
        public void FloodBricks(int Column, int Row)
        {
            //destroy bricks around the brick clicked with the same colour recursively
            int Rows;
            int Columns;

            Rows = mRows;
            Columns = mColumns;

            if (mCountFill == 0)
                CheckOutsideTiles = false;

                if (FirstBrickClick.C > -1 && FirstBrickClick.C < Columns && FirstBrickClick.R > -1 && FirstBrickClick.R < Rows)
                    mBackColour = mWall[FirstBrickClick.R, FirstBrickClick.C].FillColour;
            

            if (Column > -1 && Column < Columns && Row > -1 && Row < Rows)
            {
                if (mWall[Row, Column].FillColour != Color.Transparent)
                {
                    //if wand is clicked/used
                    if (mWandState == true)
                    {
                        for (int i = 0; i < mRows; i++)
                        {
                            for (int j = 0; j < mColumns; j++)
                            {
                                if (i == Column && j == Row)
                                {
                                    SingleBrick.R = j;
                                    SingleBrick.C = i;
                                    mWall[j, i].FillColour = Color.Transparent;
                                    Count++;  
                                    break;
                                }
                                if (j == Row)
                                    break;
                            }
                            if (i == Column)
                                break;
                        }
                    }

                    //if wand is not used/clicked
                    else if (mWandState != true)
                    {
                        //recursion to destroy surrounding bricks if they have the same colour
                        if (mWall[Row, Column].FillColour == mBackColour)
                        {
                            if (Row > 0)
                            {
                                if (mWall[Row, Column].FillColour == BackColour || mWall[Row, Column].FillColour == Color.Transparent)
                                {
                                    if (mWall[Row, Column] != mWall[FirstBrickClick.R, FirstBrickClick.C])
                                    {
                                        mWall[Row, Column].FillColour = Color.Transparent;
                                        CheckOutsideTiles = true;
                                        mCountFill++;
                                    }
                                    FloodBricks(Column, Row - 1);
                                }
                                else
                                    return;

                            }

                            if (Column < Columns)
                            {
                                if (mWall[Row, Column].FillColour == mBackColour || mWall[Row, Column].FillColour == Color.Transparent)
                                {
                                    if (mWall[Row, Column] != mWall[FirstBrickClick.R, FirstBrickClick.C]/* && mWall[Row, Column].Matched != true*/)
                                    {
                                        mWall[Row, Column].FillColour = Color.Transparent;
                                        CheckOutsideTiles = true;
                                        mCountFill++;
                                    }
                                    FloodBricks(Column + 1, Row);
                                }
                                else
                                    return;
                            }

                            if (Row < Rows)
                            {
                                if (mWall[Row, Column].FillColour == mBackColour || mWall[Row, Column].FillColour == Color.Transparent)
                                {
                                    if (mWall[Row, Column] != mWall[FirstBrickClick.R, FirstBrickClick.C]/* && mWall[Row, Column].Matched != true*/)
                                    {
                                        mWall[Row, Column].FillColour = Color.Transparent;
                                        CheckOutsideTiles = true;
                                        mCountFill++;
                                    }
                                    FloodBricks(Column, Row + 1);
                                }
                                else
                                    return;
                            }

                            if (Column > 0)
                            {
                                if (mWall[Row, Column].FillColour == mBackColour || mWall[Row, Column].FillColour == Color.Transparent)
                                {
                                    if (mWall[Row, Column] != mWall[FirstBrickClick.R, FirstBrickClick.C]/* && mWall[Row, Column].Matched != true*/)
                                    {
                                        mWall[Row, Column].FillColour = Color.Transparent;
                                        CheckOutsideTiles = true;
                                        mCountFill++;
                                    }
                                    FloodBricks(Column - 1, Row);
                                }
                                else
                                    return;
                            }


                        }
                        else
                            return;

                    }
                    else
                        return;

                    mTrack++;

                    //make special brick go back to normal when clicked and used
                    if (mWall[Row, Column].SpecialBrick == true)
                    {
                        mWall[Row, Column].Size = 25;
                        mWall[Row, Column].BorderColour = Color.Black;
                        mDoubleScore = true;
                        mDoublePointsTrack++;
                    }
                }

            }

            //if wand was used, make wandstate false in order to continue game normally 
            if (mWandState == true)
                mWandState = false;
        }
        public void MakeBrickTransparent()
        {
            //if brick is selected should be transparent or not
            if (mCheckOutsideTiles == true && mWandState != true && mCountFill != 0)
            {
                //make transparent when other bricks are destroyed with it and it is not clicked using a wand
                mWall[FirstBrickClick.R, FirstBrickClick.C].FillColour = Color.Transparent;
            }
            else if (mCountFill == 0)
            {
                //don't make transparent, or count score
                mMatchedBricks--;
                return;
            }
        }

        public void TrackResizeWallBricks()
        {
            //tracking transparent bricks in each column
            for (int i = 0; i < mColumns; i++)
            {
                for (int j = 0; j < mRows; j++)
                {
                    if (i == 0)
                    {
                        if (mWall[j, i].FillColour == Color.Transparent)
                        {
                            mCountTransparent0++;
                        }
                    }
                    if (i == 1)
                    {
                        if (mWall[j, i].FillColour == Color.Transparent)
                        {
                            mCountTransparent1++;
                        }
                    }
                    if (i == 2)
                    {
                        if (mWall[j, i].FillColour == Color.Transparent)
                        {
                            mCountTransparent2++;
                        }
                    }
                    if (i == 3)
                    {
                        if (mWall[j, i].FillColour == Color.Transparent)
                        {
                            mCountTransparent3++;
                        }
                    }
                    if (i == 4)
                    {
                        if (mWall[j, i].FillColour == Color.Transparent)
                        {
                            mCountTransparent4++;
                        }
                    }
                    if (i == 5)
                    {
                        if (mWall[j, i].FillColour == Color.Transparent)
                        {
                            mCountTransparent5++;
                        }
                    }
                    if (i == 6)
                    {
                        if (mWall[j, i].FillColour == Color.Transparent)
                        {
                            mCountTransparent6++;
                        }
                    }
                    if (i == 7)
                    {
                        if (mWall[j, i].FillColour == Color.Transparent)
                        {
                            mCountTransparent7++;
                        }
                    }
                    if (i == 8)
                    {
                        if (mWall[j, i].FillColour == Color.Transparent)
                        {
                            mCountTransparent8++;
                        }
                    }
                    if (i == 9)
                    {
                        if (mWall[j, i].FillColour == Color.Transparent)
                        {
                            mCountTransparent9++;
                        }
                    }
                    if (i == 10)
                    {
                        if (mWall[j, i].FillColour == Color.Transparent)
                        {
                            mCountTransparent10++;
                        }
                    }
                    if (i == 11)
                    {
                        if (mWall[j, i].FillColour == Color.Transparent)
                        {
                            mCountTransparent11++;
                        }
                    }
                    if (i == 12)
                    {
                        if (mWall[j, i].FillColour == Color.Transparent)
                        {
                            mCountTransparent12++;
                        }
                    }
                    if (i == 13)
                    {
                        if (mWall[j, i].FillColour == Color.Transparent)
                        {
                            mCountTransparent13++;
                        }
                    }
                    if (i == 14)
                    {
                        if (mWall[j, i].FillColour == Color.Transparent)
                        {
                            mCountTransparent14++;
                        }
                    }
                    if (i == 15)
                    {
                        if (mWall[j, i].FillColour == Color.Transparent)
                        {
                            mCountTransparent15++;
                        }
                    }
                }
            }





        }
        public void ResizeWall()
        {
            //make the transparent squares go to the top to 'resize' the grid
            mBrickRow = -1;
            mBrickColumn = -1;
            mMatchedBricks = 0;
            
            for (int i = mColumns - 1; i >= 0; i--) //loop columns
            {
                mCount = 0;
                mBrickRow = -1;
                mBrickColumn = -1;
                
                                                                                                                                                                        
                for (int j = mRows - 1; j >= 0; j--)  //loop rows
                {
                    //keeping track of destoryed bricks 
                    if (mWall[j, i].FillColour == Color.Transparent)
                    {
                        mMatchedBricks++;
                    }
                    //single brick from wand use
                    if (mWall[j, i] == mWall[SingleBrick.R, SingleBrick.C])
                    {
                        mMatchedBricks++;
                        mPoints = mMatchedBricks * (mMatchedBricks + 10);
                        mScore = mPoints;
                        mWall[j + mCount, i].FillColour = mWall[j, i].FillColour;
                        
                    }

                    //column 1
                    if (i == 0)
                    {
                        //tracking matched/destroyed squares
                        if (mWall[j, i].FillColour == Color.Transparent)
                        {
                            mBrickRow = j;
                            mBrickColumn = i;
                            mCount++;
                        }

                        //making rest of bricks fall to replace the destroyed one
                        if (j < mBrickRow)
                        {
                            if (mWall[j, i].FillColour != Color.Transparent)
                            {
                                mWall[j + mCount, i].FillColour = mWall[j, i].FillColour;
                            }
                        }

                        //destroyed bricks go to the top of the wall
                        if (mBrickRow != -1 && mBrickColumn != -1)
                        {
                            if (j == mCountTransparent0 - 1)
                            {
                                mWall[j, i].FillColour = Color.Transparent;
                                mCountTransparent0--;
                                
                            }

                        }
                    }

                    //column 2
                    if (i == 1)
                    {
                        //tracking matched/destroyed squares
                        if (mWall[j, i].FillColour == Color.Transparent)
                        {
                            mBrickRow = j;
                            mBrickColumn = i;
                            mCount++;
                        }

                        //making rest of bricks fall to replace the destroyed one
                        if (j < mBrickRow)
                        {
                            if (mWall[j, i].FillColour != Color.Transparent)
                            {
                                mWall[j + mCount, i].FillColour = mWall[j, i].FillColour;
                            }
                        }

                        //destroyed bricks go to the top of the wall
                        if (mBrickRow != -1 && mBrickColumn != -1)
                        {
                            if (j == mCountTransparent1 - 1)
                            {
                                mWall[j, i].FillColour = Color.Transparent;
                                mCountTransparent1--;
                            }

                        }
                    }
                    //column 3
                    if (i == 2)
                    {
                        //tracking matched/destroyed squares
                        if (mWall[j, i].FillColour == Color.Transparent)
                        {
                            mBrickRow = j;
                            mBrickColumn = i;
                            mCount++;
                            
                        }

                        //making rest of bricks fall to replace the destroyed one
                        if (j < mBrickRow)
                        {
                            if (mWall[j, i].FillColour != Color.Transparent)
                            {
                                mWall[j + mCount, i].FillColour = mWall[j, i].FillColour;
                            }
                        }

                        //destroyed bricks go to the top of the wall
                        if (mBrickRow != -1 && mBrickColumn != -1)
                        {
                            if (j == mCountTransparent2 - 1)
                            {
                                mWall[j, i].FillColour = Color.Transparent;
                                mCountTransparent2--;
                            }

                        }
                    }
                    //column 4
                    if (i == 3)
                    {
                        //tracking matched/destroyed squares
                        if (mWall[j, i].FillColour == Color.Transparent)
                        {
                            mBrickRow = j;
                            mBrickColumn = i;
                            mCount++;
                        }

                        //making rest of bricks fall to replace the destroyed one
                        if (j < mBrickRow)
                        {
                            if (mWall[j, i].FillColour != Color.Transparent)
                            {
                                mWall[j + mCount, i].FillColour = mWall[j, i].FillColour;
                            }
                        }
                        //destroyed bricks go to the top of the wall
                        if (mBrickRow != -1 && mBrickColumn != -1)
                        {
                            if (j == mCountTransparent3 - 1)
                            {
                                mWall[j, i].FillColour = Color.Transparent;
                                mCountTransparent3--;
                            }

                        }
                    }
                    //column 5
                    if (i == 4)
                    {
                        //tracking matched/destroyed squares
                        if (mWall[j, i].FillColour == Color.Transparent)
                        {
                            mBrickRow = j;
                            mBrickColumn = i;
                            mCount++;
                        }
                        //making rest of bricks fall to replace the destroyed one
                        if (j < mBrickRow)
                        {
                            if (mWall[j, i].FillColour != Color.Transparent)
                            {
                                mWall[j + mCount, i].FillColour = mWall[j, i].FillColour;
                            }
                        }
                        //destroyed bricks go to the top of the wall
                        if (mBrickRow != -1 && mBrickColumn != -1)
                        {
                            if (j == mCountTransparent4 - 1)
                            {
                                mWall[j, i].FillColour = Color.Transparent;
                                mCountTransparent4--;
                            }

                        }
                    }
                    //column 6
                    if (i == 5)
                    {
                        //tracking matched/destroyed squares
                        if (mWall[j, i].FillColour == Color.Transparent)
                        {
                            mBrickRow = j;
                            mBrickColumn = i;
                            mCount++;
                        }
                        //making rest of bricks fall to replace the destroyed one
                        if (j < mBrickRow)
                        {
                            if (mWall[j, i].FillColour != Color.Transparent)
                            {
                                mWall[j + mCount, i].FillColour = mWall[j, i].FillColour;
                            }
                        }
                        //destroyed bricks go to the top of the wall
                        if (mBrickRow != -1 && mBrickColumn != -1)
                        {
                            if (j == mCountTransparent5 - 1)
                            {
                                mWall[j, i].FillColour = Color.Transparent;
                                mCountTransparent5--;
                            }

                        }
                    }
                    //column 7
                    if (i == 6)
                    {
                        //tracking matched/destroyed squares
                        if (mWall[j, i].FillColour == Color.Transparent)
                        {
                            mBrickRow = j;
                            mBrickColumn = i;
                            mCount++;
                        }
                        //making rest of bricks fall to replace the destroyed one
                        if (j < mBrickRow)
                        {
                            if (mWall[j, i].FillColour != Color.Transparent)
                            {
                                mWall[j + mCount, i].FillColour = mWall[j, i].FillColour;
                            }
                        }
                        //destroyed bricks go to the top of the wall
                        if (mBrickRow != -1 && mBrickColumn != -1)
                        {
                            if (j == mCountTransparent6 - 1)
                            {
                                mWall[j, i].FillColour = Color.Transparent;
                                mCountTransparent6--;
                            }

                        }
                    }
                    //column 8
                    if (i == 7)
                    {
                        //tracking matched/destroyed squares
                        if (mWall[j, i].FillColour == Color.Transparent)
                        {
                            mBrickRow = j;
                            mBrickColumn = i;
                            mCount++;
                        }
                        //making rest of bricks fall to replace the destroyed one
                        if (j < mBrickRow)
                        {
                            if (mWall[j, i].FillColour != Color.Transparent)
                            {
                                mWall[j + mCount, i].FillColour = mWall[j, i].FillColour;
                            }
                        }
                        //destroyed bricks go to the top of the wall
                        if (mBrickRow != -1 && mBrickColumn != -1)
                        {
                            if (j == mCountTransparent7 - 1)
                            {
                                mWall[j, i].FillColour = Color.Transparent;
                                mCountTransparent7--;
                            }

                        }
                    }
                    //column 9
                    if (i == 8)
                    {
                        //tracking matched/destroyed squares
                        if (mWall[j, i].FillColour == Color.Transparent)
                        {
                            mBrickRow = j;
                            mBrickColumn = i;
                            mCount++;
                        }
                        //making rest of bricks fall to replace the destroyed one
                        if (j < mBrickRow)
                        {
                            if (mWall[j, i].FillColour != Color.Transparent)
                            {
                                mWall[j + mCount, i].FillColour = mWall[j, i].FillColour;
                            }
                        }
                        //destroyed bricks go to the top of the wall
                        if (mBrickRow != -1 && mBrickColumn != -1)
                        {
                            if (j == mCountTransparent8 - 1)
                            {
                                mWall[j, i].FillColour = Color.Transparent;
                                mCountTransparent8--;
                            }

                        }
                    }
                    //column 10
                    if (i == 9)
                    {
                        //tracking matched/destroyed squares
                        if (mWall[j, i].FillColour == Color.Transparent)
                        {
                            mBrickRow = j;
                            mBrickColumn = i;
                            mCount++;
                        }
                        //making rest of bricks fall to replace the destroyed one
                        if (j < mBrickRow)
                        {
                            if (mWall[j, i].FillColour != Color.Transparent)
                            {
                                mWall[j + mCount, i].FillColour = mWall[j, i].FillColour;
                            }
                        }
                        //destroyed bricks go to the top of the wall
                        if (mBrickRow != -1 && mBrickColumn != -1)
                        {
                            if (j == mCountTransparent9 - 1)
                            {
                                mWall[j, i].FillColour = Color.Transparent;
                                mCountTransparent9--;
                            }

                        }
                    }
                    //column 11
                    if (i == 10)
                    {
                        //tracking matched/destroyed squares
                        if (mWall[j, i].FillColour == Color.Transparent)
                        {
                            mBrickRow = j;
                            mBrickColumn = i;
                            mCount++;
                        }
                        //making rest of bricks fall to replace the destroyed one
                        if (j < mBrickRow)
                        {
                            if (mWall[j, i].FillColour != Color.Transparent)
                            {
                                mWall[j + mCount, i].FillColour = mWall[j, i].FillColour;
                            }
                        }
                        //destroyed bricks go to the top of the wall
                        if (mBrickRow != -1 && mBrickColumn != -1)
                        {
                            if (j == mCountTransparent10 - 1)
                            {
                                mWall[j, i].FillColour = Color.Transparent;
                                mCountTransparent10--;
                            }

                        }
                    }
                    //column 12
                    if (i == 11)
                    {
                        //tracking matched/destroyed squares
                        if (mWall[j, i].FillColour == Color.Transparent)
                        {
                            mBrickRow = j;
                            mBrickColumn = i;
                            mCount++;
                        }
                        //making rest of bricks fall to replace the destroyed one
                        if (j < mBrickRow)
                        {
                            if (mWall[j, i].FillColour != Color.Transparent)
                            {
                                mWall[j + mCount, i].FillColour = mWall[j, i].FillColour;
                            }
                        }
                        //destroyed bricks go to the top of the wall
                        if (mBrickRow != -1 && mBrickColumn != -1)
                        {
                            if (j == mCountTransparent11 - 1)
                            {
                                mWall[j, i].FillColour = Color.Transparent;
                                mCountTransparent11--;
                            }

                        }
                    }
                    //column 13
                    if (i == 12)
                    {
                        //tracking matched/destroyed squares
                        if (mWall[j, i].FillColour == Color.Transparent)
                        {
                            mBrickRow = j;
                            mBrickColumn = i;
                            mCount++;
                        }
                        //making rest of bricks fall to replace the destroyed one
                        if (j < mBrickRow)
                        {
                            if (mWall[j, i].FillColour != Color.Transparent)
                            {
                                mWall[j + mCount, i].FillColour = mWall[j, i].FillColour;
                            }
                        }
                        //destroyed bricks go to the top of the wall
                        if (mBrickRow != -1 && mBrickColumn != -1)
                        {
                            if (j == mCountTransparent12 - 1)
                            {
                                mWall[j, i].FillColour = Color.Transparent;
                                mCountTransparent12--;
                            }

                        }
                    }
                    //column 14
                    if (i == 13)
                    {
                        //tracking matched/destroyed squares
                        if (mWall[j, i].FillColour == Color.Transparent)
                        {
                            mBrickRow = j;
                            mBrickColumn = i;
                            mCount++;
                        }
                        //making rest of bricks fall to replace the destroyed one
                        if (j < mBrickRow)
                        {
                            if (mWall[j, i].FillColour != Color.Transparent)
                            {
                                mWall[j + mCount, i].FillColour = mWall[j, i].FillColour;
                            }
                        }
                        //destroyed bricks go to the top of the wall
                        if (mBrickRow != -1 && mBrickColumn != -1)
                        {
                            if (j == mCountTransparent13 - 1)
                            {
                                mWall[j, i].FillColour = Color.Transparent;
                                mCountTransparent13--;
                            }

                        }
                    }
                    //column 15
                    if (i == 14)
                    {
                        //tracking matched/destroyed squares
                        if (mWall[j, i].FillColour == Color.Transparent)
                        {
                            mBrickRow = j;
                            mBrickColumn = i;
                            mCount++;
                        }
                        //making rest of bricks fall to replace the destroyed one
                        if (j < mBrickRow)
                        {
                            if (mWall[j, i].FillColour != Color.Transparent)
                            {
                                mWall[j + mCount, i].FillColour = mWall[j, i].FillColour;
                            }
                            
                        }
                        //destroyed bricks go to the top of the wall
                        if (mBrickRow != -1 && mBrickColumn != -1)
                        {
                            if (j == mCountTransparent14 - 1)
                            {
                                mWall[j, i].FillColour = Color.Transparent;
                                mCountTransparent14--;
                            }

                        }
                        

                    }
                    //column 16
                    if (i == 15)
                    {
                        //tracking matched/destroyed squares
                        if (mWall[j, i].FillColour == Color.Transparent)
                        {
                            mBrickRow = j;
                            mBrickColumn = i;
                            mCount++;
                        }
                        //making rest of bricks fall to replace the destroyed one
                        if (j < mBrickRow)
                        {
                            if (mWall[j, i].FillColour != Color.Transparent)
                            {
                                mWall[j + mCount, i].FillColour = mWall[j, i].FillColour;
                            }
                        }
                        //destroyed bricks go to the top of the wall
                        if (mBrickRow != -1 && mBrickColumn != -1)
                        {
                            if (j == mCountTransparent15 - 1)
                            {
                                mWall[j, i].FillColour = Color.Transparent;
                                mCountTransparent15--;
                            }

                        }

                    }


                }
            }
        }
        

        public void ScoreUpdate()
        {
            //Calculate Points = n * (n + 10) for each brick destroyed
            mMatchedBricks = MatchedBricks - 1;

            mPoints = mMatchedBricks * (mMatchedBricks + 10);
            mScore = mPoints;

            //double points if special brick is clicked
            if (mDoubleScore == true && mDoublePointsTrack > 0)
            {
                mDoublePoints = mPoints * 2;
                mScore = mDoublePoints;
                mDoubleScore = false;
                mDoublePointsTrack = 1;
            }
            //leave the double points and continue adding to the score
            else if (mDoublePointsTrack == 1)
            {
                mPoints = mDoublePoints + mMatchedBricks * (mMatchedBricks + 10);
                mScore = mPoints;
            }
            //continue game score
            if (mContinueGame == true)
            {
                mScore = OldHighScore + mScore;
            }

        }

        public void TrackingGame()
        {
            //keeping track of the resizing of the grid, and how many bricks were transparent 
            mCountAllTransparentBricks = 256;

            for (int i = 0; i < mRows; i++)
            {
                for (int j = 0; j < mColumns; j++)
                {
                    if (mWall[i, j].FillColour == Color.Transparent)
                    {
                        mCountAllTransparentBricks--;
                    }
                }
            }

        }

        public void CheckForNoMatches()
        {
            //check if no more matches can be made
            if (mWall[FirstBrickClick.R, FirstBrickClick.C].Matched == false && mCountFill == 0)
            {
                EndGame = true;
            }
        }

    }
}
