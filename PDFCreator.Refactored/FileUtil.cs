using System;
using System.IO;

namespace PDFCreator.Refactored
{
    public class FileUtil
    {
        private static FileUtil _instance = new FileUtil();

        protected FileUtil()
        {
        }

        public static FileUtil Instance
        {
            get { return _instance; }
            protected set { _instance = value; }
        }

        public virtual bool DirectoryIsEmpty(string path)
        {
            return (Directory.GetFiles(path).Length == 0 && Directory.GetDirectories(path).Length == 0);
        }

        /// <summary>
        ///     Checks if the given path is a (syntactically) valid rooted path, i.e. "C:\Temp\test.txt". This file is not required
        ///     to exist
        /// </summary>
        /// <param name="path">The path to check</param>
        /// <returns>true, if the path is valid</returns>
        public virtual bool IsValidRootedPath(string path)
        {
            if (String.IsNullOrEmpty(path))
                return false;

            if (path.Length < 3)
                return false;

            if (((path.IndexOf(":", StringComparison.Ordinal) != 1) || (path.IndexOf("\\", StringComparison.Ordinal) != 2)) && (!path.StartsWith(@"\\")))
                return false;

            try
            {
                var fi = new FileInfo(path);
            }
            catch (ArgumentException)
            {
                return false;
            }
            catch (NotSupportedException)
            {
                return false;
            }

            return true;
        }
    }
}
