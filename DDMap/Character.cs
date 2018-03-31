using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DDMap.Common;

namespace DDMap
{
    [Serializable]
    public class Character:Archetype
    {
        public String CharacterName { get; set; }

        [NonSerialized]
        private Panel _currentPanel; 
        public Panel CurrentPanel
        {
            get
            {
                return _currentPanel;
            }
            set
            {
                _currentPanel = value;
                if(value != null)
                {
                    Position = value.Location;
                }
                  
            }
        }

        public int ClasseArmatura
        {
            get
            {
                return 10 + CATemp + CAVari + CANaturale + CATaglia + CADestrezza + CAScudo + CAArmatura;
            }
        }

        public int CAColtoAllaSprovvista
        {
            get
            {
                return 10 + CATemp + CAVari + CANaturale + CATaglia + CAScudo + CAArmatura;
            }
        }

        public int CAContatto
        {
            get
            {
                return 10 + CATemp + CAVari + CATaglia + CADestrezza;
            }
        }

        public Point Position;
        

        public Character()
        {
            Name = string.Empty;
            PF = 0;
            Size = DDSize.Minuscola;
            Info = string.Empty;
            CurrentPanel = null;
            Position = new Point(-1, -1);
            Race = string.Empty;
        }

        

        public Character(string name, int pf, string race, DDSize size, string info = null)
        {
            Name = name;
            PF = pf;
            Size = size;
            Info = info;
            CurrentPanel = null;
            Position = new Point(-1, -1);
            Race = race;
        }

        public Character(string name, string shortName, string race, int pF, DDSize size, string info, Color colour,
            string danni, string attacchi, Dadi dadoVita, Alignment allineamento, int cATemp, int cAVari, int cANaturale,
            int cATaglia, int cADestrezza, int cAScudo, int cAArmatura, string faccia_Portata, string clima_Terreno, string talenti,
            string qualitaSpeciali, string attacchiSpeciali, string loot, int gradoSfida, int carisma, int saggezza, int intelligenza,
            int costituzione, int destrezza, int forza, int tSVolonta, int tSRiflessi, int tSTempra, int velocita, int iniziativa,
            int numeroDadiVita) : this(name, pF, race, size, info)
        {
            CharacterName = String.IsNullOrEmpty(shortName) ? name : shortName;
            Colour = colour;
            Danni = danni;
            Attacchi = attacchi;
            DadoVita = dadoVita;
            Allineamento = allineamento;
            CATemp = cATemp;
            CAVari = cAVari;
            CANaturale = cANaturale;
            CATaglia = cATaglia;
            CADestrezza = cADestrezza;
            CAScudo = cAScudo;
            CAArmatura = cAArmatura;
            Faccia_Portata = faccia_Portata;
            Clima_Terreno = clima_Terreno;
            Talenti = talenti;
            QualitaSpeciali = qualitaSpeciali;
            AttacchiSpeciali = attacchiSpeciali;
            Loot = loot;
            GradoSfida = gradoSfida;
            Carisma = carisma;
            Saggezza = saggezza;
            Intelligenza = intelligenza;
            Costituzione = costituzione;
            Destrezza = destrezza;
            Forza = forza;
            TSVolonta = tSVolonta;
            TSRiflessi = tSRiflessi;
            TSTempra = tSTempra;
            Velocita = velocita;
            Iniziativa = iniziativa;
            NumeroDadiVita = numeroDadiVita;
        }

        public Character(string name, int pf, string info = null)
        {
            Name = name;
            PF = pf;
            Info = info;
        }

        public Character(string characterName, int pF, DDSize size, string info,
            string danni, string attacchi, Dadi dadoVita, Alignment allineamento, int cATemp, int cAVari, int cANaturale,
            int cATaglia, int cADestrezza, int cAScudo, int cAArmatura, string faccia_Portata, string clima_Terreno, string talenti,
            string qualitaSpeciali, string attacchiSpeciali, string loot, int gradoSfida, int carisma, int saggezza, int intelligenza,
            int costituzione, int destrezza, int forza, int tSVolonta, int tSRiflessi, int tSTempra, int velocita, int iniziativa,
            int numeroDadiVita)
        {
            PF = pF;
            Size = size;
            CharacterName = characterName;
            Danni = danni;
            Attacchi = attacchi;
            DadoVita = dadoVita;
            Allineamento = allineamento;
            CATemp = cATemp;
            CAVari = cAVari;
            CANaturale = cANaturale;
            CATaglia = cATaglia;
            CADestrezza = cADestrezza;
            CAScudo = cAScudo;
            CAArmatura = cAArmatura;
            Faccia_Portata = faccia_Portata;
            Clima_Terreno = clima_Terreno;
            Talenti = talenti;
            QualitaSpeciali = qualitaSpeciali;
            AttacchiSpeciali = attacchiSpeciali;
            Loot = loot;
            GradoSfida = gradoSfida;
            Carisma = carisma;
            Saggezza = saggezza;
            Intelligenza = intelligenza;
            Costituzione = costituzione;
            Destrezza = destrezza;
            Forza = forza;
            TSVolonta = tSVolonta;
            TSRiflessi = tSRiflessi;
            TSTempra = tSTempra;
            Velocita = velocita;
            Iniziativa = iniziativa;
            NumeroDadiVita = numeroDadiVita;
        }

        public override string ToString()
        {
            return Name;
        }

        public void CopyCharacter(Character c)
        {
            PF = c.PF;
            Size = c.Size;
            Danni = c.Danni;
            Attacchi = c.Attacchi;
            DadoVita = c.DadoVita;
            Allineamento = c.Allineamento;
            CATemp = c.CATemp;
            CAVari = c.CAVari;
            CANaturale = c.CANaturale;
            CATaglia = c.CATaglia;
            CADestrezza = c.CADestrezza;
            CAScudo = c.CAScudo;
            CAArmatura = c.CAArmatura;
            Faccia_Portata = c.Faccia_Portata;
            Clima_Terreno = c.Clima_Terreno;
            Talenti = c.Talenti;
            QualitaSpeciali = c.QualitaSpeciali;
            AttacchiSpeciali = c.AttacchiSpeciali;
            Loot = c.Loot;
            GradoSfida = c.GradoSfida;
            Carisma = c.Carisma;
            Saggezza = c.Saggezza;
            Intelligenza = c.Intelligenza;
            Costituzione = c.Costituzione;
            Destrezza = c.Destrezza;
            Forza = c.Forza;
            TSVolonta = c.TSVolonta;
            TSRiflessi = c.TSRiflessi;
            TSTempra = c.TSTempra;
            Velocita = c.Velocita;
            Iniziativa = c.Iniziativa;
            NumeroDadiVita = c.NumeroDadiVita;
        }
         
    }
}
