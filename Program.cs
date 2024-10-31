using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace FM_Chmiel
{
    // Abstraktní třída Zvire s metodami a vlastnostmi, které budou společné pro všechna zvířata
    public abstract class Zvire
    {
        public string druhy { get; protected set; }
        public int veky { get; set; }

        // Konstruktor pro nastavení druhu zvířete a věku
        public Zvire(string druh, int vek)
        {
            druhy = druh;
            veky = vek;
        }

        // Abstraktní metoda pro vydávání zvuku
        public abstract void VydatZvuk();
    }

    // Třída Pes
    public class Pes : Zvire
    {
        public Pes(int vek) : base("Pes", vek) { }

        public override void VydatZvuk()
        {
            Console.WriteLine("Haf");
            Console.WriteLine("Vrrr");
        }
    }

    // Třída Kocka
    public class Kocka : Zvire
    {
        public Kocka(int vek) : base("Kočka", vek) { }

        public override void VydatZvuk()
        {
            Console.WriteLine("Mňau");
            Console.WriteLine("Práá");
        }
    }

    // Třída Krava
    public class Krava : Zvire
    {
        public Krava(int vek) : base("Krava", vek) { }

        public override void VydatZvuk()
        {
            Console.WriteLine("Múú");
            Console.WriteLine("Búú");
        }
    }

    // Třída Kun
    public class Kun : Zvire
    {
        public Kun(int vek) : base("Kůň", vek) { }

        public override void VydatZvuk()
        {
            Console.WriteLine("Řehé");
            Console.WriteLine("Frknutí");
        }
    }

    // Třída Ovecka
    public class Ovecka : Zvire
    {
        public Ovecka(int vek) : base("Ovečka", vek) { }

        public override void VydatZvuk()
        {
            Console.WriteLine("Béé");
            Console.WriteLine("Méé");
        }
    }

    // Třída Prase
    public class Prase : Zvire
    {
        public Prase(int vek) : base("Prase", vek) { }

        public override void VydatZvuk()
        {
            Console.WriteLine("Chrochro");
            Console.WriteLine("Kvik");
        }
    }

    // Třída Kralik
    public class Kralik : Zvire
    {
        public Kralik(int vek) : base("Králík", vek) { }

        public override void VydatZvuk()
        {
            Console.WriteLine("Píp");
            Console.WriteLine("Dup dup");
        }
    }

    // Třída Slepice
    public class Slepice : Zvire
    {
        public Slepice(int vek) : base("Slepice", vek) { }

        public override void VydatZvuk()
        {
            Console.WriteLine("Koko");
            Console.WriteLine("Kudák");
        }
    }

    // Třída Husa
    public class Husa : Zvire
    {
        public Husa(int vek) : base("Husa", vek) { }

        public override void VydatZvuk()
        {
            Console.WriteLine("Ga ga");
            Console.WriteLine("Ššš");
        }
    }

    // Třída Kachna
    public class Kachna : Zvire
    {
        public Kachna(int vek) : base("Kachna", vek) { }

        public override void VydatZvuk()
        {
            Console.WriteLine("Kvák");
            Console.WriteLine("Kvok");
        }
    }

    // Tovární třída pro vytváření instancí konkrétních zvířat
    public class VytvorZvire
    {
        public static Zvire VytvorPsa(int vek)
        {
            return new Pes(vek);
        }

        public static Zvire VytvorKocku(int vek)
        {
            return new Kocka(vek);
        }

        public static Zvire VytvorKravu(int vek)
        {
            return new Krava(vek);
        }

        public static Zvire VytvorKone(int vek)
        {
            return new Kun(vek);
        }

        public static Zvire VytvorOvecka(int vek)
        {
            return new Ovecka(vek);
        }

        public static Zvire VytvorPrase(int vek)
        {
            return new Prase(vek);
        }

        public static Zvire VytvorKralika(int vek)
        {
            return new Kralik(vek);
        }

        public static Zvire VytvorSlepici(int vek)
        {
            return new Slepice(vek);
        }

        public static Zvire VytvorHusu(int vek)
        {
            return new Husa(vek);
        }

        public static Zvire VytvorKachnu(int vek)
        {
            return new Kachna(vek);
        }
    }

    class Program
    {
        static void Main()
        {
            // Vytvoření několika zvířat pomocí tovární metody
            Zvire pes = VytvorZvire.VytvorPsa(38);
            Zvire kocka = VytvorZvire.VytvorKocku(12);
            Zvire krava = VytvorZvire.VytvorKravu(99);
            Zvire slepice = VytvorZvire.VytvorSlepici(4);

            // Výpis vlastností a zvuků zvířat
            // Zpomalování at je to pekni
            Console.WriteLine($"{pes.druhy} má {pes.veky} roky a vydává zvuky:");
            pes.VydatZvuk();
            Console.WriteLine($"{kocka.druhy} má {kocka.veky} roky a vydává zvuky:");
            kocka.VydatZvuk();
            Console.WriteLine($"{krava.druhy} má {krava.veky} roky a vydává zvuky:");
            krava.VydatZvuk();
            Console.WriteLine($"{slepice.druhy} má {slepice.veky} let a vydává zvuky:");
            slepice.VydatZvuk();

            Console.ReadKey();
        }
    }
}
