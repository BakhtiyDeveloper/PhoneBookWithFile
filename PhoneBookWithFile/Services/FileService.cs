﻿using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;

namespace PhoneBookWithFile.Services
{
    internal class FileService : IFileService
    {
        private const string filePath = "../../../phoneBook.txt";
        private ILoggingService loggingService;

        public FileService()
        {
            this.loggingService = new LoggingService();

            EnsureFileExists();
        }

        private static void EnsureFileExists()
        {
            bool isFilePresent = File.Exists(filePath);

            if (isFilePresent is false)
            {
                File.Create(filePath).Close();
            }
        }

        public string AddNameAndNumber(string nameAndNumber)
        {
            string line = "\n";
            File.AppendAllText(filePath, nameAndNumber + line);

            return nameAndNumber;
        }

        public void ClearFile()
        {
            File.WriteAllText(filePath, string.Empty);
        }

        public string ReadFile()
        {
            throw new NotImplementedException();
        }

        public void RemoveNameAndNumber(string nameAndNumber)
        {
            List<string> lines = File.ReadAllLines(filePath).ToList();
            string lineToRemove = nameAndNumber;
            lines.Remove(lineToRemove);
            File.WriteAllLines(filePath, lines);
        }

        public void ReplaceNumberAndName(string nameAndNumber)
        {
            RemoveNameAndNumber(nameAndNumber);
            AddNameAndNumber(nameAndNumber);
        }

        void IFileService.AddNameAndNumber(string nameAndNumber)
        {
            throw new NotImplementedException();
        }
    }
}