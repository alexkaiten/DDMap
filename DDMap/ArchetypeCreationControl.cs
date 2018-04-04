using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Resources;
using System.Xml.Serialization;

namespace DDMap
{
    public partial class ArchetypeCreationControl : UserControl
    {
        
        List<Archetype> archetypes = new List<Archetype>();
        public DataMap dataMap;

        public ArchetypeCreationControl()
        {
            InitializeComponent();
            loadArchetypes();
            fillDLLs();
            resetFields();
            listBox2.DisplayMember = "CharacterName";
            this.newArchetypeBtn.Text = "New Character";
            this.addCharacterBtn.Text = "Add Character";
            this.addArchetypeBtn.Text = "Add Archetype";
            this.deleteCharacterBtn.Text = "DeleteCharacter";
            this.saveArchetypesBtn.Text = "Save Archetypes";
        }

        private void fillDLLs()
        {
            dadiVitaDDL.DataSource = Enum.GetValues(typeof(Common.Dadi));
            AlignmentDDL.DataSource = Enum.GetValues(typeof(Common.Alignment));
            sizeDDL.DataSource = Enum.GetValues(typeof(Common.DDSize));
        }

        private void newArchetypeBtn_Click(object sender, EventArgs e)
        {
            resetFields();
        }

        private void resetFields()
        {
            this.infoTextBox.Text = string.Empty;
            this.nameTextBox.Text = string.Empty;
            this.shortNameTextBox.Text = string.Empty;
            this.pf.Value = 0;
            this.raceTextBox.Text = string.Empty;
            this.danniTextBox.Text = string.Empty;
            this.attacchiTextBox.Text = string.Empty;
            this.sizeDDL.SelectedIndex = 0;
            this.dadiVitaDDL.SelectedIndex = 0;
            this.AlignmentDDL.SelectedIndex = 0;
            this.classeArmaturaLabel.Text = "10";
            this.caColtoSprovvistaLabel.Text = "10";
            this.caContattoLabel.Text = "10";
            this.facciaPortataTextBox.Text = string.Empty;
            this.climaTerrenoTextBox.Text = string.Empty;
            this.talentiTextBox.Text = string.Empty;
            this.qualitaSpecialiTextBox.Text = string.Empty;
            this.attacchiSpecialiTextBox.Text = string.Empty;
            this.lootTextBox.Text = string.Empty;
            this.gradoSfida.Value = 0;
            this.carisma.Value = 0;
            this.saggezza.Value = 0;
            this.intelligenza.Value = 0;
            this.costituzione.Value = 0;
            this.destrezzaParametro.Value = 0;
            this.forza.Value = 0;
            this.volonta.Value = 0;
            this.riflessi.Value = 0;
            this.tempra.Value = 0;
            this.temp.Value = 0;
            this.vari.Value = 0;
            this.naturale.Value = 0;
            this.taglia.Value = 0;
            this.destrezza.Value = 0;
            this.scudo.Value = 0;
            this.armatura.Value = 0;
            this.velocita.Value = 0;
            this.iniziativa.Value = 0;
            this.dadiVitaNumericUpDown.Value = 0;
            this.colorPanel.BackColor = Color.Blue;
        }

