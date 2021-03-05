using System;
using System.Collections.Generic;
using System.Linq;

namespace DelegatesIntro
{
    class Program
    {
        // Definition Delegates
                       // returtype metodenavn(parameterType parameterNavn)
        public delegate Car FindModel(Car car); // delegate er en forskrift for en signatur / prototype
        // en delegate er en type
        public static Car c;

        // oprette en delegate som kan lægge 2 tal sammen
        public delegate int Calculate(int t1, int t2);
        public delegate string MyString(int s);
        //Func<int,int, int> hansOgGrethe ....
        //Func<int, string> navn
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
            Car cc = new Car();
            FindModel variabel = new FindModel(testing);
            // var1 er en delegate variabel
            FindModel var1 = testing; // svare til jeg skrev en metode her - signatur
            var1(cc); // Invoke signatur (kalder metoden testing) - testing(cc);
            testing(cc);
            int tal = 5;

            // Hvorfor - I kan kun se effekten i metoder

            //C#1.0 delegate type and delegate instance
            FindModel fun1 = new FindModel(testing); // testing er en metode med den signatur

            //C#2.0 method group conversion - Der kan være flere metoder
            FindModel fun2 = testing; // flere metoder syntax : fun2 += testing2;

            //C#2.0 generic delegate and anonymous method
            //Func<string, int> fun3 = delegate (string text) { return text.Length; };
            FindModel fun3 = delegate (Car myCar) { return myCar; };

            //C#3.0 lamba expression
            FindModel fun4 = (Car myCar) => { return myCar; };

            //C#3.0 simple expression, no need braces
            FindModel fun5 = (Car myCar) => myCar;
            //C#3.0 let the compiler infer the parameter type
            FindModel fun6 = (myCar) => myCar;
            //C#3.0 no need unnecessary parentheses
            FindModel fun7 = myCar => myCar;

            #endregion lambda udledes


            #region hente data fra en colleciton old school before LINQ and with LINQ
            List<Car> tempList = new List<Car>();
            foreach (Car obj in carsList)
            {
                if (obj.model == "rio")
                {
                    tempList.Add(obj);
                }
            }
            #endregion

            #region calculate
            Calculate cal1 = metode;
            Console.WriteLine(cal1(3, 6));
            cal1 = subtract;
            Console.WriteLine(cal1(3, 6));

            metode(3, 6); subtract(3, 6);
           // var linq1 = carsList.Where(x => x.model.All())
            //var linq2 = carsList.Where(x => x.model.Any())
            //var linq3 = carsList.Where(x => x.model.Distinct())
            //var linq12 = carsList.VoresMetode(511);
            int gg = 9;
            // invoke multi
            multi(metode, 3, 5);
            multi(subtract, 33, 11);
            multi(gange, 44, 5);
            multi(delegate (int t1, int t2) { return t1 / t2; }, 5,5);
            multi((int t1, int t2) => { return t1 + t2; }, 6, 12); // lambda udtryk
            multi((int t1, int t2) => { return t1 + t2; }, 6, 12);
            #endregion
            #region 
            #endregion
            #region 
            #endregion
            #region 
            #endregion
            Console.ReadKey();
        }
        #region static methods addition, subtraction, divide, multiple and multi
        /* USE CASE
         * 
         */
                    //Car FindModel(Car car);
        public static Car testing(Car c)
        {
            return new Car();
        }

        public static int metode(int t1, int t2)
        {
            return t1 + t2;
        }
        public static int subtract(int t1, int t2)
        {
            return t1 - t2;
        }

        public static int gange(int t1,int t2)
        {
            return 44;
        }

        //public static void multi(char tegn)
        //{
        //    if (tegn =='+')
        //    {
        //        // så blabla
        //    }
        //}

        // vi skal oprette en metode om 15 min
        // hvad skal der ske??
        // den skal vise resultatet af + - * mm
        // så skal vi fodre den med en parameter der fortæller om vi vil plus, minus, gange osv.
        // fodre den med en metode og 2 tal

        //public static void multi2(giv mig en adresse, int t1, int t2) { }
        public static void multi(Calculate calculate,int t1, int t2)
        {
            Console.WriteLine(calculate(t1,t2));
            //Console.WriteLine(subtract(12,24));
        }



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
