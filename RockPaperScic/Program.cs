using System;
using System.Collections;
namespace RockPaperScic
{
    public class Player {
        ArrayList probs = new ArrayList();
        public Player(String[] hand_moves) {
            foreach (String move in hand_moves){
                probs.Add(move);
            }
        }
        public String hand_move() {
            Random rnd = new Random();
            int index = rnd.Next(probs.Count);
            String ret_str = probs[index].ToString();
            return ret_str;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            // Changeable Variables
            String[] a_moves = {"Paper"};
            String[] b_moves = { "Rock", "Scissors", "Paper" };
            int total_games = 100;


            // Code
            int a_wins = 0;
            int b_wins = 0;
            int draw = 0;
            
            Player pa = new Player(a_moves);
            Player pb = new Player(b_moves);
            for (int i = 0; i < total_games; i++) {
                String pa_move = pa.hand_move();
                String pb_move = pb.hand_move();
                switch (pb_move) {
                    case "Rock": b_wins += 1;break;
                    case "Paper": draw += 1;break;
                    case "Scissors": a_wins += 1;break;
                    default:break;
                }
                    
            }
            Console.WriteLine("Player A wins " + a_wins + " of " + total_games + " games.");
            Console.WriteLine("Player B wins " + b_wins + " of " + total_games + " games.");
            Console.WriteLine("Tie: " + draw + " of " + total_games + " games.");
        }
    }
}
