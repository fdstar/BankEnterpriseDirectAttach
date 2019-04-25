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
    /// 12.7.5.直联实时购汇根据卖出人民币账查询买入外币账号请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ12_7_5 : CMBBase<RQINFO>, IRequest<RS12_7_5>
    {
        /// <summary>
        /// NTEXPRMB
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTEXPRMB";
        /// <summary>
        /// 12.7.5.直联实时购汇根据卖出人民币账查询买入外币账号请求内容
        /// </summary>
        public NTEXPRMBX NTEXPRMBX { get; set; }
    }
    /// <summary>
    /// 12.7.5.直联实时购汇根据卖出人民币账查询买入外币账号请求内容
    /// </summary>
    public class NTEXPRMBX
    {
        /// <summary>
        /// 分行号	C(2)	附录A.1
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 汇款帐号	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 账号类型	C(1)	F:活期 D:定期 M:保证金
        /// </summary>
        public string ACCTYP { get; set; }
        /// <summary>
        /// 保留字	C(50)
        /// </summary>
        public string RSV50Z { get; set; }
    }
}
