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
    /// 17.26.单笔设置公司卡非关联付方账号的入账方式响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS17_26 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTDMDRMD
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTDMDRMD";
    }
}
