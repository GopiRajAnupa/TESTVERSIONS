using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Octokit;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Net;
using System.IO;
using System.Collections;
using System.Threading;
using Xunit;
namespace GIT_APPLICATION
{
    public partial class Form2 : Form
    {
        public string username
        {
            get;
            set;
        }
        public string password
        {
            get;
            set;
        }
        public GitHubClient client
        {
            get;
            set;
        }
        TextBox textBox1 = new TextBox();
        Button btnprojectname = new Button();
        ContextMenuStrip contextMenus = new ContextMenuStrip();
        ContextMenuStrip ListcontextMenus = new ContextMenuStrip();

        public Form2()
        {

            btnprojectname.Size = new System.Drawing.Size(75, 23);
            btnprojectname.TabIndex = 0;
            btnprojectname.Text = "My Button";
            btnprojectname.UseVisualStyleBackColor = true;
            // Set button click event
            //btnprojectname.Click += new EventHandler(Btnprojectname_ClickAsync);
            InitializeComponent();
            label9.Visible = false;
            label8.Visible = false;
            treeView1.MouseClick += new MouseEventHandler(treeView1_MouseDown);
            lstRepos.MouseDown += new MouseEventHandler(lstRepos_MouseDown);
            contextMenus.ItemClicked += new ToolStripItemClickedEventHandler(contexMenu_ItemClicked);
            ListcontextMenus.ItemClicked += new ToolStripItemClickedEventHandler(ListcontextMenus_ItemClicked);
            loadMenuItems();
            ListMenu();
        }
        private void lstRepos_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ListcontextMenus.Show(lstRepos, new Point(e.X, e.Y));

            }
        }
        public void ListMenu()
        {
            ListcontextMenus.ImageList = imageList1;
            ListcontextMenus.Items.Add("New Repository", imageList1.Images[0]);
            ListcontextMenus.Items.Add("DELETE Repository", imageList1.Images[4]);
            ListcontextMenus.Items.Add("RENAME Repository");
            ListcontextMenus.Items.Add("REFRESH");
        }


        void loadMenuItems()
        {
            contextMenus.Items.Add("CLONE FILE");
            contextMenus.Items.Add("DELETE FILE");
            contextMenus.Items.Add("RENAME FILE");
            contextMenus.Items.Add("PROPERTIES");
        }
        public async Task CloneFileToSystemAsync()
        {
            String Data = await GetContentDataAsync();
            GetdataAsync();
        }
        public void GetdataAsync()
        {
            var data = DownloadDataAsync();
        }

        protected async Task<string> DownloadDataAsync()
        {
            //return data;
            GitHubClient gitHubClient = new GitHubClient(client.Connection);
            //--manuplating
            lstRepos.SelectedItem = treeView1.SelectedNode.Text;
            Repository objRepo = ((Repository)lstRepos.SelectedItem);
            var DataFromRep =  await client.Repository.Content.GetAllContents(objRepo.Id);
            foreach(RepositoryContent s in DataFromRep)
            {
                MessageBox.Show(s.Content.ToString());
            }
            return "";
        }

        string Omode = "";
        void ListcontextMenus_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ToolStripItem item = e.ClickedItem;
            if (item.Text == "New Repository")
            {
                Omode = "Create";
                AddNewRepo();
            }
            if (item.Text == "DELETE Repository")
            {
                Omode = "Delete";
                DeleteSelectedRepo();
                RefreshALl();
            }
            if (item.Text == "RENAME FILE")
            {
                Omode = "RENAME";
                formPopup.Show();
                MessageBox.Show("Edit Value");
                RepText.Text = lstRepos.SelectedItem.ToString();
                MessageBox.Show(item.Text);
                RefreshALl();
            }
            if (item.Text == "RENAME Repository")
            {
                if (lstRepos.SelectedItem != "")
                {
                    Omode = "RENAME";
                    AddNewRepo();
                }
                else
                {
                    label9.Visible = true;
                    label9.ForeColor = Color.Red;
                    label9.Text = "Select Item";
                }
            }
            if (item.Text == "REFRESH")
            {
                RefreshALl();

            }

        }
        void RenameSelectedRepo()
        {
            RepositoryUpdate update = new RepositoryUpdate(RepText.Text);
            Repository objRepo = ((Repository)lstRepos.SelectedItem);
            client.Repository.Edit(objRepo.Id, update);
            GetAllRepositariesForProject();
        }
        void contexMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ToolStripItem item = e.ClickedItem;
            if (item.Text == "CLONE FILE")
            {
                CloneFileToSystemAsync();
            }
            if (item.Text == "DELETE FILE")
            {
                DeleteSelectedRepo();
            }
            if (item.Text == "RENAME FILE")
            {
                MessageBox.Show(item.Text);
            }
            if (item.Text == "REFRESH")
            {
                label9.Visible = false;
                RefreshALl();
                MessageBox.Show(item.Text);
            }
            //GetAllRepositariesForProject();
        }
        protected void RefreshALl()
        {
            label9.Text = "";
            label9.Visible = false;
            for (int i = 0; i < 2; i++)
                GetAllRepositariesForProject();
        }

        TextBox RepText = new TextBox();
        Button button = new Button();
        Form formPopup = new Form();
        protected void AddNewRepo()
        {
            button.Click += new EventHandler(Button_Click);
            System.Windows.Forms.Label RepName = new System.Windows.Forms.Label();
            formPopup.Controls.Add(RepText);
            formPopup.Controls.Add(button);
            button.Text = "CREATE";
            System.Windows.Forms.Label label = new System.Windows.Forms.Label();
            label.Text = "ENTER REPO NAME:";
            label.Location = new Point(150, 70);
            RepText.Location = new Point(90, 70);
            button.Location = new Point(100, 100);
            formPopup.MaximizeBox = false;
            formPopup.MinimizeBox = false;
            formPopup.Text = client.Credentials.Login + " / CreateNewRepo";
            formPopup.StartPosition = FormStartPosition.WindowsDefaultLocation;
            //NewRepository repository = new NewRepository(RepText.Text);
            //client.Repository.Create(repository);
            if (formPopup.IsDisposed == true)
            {
                InitializeComponent();
                Form formPopup = new Form();
                formPopup.Show();
                formPopup.Visible = true;
            }
            if (formPopup.IsDisposed == false)
            {
                formPopup.Show();
                formPopup.Visible = true;
            }
            if (Omode == "RENAME")
            {
                var SelectedName = (Repository)(lstRepos.SelectedItem);
                RepText.Text = SelectedName.Name.ToString();

            }
        }
        private void Button_Click(object sender, EventArgs w)
        {
            if (Omode == "Create")
            {
                if (RepText.Text != "")
                {
                    NewRepository repository = new NewRepository(RepText.Text);
                    client.Repository.Create(repository);
                    GetAllRepositariesForProject();
                    formPopup.Visible = false;
                    label9.Visible = true;
                    label9.Text = "Repo Created Successfully";
                    label9.ForeColor = Color.Green;
                }
                else
                {

                    label9.Visible = true;
                    label9.ForeColor = Color.Red;
                    label9.Text = "Please Enter Repo Name";
                }
            }
            if (Omode == "RENAME")
            {
                RenameSelectedRepo();
                this.formPopup.Close();
            }
        }
        private void treeView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenus.Show(treeView1, new Point(e.X, e.Y));
            }
        }

        private Task<IReadOnlyList<RepositoryContent>> GetChildNodeAsync()
        {
            GitHubClient gitHubClient = new GitHubClient(client.Connection);
            Repository objRepo = ((Repository)lstRepos.SelectedItem);
            Task<IReadOnlyList<RepositoryContent>> data = gitHubClient.Repository.Content.GetAllContents(objRepo.Id);
            return data;
        }
        TreeNode treeNode = new TreeNode();
        private void LoadTreeStructure()
        {
            treeNode.Nodes.Clear();
            string MainNode = Convert.ToString(((Repository)lstRepos.Items[0]).Name);
            treeNode.Text = MainNode.ToString();
            treeNode.ImageIndex = 0;
            if (treeView1.Nodes.Count > 0)
                treeView1.Nodes.Clear();
            treeView1.Nodes.Add(treeNode);
            treeView1.ImageIndex = 0;
            if (treeView1.SelectedNode != null)
                treeView1.SelectedNode.ImageIndex = 5;
        }


        private void Form2_Load(object sender, EventArgs e)
        {

            var productiInformation = new ProductHeaderValue(client.Credentials.Login);
            GetAllRepositariesForProject();

        }

        public async void GetAllRepositariesForProject()
        {
            IReadOnlyList<Repository> listofRepos = await client.Repository.GetAllForCurrent();
            DataTable dts = new DataTable();
            lstRepos.DisplayMember = "Name";
            if (listofRepos != null)
                lstRepos.DataSource = listofRepos;
        }
        int RepID = 0;
        public async void GetProjectData()
        {
            string SelectedRepo = ((Repository)lstRepos.Items[0]).Name;
            DataTable myproject = new DataTable();
            myproject.Columns.Add("PROJECTS");
            DataTable<projects> dt = new DataTable<projects>();
            Repository repository = await client.Repository.Get(client.Credentials.Login, SelectedRepo);
            RepID = Convert.ToInt32(repository.Id);
            var projectlist = await client.Repository.Project.GetAllForRepository(repository.Id);
            lstProjects.DisplayMember = "Name";
            lstProjects.DataSource = projectlist;
        }



        private void button5_Click(object sender, EventArgs e)
        {
            //GetProjectData();

        }
        private async void lstRepos_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadTreeStructure();
            treeView1.Show();

            try
            {
                string MainNode = Convert.ToString(((Repository)lstRepos.Items[lstRepos.SelectedIndex]).Name);
                treeNode.Text = MainNode;
                IReadOnlyList<RepositoryContent> lstFiles = await GetChildNodeAsync();
                if (lstFiles != null)
                {
                    treeView1.ImageList = imageList1;
                    RepsCont<RepositoryContent> con = new RepsCont<RepositoryContent>();
                    label8.Visible = false;
                    treeView1.Name = (lstRepos.SelectedValue.ToString());
                    foreach (RepositoryContent content in lstFiles)
                    {
                        if (content.Type == "file")
                        {
                            treeView1.Nodes.Add(content.Name);
                            treeView1.ImageIndex = 3;
                        }
                        if (content.Type == "Dir" || content.Type == "dir")
                        {
                            Repository objRepo = ((Repository)lstRepos.SelectedItem);
                            var contents = await client.Repository.Content.GetAllContents(objRepo.Id, content.Path);
                            TreeNode ParentNode = new TreeNode(content.Name);
                            ParentNode.ImageIndex = 2;
                            foreach (RepositoryContent s in contents)
                            {
                                //ParentNode.ImageIndex = 1;
                                if (s.Type == "Dir" || s.Type == "dir")
                                {
                                    var Subdata = await client.Repository.Content.GetAllContents(objRepo.Id, s.Path);
                                    TreeNode SubdataNode = new TreeNode(s.Name);
                                    SubdataNode.ImageIndex = 2;
                                    foreach (RepositoryContent subContent in Subdata)
                                    {
                                        SubdataNode.Nodes.Add(subContent.Name);
                                    }
                                    ParentNode.Nodes.Add(SubdataNode);
                                }
                                else
                                {
                                    //ParentNode.Nodes.Add(s.Name);
                                    TreeNode SubdataNode = new TreeNode(s.Name);
                                    SubdataNode.ImageIndex = 3;
                                    ParentNode.Nodes.Add(SubdataNode);
                                }
                            }
                            treeView1.Nodes.Add(ParentNode);
                        }
                    }
                }

            }
            catch (Exception ece)
            {
                label8.Visible = true;
                label8.ForeColor = Color.Red;
            }

        }
        public string DeleteSelectedRepo()
        {
            if (lstRepos.SelectedItem != null && Omode == "Delete")
            {
                string MainNode = Convert.ToString(((Repository)lstRepos.Items[lstRepos.SelectedIndex]).Name);
                Repository Currentrepoid = ((Repository)lstRepos.SelectedItem);
                long CurrRepoID = Currentrepoid.Id;
                client.Repository.Delete(CurrRepoID);
                GetAllRepositariesForProject();
            }
            return "";
        }
        public async Task<string> GetContentDataAsync()
        {

            string data = "";
            string MainNode = Convert.ToString(((Repository)lstRepos.Items[lstRepos.SelectedIndex]).Name);
            treeNode.Text = MainNode;
            IReadOnlyList<RepositoryContent> lstFiles = await GetChildNodeAsync();
            RepsCont<RepositoryContent> con = new RepsCont<RepositoryContent>();
            if (lstFiles != null)
            {
                label8.Visible = false;
                foreach (RepositoryContent content in lstFiles)
                {
                    if (treeView1.SelectedNode.Text == content.Name)
                    {
                        WebClient webClient = new WebClient();
                        byte[] Fulldata = webClient.DownloadData(content.DownloadUrl);
                        if (Fulldata.Length > 0)
                        {
                            System.Text.UTF8Encoding enc = new System.Text.UTF8Encoding();
                            data = enc.GetString(Fulldata);
                            SaveFileDialog save = new SaveFileDialog();
                            save.FileName = content.Name;
                            save.Filter = "Text File | *.txt";
                            if (save.ShowDialog() == DialogResult.OK)
                            {
                                StreamWriter writer = new StreamWriter(save.OpenFile());
                                writer.Write(data);
                                writer.Dispose();
                                writer.Close();

                            }
                        }
                    }
                }

            }


            return "";
        }
        public static void SaveBytesToFile(string filename, byte[] bytesToWrite)
        {
            if (filename != null && filename.Length > 0 && bytesToWrite != null)
            {
                if (!Directory.Exists(Path.GetDirectoryName(@"D:\downloadGit")))
                    Directory.CreateDirectory(Path.GetDirectoryName(filename));
                FileStream file = File.Create(filename);
                file.Write(bytesToWrite, 0, bytesToWrite.Length);
                file.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CloneFileToSystemAsync();
        }
    }


}
