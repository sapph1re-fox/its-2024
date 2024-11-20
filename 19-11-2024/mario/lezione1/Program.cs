namespace Cs1
{
    class Program{
        //Metodo che restituisce un decimal preso in input da tastiera e restituisce errore in caso di input errato
        static decimal InputDouble(){
            bool flag=true;
            decimal input=0;
            do{
                if(!flag)
                Console.WriteLine("Input error, value not valid\ntry again");
                flag=decimal.TryParse(Console.ReadLine(), out input); //prende un input e controlla se è valido
            }while(!flag);
            return input;
        }

        //uguale a prima, ma stampa un output (passato quando chiami la funzione) prima di chiedere un input e non restituisce errori
        static decimal InputDouble(string output){
            bool flag=false;
            decimal input=0;
            do{
                Console.WriteLine(output);
                flag=decimal.TryParse(Console.ReadLine(), out input); //prende un input e controlla se è valido
            }while(!flag);
            return input;
        }

        //Metodo che calcola l'altezza di un triangolo
        static decimal Altezza(decimal area, decimal lato){
            return 2*area/lato;
        }

        //Metodo che calcola l'area di un triangolo
        static decimal Area(decimal lato, decimal altezza){
            return lato*altezza/2;
        }

        //Metodo che calcola il perimetro di un triangolo
        static decimal Perimetro(decimal lato1,decimal lato2, decimal lato3){
            return lato1+lato2+lato3;
        }

        //MAIN
        static void Main(string[] args){
            Console.ForegroundColor=ConsoleColor.Blue;   //Cambia il colore del testo nella console
            Console.BackgroundColor=ConsoleColor.Green;   //Cambia il colore dello sfondo nel terminale
            Console.WriteLine("TRIANGOLO");
            //bool flag=false;
            decimal area=0,altezza=0,lato=0,lato2=0,lato3=0;
            do{
                //Scelta della funzione desiderata
                Console.WriteLine("\n\nFUNZIONI DEL  PROGRAMMA:\nArea\nPerimetro\nAltezza\nEsci per uscire");
                switch(Console.ReadLine()?.ToLower()){     //'?' restituisce NULL invece di un messaggio di errore se viene inserito un valore vuoto in Input
                    case "esci":
                    case "uscita":
                    case "exit":
                        //Chiude il programma
                        //break;
                        return;
                    case "area":
                        //calcolo area del triangolo
                        lato=InputDouble("Inserisci la base del triangolo");
                        altezza=InputDouble("Inserisci l'altezza del triangolo");
                        Console.WriteLine("L'area del triangolo è: " + Math.Round(Area(lato,altezza),2));  //richiama il metodo per calcolare il risultato e arrotonda a 2 cifre decimali
                        Console.ReadKey();     //Normalmente prende in input una key, mentre qui è utilizzato per mettere in pausa il programma fino alla pressione di un tasto che non è obbligatoriamente INVIO
                        break;
                    case "perimetro":
                        //calcolo perimetro del triangolo
                        lato=InputDouble("Inserisci il lato 1 del triangolo");
                        lato2=InputDouble("Inserisci il lato 2 del triangolo");
                        lato3=InputDouble("Inserisci il lato 3 del triangolo");
                        Console.WriteLine("Il perimetro del triangolo è: " + Math.Round(Perimetro(lato,lato2,lato3),2));  //richiama il metodo per calcolare il risultato e arrotonda a 2 cifre decimali
                        Console.ReadKey();     //Normalmente prende in input una key, mentre qui è utilizzato per mettere in pausa il programma fino alla pressione di un tasto che non è obbligatoriamente INVIO                        
                        break;
                    case "altezza":
                        //calcolo altezza del triangolo
                        area=InputDouble("Inserisci l'area del triangolo");
                        lato=InputDouble("Inserisci la lunghezza della base del triangolo");
                        Console.WriteLine("L'altezza del triangolo è:" + Math.Round(Altezza(area,lato),2));  //richiama il metodo per calcolare il risultato e arrotonda a 2 cifre decimali
                        Console.ReadKey();     //Normalmente prende in input una key, mentre qui è utilizzato per mettere in pausa il programma fino alla pressione di un tasto che non è obbligatoriamente INVIO
                        break;
                    default:
                        //in caso di input non valido
                        Console.WriteLine("Funzione non valida");
                        Console.ReadKey();     //Normalmente prende in input una key, mentre qui è utilizzato per mettere in pausa il programma fino alla pressione di un tasto che non è obbligatoriamente INVIO                       
                        break;
                }
            }while(true/*!flag*/);
        }
    }
}


