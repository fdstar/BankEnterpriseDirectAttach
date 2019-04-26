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
    /// 12.10.5.离岸外汇汇款查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ12_10_5 : CMBBase<RQINFO>, IRequest<RS12_10_5>
    {
        /// <summary>
        /// NTQRYRTO
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTQRYRTO";
        /// <summary>
        /// 12.10.5.离岸外汇汇款查询请求内容
        /// </summary>
        public NTQRYRTOY NTQRYRTOY { get; set; }
    }
    /// <summary>
    /// 12.10.5.离岸外汇汇款查询请求内容
    /// </summary>
    public class NTQRYRTOY
    {
        /// <summary>
        /// 业务模式 	 C(6)
        /// </summary>
        public string BUSCOD { get; set; }
        /// <summary>
        /// 交易类型 	 C(1)
        /// 1：汇往招行离岸户口
        /// 2：汇往招行非离岸户口
        /// 3：汇往他行境内汇款
        /// 4：汇往其他银行境外汇款
        /// </summary>
        public string TRSCOD { get; set; }
        /// <summary>
        /// 起始日期	D   开始日期和结束日期间隔不能超过100天
        /// </summary>
        [XmlIgnore]
        public DateTime BGNDAT { get; set; }
        /// <summary>
        /// 起始日期	D, 对应<see cref="BGNDAT"/>
        /// </summary>
        [XmlElement("BGNDAT")]
        public string BGNDATStr
        {
            get
            {
                return this.BGNDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.BGNDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 结束日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime ENDDAT { get; set; }
        /// <summary>
        /// 结束日期	D, 对应<see cref="ENDDAT"/>
        /// </summary>
        [XmlElement("ENDDAT")]
        public string ENDDATStr
        {
            get
            {
                return this.ENDDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.ENDDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 金额底限 	 M
        /// </summary>
        public decimal? MINAMT { get; set; }
        /// <summary>
        /// 金额上限 	M
        /// </summary>
        public decimal? MAXAMT { get; set; }
        /// <summary>
        /// 经办用户名	 Z(30)
        /// </summary>
        public string OPRLGN { get; set; }
        /// <summary>
        /// 日期类型	 C(1)	A：经办日 B：期望日 默认A
        /// </summary>
        public string DATFLG { get; set; }
        /// <summary>
        /// 请求状态 	 C(30)	附录A.5
        /// </summary>
        public string AUTSTR { get; set; }
        /// <summary>
        /// 特殊码 50	C(50)
        /// </summary>
        public string RSV50Z { get; set; }
    }
}
