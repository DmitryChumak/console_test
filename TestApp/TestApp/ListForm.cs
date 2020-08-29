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

namespace TestApp
{
    public partial class ListForm : Form
    {
        string path;
        string searchPattern;
        FileInfo[] files;

        public ListForm(string directory, string type)
        {
            InitializeComponent();
            this.path = directory;
            this.searchPattern = type;
        }

        private void ListForm_Load(object sender, EventArgs e)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            files = directoryInfo.GetFiles(searchPattern);
            listBox1.DataSource = files;
        }
        public FileInfo[] GetItems()
        {
            return files;
        }
    }
}
