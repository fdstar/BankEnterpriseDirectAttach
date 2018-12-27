using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 定期存款信息查询响应主体
    /// </summary>
    public class SECURITIES_MSGSRSV1_TIMEDEPOSITQUERYTRNRS : IResponse
    {
        /// <summary>
        /// 定期存款信息查询响应
        /// </summary>
        public TIMEDEPOSITQUERYTRNRS TIMEDEPOSITQUERYTRNRS { get; set; }
    }
    /// <summary>
    /// 定期存款信息查询响应
    /// </summary>
    public class TIMEDEPOSITQUERYTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 定期存款信息查询结果
        /// </summary>
        [XmlElement(Order = 2)]
        public TIMEDEPOSITRSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 定期存款信息查询结果
    /// </summary>
    public class TIMEDEPOSITRSBODY
    {
        /// <summary>
        /// 开户行，长度60位，必回
        /// </summary>
        [XmlElement(Order = 0)]
        public string BANKDESC { get; set; }
        /// <summary>
        /// 户名，必回
        /// </summary>
        [XmlElement(Order = 1)]
        public string TIMENAME { get; set; }
        /// <summary>
        /// 账户，最长60位，必回
        /// </summary>
        [XmlElement(Order = 2)]
        public string TIMEACCTID { get; set; }
        /// <summary>
        /// 存单号码，必回
        /// </summary>
        [XmlElement(Order = 3)]
        public string CHEQUENUM { get; set; }
        /// <summary>
        /// 存款金额，必回
        /// </summary>
        [XmlElement(Order = 4)]
        public decimal BALAMT { get; set; }
        /// <summary>
        /// 存款利率，必回
        /// </summary>
        [XmlElement(Order = 5)]
        public decimal INTRST { get; set; }
        /// <summary>
        /// 存期，必回
        /// </summary>
        [XmlElement(Order = 6)]
        public string TERM { get; set; }
        /// <summary>
        /// 起息日期，格式yyyyMMdd，必回
        /// </summary>
        [XmlElement(Order = 7)]
        public string DTSTART { get; set; }
        /// <summary>
        /// 到期日，格式yyyyMMdd，必回
        /// </summary>
        [XmlElement(Order = 8)]
        public string DTEND { get; set; }
        /// <summary>
        /// 支取日，格式yyyyMMdd，必回
        /// </summary>
        [XmlElement(Order = 9)]
        public string DTDRAW { get; set; }
        /// <summary>
        /// 质押情况，必回
        /// </summary>
        [XmlElement(Order = 10)]
        public string IMPAWN { get; set; }
    }
}
