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
    /// 8.6.4.组合存款业务综合查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS8_6_4 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTCMALST
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTCMALST";
        /// <summary>
        /// 8.6.4.组合存款业务综合查询响应集合
        /// </summary>
        [XmlElement("NTCMALSTZ1")]
        public List<NTCMALSTZ1> List { get; set; }
    }
    /// <summary>
    /// 8.6.4.组合存款业务综合查询响应内容
    /// </summary>
    public class NTCMALSTZ1
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
        /// 业务模式	C(5)
        /// </summary>
        public string BUSMOD { get; set; }
        /// <summary>
        /// 操作类型	C(4)    FDRL-关联智能定期账号 FDRD-取消关联智能定期账号
        /// </summary>
        public string OPRTYP { get; set; }
        /// <summary>
        /// 分行号	C(2)
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 活期帐号	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 业务参考号	C(30)
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 协议编号	C(8)
        /// </summary>
        public string CSTNBR { get; set; }
        /// <summary>
        /// 请求状态	C(3)
        /// </summary>
        public string REQSTA { get; set; }
        /// <summary>
        /// 业务处理结果	C(1)
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
    }
}
