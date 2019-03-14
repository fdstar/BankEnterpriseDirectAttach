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
    /// 4.1.查询交易代码请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ4_1 : CMBBase<RQINFO>, IRequest<RS4_1>
    {
        /// <summary>
        /// NTAGTLS2
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTAGTLS2";
        /// <summary>
        /// 4.1.查询交易代码请求内容
        /// </summary>
        public NTAGTLS2X NTAGTLS2X { get; set; }
    }
    /// <summary>
    /// 4.1.查询交易代码请求内容
    /// </summary>
    public class NTAGTLS2X
    {
        /// <summary>
        /// 业务代码	C(6)	N03020:代发； N03030:代扣;
        /// </summary>
        public string BUSCOD { get; set; }
        /// <summary>
        /// 账户	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 币别	C(2)	附录A.3
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 协议状态	C(1)	A 有效  C 关闭  默认传A
        /// </summary>
        public string STSCOD { get; set; }
    }
}
