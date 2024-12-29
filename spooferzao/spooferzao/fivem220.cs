using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace spooferzao
{
    public partial class fivem220 : UserControl
    {
        public fivem220()
        {
            InitializeComponent();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            string urlArquivo = "https://github.com/Miguelao771/dawdawdwadawdgfhihguhughfhgjlihyg.git";  // Substitua pela URL do arquivo .exe
            string caminhoDestino = @"C:\Windows\temp";  // Defina o caminho para salvar o arquivo

            // Passo 1: Baixar o arquivo .exe
            BaixarArquivo(urlArquivo, caminhoDestino);

            // Passo 2: Executar o arquivo .exe
            ExecutarArquivo(caminhoDestino);

            // Passo 3: Aguardar um tempo (simulando o uso do programa) antes de desinstalar
            Thread.Sleep(10000);  // Aguarda 10 segundos, ajuste conforme necessário

            // Passo 4: Desinstalar o programa
            DesinstalarPrograma("Hydra");  // Substitua pelo nome do programa
        }

        static void BaixarArquivo(string url, string caminhoDestino)
        {
            using (WebClient client = new WebClient())
            {
                try
                {
                    Console.WriteLine("Baixando o arquivo...");
                    client.DownloadFile(url, caminhoDestino);
                    Console.WriteLine($"Arquivo baixado com sucesso para {caminhoDestino}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao baixar o arquivo: {ex.Message}");
                }
            }
        }

        static void ExecutarArquivo(string caminhoArquivo)
        {
            try
            {
                Console.WriteLine($"Executando {caminhoArquivo}...");
                Process.Start(caminhoArquivo);
                Console.WriteLine("Arquivo executado com sucesso.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao executar o arquivo: {ex.Message}");
            }
        }

        static void DesinstalarPrograma(string nomePrograma)
        {
            try
            {
                Console.WriteLine($"Desinstalando o programa {nomePrograma}...");
                ManagementObjectSearcher searcher = new ManagementObjectSearcher(
                    $"SELECT * FROM Win32_Product WHERE Name = '{nomePrograma}'");

                foreach (ManagementObject programa in searcher.Get())
                {
                    programa.InvokeMethod("Uninstall", null);
                    Console.WriteLine($"Programa {nomePrograma} desinstalado com sucesso.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao desinstalar o programa: {ex.Message}");
            }
        }

        private void gunaPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
