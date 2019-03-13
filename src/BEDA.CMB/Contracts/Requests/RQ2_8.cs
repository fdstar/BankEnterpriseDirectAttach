using BEDA.CMB.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CMB.Contracts.Requests
{
    /// <summary>
    /// 2.8.查询电子回单信息（保存图片）请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ2_8 : CMBBase<RQINFO>, IRequest<RS2_8>
    {
        /// <summary>
        /// SDKCSFDFBRTIMG
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "SDKCSFDFBRTIMG";
        /// <summary>
        /// 2.8.查询电子回单信息（保存图片）请求内容
        /// </summary>
        public CSRRCFDFY0 CSRRCFDFY0 { get; set; }
    }
}
