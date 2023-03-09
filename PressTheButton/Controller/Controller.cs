using System;
using System.Collections.Generic;
using System.Text;

namespace PressTheButton.Controller
{
    class Controller
    {
        int score = 0;
        int x = 365;
        int y = 180;
        int moveSpeedX = 2;
        int untilSpeedIncreaseX = 10;
        bool moveX = false;
        int moveSpeedY = 2;
        int untilSpeedIncreaseY = 30;
        bool moveY = false;

        public int Score { get => score; set => score = value; }
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }

        public void UpdateStuffAlways()
        {
            if (Score >= 5)
            {
                ButtonMoveXLogic();
            }
            if (Score >= 25)
            {
                ButtonMoveYLogic();
            }
            if (Score >= untilSpeedIncreaseX && Score <= 25)
            {
                untilSpeedIncreaseX += 5;
                moveSpeedX += 2;
            }
            else if (Score >= untilSpeedIncreaseY && Score <= 50)
            {
                untilSpeedIncreaseY += 5;
                moveSpeedY += 2;
            }
        }
        private void ButtonMoveXLogic()
        {
            if (X <= 0)
            {
                moveX = false;
            }
            else if (X >= 700)
            {
                moveX = true;
            }
            if (!moveX)
            {
                MoveButtonRight(moveSpeedX);
            }
            else if (moveX)
            {
                MoveButtonLeft(moveSpeedX);
            }
        }

        private void ButtonMoveYLogic()
        {
            if (Y <= 0)
            {
                moveY = false;
            }
            else if (Y >= 350)
            {
                moveY = true;
            }
            if (!moveY)
            {
                MoveButtonDown(moveSpeedY);
            }
            else if (moveY)
            {
                MoveButtonUp(moveSpeedY);
            }
        }

        private void MoveButtonRight(int amount)
        {
            X += amount;
        }

        private void MoveButtonLeft(int amount)
        {
            X -= amount;
        }

        private void MoveButtonUp(int amount)
        {
            Y -= amount;
        }

        private void MoveButtonDown(int amount)
        {
            Y += amount;
        }
    }
}

