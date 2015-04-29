using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pdfforge.PDFCreator.Core
{
    public interface IJobInfo
    {
        string InfFile { get; }
        IList<SourceFileInfo> SourceFiles { get; }
    }
}
