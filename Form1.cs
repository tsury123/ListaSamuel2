using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Listinha_da_Cida_T4__VS_
{
    public partial class Form1 : Form
    {
        private Contato[] listaDeContatos = new Contato[1];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Ler();
            AtualizarDisplay();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Contato objetoContato = new Contato(txtNome.Text,
            txtSobrenome.Text, txtTelefone.Text, txtMail.Text);
            Escrever(objetoContato);
            Ler();
            AtualizarDisplay();
            LimparFormulario();
        }

        private void Escrever(Contato contato)
        {
            StreamWriter escrevedorDeArquivos = new StreamWriter("Contatos.txt");
            escrevedorDeArquivos.WriteLine(listaDeContatos.Length + 1);
            escrevedorDeArquivos.WriteLine(contato.PrimeiroNome);
            escrevedorDeArquivos.WriteLine(contato.Sobrenome);
            escrevedorDeArquivos.WriteLine(contato.Telefone);
            escrevedorDeArquivos.WriteLine(contato.Mail);

            for (int i = 0; i < listaDeContatos.Length; i++)
            {

                escrevedorDeArquivos.WriteLine(listaDeContatos[i].PrimeiroNome);
                escrevedorDeArquivos.WriteLine(listaDeContatos[i].Sobrenome);
                escrevedorDeArquivos.WriteLine(listaDeContatos[i].Telefone);
                escrevedorDeArquivos.WriteLine(listaDeContatos[i].Mail);
            }
            escrevedorDeArquivos.Close();
        }

        private void Ler()
        {
            StreamReader leitorDeArquivos = new StreamReader("Contatos.txt");
            listaDeContatos=new Contato[Convert.ToInt32(leitorDeArquivos.ReadLine())]; 
            // Copia os dados do arquivo de texto para o vetor listaDeContatos
            for (int i = 0; i < listaDeContatos.Length; i++)
            {
                listaDeContatos[i] = new Contato();
                listaDeContatos[i].PrimeiroNome = leitorDeArquivos.ReadLine();
                listaDeContatos[i].Sobrenome = leitorDeArquivos.ReadLine();
                listaDeContatos[i].Telefone = leitorDeArquivos.ReadLine();
                listaDeContatos[i].Mail = leitorDeArquivos.ReadLine();
            }
            leitorDeArquivos.Close();
        }
         
        private void AtualizarDisplay()
        {
            lstContatos.Items.Clear();
            for (int i = 0; i < listaDeContatos.Length; i++)
            {
                lstContatos.Items.Add(listaDeContatos[i].ToString());
            }
        }

        private void LimparFormulario()
        {
            txtNome.Text = string.Empty;
            txtSobrenome.Text = string.Empty;
            txtTelefone.Text = string.Empty;
            txtMail.Text = string.Empty;

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstContatos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void textMail_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Ordenar();
            AtualizarDisplay();
        }
            // Aplicação prática do algoritmo "Bublle Sort".
        private void Ordenar()
        {
            //Variável para guardar

            Contato temporario;
            bool trocar = true;
            do
            {
                trocar = false;
                for (int i = 0; i < (listaDeContatos.Length - 1); i++)
                {
                    if (listaDeContatos[i].PrimeiroNome.CompareTo
                        (listaDeContatos[i + 1].PrimeiroNome) > 0)
                    {
                        temporario = listaDeContatos[i];
                        listaDeContatos[i] = listaDeContatos[i + 1];
                        listaDeContatos[i + 1] = temporario;
                        trocar = true;
                    }
                }
            } while (trocar == true);

        }

    }
}
