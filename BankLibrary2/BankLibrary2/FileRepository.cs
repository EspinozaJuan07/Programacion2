using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibrary2
{
    public class FileRepository
    {
        private StreamWriter? _filewriter;
        private StreamReader? _filereader;
        private FileStream _filestream;
        private string _fileName;

        public FileRepository(string fileName) 
        {
            _fileName = fileName;
        }

        public void OpenOrCreateFile()
        {
            try
            {
                _filestream = new FileStream(_fileName, FileMode.OpenOrCreate, FileAccess.Write);
                _filewriter = new StreamWriter(_filestream);
            }
            catch (IOException)
            {
                throw new IOException("ERROR AL ABRIR EL ARCHIVO");
                throw;
            }
        }

        public void OpenFile()
        {
            try
            {
                _filestream = new FileStream(_fileName, FileMode.Open, FileAccess.Read);
                _filereader = new StreamReader(_filestream);
            }
            catch (IOException)
            {
                throw new IOException("ERRO AL ABRIR EL ARCHIVO");
            }
        }

        public void WriteRecordToFile(Record record)
        {
            try
            {
                _filewriter?.WriteLine($"{record.cuenta},{record.PrimerNombre}," + $"{record.Apellido},{record.Balance}");
            }
            catch (IOException)
            {

                throw new IOException("ERROR AL ESCRIBIR EN ARCHIVO");
            }
        }

        public string? ReadNextRecord()
        {
            try
            {
                return _filereader?.ReadLine();
            }
            catch (IOException)
            {

                throw new IOException("ERROR AL LEER EL ARCHIVO");
            }
        }

        public void ResetFilePointer()
        {
            try
            {
                _filestream?.Seek(0, SeekOrigin.Begin);
            }
            catch (IOException)
            { 
                throw new IOException("ERROR AL RESTABLECER EL PUNTERO DEL ARCHIVO");
            }
        }

        public void CloseFile()
        {
            try
            {
                _filewriter?.Close();
                _filereader?.Close();
            }
            catch (IOException)
            {

                throw new IOException("NO SE PUEDE CERRAR EL ARCHIVO");
            }
        }
    }
}
