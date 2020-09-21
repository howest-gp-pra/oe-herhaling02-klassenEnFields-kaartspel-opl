using System;
using System.Collections.Generic;
using System.Text;

namespace Pra.OefeningKlassenFields.CORE
{
    public enum KaartKleur { rood, zwart }
    public enum KaartSoort { ruiten, harten, schoppen, klavers }
    public class Kaart
    {
        public KaartKleur kleur;  // hier komt rood of zwart
        public KaartSoort soort;  // hier komt ruiten, harten, schoppen of klavers
        public int waarde; // hier komt de waarde 1, 2, 3 ... 11 (voor boer), 12 (voor dame), 13 (voor heer)
        public int bonus;  // harten => bonus = 0, ruiten => bonus = 2, klavers => bonus = 4, schoppen => bonus = 6

        public Kaart(KaartSoort soort, int waarde)
        {
            if (soort == KaartSoort.harten)
            {
                kleur = KaartKleur.rood;
                bonus = 0;
            }
            else if (soort == KaartSoort.ruiten)
            {
                kleur = KaartKleur.rood;
                bonus = 2;
            }
            else if (soort == KaartSoort.klavers)
            {
                kleur = KaartKleur.zwart;
                bonus = 4;
            }
            else
            {
                kleur = KaartKleur.zwart;
                bonus = 6;
            }
            this.soort = soort;
            this.waarde = waarde;
        }
    }

}
