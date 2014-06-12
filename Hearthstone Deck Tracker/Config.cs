﻿using System.Collections.Generic;
using System.Xml.Serialization;

namespace Hearthstone_Deck_Tracker
{
    public class Config
    {
        [XmlIgnore]
        public readonly string ConfigPath = "config.xml";

        public string LastDeck = "";
        public bool HideInBackground = false;
        public bool HideInMenu = false;
        public bool HideEnemyCards = false;
        public bool HideEnemyCardCount = false;
        public bool HidePlayerCardCount = false;
        public bool HideDrawChances = false;
        public bool HideOverlay = false;
        public int WindowHeight = 672;
        public string HearthstoneDirectory = "";
        public bool ShowInTaskbar = false;
        public bool HighlightCardsInHand = false;
        public int OffsetX = 0;
        public int OffsetY = 0;
        public int CustomWidth = -1;
        public int CustomHeight = -1;
        public bool VisibleOverlay = false;
        public int PlayerWindowHeight = 0;
        public int OpponentWindowHeight = 0;
        public bool WindowsTopmost = false;
        public string WindowsBackgroundHex = "";
        public int UpdateDelay = 100;
        public double PlayerDeckTop = 17;
        public double PlayerDeckHeight = 65;
        public double OpponentDeckHeight = 65;
        public double OpponentDeckTop = 17;
        public double PlayerDeckLeft = 99.5;
        public double OpponentDeckLeft = 0.5;
        public double OverlayOpacity = 100;
        public bool KeepDecksVisible = true;
        public bool MinimizeToTray = false;
        public double TimerLeft = 75;
        public bool ShowAllDecks = false;

        [XmlArray(ElementName = "SelectedTags")]
        [XmlArrayItem(ElementName = "Tag")]
        public List<string> SelectedTags = new List<string>() { "All" };
    }
}