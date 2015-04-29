using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pdfforge.PDFCreator.Core
{
    /// <summary>
    ///     SourceFileInfo holds data stored about a single source file, like name of the input file, printer name etc.
    /// </summary>
    public class SourceFileInfo
    {
        /// <summary>
        ///     The full path of the source file
        /// </summary>
        public string Filename { get; set; }
    }
}
