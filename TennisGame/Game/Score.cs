using System;
using System.Collections.Generic;

namespace Game
{
    /// <summary>
    /// Classe per il calcolo dello score
    /// </summary>
    public class Score
    {
        /// <summary>
        /// Dictionari che mi gestisce la definizione punteggio numerico -> "keyword"
        /// per i punteggi base
        /// </summary>
        private Dictionary<int, string> pointText = new Dictionary<int, string>
        {
            {0,"Love"},{1,"Fifteen"},{2,"Thirty"},{3,"Forty"}
        };

        /// <summary>
        /// Algoritmo calcolo punteggio
        /// </summary>
        /// <param name="pointA">punteggio player A</param>
        /// <param name="pointB">punteggio player B</param>
        /// <returns>restituisce un array con il punteggio del primo e del secondo giocatore</returns>
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
                    {
                        return new string[] { "Advantage", pointText[pointB] };
                    }
                    return new string[] { pointText[pointA], "Advantage" };
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
            return new string[] { pointText[pointA], pointText[pointB] };
        }

    }
}
