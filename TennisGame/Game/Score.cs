using System;

namespace Game
{
    public class Score
    {
        public string[] GetResult(int pointA, int pointB)
        {
            var result = new string[] { string.Empty, string.Empty };
            //caso Deuce e Advantage:
            //giocatore 1 ha almeno 3 punti
            //giocatore 2 ha almeno 3 punti
            if (pointA >= 3 && pointB >= 3)
            {
                //i punteggi sono uguali
                if (pointA == pointB)
                {
                    return new string[] { "Deuce", "Deuce" };
                }
                else if (Math.Abs(pointA - pointB) == 1)
                {
                    //la differenza è di un solo punto Advantage
                    if (pointA > pointB)
                        return new string[] { "Advantage", pointToText(pointB) };
                    return new string[] { pointToText(pointA), "Advantage" };
                }
            }
            // se il punteggio è almeno di 4 e si distanziano di 2 punti allora
            // uno dei due è vincitore
            if ((pointA >= 4 || pointB >= 4) && Math.Abs(pointA - pointB) >= 2)
            {
                if (pointA > pointB)
                    return new string[] { "Winner", "Loser" };
                return new string[] { "Loser", "Winner" };
            }

            //se non è nessuno dei casi precedenti allora è un punteggio base
            return new string[] { pointToText(pointA), pointToText(pointB) };
        }

        private string pointToText(int point)
        {
            switch (point)
            {
                case 1:
                    return "Fifteen";
                case 0:
                    return "Love";
                case 2:
                    return "Thirty";
                case 3:
                    return "Forty";
                default:
                    return "Winner";
            }
        }
    }
}
