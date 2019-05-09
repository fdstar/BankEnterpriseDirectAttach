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
    /// 31.2.内部户MT940业务综合查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS31_2 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTIAMQYD
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTIAMQYD";
        /// <summary>
        /// 31.2.内部户MT940业务综合查询响应集合
        /// </summary>
        [XmlElement("NTIAMQYDZ1")]
        public List<NTIAMQYDZ1> List { get; set; }
    }
    /// <summary>
    /// 31.2.内部户MT940业务综合查询响应内容
    /// </summary>
    public class NTIAMQYDZ1
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
        /// 分行号	C(2)
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 活期结算户	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 内部户	C(35)
        /// </summary>
        public string INANBR { get; set; }
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
        /// <summary>
        /// 请求状态 	C(3)
        /// </summary>
        public string REQSTA { get; set; }
        /// <summary>
        /// 请求结果 	C(1) 
        /// </summary>
        public string RTNFLG { get; set; }
        /// <summary>
        /// 对方参考号	C(30)
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 结果描述	Z(192)
        /// </summary>
        public string RTNTXT { get; set; }
    }
}