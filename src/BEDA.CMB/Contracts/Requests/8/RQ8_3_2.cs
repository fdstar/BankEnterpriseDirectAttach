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
    /// 8.3.2.理财产品信息查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ8_3_2 : CMBBase<RQINFO>, IRequest<RS8_3_2>
    {
        /// <summary>
        /// NTQDILST
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTQDILST";
        /// <summary>
        /// 8.3.2.理财产品信息查询请求内容
        /// </summary>
        public NTQDILSTX NTQDILSTX { get; set; }
    }
    /// <summary>
    /// 8.3.2.理财产品信息查询请求内容
    /// </summary>
    public class NTQDILSTX
    {
        /// <summary>
        /// 帐号	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 币种	C(2)	A.3 货币代码表
        /// </summary>
        public string QRYCCY { get; set; }
        /// <summary>
        /// 预期收益	C(1)
        /// 空=查全部
        /// 4=收益区间：-15% ~ 20
        /// 3=收益区间：-5% ~ 10
        /// 2=收益区间：-3% ~ 5
        /// 1=收益区间：0% ~ 2
        /// </summary>
        public string QRYRTN { get; set; }
        /// <summary>
        /// 查询类型	C(4)	RGQN=认购期产品；空=查全部
        /// </summary>
        public string QRYTPY { get; set; }
    }
}
