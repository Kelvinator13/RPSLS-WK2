using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigBangGame
{
    class HumanClass : PlayerClass
    {
        //member variables (has a relationship/ 
        public int humanNumber;
        public string moveChoosen;



        //Constructor  (Spawna/creator)
        public Human()
        {
            this.playScore = 0;
        }
        //player may select move for submission too compare method.

     
        public virtual void ChooseMove()
        {
            for (int i = 0; i < moveList.Count; i++)
            {
                Console.WriteLine(moveList[i].moveType);
            }
            Console.Write("Select your gestured move using 1-5: ");
            selectedHumanMove = Convert.ToBoolean(Console.ReadLine());
            switch (selectedHumanMove)
            {
            playerMove = moveList[0];
            break;
            playerMove = moveList[1];
            break;
            playerMove = moveList[0];
            break;
            playerMove = moveList[0];
            break;
            playerMove = moveList[0];
            break;

            // Default statement
            Console.WriteLine("The value selected is invalid. ")

                chooseMove();
            break;

        }

        }
        public virtual void MoveChoosen()
        {

        }

    }

}
