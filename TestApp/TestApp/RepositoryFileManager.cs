using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;


namespace TestApp
{
    class RepositoryFileManager 
    {
        private Dictionary<string, Action<FileMethods>> saveFileManipulations =
            new Dictionary<string, Action<FileMethods>>();
        
        private Dictionary<string, Func<string, string>> openFileManipulations =
            new Dictionary<string, Func<string, string>>();
       
        public void SaveToFile(string data)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            FileMethods fm = new FileMethods();

            sfd.Filter = "txt(*.txt) | *.txt|dat(*.dat) | *.dat|json(*.json) | *.json|xml(*.xml) | *.xml";
            sfd.ShowDialog();

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                saveFileManipulations.Add(".txt", (method) => method.Save_Txt(sfd.FileName, data));
                saveFileManipulations.Add(".dat", (method) => method.Save_Dat(sfd.FileName, data));
                saveFileManipulations.Add(".json", (method) => method.Save_Json(sfd.FileName, data));
                saveFileManipulations.Add(".xml", (method) => method.Save_Xml(sfd.FileName, data));                            
                saveFileManipulations[Path.GetExtension(sfd.FileName)](fm);
            }           
        }

        public string ReadFromFile()
        {
            string text = null;
            OpenFileDialog ofd = new OpenFileDialog();
            FileMethods fm = new FileMethods();
            ofd.Filter = "txt(*.txt) | *.txt|dat(*.dat) | *.dat|json(*.json) | *.json|xml(*.xml) | *.xml";
            ofd.ShowDialog();
        
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                openFileManipulations.Add(".txt", fm.Open_Txt);
                openFileManipulations.Add(".dat", fm.Open_Dat);
                openFileManipulations.Add(".json", fm.Open_Json);
                openFileManipulations.Add(".xml", fm.Open_Xml);
                text = openFileManipulations[Path.GetExtension(ofd.FileName)](ofd.FileName);
            }
            return text;
        }
            
      
    }
}
