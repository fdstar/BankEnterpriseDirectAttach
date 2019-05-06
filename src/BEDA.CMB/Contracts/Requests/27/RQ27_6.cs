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
    /// 27.6.自动划拨协议查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ27_6 : CMBBase<RQINFO>, IRequest<RS27_6>
    {
        /// <summary>
        /// NTCSTLST
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTCSTLST";
        /// <summary>
        /// 27.6.自动划拨协议查询请求内容
        /// </summary>
        public NTCSTLSTX1 NTCSTLSTX1 { get; set; }
    }
    /// <summary>
    /// 27.6.自动划拨协议查询请求内容
    /// </summary>
    public class NTCSTLSTX1
    {
        /// <summary>
        /// 分行号	C(2)    输入子户，则分行号必输
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 子户	C(35)   子户和母户不能同时为空
        /// </summary>
        public string EACNBR { get; set; }
        /// <summary>
        /// 母户	C(35)
        /// </summary>
        public string OBJEAC { get; set; }
        /// <summary>
        /// 协议类型	C(1)
        /// A ：实时资金归集
        /// B ：实时资金补足
        /// C ：定期资金归集
        /// D ：定期资金补足
        /// </summary>
        public string CSTTYP { get; set; }
        /// <summary>
        /// 母户分行号	C(2)    输入母户，则母户分行号必输
        /// </summary>
        public string TOPBBK { get; set; }
    }
}
