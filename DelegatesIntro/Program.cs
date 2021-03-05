using System;
using System.Collections.Generic;

namespace DelegatesIntro
{
    class Program
    {
        // Definition Delegates

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            #region data
            List<Car> carsList = new List<Car>()
            {
                new Car(){id=1,model="rio",brand="kia",year=2006,price=250000, color="red"},
                new Car(){id=2,model="rio",brand="kia",year=2007,price=265000,color="black"},
                new Car(){id=3,model="panda",brand="fiat",year=2017,price=265000,color="black"},
                new Car(){id=4,model="panda",brand="fiat",year=2017,price=365000,color="yellow"},
                new Car(){id=5,model="S40",brand="volvo",year=2018,price=665000,color="white"},
                new Car(){id=6,model="S65",brand="volvo",year=2018,price=600000,color="white"},
                new Car(){id=7,model="gorm",brand="ferrari",year=2000,price=4665000,color="white"},
                new Car(){id=8,model="knud",brand="ferrari",year=2019,price=4665000,color="white"},
            };
            #endregion data
            #region lambda udledes
            ////C#1.0 delegate type and delegate instance
            //FindModel fun1 = new FindModel(testing); // testing er en metode med den signatur

            ////C#2.0 method group conversion - Der kan være flere metoder
            //FindModel fun2 = testing; // flere metoder syntax : fun2 += testing2;

            ////C#2.0 generic delegate and anonymous method
            ////Func<string, int> fun3 = delegate (string text) { return text.Length; };
            //FindModel fun3 = delegate (Car myCar) { return myCar; };

            ////C#3.0 lamba expression
            //FindModel fun4 = (Car myCar) => { return myCar; };

            ////C#3.0 simple expression, no need braces
            //FindModel fun5 = (Car myCar) => myCar;
            ////C#3.0 let the compiler infer the parameter type
            //FindModel fun6 = (myCar) => myCar;
            ////C#3.0 no need unnecessary parentheses
            //FindModel fun7 = myCar => myCar;

            #endregion lambda udledes


            #region hente data fra en colleciton old school before LINQ and with LINQ
            #endregion

            #region 
            #endregion
            #region 
            #endregion
            #region 
            #endregion
            #region 
            #endregion
        }
        #region static methods addition, subtraction, divide, multiple and multi
        /* USE CASE
         * 
         */
        #endregion
        #region Opgavee
        /* Vi skal nu kode en lommeregner der benytter principperne for delegate
        * Vi kan benytte de 4 regnearter(addition, subtraction, divivde, multiple)
        * 1) Hvordan skriver vi et regnestykke på maskinen??
        * 2) vi kan fodre den med 2 faste tal, eller brugerindtasting.
        * 3) Hvordan kalder vi et regnestykke på maskinen??
        * 4) Kald nu et regnestykke med en delegate reference
        * 5) Kald nu et regnestykke med en delegate reference
        * 6) Du bør finde ud af...What the Fuck???
        * 7) Opret en metode, som har følgende parametre(delegate, int, int)
        * 8) Kald nu denne metode og se hvad der sker(kan være temmelig svært)
        * 9) Kald metoden med alle 4 regnearter, en adgangen.
        * 10) EKSTRA : Prøv at kalde metoden med alle 4 regnearter på en gang(multiple delegates)
        * 11) Tror du en delegate kan være i en form for struktur, således antallet af linjer
        * igen bliver minimeret?? JA.....
        * 12) Prøv at benytte den nye delegate struktur, på minimum 3 forskellige måder!!
        */
        #endregion 
    }
}
