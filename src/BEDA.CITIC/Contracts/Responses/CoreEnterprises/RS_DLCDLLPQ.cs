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
    /// 融资详情查询响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLCDLLPQ : RsBase
    {
        /// <summary>
        /// SCF放款批次号 varchar(15)
        /// </summary>
        [XmlElement("scfTxNo")]
        public string ScfTxNo { get; set; }
        /// <summary>
        /// 借款企业组织机构代码 varchar(12)
        /// </summary>
        [XmlElement("orgCode")]
        public string OrgCode { get; set; }
        /// <summary>
        /// 借款企业ID varchar(20)，企业客户号
        /// </summary>
        [XmlElement("lonCpID")]
        public string LonCpID { get; set; }
        /// <summary>
        /// 协议编号 varchar(60)
        /// </summary>
        [XmlElement("agtNo")]
        public string AgtNo { get; set; }
        /// <summary>
        /// 操作人编号，企业端操作人员编号varchar(20)
        /// </summary>
        [XmlElement("optNo")]
        public string OptNo { get; set; }
        /// <summary>
        /// 操作人姓名 varchar(60)
        /// </summary>
        [XmlElement("optNam")]
        public string OptNam { get; set; }
        /// <summary>
        /// 业务模式 varchar(20) ，取值为：汽车-先票后货三方；汽车-先票后货两方；汽车-保兑仓
        /// </summary>
        [XmlElement("bizMod")]
        public string BizMod { get; set; }
        /// <summary>
        /// 授信产品 varchar(20) ，取值为：银行承兑汇票；流动资金贷款；法人账户透支；商票贴现；国内信用证；进口信用证；非信用证项下进口押汇
        /// </summary>
        [XmlElement("cdtprod")]
        public string Cdtprod { get; set; }
        /// <summary>
        /// 流水号 varchar(20)
        /// </summary>
        [XmlElement("srlNo")]
        public string SrlNo { get; set; }
        /// <summary>
        /// 订货计划类型 varchar(20)
        /// </summary>
        [XmlElement("odpltTyp")]
        public string OdpltTyp { get; set; }
        /// <summary>
        /// 订货计划总金额 decimal(19,2)
        /// </summary>
        [XmlElement("tamTodpl")]
        public decimal TamTodpl { get; set; }
        /// <summary>
        /// 车辆类型 varchar(100)
        /// </summary>
        [XmlElement("carType")]
        public string CarType { get; set; }
        /// <summary>
        /// 首付款保证金比例 decimal(9,6)，融资信息
        /// </summary>
        [XmlElement("fstdpsRt")]
        public decimal FstdpsRt { get; set; }
        /// <summary>
        /// 首付款保证金金额 decimal(19,2)，融资信息
        /// </summary>
        [XmlElement("fstdpsAmt")]
        public decimal FstdpsAmt { get; set; }
        /// <summary>
        /// 自有资金金额 decimal(19,2)，融资信息
        /// </summary>
        [XmlElement("eqcptAmt")]
        public decimal EqcptAmt { get; set; }
        /// <summary>
        /// 自有资金比例 decimal(9,6)，融资信息
        /// </summary>
        [XmlElement("eqcptRt")]
        public decimal EqcptRt { get; set; }
        /// <summary>
        /// 融资金额 decimal(19,2)
        /// </summary>
        [XmlElement("lonAmt")]
        public decimal LonAmt { get; set; }
        /// <summary>
        /// 融资申请日 char(8)，格式YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime LonAplDt { get; set; }
        /// <summary>
        /// 融资申请日 char(8)，格式YYYYMMDD, 对应<see cref="LonAplDt"/>
        /// </summary>
        [XmlElement("lonAplDt")]
        public string LonAplDtStr
        {
            get
            {
                return this.LonAplDt.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.LonAplDt = tmp;
                }
            }
        }
        /// <summary>
        /// 属性1 varchar(30)，按约定返回
        /// </summary>
        [XmlElement("field1")]
        public string Field1 { get; set; }
        /// <summary>
        /// 属性2 varchar(30)，按约定返回
        /// </summary>
        [XmlElement("field2")]
        public string Field2 { get; set; }
        /// <summary>
        /// 属性3 varchar(60)，按约定返回
        /// </summary>
        [XmlElement("field3")]
        public string Field3 { get; set; }
        /// <summary>
        /// 属性4 varchar(60)，按约定返回
        /// </summary>
        [XmlElement("field4")]
        public string Field4 { get; set; }
        /// <summary>
        /// 属性5 varchar(100) ，按约定返回
        /// </summary>
        [XmlElement("field5")]
        public string Field5 { get; set; }
        /// <summary>
        /// 属性6 varchar(100) ，按约定返回
        /// </summary>
        [XmlElement("field6")]
        public string Field6 { get; set; }
        /// <summary>
        /// 属性7 decimal(19,2) ，按约定返回
        /// </summary>
        [XmlElement("field7")]
        public decimal? Field7 { get; set; }

        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<FinancingDetail> List { get; set; }
    }
    /// <summary>
    /// 融资详情
    /// </summary>
    public class FinancingDetail
    {
        /// <summary>
        /// 属性8  varchar(30)，如：数量，按约定返回
        /// </summary>
        [XmlElement("field8")]
        public string Field8 { get; set; }
        /// <summary>
        /// 属性9  decimal(19,2)，如：车价，按约定返回
        /// </summary>
        [XmlElement("field9")]
        public decimal? Field9 { get; set; }
        /// <summary>
        /// 属性10 varchar(30) ，按约定返回
        /// </summary>
        [XmlElement("field10")]
        public string Field10 { get; set; }
        /// <summary>
        /// 属性11 varchar(60) ，按约定返回
        /// </summary>
        [XmlElement("field11")]
        public string Field11 { get; set; }
        /// <summary>
        /// 属性12 varchar(60) ，按约定返回
        /// </summary>
        [XmlElement("field12")]
        public string Field12 { get; set; }
        /// <summary>
        /// 属性13 varchar(100)，如：车型（拼合），按约定返回
        /// </summary>
        [XmlElement("field13")]
        public string Field13 { get; set; }
        /// <summary>
        /// 属性14 varchar(100) ，按约定返回
        /// </summary>
        [XmlElement("field14")]
        public string Field14 { get; set; }
        /// <summary>
        /// 属性15 varchar(200) ，按约定返回
        /// </summary>
        [XmlElement("field15")]
        public string Field15 { get; set; }
    }
}
