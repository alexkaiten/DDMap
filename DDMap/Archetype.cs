using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using static DDMap.Common;

namespace DDMap
{
    [Serializable]
    public class Archetype
    {
        public String Name { get; set; }
        public String ShortName { get; set; }
        public String Race { get; set; }
        public int PF { get; set; }
        public DDSize Size { get; set; }
        public String Info { get; set; }
        
        [XmlIgnore]
        public Color Colour { get; set; }

        [XmlElement("Colour")]
        public int BackColorAsArgb
        {
            get { return Colour.ToArgb(); }
            set { Colour = Color.FromArgb(value); }
        }
        public String Danni { get; set; }
        public String Attacchi { get; set; }
        public Dadi DadoVita { get; set; }
        public Alignment Allineamento { get; set; }
        public int CATemp { get; set; }
        public int CAVari { get; set; }
        public int CANaturale { get; set; }
        public int CATaglia { get; set; }
        public int CADestrezza { get; set; }
        public int CAScudo { get; set; }
        public int CAArmatura { get; set; }
        public string Faccia_Portata { get; set; }
        public string Clima_Terreno { get; set; }
        public string Talenti { get; set; }
        public string QualitaSpeciali { get; set; } 
        public string AttacchiSpeciali { get; set; }
        public string Loot { get; set; }
        public int GradoSfida { get; set; }
        public int Carisma { get; set; }
        public int Saggezza { get; set; }
        public int Intelligenza { get; set; }
        public int Costituzione { get; set; }
        public int Destrezza { get; set; }
        public int Forza { get; set; }
        public int TSVolonta { get; set; }
        public int TSRiflessi { get; set; }
        public int TSTempra { get; set; }
        public int Velocita { get; set; }
        public int Iniziativa { get; set; }
        public int NumeroDadiVita { get; set; }

        public Archetype()
        {
            this.Name = String.Empty;
            this.ShortName = String.Empty;
            this.Race = String.Empty;
            this.PF = 0;
            this.Size = DDSize.Minuscola;
            this.Info = String.Empty;
        }

        public Archetype(string name, string shortName, string race, int pf, DDSize size, string info)
        {
            this.Name = name;
            this.ShortName = shortName;
            this.Race = race;
            this.PF = pf;
            this.Size = size;
            this.Info = info;
        }

        public Archetype(string name, string shortName, string race, int pF, DDSize size, string info, Color colour, 
            string danni, string attacchi, Dadi dadoVita, Alignment allineamento, int cATemp, int cAVari, int cANaturale, 
            int cATaglia, int cADestrezza, int cAScudo, int cAArmatura, string faccia_Portata, string clima_Terreno, string talenti, 
            string qualitaSpeciali, string attacchiSpeciali, string loot, int gradoSfida, int carisma, int saggezza, int intelligenza, 
            int costituzione, int destrezza, int forza, int tSVolonta, int tSRiflessi, int tSTempra, int velocita, int iniziativa, 
            int numeroDadiVita) : this(name, shortName, race, pF, size, info)
        {
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

        public override string ToString()
        {
            return Name;
        }
    }
}
