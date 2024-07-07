using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Tic_Tac_Toe_Game.Models.MoveTypes;
using Tic_Tac_Toe_Game.Utils;
using Tic_Tac_Toe_Game.Views;

namespace Tic_Tac_Toe_Game.Models
{
    /*
     * Acts as the central game model.
     * Implemented using the singleton design pattern.
     */
    public class GameModel : IPublisher
    {
        private int[,] board; //1 means x, 0 means empty, -1 means 0.
        private int[,] winloss;
        private int turn;
        private AI_MoveType opponentMoveType;
        private LinkedList<ISubscriber> subscribers;
        private int computerDelay;
        private int computerCounter;
        Player player2;
        GameScreen gameScreen;


        private static GameModel gameModel;
        private static readonly Object syncLock = new Object();

        private GameModel() {
            winloss = new int[3, 3];
            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 3; j++)
                {
                    winloss[i, j] = 0;
                }
            }
            opponentMoveType = new MediumAI_MoveType();
            computerDelay = 10;

        }
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

        public int[,] getRecords() {
            return winloss;
        }

        public void setGameScreen(GameScreen gs) {
            gameScreen = gs;
        }

        public void resetGame() {
            subscribers = new LinkedList<ISubscriber>();
            computerCounter = -1;
            board = new int[3, 3];
            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 3; j++)
                {
                    board[i, j] = 0;
                }
            }
            turn = 1;
            if (gameScreen != null) {
                gameScreen.updateGrid(board, turn);
            }

            Player player1 = new Player(new Player_MoveType(), 1);
            player2 = new ComputerPlayer(opponentMoveType, 0, computerDelay);
            //subscribers.AddLast(player2);


        }

        public Boolean winSequence() {
            int outcome = HardAI_MoveType.checkBoard(board, 1);
            if (outcome != 0 || turn > 9)
            {
                int ai_ID = opponentMoveType.getID();
                //temporary game end sequence
                if (outcome == 0)
                {
                    winloss[ai_ID, 1] += 1;
                    gameScreen.endGameDefaults("You Drew!");
                }
                else if (outcome == 1)
                {
                    winloss[ai_ID, 0] += 1;
                    gameScreen.endGameDefaults("You Won!");

                }
                else
                {
                    winloss[ai_ID, 2] += 1;
                    gameScreen.endGameDefaults("You Lost!");
                }

                //resetGame();
                return true;
            }
            return false;
        }

        public Boolean tryBoardPosition(Move boardPos) {
            if (board[boardPos.row, boardPos.col] == 0) {
                board[boardPos.row, boardPos.col] = (turn % 2 == 1) ? 1 : -1;
                gameScreen.updateGrid(board, ++turn);
                gameScreen.updateTurnLabel(turn);
                //player2.setActive(true);
                if (winSequence()) {
                    return true;
                }

                if (turn < 9) {
                    computerCounter = computerDelay;
                }
                
                return true;
            } 
            return false;
        }

        public void updateTick() {
            if (computerCounter > 0)
            {
                computerCounter -= 1;
            }
            else if (computerCounter == 0) {
                computerCounter = -1;
                Move cMove = opponentMoveType.getMove(board, turn);
                board[cMove.row, cMove.col] = -1;
                gameScreen.updateGrid(board, ++turn);
                gameScreen.updateTurnLabel(turn);
                winSequence();
            }
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

        public void setOpponentMoveType(AI_MoveType gMoveType, int compDelay) { 
            opponentMoveType = gMoveType;
            computerDelay = compDelay;
        }
    }
}
