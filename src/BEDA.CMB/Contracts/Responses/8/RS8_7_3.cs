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
    /// 8.7.3.归集存款内部转账综合查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS8_7_3 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTCMCQRD
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTCMCQRD";
        /// <summary>
        /// 8.7.3.归集存款内部转账综合查询响应集合
        /// </summary>
        [XmlElement("NTCMCQRYZ1")]
        public List<NTCMCQRYZ1> List { get; set; }
    }
    /// <summary>
    /// 8.7.3.归集存款内部转账综合查询响应内容
    /// </summary>
    public class NTCMCQRYZ1
    {
        /// <summary>
        /// 流程实例号	C(10)
        /// </summary>
        public string REQNBR { get; set; }
        /// <summary>
        /// 业务类型	C(6)
        /// </summary>
        public string BUSCOD { get; set; }
        /// <summary>
        /// 分行号  	C(3) 	附录A.1
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 活期帐号	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 协议编号	C(8)
        /// </summary>
        public string CSTNBR { get; set; }
        /// <summary>
        /// 业务参考号	C(30)
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 币种    	C(2) 	附录A.3
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 转账金额	M
        /// </summary>
        public decimal TRSAMT { get; set; }
        /// <summary>
        /// 请求状态	C(3)	附录A.5
        /// </summary>
        public string REQSTA { get; set; }
        /// <summary>
        /// 业务处理结果	C(1)	附录A.6
        /// </summary>
        public string RTNFLG { get; set; }
        /// <summary>
        /// 经办日	D
        /// </summary>
        [XmlIgnore]
        public DateTime OPRDAT { get; set; }
        /// <summary>
        /// 经办日	D, 对应<see cref="OPRDAT"/>
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
        /// <summary>
        /// 附言	Z(62)
        /// </summary>
        public string OTHTXT { get; set; }
        /// <summary>
        /// 失败原因	C(192)
        /// </summary>
        public string RNSTXT { get; set; }
    }
}
