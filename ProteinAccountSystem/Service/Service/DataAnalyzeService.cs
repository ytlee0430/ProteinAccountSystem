using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using ProteinSystem.Entity;
using ProteinSystem.Interface.Service;

namespace ProteinSystem.Service.Service
{
    //TODO:where brand,ProductionDetailType etc
    public class DataAnalyzeService : IDataAnalyzeService
    {
        public List<PhuraseProductViewModel> AnalyzeFlavor(List<PhuraseProductModel> list)
        {
            var result = list.Where(l => l.ProductionDetailType == 1).GroupBy(l => l.Flavor).Select(g => new PhuraseProductModel
            {
                Flavor = g.Key,
                Count = g.Sum(s => s.Count),
            }).OrderByDescending(o => o.Count);

            return Mapper.Map<List<PhuraseProductViewModel>>(result);
        }

        public List<PhuraseProductViewModel> AnalyzeFlavorAndPackage(List<PhuraseProductModel> list)
        {
            var result = list.Where(l => l.ProductionDetailType == 1).GroupBy(l => new { l.Package, l.Flavor }).Select(g => new PhuraseProductModel
            {
                Flavor = g.Key.Flavor,
                Package = g.Key.Package,
                Count = g.Sum(s => s.Count),
            }).OrderByDescending(o => o.Count);

            return Mapper.Map<List<PhuraseProductViewModel>>(result);
        }
    }
}