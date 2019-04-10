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
    /// 17.25.单笔设置公司卡关联付方账号响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS17_25 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTDMDRAD
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTDMDRAD";
    }
}
