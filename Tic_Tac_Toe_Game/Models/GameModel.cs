using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Tic_Tac_Toe_Game.Models.MoveTypes;
using Tic_Tac_Toe_Game.Utils;

namespace Tic_Tac_Toe_Game.Models
{
    /*
     * Acts as the central game model.
     * Implemented using the singleton design pattern.
     */
    internal class GameModel : IPublisher
    {
        private int[,] board; //1 means x, 0 means empty, -1 means 0.
        private AI_MoveType opponentMoveType;
        private LinkedList<ISubscriber> subscribers;
        
        private static GameModel gameModel;
        private static readonly Object syncLock = new Object();
        public static GameModel getGameModel()
        {
            if (gameModel == null)
            {
                lock (syncLock)
                {
                    if (gameModel == null)
                    {
                        gameModel = new GameModel(); //Ensures there should only ever be one GameModel
                    }
                }

            }
            return gameModel;
        }

        private void resetGame() {
            subscribers = new LinkedList<ISubscriber>();
            board = new int[3, 3];
            for (int i = 0; i < 3; i++) { 
                for (int j = 0; j < 3; j++)
                {
                    board[i, j] = 0;
                }
            }
            //opponentMoveType = [get something from controller]

            Player player1 = new Player(new Player_MoveType(), 1);
            Player player2 = new Player(opponentMoveType, 1);

            

        }

        public void addSubscriber(ISubscriber subscriber) {
            if (subscribers != null) { 
                subscribers.AddFirst(subscriber);
            }
        }
        public void removeSubscriber(ISubscriber subscriber) {
            if (subscribers != null) {
                subscribers.Remove(subscriber); 
            }
        }
        public void notifySubscribers() {
            foreach (ISubscriber subscriber in subscribers) {
                if (subscriber.isActive()) {
                    subscriber.update();
                }
            }
        }

        public int[,] getBoard() {
            return board;
        }

        private void setOpponentMoveType(AI_MoveType gMoveType) { 
            opponentMoveType = gMoveType;
        }
    }
}
