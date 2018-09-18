using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Security;

namespace alterarEmail
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Enabled = false;
            this.openFileDialog1 = new OpenFileDialog();
            this.MaximizeBox = false;  //desabilita o maximizar
            this.FormBorderStyle = FormBorderStyle.FixedSingle;  //não permitir redimensionar o form pelo mouse
        }

        List<string> listaEmail = new List<string>();
        Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
        
        private void button1_Click(object sender, EventArgs e)
        {
            //OpenFileDialog openfiledialog = new OpenFileDialog();
            this.openFileDialog1.Filter = "Arquivo (*.txt;*csv)|*.txt;*csv";  //mostrar/filtar apenas arquivos .txt e .csv
            String arquivo = "";

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    arquivo = openFileDialog1.FileName;
                    Stream entrada = File.Open(arquivo, FileMode.Open);
                    StreamReader leitor = new StreamReader(entrada);
                    string linha;

                    while ((linha = leitor.ReadLine()) != null)
                    {
                        listaEmail.Add(linha.ToLower());                                                                
                    }

                    leitor.Close();
                    entrada.Close();
                    carregaLista(arquivo);
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show("Erro de permissão ao acessar o arquivo: "+ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Um erro foi detectado: "+ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Nenhum arquivo selecionado :(");
            }           
        }

        
        private void carregaLista(String arquivo)
        {
            StringBuilder linhaBuilder = new StringBuilder();
            int contador = 0;

            Dados dados = new Dados();
            dictionary2 = dados.getDictionary();
            
            foreach (string value in listaEmail)
            {
                string teste = value;
                string ant = value;             
                
                foreach (String strKey in dictionary2.Keys)
                {                    
                    if (teste.Contains(strKey))
                    {
                        teste = teste.Replace(strKey, dictionary2[strKey]);
                    }                    
                }                
                linhaBuilder.AppendLine(teste);
                contador += ant != teste ? 1 : 0;
            }
                        
            Stream saida = File.Open(arquivo, FileMode.Create);
            StreamWriter escritor = new StreamWriter(saida);
            escritor.WriteLine(linhaBuilder);

            escritor.Close();
            saida.Close();           
            textBox1.Text = "Total de e-mails recuperados: " + contador;
            contador = 0;
            linhaBuilder.Clear();
            listaEmail.Clear();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.AliceBlue;
            button1.BackColor = Color.Beige;
        }
    }
}
