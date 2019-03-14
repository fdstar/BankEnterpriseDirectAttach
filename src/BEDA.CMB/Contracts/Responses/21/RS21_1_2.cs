using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CMB.Contracts.Responses
{
    /// <summary>
    /// 21.1.2.交易查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS21_1_2 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTQRYEBN
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTQRYEBN";
        /// <summary>
        /// 21.1.2.交易查询响应集合
        /// </summary>
        [XmlElement("NTWAUEBPZ")]
        public List<NTWAUEBPZ> List { get; set; }
    }
    /// <summary>
    /// 21.1.2.交易查询响应响应内容
    /// </summary>
    public class NTWAUEBPZ
    {
        /// <summary>
        /// 流程实例号	C(10)
        /// </summary>
        public string REQNBR { get; set; }
        /// <summary>
        /// 业务类型	C(6)	附录A.4
        /// </summary>
        public string BUSCOD { get; set; }
        /// <summary>
        /// 业务模式	C(5)
        /// </summary>
        public string BUSMOD { get; set; }
        /// <summary>
        /// 银行号	C(2)	附录A.1
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 帐号	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 币种	C(2)	附录A.3
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 金额	M
        /// </summary>
        public decimal TRSAMT { get; set; }
        /// <summary>
        /// 经办日	D
        /// </summary>
        [XmlIgnore]
        public DateTime? OPRDAT { get; set; }
        /// <summary>
        /// 经办日	D, 对应<see cref="OPRDAT"/>
        /// </summary>
        [XmlElement("OPRDAT")]
        public string OPRDATStr
        {
            get
            {
                return this.OPRDAT?.ToString("yyyyMMdd");
            }
            set
            {
                this.OPRDAT = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.OPRDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 参考号	C(30)
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 请求状态	C(3)	附录A.5
        /// </summary>
        public string REQSTS { get; set; }
        /// <summary>
        /// 业务处理结果	C(1)	附录 A.6
        /// </summary>
        public string RTNFLG { get; set; }
        /// <summary>
        /// 附件标志	C(1)
        /// </summary>
        public string ATHFLG { get; set; }
        /// <summary>
        /// 保留字 30	C(30)
        /// </summary>
        public string RSV30Z { get; set; }
    }
}
