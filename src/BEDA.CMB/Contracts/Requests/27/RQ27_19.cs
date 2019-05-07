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
    /// 27.19.多级现金池当天综合交易查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ27_19 : CMBBase<RQINFO>, IRequest<RS27_19>
    {
        /// <summary>
        /// NTMTLTRD
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTMTLTRD";
        /// <summary>
        /// 27.19.多级现金池当天综合交易查询请求内容
        /// </summary>
        public NTMTLTRDY1 NTMTLTRDY1 { get; set; }
    }
    /// <summary>
    /// 27.19.多级现金池当天综合交易查询请求内容
    /// </summary>
    public class NTMTLTRDY1
    {
        /// <summary>
        /// 分行号	C(2)
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 户口号	C(35)
        /// </summary>
        public string EACNBR { get; set; }
        /// <summary>
        /// 交易类型	C(1)
        /// 1  所有账务
        /// 2  协议内交易
        /// 3  协议外交易
        /// </summary>
        public string TRXTYP { get; set; }
        /// <summary>
        /// 查询方式	C(1)
        /// 1  统一协议内交易
        /// 2  不统一协议内交易
        /// </summary>
        public string QRYMOD { get; set; }
    }
}
