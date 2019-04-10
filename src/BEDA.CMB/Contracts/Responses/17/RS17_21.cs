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
    /// 17.21.修改虚拟户非关联付款方入账方式响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS17_21 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTDMATMN
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTDMATMN";
    }
}
