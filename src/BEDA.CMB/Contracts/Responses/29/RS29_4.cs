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
    /// 29.4.商户清分处理结果查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS29_4 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTSTMQTS
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTSTMQTS";
        /// <summary>
        /// 29.4.商户清分处理结果查询响应集合
        /// </summary>
        [XmlElement("NTSTMQTSZ1")]
        public List<NTSTMQTSZ1> List { get; set; }
    }
    /// <summary>
    /// 29.4.商户清分处理结果查询响应内容
    /// </summary>
    public class NTSTMQTSZ1
    {
        /// <summary>
        /// 流程实例号	C(10)
        /// </summary>
        public string REQNBR { get; set; }
        /// <summary>
        /// 业务模式 	C(5)
        /// </summary>
        public string BUSMOD { get; set; }
        /// <summary>
        /// 管理机构客户号	C(10)
        /// </summary>
        public string CLTNBR { get; set; }
        /// <summary>
        /// 行内商户号	C(20)
        /// </summary>
        public string MCHSID { get; set; }
        /// <summary>
        /// 收款账号	C(35)
        /// </summary>
        public string EACNBR { get; set; }
        /// <summary>
        /// 业务参考号	C(30)
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 金额     	M
        /// </summary>
        public decimal CCYAMT { get; set; }
        /// <summary>
        /// 请求状态 	C(3)
        /// </summary>
        public string REQSTA { get; set; }
        /// <summary>
        /// 请求结果 	C(1) 
        /// </summary>
        public string RTNFLG { get; set; }
        /// <summary>
        /// 经办日   	D
        /// </summary>
        [XmlIgnore]
        public DateTime OPRDAT { get; set; }
        /// <summary>
        /// 经办日   	D, 对应<see cref="OPRDAT"/>
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
        /// 结束日   	D
        /// </summary>
        [XmlIgnore]
        public DateTime ENDDAT { get; set; }
        /// <summary>
        /// 结束日   	D, 对应<see cref="ENDDAT"/>
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
        /// 失败原因 	Z(192)
        /// </summary>
        public string RSNTXT { get; set; }
    }
}
