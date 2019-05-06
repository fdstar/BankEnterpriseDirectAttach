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
    /// 27.12.划拨关系限额设置经办响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS27_12 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTALMADD
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTALMADD";
        /// <summary>
        /// 27.12.划拨关系限额设置经办响应内容
        /// </summary>
        public NTOPRRTNZ NTOPRRTNZ { get; set; }
    }
}
