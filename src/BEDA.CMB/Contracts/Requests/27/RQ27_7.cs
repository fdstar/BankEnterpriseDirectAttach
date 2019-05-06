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
    /// 27.7.自动划拨协议详情查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ27_7 : CMBBase<RQINFO>, IRequest<RS27_7>
    {
        /// <summary>
        /// NTCSTINF
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTCSTINF";
        /// <summary>
        /// 27.7.自动划拨协议详情查询请求内容
        /// </summary>
        public NTCSTINFX1 NTCSTINFX1 { get; set; }
    }
    /// <summary>
    /// 27.7.自动划拨协议详情查询请求内容
    /// </summary>
    public class NTCSTINFX1
    {
        /// <summary>
        /// 产品编号	C(8)
        /// </summary>
        public string PRDNBR { get; set; }
        /// <summary>
        /// 划拨关系编号	C(5)
        /// </summary>
        public string RLTNBR { get; set; }
        /// <summary>
        /// CSTTYP	协议类型	C(1)
        /// A ：实时资金归集
        /// B ：实时资金补足
        /// C ：定期资金归集
        /// D ：定期资金补足
        /// 值为A，输出接口NTFDUINFZ1
        /// 值为B，输出接口NTFDDINFZ1
        /// 值为C，输出接口NTTDUINFZ1
        /// 值为D，输出接口NTTDDINFZ1
        /// </summary>
        public string CSTTYP { get; set; }
        /// <summary>
        /// 协议编号	C(10)   	直连控制协议类型为 C ：定期资金归集 或 D ：定期资金补足 时必输
        /// </summary>
        public string CSTNBR { get; set; }
    }
}
