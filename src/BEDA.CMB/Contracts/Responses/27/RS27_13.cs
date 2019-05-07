using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CMB.Contracts.Responses
{
    /// <summary>
    /// 27.13.维护/终止划拨关系限额响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS27_13 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTALMMNT
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTALMMNT";
        /// <summary>
        /// 27.13.维护/终止划拨关系限额响应内容
        /// </summary>
        public NTOPRRTNZ NTOPRRTNZ { get; set; }
    }
}
