using System.Collections.Generic;
using ProteinSystem.Entity;

namespace ProteinSystem.Interface.Service
{
    public interface IDataAnalyzeService
    {
        List<PhuraseProductViewModel> AnalyzeFlavor(List<PhuraseProductModel> list);

        List<PhuraseProductViewModel> AnalyzeFlavorAndPackage(List<PhuraseProductModel> list);
    }
}