        private void addArchetypeBtn_Click(object sender, EventArgs e)
        {

            if (ValidateForm())
            {
                Archetype arch = new Archetype(this.nameTextBox.Text, this.shortNameTextBox.Text, this.raceTextBox.Text, (int)pf.Value, (Common.DDSize)sizeDDL.SelectedItem, this.infoTextBox.Text,
                    colorPanel.BackColor, danniTextBox.Text, attacchiTextBox.Text, (Common.Dadi)dadiVitaDDL.SelectedItem, (Common.Alignment)AlignmentDDL.SelectedItem, (int)temp.Value, (int)vari.Value, (int)naturale.Value,
                    (int)taglia.Value, (int)destrezza.Value, (int)scudo.Value, (int)armatura.Value, facciaPortataTextBox.Text, climaTerrenoTextBox.Text, talentiTextBox.Text, qualitaSpecialiTextBox.Text,
                    attacchiSpecialiTextBox.Text, lootTextBox.Text, (int)gradoSfida.Value, (int)carisma.Value, (int)saggezza.Value, (int)intelligenza.Value, (int)costituzione.Value, (int)destrezza.Value,
                    (int)forza.Value, (int)volonta.Value, (int)riflessi.Value, (int)tempra.Value, (int)velocita.Value, (int)iniziativa.Value, (int)dadiVitaNumericUpDown.Value, new Couple<double>((double)dimensionWidth.Value, (double)dimensionHeight.Value));

                Archetype a = archetypes.Where(t => t.Name.Equals(arch.Name)).FirstOrDefault();
                if (a != null)
                {
                    a = arch;
                }
                else
                {
                    archetypes.Add(arch);
                    listBox1.Items.Add(arch);
                }
            }
            else
            {
                MessageBox.Show("Compila i campi");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Archetype a = (Archetype)listBox1.SelectedItem;
            fillForm(a);
        }

        private void fillForm(Archetype a)
        {
            this.nameTextBox.Text = a.Name;
            this.shortNameTextBox.Text = a.ShortName;
            pf.Value = a.PF;
            this.raceTextBox.Text = a.Race.ToString();
            this.infoTextBox.Text = a.Info;
            this.danniTextBox.Text = a.Danni;
            this.attacchiTextBox.Text = a.Attacchi;
            this.sizeDDL.SelectedItem = a.Size;
            this.dadiVitaDDL.SelectedItem= a.DadoVita;
            this.AlignmentDDL.SelectedItem = a.Allineamento;
            this.classeArmaturaLabel.Text = Convert.ToString(10 + a.CATemp + a.CAVari + a.CANaturale + a.CATaglia + a.CADestrezza + a.CAScudo + a.CAArmatura); 
            this.caColtoSprovvistaLabel.Text = Convert.ToString(10 + a.CATemp + a.CAVari + a.CANaturale + a.CATaglia + a.CAScudo + a.CAArmatura);
            this.caContattoLabel.Text = Convert.ToString(10 + a.CATemp + a.CAVari+ a.CATaglia + a.CADestrezza);
            this.facciaPortataTextBox.Text = a.Faccia_Portata;
            this.climaTerrenoTextBox.Text = a.Clima_Terreno;
            this.talentiTextBox.Text = a.Talenti;
            this.qualitaSpecialiTextBox.Text = a.QualitaSpeciali;
            this.attacchiSpecialiTextBox.Text = a.AttacchiSpeciali;
            this.lootTextBox.Text = a.Loot;
            this.gradoSfida.Value = a.GradoSfida;
            this.carisma.Value = a.Carisma;
            this.saggezza.Value = a.Saggezza;
            this.intelligenza.Value = a.Intelligenza;
            this.costituzione.Value = a.Costituzione;
            this.destrezzaParametro.Value = a.Destrezza;
            this.forza.Value = a.Forza;
            this.volonta.Value = a.TSVolonta;
            this.riflessi.Value = a.TSRiflessi;
            this.tempra.Value = a.TSTempra;
            this.temp.Value = a.CATemp;
            this.vari.Value = a.CAVari;
            this.naturale.Value = a.CANaturale;
            this.taglia.Value = a.CATaglia;
            this.destrezza.Value = a.CADestrezza;
            this.scudo.Value = a.CAScudo;
            this.armatura.Value = a.CAArmatura;
            this.velocita.Value = a.Velocita;
            this.iniziativa.Value = a.Iniziativa;
            this.dadiVitaNumericUpDown.Value = a.NumeroDadiVita;
            this.colorPanel.BackColor = a.Colour;
            if (a.Size.Equals(Common.DDSize.Grande) ||
                a.Size.Equals(Common.DDSize.Enorme) ||
                a.Size.Equals(Common.DDSize.Colossale) ||
                a.Size.Equals(Common.DDSize.Mastodontica))
            {
                dimensionWidth.Enabled = true;
                dimensionHeight.Enabled = true;
                dimensionWidth.Value = (decimal)a.Dimensions.i;
                dimensionHeight.Value = (decimal)a.Dimensions.j;
                
            }
            else
            {
                dimensionWidth.Value = 0;
                dimensionHeight.Value = 0;
                dimensionWidth.Enabled = false;
                dimensionHeight.Enabled = false;
            }
        }

        private void saveArchetypesBtn_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Archetype>));
            using (TextWriter writer = new StreamWriter(Path.GetDirectoryName(Application.ExecutablePath) + @"\Archetypes\" + "archetypes.arch"))
            {
                serializer.Serialize(writer, archetypes);
            }

        }

        private void loadArchetypes()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Archetype>));

            if (System.IO.File.Exists(Path.GetDirectoryName(Application.ExecutablePath) + @"\Archetypes\" + "archetypes.arch"))
            {
                using (TextReader reader = new StreamReader(Path.GetDirectoryName(Application.ExecutablePath) + @"\Archetypes\" + "archetypes.arch"))
                {

                    archetypes = (List<Archetype>)serializer.Deserialize(reader);
                    foreach(Archetype archetype in archetypes)
                    {
                        listBox1.Items.Add(archetype);
                    }
                }
            }
        }

        private bool ValidateForm()
        {
            return this.nameTextBox.Text != string.Empty &&
                this.raceTextBox.Text != string.Empty &&
                this.sizeDDL.SelectedIndex > -1;
        }

        private void addCharacterBtn_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                string tryName = string.IsNullOrEmpty(this.shortNameTextBox.Text) ? this.nameTextBox.Text : shortNameTextBox.Text;
                bool found = false;
                int i = 1;
                while (!found)
                {
                    if (!dataMap.Characters.Any(t => t.CharacterName.Equals(tryName)))
                    {
                        Character c = new Character(this.nameTextBox.Text, tryName, this.raceTextBox.Text, (int)pf.Value, (Common.DDSize)sizeDDL.SelectedItem, this.infoTextBox.Text,
                    colorPanel.BackColor, danniTextBox.Text, attacchiTextBox.Text, (Common.Dadi)dadiVitaDDL.SelectedItem, (Common.Alignment)AlignmentDDL.SelectedItem, (int)temp.Value, (int)vari.Value, (int)naturale.Value,
                    (int)taglia.Value, (int)destrezza.Value, (int)scudo.Value, (int)armatura.Value, facciaPortataTextBox.Text, climaTerrenoTextBox.Text, talentiTextBox.Text, qualitaSpecialiTextBox.Text,
                    attacchiSpecialiTextBox.Text, lootTextBox.Text, (int)gradoSfida.Value, (int)carisma.Value, (int)saggezza.Value, (int)intelligenza.Value, (int)costituzione.Value, (int)destrezza.Value,
                    (int)forza.Value, (int)volonta.Value, (int)riflessi.Value, (int)tempra.Value, (int)velocita.Value, (int)iniziativa.Value, (int)dadiVitaNumericUpDown.Value, new Couple<double>((double)dimensionWidth.Value, (double)dimensionHeight.Value));
                        dataMap.Characters.Add(c);
                        ((Form1)this.Parent).UpdateCharacterList();
                        found = true;
                    }
                    else
                    {
                        tryName = (string.IsNullOrEmpty(this.shortNameTextBox.Text) ? this.nameTextBox.Text : shortNameTextBox.Text) + i;
                        i++;
                    }
                }
            }
            else
            {
                MessageBox.Show("Compila i campi!");
            }
        }


        private void fillCharactersList()
        {
            listBox2.Items.Clear();
            foreach (Character c in dataMap.Characters)
            {
                listBox2.Items.Add(c);
            }
        }

        public void UpdateCharacterList()
        {
            fillCharactersList();
        }

        public void initialize()
        {
            dataMap = new DataMap();
        }

        private void colorPanel_MouseDown(object sender, MouseEventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();
            Panel p = (Panel)sender;

            if (result == DialogResult.OK)
            {
                p.BackColor = colorDialog1.Color;
            }
        }

        private void armatura_ValueChanged(object sender, EventArgs e)
        {
            setCA();
        }

        private void scudo_ValueChanged(object sender, EventArgs e)
        {
            setCA();
        }

        private void destrezza_ValueChanged(object sender, EventArgs e)
        {
            setCA();
        }

        private void taglia_ValueChanged(object sender, EventArgs e)
        {
            setCA();
        }

        private void naturale_ValueChanged(object sender, EventArgs e)
        {
            setCA();
        }

        private void vari_ValueChanged(object sender, EventArgs e)
        {
            setCA();
        }

        private void temp_ValueChanged(object sender, EventArgs e)
        {
            setCA();
        }

        private void setCA()
        {
            this.classeArmaturaLabel.Text = Convert.ToString(10 + armatura.Value + scudo.Value + destrezza.Value + taglia.Value + naturale.Value + vari.Value + temp.Value);
            this.caColtoSprovvistaLabel.Text = Convert.ToString(10 + temp.Value + vari.Value + naturale.Value + taglia.Value + scudo.Value + armatura.Value);
            this.caContattoLabel.Text = Convert.ToString(10 + temp.Value + vari.Value + taglia.Value + destrezza.Value);
        }

        private void deleteCharacterBtn_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex > -1)
            {
                dataMap.Characters.Remove((Character)listBox2.SelectedItem);
            }
            ((Form1)this.Parent).UpdateCharacterList();
        }

        private void newArchetypeBtn_Load(object sender, EventArgs e)
        {

        }

        private void sizeDDL_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((Common.DDSize)sizeDDL.SelectedItem).Equals(Common.DDSize.Grande) ||
                ((Common.DDSize)sizeDDL.SelectedItem).Equals(Common.DDSize.Enorme) ||
                ((Common.DDSize)sizeDDL.SelectedItem).Equals(Common.DDSize.Colossale) ||
                ((Common.DDSize)sizeDDL.SelectedItem).Equals(Common.DDSize.Mastodontica))
            {
                dimensionWidth.Enabled = true;
                dimensionHeight.Enabled = true;
                if (((Common.DDSize)sizeDDL.SelectedItem).Equals(Common.DDSize.Grande))
                {
                    dimensionWidth.Value = 1;
                    dimensionHeight.Value = 1;
                }
                else
                {
                    dimensionWidth.Value = (decimal)Common.Taglie[(Common.DDSize)sizeDDL.SelectedItem].i;
                    dimensionHeight.Value = (decimal)Common.Taglie[(Common.DDSize)sizeDDL.SelectedItem].j;
                }
            }
            else
            {
                dimensionWidth.Value = 0;
                dimensionHeight.Value = 0;
                dimensionWidth.Enabled = false;
                dimensionHeight.Enabled = false;
            }
        }
    }
}
