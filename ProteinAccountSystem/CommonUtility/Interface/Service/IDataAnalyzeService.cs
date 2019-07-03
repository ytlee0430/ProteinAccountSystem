using Common.Entity;
using System.Collections.Generic;

namespace Common.Interface.Service
{
    public interface IDataAnalyzeService
    {
        List<PhuraseProductViewModel> AnalyzeFlavor(List<PhuraseProductModel> list);

        List<PhuraseProductViewModel> AnalyzeFlavorAndPackage(List<PhuraseProductModel> list);
    }
}