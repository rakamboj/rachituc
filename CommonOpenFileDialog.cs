using System;

namespace WpfApp2
{
    internal class CommonOpenFileDialog
    {
        internal string FileName;

        public string InitialDirectory { get; internal set; }
        public bool IsFolderPicker { get; internal set; }

        internal object ShowDialog()
        {
            throw new NotImplementedException();
        }
    }
}