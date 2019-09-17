using BEDA.CITIC.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CITIC.Contracts.Requests
{
    /// <summary>
    /// 发货/退货信息发送请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLCDRGSM : RqBase<RS_DLCDRGSM>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLCDRGSM"; set { } }

        /// <summary>
        /// 借款企业组织机构代码 varchar(12) ，可空
        /// </summary>
        [XmlElement("orgCode")]
        public string OrgCode { get; set; }
        /// <summary>
        /// 流水号 varchar(20)，企业端交易流水号
        /// </summary>
        [XmlElement("serialNo")]
        public string SerialNo { get; set; }
        /// <summary>
        /// 借款企业ID varchar(20)，企业系统内部的经销商编号
        /// </summary>
        [XmlElement("lonCpID")]
        public string LonCpID { get; set; }
        /// <summary>
        /// 协议编号 ，SCF放款申请时上送给企业端varchar(60) ，可空
        /// </summary>
        [XmlElement("agtNo")]
        public string AgtNo { get; set; }
        /// <summary>
        /// 业务模式 varchar(20) ，可空，取值为：汽车-先票后货三方；汽车-先票后货两方；汽车-保兑仓
        /// </summary>
        [XmlElement("bizMod")]
        public string BizMod { get; set; }
        /// <summary>
        /// 放款批次号，SCF放款申请时上送给企业端 varchar(15) ，可空
        /// </summary>
        [XmlElement("scfTxNo")]
        public string ScfTxNo { get; set; }
        /// <summary>
        /// 授信产品 varchar(20) ，可空，取值为：银行承兑汇票；流动资金贷款；法人账户透支；商票贴现；国内信用证；进口信用证；非信用证项下进口押汇
        /// </summary>
        [XmlElement("cdtprod")]
        public string Cdtprod { get; set; }
        /// <summary>
        /// 承运人 varchar(122) ，可空
        /// </summary>
        [XmlElement("carr")]
        public string Carr { get; set; }
        /// <summary>
        /// 目的地 varchar(256) ，可空
        /// </summary>
        [XmlElement("dest")]
        public string Dest { get; set; }
        /// <summary>
        /// 预计到货日期 char(8) ，可空，格式YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime? ExparrDt { get; set; }
        /// <summary>
        /// 预计到货日期 char(8) ，可空，格式YYYYMMDD, 对应<see cref="ExparrDt"/>
        /// </summary>
        [XmlElement("exparrDt")]
        public string ExparrDtStr
        {
            get
            {
                return this.ExparrDt?.ToString("yyyyMMdd");
            }
            set
            {
                this.ExparrDt = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.ExparrDt = tmp;
                }
            }
        }
        /// <summary>
        /// 属性1 varchar(30)，发货状态：1发货，2退货
        /// </summary>
        [XmlElement("field1")]
        public string Field1 { get; set; }
        /// <summary>
        /// 属性2 varchar(60)，可空，按约定上送
        /// </summary>
        [XmlElement("field2")]
        public string Field2 { get; set; }
        /// <summary>
        /// 属性3 varchar(100)，可空，按约定上送
        /// </summary>
        [XmlElement("field3")]
        public string Field3 { get; set; }


        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlElement("list")]
        public CITICCollection<GoodsInfo> Collection { get; set; }
    }
    /// <summary>
    /// 发货/退货信息
    /// </summary>
    public class GoodsInfo
    {
        /// <summary>
        /// 属性4 varchar(30)，车架号，按约定上送
        /// </summary>
        [XmlElement("field4")]
        public string Field4 { get; set; }
        /// <summary>
        /// 属性5 decimal(19,2)，车价，按约定上送
        /// </summary>
        [XmlElement("field5")]
        public string Field5 { get; set; }
        /// <summary>
        /// 属性6 varchar(10)，汽车状态，可空，按约定上送
        /// </summary>
        [XmlElement("field6")]
        public string Field6 { get; set; }
        /// <summary>
        /// 属性7 varchar(30)，发动机号，可空，按约定上送
        /// </summary>
        [XmlElement("field7")]
        public string Field7 { get; set; }
        /// <summary>
        /// 品牌varchar(40) ，可空，按约定上送
        /// </summary>
        [XmlElement("brand")]
        public string Brand { get; set; }
        /// <summary>
        /// 属性8 varchar(200)，车型，可空，按约定上送
        /// </summary>
        [XmlElement("field8")]
        public string Field8 { get; set; }
        /// <summary>
        /// 属性9 varchar(30)，款式，可空，按约定上送
        /// </summary>
        [XmlElement("field9")]
        public string Field9 { get; set; }
        /// <summary>
        /// 属性10 varchar(60)，配置，可空，按约定上送
        /// </summary>
        [XmlElement("field10")]
        public string Field10 { get; set; }
        /// <summary>
        /// 合格证编号 varchar(60)，合格证编号，按约定上送
        /// </summary>
        [XmlElement("hgzNo")]
        public string HgzNo { get; set; }
        /// <summary>
        /// 属性11 varchar(100)，票号（融资编号），按约定上送
        /// </summary>
        [XmlElement("field11")]
        public string Field11 { get; set; }
    }
}