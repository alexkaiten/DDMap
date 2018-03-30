using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDMap
{
    public partial class DialogForm : Form
    {
        public DialogForm()
        {
            InitializeComponent();
            fillDLLs();

        }

        private void fillDLLs()
        {
            dadiVitaDDL.DataSource = Enum.GetValues(typeof(Common.Dadi));
            AlignmentDDL.DataSource = Enum.GetValues(typeof(Common.Alignment));
            sizeDDL.DataSource = Enum.GetValues(typeof(Common.DDSize));
        }

        public void SetCharacter(Character a)
        {
            this.characterNameLabel.Text = a.CharacterName;
            this.characterRaceTypeLabel.Text = a.Name + " - " + a.Race;
            pf.Value = a.PF;
            this.infoTextBox.Text = a.Info;
            this.danniTextBox.Text = a.Danni;
            this.attacchiTextBox.Text = a.Attacchi;
            this.sizeDDL.SelectedItem = a.Size;
            this.dadiVitaDDL.SelectedItem = a.DadoVita;
            this.AlignmentDDL.SelectedItem = a.Allineamento;
            this.classeArmaturaLabel.Text = Convert.ToString(10 + a.CATemp + a.CAVari + a.CANaturale + a.CATaglia + a.CADestrezza + a.CAScudo + a.CAArmatura);
            this.caColtoSprovvistaLabel.Text = Convert.ToString(10 + a.CATemp + a.CAVari + a.CANaturale + a.CATaglia + a.CAScudo + a.CAArmatura);
            this.caContattoLabel.Text = Convert.ToString(10 + a.CATemp + a.CAVari + a.CATaglia + a.CADestrezza);
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
        }

        public Character GetModifiedCharacter()
        {
            Character returnChar;
            returnChar = new Character(this.characterNameLabel.Text, (int)pf.Value, (Common.DDSize)sizeDDL.SelectedItem, this.infoTextBox.Text, danniTextBox.Text, attacchiTextBox.Text, (Common.Dadi)dadiVitaDDL.SelectedItem, (Common.Alignment)AlignmentDDL.SelectedItem, (int)temp.Value, (int)vari.Value, (int)naturale.Value,
                    (int)taglia.Value, (int)destrezza.Value, (int)scudo.Value, (int)armatura.Value, facciaPortataTextBox.Text, climaTerrenoTextBox.Text, talentiTextBox.Text, qualitaSpecialiTextBox.Text,
                    attacchiSpecialiTextBox.Text, lootTextBox.Text, (int)gradoSfida.Value, (int)carisma.Value, (int)saggezza.Value, (int)intelligenza.Value, (int)costituzione.Value, (int)destrezza.Value,
                    (int)forza.Value, (int)volonta.Value, (int)riflessi.Value, (int)tempra.Value, (int)velocita.Value, (int)iniziativa.Value, (int)dadiVitaNumericUpDown.Value);

            return returnChar;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }
    }
}
