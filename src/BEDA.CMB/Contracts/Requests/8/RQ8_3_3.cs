using BEDA.CMB.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CMB.Contracts.Requests
{
    /// <summary>
    /// 8.3.3.理财产品详细信息查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ8_3_3 : CMBBase<RQINFO>, IRequest<RS8_3_3>
    {
        /// <summary>
        /// NTQDIDEF
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTQDIDEF";
        /// <summary>
        /// 8.3.3.理财产品详细信息查询请求内容
        /// </summary>
        public NTQDIDEFX NTQDIDEFX { get; set; }
    }
    /// <summary>
    /// 8.3.3.理财产品详细信息查询请求内容
    /// </summary>
    public class NTQDIDEFX
    {
        /// <summary>
        /// 产品代码	C(8)
        /// </summary>
        public string RIPCOD { get; set; }
    }
}
