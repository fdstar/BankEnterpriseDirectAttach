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
    /// 12.9.2.企业货物贸易收支名录情况查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ12_9_2 : CMBBase<RQINFO>, IRequest<RS12_9_2>
    {
        /// <summary>
        /// NTTBLQRY
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTTBLQRY";
        /// <summary>
        /// 12.9.2.企业货物贸易收支名录情况查询请求内容
        /// </summary>
        public NTTBLQRYX1 NTTBLQRYX1 { get; set; }
    }
    /// <summary>
    /// 12.9.2.企业货物贸易收支名录情况查询请求内容
    /// </summary>
    public class NTTBLQRYX1
    {
        /// <summary>
        /// 客户号       	C(10)
        /// </summary>
        public string CLTNBR { get; set; }
        /// <summary>
        /// 分行号       	C(2)
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 组织机构代码	C(9)    组织机构代码, 需查询企业的组织机构代码证上号码，不含“-”
        /// </summary>
        public string CUSCOD { get; set; }
        /// <summary>
        /// 保留字50	C(50)
        /// </summary>
        public string RSV50Z { get; set; }
    }
}
