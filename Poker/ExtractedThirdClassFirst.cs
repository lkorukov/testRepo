using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    class ExtractedThirdClassFirst
    {
        #region Variables
        ProgressBar asd = new ProgressBar();
        public int Nm;
        Panel pPanel = new Panel(); Panel b1Panel = new Panel(); Panel b2Panel = new Panel(); Panel b3Panel = new Panel();
        Panel b4Panel = new Panel(); Panel b5Panel = new Panel();
        int call = 500, foldedPlayers = 5;
        public int Chips = 10000, bot1Chips = 10000, bot2Chips = 10000, bot3Chips = 10000, bot4Chips = 10000, bot5Chips = 10000;
        double type, rounds = 0, b1Power, b2Power, b3Power, b4Power, b5Power, pPower = 0, pType = -1, Raise = 0,
        b1Type = -1, b2Type = -1, b3Type = -1, b4Type = -1, b5Type = -1;
        bool B1turn = false, B2turn = false, B3turn = false, B4turn = false, B5turn = false;
        bool B1Fturn = false, B2Fturn = false, B3Fturn = false, B4Fturn = false, B5Fturn = false;
        bool pFolded, b1Folded, b2Folded, b3Folded, b4Folded, b5Folded, intsadded, changed;
        int pCall = 0, b1Call = 0, b2Call = 0, b3Call = 0, b4Call = 0, b5Call = 0, pRaise = 0, b1Raise = 0, b2Raise = 0, b3Raise = 0, b4Raise = 0, b5Raise = 0;
        int height, width, winners = 0, Flop = 1, Turn = 2, River = 3, End = 4, maxLeft = 6;
        int last = 123, raisedTurn = 1;
        List<bool?> bools = new List<bool?>();
        List<Type> Win = new List<Type>();
        List<string> CheckWinners = new List<string>();
        List<int> ints = new List<int>();
        bool PFturn = false, Pturn = true, restart = false, raising = false;
        Poker.Type sorted;
        string[] ImgLocation = Directory.GetFiles("Assets\\Cards", "*.png", SearchOption.TopDirectoryOnly);
        /*string[] ImgLocation ={
                   "Assets\\Cards\\33.png","Assets\\Cards\\22.png",
                    "Assets\\Cards\\29.png","Assets\\Cards\\21.png",
                    "Assets\\Cards\\36.png","Assets\\Cards\\17.png",
                    "Assets\\Cards\\40.png","Assets\\Cards\\16.png",
                    "Assets\\Cards\\5.png","Assets\\Cards\\47.png",
                    "Assets\\Cards\\37.png","Assets\\Cards\\13.png",
                    
                    "Assets\\Cards\\12.png",
                    "Assets\\Cards\\8.png","Assets\\Cards\\18.png",
                    "Assets\\Cards\\15.png","Assets\\Cards\\27.png"};*/
        int[] Reserve = new int[17];
        Image[] Deck = new Image[52];
        PictureBox[] Holder = new PictureBox[52];
        Timer timer = new Timer();
        Timer Updates = new Timer();
        int t = 60, i, bb = 500, sb = 250, up = 10000000, turnCount = 0;
        #endregion
    }
}
