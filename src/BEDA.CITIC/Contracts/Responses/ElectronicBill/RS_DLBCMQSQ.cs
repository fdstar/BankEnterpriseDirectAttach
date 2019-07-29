using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CITIC.Contracts.Responses
{
    /// <summary>
    /// 接收方签收信息查询响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLBCMQSQ : RsBase
    {
        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<ReceiverSignsInfo> List { get; set; }
    }
    /// <summary>
    /// 接收方签收信息
    /// </summary>
    public class ReceiverSignsInfo
    {
        /// <summary>
        /// 交易状态 char(7)
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
        /// <summary>
        /// 交易状态信息 varchar(254)
        /// </summary>
        [XmlElement("statusText")]
        public string StatusText { get; set; }
        /// <summary>
        /// 对方回复备注 varchar(256)
        /// </summary>
        [XmlElement("RCVMEMO")]
        public string RCVMEMO { get; set; }
        /// <summary>
        /// 保证人地址 varchar(256)
        /// </summary>
        [XmlElement("WAREADR")]
        public string WAREADR { get; set; }
        /// <summary>
        /// 协议号 char(30)
        /// </summary>
        [XmlElement("PROTOCOLNO")]
        public string PROTOCOLNO { get; set; }
        /// <summary>
        /// 回复日期 char(8)格式YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime RSPDATE { get; set; }
        /// <summary>
        /// 回复日期 char(8)格式YYYYMMDD, 对应<see cref="RSPDATE"/>
        /// </summary>
        [XmlElement("RSPDATE")]
        public string RSPDATEStr
        {
            get
            {
                return this.RSPDATE.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.RSPDATE = tmp;
                }
            }
        }
        /// <summary>
        /// 代理回复标记 char(4) 在收票回复、单位间转让背书的背书回复、提示付款回复和逾期提示付款回复时，代理回复标识为“银行代理”或“客户自己签章”，其他回复必须为“客户自己签章” PS00开户机构代理回复签章 PS01客户自己签章
        /// </summary>
        [XmlElement("AGRSPMK")]
        public string AGRSPMK { get; set; }
        /// <summary>
        /// 回复标记 char(4)
        /// </summary>
        [XmlElement("RSPMARK")]
        public string RSPMARK { get; set; }
        /// <summary>
        /// 到期无条件支付 char(4) 若不为空只能是CC00
        /// </summary>
        [XmlElement("UNCNPAY")]
        public string UNCNPAY { get; set; }
        /// <summary>
        /// 拒付理由代码 char(4) 见附录4.1.6
        /// </summary>
        [XmlElement("DSHNRCD")]
        public string DSHNRCD { get; set; }
        /// <summary>
        /// 拒付备注 varchar(256) 拒付代码为 DC09时，填写
        /// </summary>
        [XmlElement("DSHNRSN")]
        public string DSHNRSN { get; set; }
        /// <summary>
        /// 追索理由代码 char(4)，非拒付追索时填写 RC00 承兑人被依法宣告破产； RC01 承兑人因违法被责令终止活动
        /// </summary>
        [XmlElement("RCRSBCD")]
        public string RCRSBCD { get; set; }
        /// <summary>
        /// 逾期原因说明 char(256)
        /// </summary>
        [XmlElement("ODUERSN")]
        public string ODUERSN { get; set; }
    }
}