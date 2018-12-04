using General.Contracts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CodeGenerator.Domain
{
    public class FileReader : IReader
    {
        private readonly string _path;

        public FileReader(string path) => _path = path;

        public string Read() => File.ReadAllText(_path);
    }
}
