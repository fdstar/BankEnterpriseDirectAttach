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
    /// 22.1.7.询价查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ22_1_7 : CMBBase<RQINFO>, IRequest<RS22_1_7>
    {
        /// <summary>
        /// NTBILIND
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTBILIND";
        /// <summary>
        /// 22.1.7.询价查询请求内容
        /// </summary>
        public NTBILINDX1 NTBILINDX1 { get; set; }
        /// <summary>
        /// 22.1.7.询价查询请求集合
        /// </summary>
        [XmlElement("NTBILINDX2")]
        public List<NTBILINDX2> List { get; set; }
    }
    /// <summary>
    /// 22.1.7.询价查询请求内容
    /// </summary>
    public class NTBILINDX1
    {
        /// <summary>
        /// 查询分行号	C(2)
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 查询账号	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
    }
    /// <summary>
    /// 22.1.7.询价查询请求内容
    /// </summary>
    public class NTBILINDX2
    {
        /// <summary>
        /// 票据号	C(30)
        /// </summary>
        public string BILNBR { get; set; }
        /// <summary>
        /// 票面金额	M
        /// </summary>
        public decimal BILAMT { get; set; }
        /// <summary>
        /// 票据介质	C(1)	‘E’   电子商业汇票 ‘P’   纸质商业汇票
        /// </summary>
        public string BILSHP { get; set; }
    }
}
