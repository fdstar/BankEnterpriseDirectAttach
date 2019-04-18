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
    /// 8.3.10.交易综合查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS8_3_10 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTQRYQDI
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTQRYQDI";
        /// <summary>
        /// 8.3.10.交易综合查询响应集合
        /// </summary>
        [XmlElement("NTWAUQDIZ")]
        public List<NTWAUQDIZ> List { get; set; }
    }
    /// <summary>
    /// 8.3.10.交易综合查询响应内容
    /// </summary>
    public class NTWAUQDIZ
    {
        /// <summary>
        /// 流程实例号	C(10)
        /// </summary>
        public string REQNBR { get; set; }
        /// <summary>
        /// 业务编码	C(6)
        /// </summary>
        public string BUSCOD { get; set; }
        /// <summary>
        /// 交易类型	C(4)
        /// </summary>
        public string RQSCOD { get; set; }
        /// <summary>
        /// 业务模式	C(5)
        /// </summary>
        public string BUSMOD { get; set; }
        /// <summary>
        /// 分行号	C(2)
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 户口号	C(35)
        /// </summary>
        public string EACNBR { get; set; }
        /// <summary>
        /// 产品代码	C(8)
        /// </summary>
        public string RIPCOD { get; set; }
        /// <summary>
        /// 币种	C(2)
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 交易金额	M
        /// </summary>
        public decimal TRSAMT { get; set; }
        /// <summary>
        /// 请求状态	C(3)	A.5 业务请求状态  补充：BAC=银行已受理
        /// </summary>
        public string REQSTS { get; set; }
        /// <summary>
        /// 处理结果	C(1)	A.6 业务处理结果
        /// </summary>
        public string RTNFLG { get; set; }
        /// <summary>
        /// 业务参考号	C(30)
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 经办日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime OPRDAT { get; set; }
        /// <summary>
        /// 经办日期	D, 对应<see cref="OPRDAT"/>
        /// </summary>
        [XmlElement("OPRDAT")]
        public string OPRDATStr
        {
            get
            {
                return this.OPRDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.OPRDAT = tmp;
                }
            }
        }
    }
}
