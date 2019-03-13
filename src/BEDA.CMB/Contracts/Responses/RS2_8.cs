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
    /// 2.8.查询电子回单信息（保存图片）响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS2_8 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// SDKCSFDFBRTIMG
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "SDKCSFDFBRTIMG";
    }
}
