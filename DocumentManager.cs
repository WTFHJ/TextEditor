using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

namespace TextEditor
{
    class DocumentManager
    {
        private string _currentFile;
        private RichTextBox _richTextBox;

        public DocumentManager(RichTextBox textbox)
        {
            _richTextBox = textbox;
        }

        public bool OpenDocument()
        {
            OpenFileDialog dialog = new OpenFileDialog();

            if (dialog.ShowDialog() ?? false)
            {
                _currentFile = dialog.FileName;

                using (Stream stream = dialog.OpenFile())
                {
                    TextRange range = new TextRange(_richTextBox.Document.ContentStart, _richTextBox.Document.ContentEnd);
                    range.Load(stream, DataFormats.Rtf);
                }

                return true;
            }

            return false;
        }

        public bool SaveDocumentAs()
        {
            SaveFileDialog dialog = new SaveFileDialog();
            if (dialog.ShowDialog() ?? false)
            {
                _currentFile = dialog.FileName;
                return SaveDocument();
            }
            return false;
        }
        public bool SaveDocument()
        {
            if (string.IsNullOrEmpty(_currentFile)) return SaveDocumentAs();
            else
            {
                using (Stream stream = new FileStream(_currentFile, FileMode.Create))
                {
                    TextRange range = new TextRange(_richTextBox.Document.ContentStart, _richTextBox.Document.ContentEnd);
                    range.Load(stream, DataFormats.Rtf);
                }
                return true;
            }
        }    
    }
}
