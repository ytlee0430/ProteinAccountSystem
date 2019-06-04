using System.Collections.Generic;
using Common.Entity;
using Common.Entity.Dto;
using Common.Enum;

namespace Common.Interface.Service
{
    public interface IEnumService
    {
        List<EnumModel> GetEnums(int selectedIndex);
        bool AddEnumValue(string description, string keyword, int enumClass, int parentType);
    }
}
