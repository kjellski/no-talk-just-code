using System.IO;

namespace pdfforge.PDFCreator.Core
{
    public static class FileUtil
    {
        public static bool DirectoryIsEmpty(string path)
        {
            return (Directory.GetFiles(path).Length == 0 && Directory.GetDirectories(path).Length == 0);
        }
    }
}
