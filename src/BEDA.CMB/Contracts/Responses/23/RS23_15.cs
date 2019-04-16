﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CMB.Contracts.Responses
{
    /// <summary>
    /// 23.15.公司卡激活响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS23_15 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTCPRACT
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTCPRACT";
    }
}
