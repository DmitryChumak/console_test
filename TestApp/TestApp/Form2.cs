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

namespace TestApp
{
    public partial class Form2 : Form
    {
        

       
        public string TText
        {
            set
            {
                textBox1.Text = value;
            }
        }

        public Form2()
        {
            InitializeComponent();
            treeView1.AfterSelect += TreeView1_AfterSelect;
        }

        private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
            string currentNodeText = treeView1.SelectedNode.Tag as string;
            
            {
                try
                {
                    foreach (var directory in Directory.GetDirectories(currentNodeText))
                    {

                        TreeNode node = new TreeNode(Path.GetFileName(directory));
                        node.Tag = directory;
                        e.Node.Nodes.Add(node);
                    }
                    foreach (var file in Directory.GetFiles(currentNodeText))
                    {

                        TreeNode node = new TreeNode(Path.GetFileName(file));
                        node.Tag = file;

                        e.Node.Nodes.Add(node);


                    }
                }
                catch(Exception)
                {
                    MessageBox.Show(" Сдесь нет дирктории");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

           

            foreach (var drive in DriveInfo.GetDrives())
            {
                TreeNode node = new TreeNode(textBox1.Text);
                node.Tag = textBox1.Text;
                treeView1.Nodes.Add(node);
            }
        }
    }
}
