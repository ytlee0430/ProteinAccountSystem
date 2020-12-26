using System.Collections.Generic;
using ProteinSystem.Entity;

namespace ProteinSystem.Interface.Service
{
    public interface IEnumService
    {
        List<EnumModel> GetEnums(int selectedIndex);

        bool AddEnumValue(string description, string keyword, int enumClass, int parentType);
    }
}