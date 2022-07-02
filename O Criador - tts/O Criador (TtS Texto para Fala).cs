using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.CognitiveServices.Speech;
using Microsoft.CognitiveServices.Speech.Audio;

namespace O_Criador___tts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            comboVozes.SelectedIndex = 0;

        }

        

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace (localTexto.Text) == false)

            {
                try
                {
                    var texto_converter = textConverter.Text;
                    string[] array_comboVozes = { "pt-BR-AntonioNeural", "pt-BR-FranciscaNeural", "es-PE-AlexNeural", "es-PE-CamilaNeural", "es-CO-GonzaloNeural", "es-CO-SalomeNeural", "en-US-BrandonNeural", "en-US-AshleyNeural" };

                    var config = SpeechConfig.FromSubscription("YOUR_CODE", "YOUR_REGION"); //<config aqui
                    config.SpeechSynthesisVoiceName = array_comboVozes[comboVozes.SelectedIndex];


                    var endereco_salvar = localTexto.Text;
                    var nome_arquivo = textFileName.Text;
                    var audioConfig = AudioConfig.FromWavFileOutput(endereco_salvar + "/" + nome_arquivo + ".wav");
                    config.SetSpeechSynthesisOutputFormat(SpeechSynthesisOutputFormat.Riff24Khz16BitMonoPcm);
                    var synthesizer = new SpeechSynthesizer(config, audioConfig);



                    synthesizer.SpeakTextAsync(texto_converter);
                    MessageBox.Show("Arquivo Salvo!", "Pronto!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception)
                {
                    MessageBox.Show("Escolha o endereço para Salvar o arquivo!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
            

            
 
        }

        

        private void comboVozes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textConverter_TextChanged(object sender, EventArgs e)
        {

        }

        private void abrirPastaSalvar_HelpRequest(object sender, EventArgs e)
        {
            
        }

        private void btnLocPasta_Click(object sender, EventArgs e)
        {
            if(pastaProcurar.ShowDialog() == DialogResult.OK)
            {
                localTexto.Text = pastaProcurar.SelectedPath;

            }


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
