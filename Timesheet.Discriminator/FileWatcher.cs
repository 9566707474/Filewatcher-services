using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace Timesheet.Discriminator
{
    public class FileWatcher
    {
        public FileSystemWatcher FileSystemWatcher { get; set; }

        public Dictionary<string, string> FileName { get; set; }

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public FileWatcher()
        {
            FileName = new Dictionary<string, string>();
            FileSystemWatcher = new FileSystemWatcher();
        }

        public void InitializeFileSystemWatcher()
        {
            FileSystemWatcher.Created += FileSystemWatcher_Created;
            FileSystemWatcher.Changed += FileSystemWatcher_Changed;
            FileSystemWatcher.Deleted += FileSystemWatcher_Deleted;
            FileSystemWatcher.Renamed += FileSystemWatcher_Renamed;

            FileSystemWatcher.Path = ApplicationConfiguration.FileWatchPath;
            FileSystemWatcher.NotifyFilter = NotifyFilters.Attributes |
            NotifyFilters.CreationTime |
            NotifyFilters.DirectoryName |
            NotifyFilters.FileName |
            NotifyFilters.LastAccess |
            NotifyFilters.LastWrite |
            NotifyFilters.Security |
            NotifyFilters.Size;

            FileSystemWatcher.Filter = "*.*";

            FileSystemWatcher.EnableRaisingEvents = true;
        }

        private void FileSystemWatcher_Renamed(object sender, RenamedEventArgs e)
        {
            log.Info(string.Format("File FileSystemWatcher_Renamed: {0}", e.Name));
        }

        private void FileSystemWatcher_Deleted(object sender, FileSystemEventArgs e)
        {
            log.Info(string.Format("File FileSystemWatcher_Deleted: {0}", e.Name));
        }

        private void FileSystemWatcher_Changed(object sender, FileSystemEventArgs e)
        {
            if (!FileName.TryGetValue(e.FullPath, out string checkColumn))
            {
                FileName.Add(e.FullPath, e.Name);
            }

            log.Info(string.Format("File FileSystemWatcher_Changed: {0}", e.Name));
        }

        private void FileSystemWatcher_Created(object sender, FileSystemEventArgs e)
        {
            if (!FileName.TryGetValue(e.FullPath, out string checkColumn))
            {
                FileName.Add(e.FullPath, e.Name);
            }

            log.Info(string.Format("File created: {0}", e.Name));
        }
    }
}