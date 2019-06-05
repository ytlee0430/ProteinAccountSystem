using Common.Entity;
using System.Collections.Generic;

namespace Common.Interface.Service
{
    public interface IEnumService
    {
        List<EnumModel> GetEnums(int selectedIndex);

        bool AddEnumValue(string description, string keyword, int enumClass, int parentType);
    }
}