// 


using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Un semplice calcolatore
             * Realizzare un programma che chiede all'utente che tipo di operazione intende
             * svolgere (0-somma, 1-prodotto, 2-divisione, 3-sottrazione, 4-quadrato, 5-media)
             * e poi se somma, prodotto, divisione o sottrazione chiede due valori, se quadrato 
             * chiede un solo valore e se media chiede 10 valori.
             * Utilizzare un vettore di interi o reali (a vostra scelta) per archiviare i valori di input
             * Opzionale:  implementare l'operazione di elevamento a potenza superiore al 2.
             * */

            string[] ArrayOperation = new string[] { "Somma", "Sottrazione", "Prodotto", "Divisione", "Quadrato", "Media" };
            Console.Write("Comando [0-add, 1-sub, 2-mul, 3-div, 4-square, 5-avg]: ");
            string cmd = Console.ReadLine();
            switch (cmd)
            {
                case "0":
                    {
                        Console.WriteLine("Operazione richiesta: {0}", ArrayOperation[Convert.ToInt32(cmd)]);

                        Console.Write("Inserisci due numeri, separati da spazio: ");
                        string sNumero = Console.ReadLine();

                        string[] svecto = sNumero.Split(' ');
                        double sum = 0.0;

                        foreach (string snum in svecto)
                        {
                            double nume;
                            if (double.TryParse(snum, out nume))
                            {
                                sum += nume;
                            }
                        }

                        Console.WriteLine("La somma dei numeri forniti è: {0}", sum);


                        break;
                    }
                case "1":
                    {
                        Console.WriteLine("Operazione richiesta: {0}", ArrayOperation[Convert.ToInt32(cmd)]);

                        Console.Write("Inserisci due numeri, separati da spazio: ");
                        string sNumber = Console.ReadLine();

                        string[] svector = sNumber.Split(' ');
                        double dif = 0.0;

                        double num1 = Convert.ToDouble(svector[0]);
                        double num2 = Convert.ToDouble(svector[1]);

                        dif = num1 - num2;

                        Console.WriteLine("La differenza dei numeri forniti è: {0}", dif);

                        break;
                    }
                case "2":
                    {
                        Console.WriteLine("Operazione richiesta: {0}", ArrayOperation[Convert.ToInt32(cmd)]);


                        Console.Write("Inserisci due numeri, separati da spazio: ");
                        string sNumbers = Console.ReadLine();

                        string[] svectors = sNumbers.Split(' ');
                        double mul = 0.0;

                        double num1 = Convert.ToDouble(svectors[0]);
                        double num2 = Convert.ToDouble(svectors[1]);

                        mul = num1 * num2;

                        Console.WriteLine("Il prodotto dei numeri forniti è: {0}", mul);
                        break;
                    }
                case "3":
                    {
                        Console.WriteLine("Operazione richiesta: {0}", ArrayOperation[Convert.ToInt32(cmd)]);


                        Console.Write("Inserisci due numeri, separati da spazio: ");
                        string sNumbero = Console.ReadLine();

                        string[] sVecto = sNumbero.Split(' ');
                        double div = 0.0;

                        double dNum1 = Convert.ToDouble(sVecto[0]);
                        double dNum2 = Convert.ToDouble(sVecto[1]);

                        div = dNum1 / dNum2;

                        Console.WriteLine("il quoziente dei numeri forniti è: {0}", div);
                        break;
                    }
                case "4":
                    {
                        Console.WriteLine("Operazione richiesta: {0}", ArrayOperation[Convert.ToInt32(cmd)]);

                        Console.Write("Inserire il numero di cui vuoi fare il quadrato: ");
                        string choise = Console.ReadLine();

                        double quadrato = 0.0;
                        double numero = 0;
                        if (double.TryParse(choise, out numero))
                        {
                            quadrato = numero * numero;
                        }

                        Console.WriteLine("Il quadrato e: {0}", quadrato);
                        break;
                    }
                case "5":
                    {
                        Console.WriteLine("Operazione richiesta: {0}", ArrayOperation[Convert.ToInt32(cmd)]);
                        Console.Write("Inserisci l'elenco dei numeri di cui intendi calcolare la media, separati da spazi vuoti, tutti sulla stessa riga: ");
                        string sNumeri = Console.ReadLine();
                        if (sNumeri == null)
                        {
                            Console.WriteLine("Non hai fornito numeri!!");
                            Environment.Exit(0);
                        }
                        string[] svect = sNumeri.Split(' ');
                        double media = 0.0;
                        int quanti = 0;
                        foreach (string snum in svect)
                        {
                            double num;
                            if (double.TryParse(snum, out num))
                            {
                                media += num;
                                quanti++;
                            }
                        }
                        media /= quanti;  //media = media / quanti
                        Console.WriteLine("La media dei numeri forniti è: {0}", media);

                        break;
                    }
                default:
                    Console.WriteLine("Richiestao comando non esistente: {0}.", cmd);
                    break;
            }
            
        }
    }
}
