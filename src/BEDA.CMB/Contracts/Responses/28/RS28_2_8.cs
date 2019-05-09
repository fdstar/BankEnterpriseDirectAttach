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
    /// 28.2.8.虚拟户内部转账响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS28_2_8 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTDMITRX
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTDMITRX";
        /// <summary>
        /// 28.2.8.虚拟户内部转账响应内容
        /// </summary>
        public NTOPRRTNZ NTOPRRTNZ { get; set; }
    }
}