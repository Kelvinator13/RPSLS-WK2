using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigBangGame
{
    class ComputerClass : PlayerClass
    {

        //member variables (has a relationship/ 
        int randomNumber;

        Random randomSelector = new Random();



        //Constructor  (Spawna/creator)

            public Computer()
        {

        }
        //Artificial Intelligence picking random number as well as choosing gesture move

        public virtual void ChooseMove()
        {
            randomNumber = randomSelection.Next(1, 5);
            switch (randomNumber)
            {
                playerMove = moveList[0];
            break;
            }
            playerMove = moveList[1];
            break;
            playerMove = moveList[2];
            break;
            playerMove = moveList[3];
            break;
            playerMove = moveList[4];
            break;

            //insert default statement
            Console.WriteLine(" Your Selection is invalid,");

            ChooseMove();
           

        }



        //Member Method (Can do)


        public virtual void MoveChoosen()
        {

        }
    }
}
