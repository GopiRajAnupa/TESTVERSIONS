using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Octokit;

namespace GIT_APPLICATION
{
    public partial class Form1 : Form
    {
        string username, Password;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "GopirajAnupa";
            textBox2.Text = "@Arjunnandhas888a";
            //textBox1.Text = "areebmalik312";
            //textBox2.Text = "Areebmalik123";
            username = textBox1.Text.ToString();
            Password = textBox2.Text.ToString();
            GetAuthenticationDetails(username, Password);
        }
        public void GetAuthenticationDetails(string username, string pwd)
        {
            var productiInformation = new ProductHeaderValue(textBox1.Text);
            //var productiInformation = new ProductHeaderValue("areebmalik312");
            if (username != "" && pwd != "")
            {
                GetBasicAuthenticaton(username, pwd, productiInformation);
            }
            else
            {
                MessageBox.Show("Enteer User or password");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        Form2 form2 = new Form2();
        public GitHubClient GetBasicAuthenticaton(string username, string Password, ProductHeaderValue productInformation)
        {
            var credentials = new Credentials(username, Password, AuthenticationType.Basic);
            var client = new GitHubClient(productInformation)
            {
                Credentials = credentials
            };
            if (client != null)
            {
                Console.WriteLine("Client is not null");
                Console.WriteLine(client.Activity);
            }
            form2.username = username;
            form2.password = Password;
            form2.client = client;
            form2.Show();
            form2.Text = "Porfile Name:" + client.Credentials.Login;
            return client;

        }
        static string repositaryname;
        private static async Task GetData(GitHubClient client)
        {

            //Console.WriteLine("\nEnter Repositary Name");
            repositaryname = Console.ReadLine();
            Repository repository = await client.Repository.Get(client.Credentials.Login, repositaryname);
            Console.WriteLine("Your Repositary ID is:");
            Console.WriteLine($"Repository.Get: Id={repository.Id}");
            Console.WriteLine("Yopur Repositary URL HTTP&SSHURl");
            Console.WriteLine("Repository SSHURL URl:" + repository.SshUrl);
            Console.WriteLine("Repository HTTP URl:" + repository.Url);
            var contents = await client.Repository.Content.GetAllContents(client.Credentials.Login, repositaryname);
            var readme = await client.Repository.Content.GetReadme(repository.Id);
            var rawText = readme.Content;
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("**************The data in the repository is:" + repository.Name + "**************\n");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Yellow;
            foreach (char ss in rawText)
            {
                Console.Beep();
                Console.Write(ss);
            }
        }
    }
}