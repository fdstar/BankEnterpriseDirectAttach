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
    /// 27.8.内部户限额单笔设置响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS27_8 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTILMADD
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTILMADD";
        /// <summary>
        /// 27.8.内部户限额单笔设置响应内容
        /// </summary>
        public NTOPRRTNZ NTOPRRTNZ { get; set; }
    }
}
