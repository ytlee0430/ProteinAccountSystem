﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Entity
{
    public class EnumModel
    {
        [DisplayName("值")]
        public int EnumValue { get; set; }
        [DisplayName("描述")]
        public string Description { get; set; }
        [DisplayName("關鍵字")]
        public string KeyWord { get; set; }
        [DisplayName("大項分類")]
        public int ParentType { get; set; }
    }
}
