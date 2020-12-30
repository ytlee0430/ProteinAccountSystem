using ProteinSystem.Enum;
using ProteinSystem.Interface.Service;

namespace ProteinSystem.Resolver
{
    public delegate IExportSheetService ExportSheetServiceResolver(ExportSheetType type); 
}
