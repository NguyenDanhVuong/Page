using System;

namespace Example1.Views
{
    class SaveFile
    {
        private String _fileName;
        private String _content;

        public string fileName { get => _fileName; set => _fileName = value; }
        public string content { get => _content; set => _content = value; }
    }
}