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
    /// 发货通知响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLCDRGNQ : RsBase
    {
        /// <summary>
        /// 收货通知书编号 varchar(20)
        /// </summary>
        [XmlElement("rcvcmdntcNo")]
        public string RcvcmdntcNo { get; set; }
        /// <summary>
        /// 核心企业名称 varchar(122)
        /// </summary>
        [XmlElement("corentNm")]
        public string CorentNm { get; set; }
        /// <summary>
        /// （在库）监管企业名称 varchar(122)
        /// </summary>
        [XmlElement("spventNm")]
        public string SpventNm { get; set; }
        /// <summary>
        /// （在途）监管企业名称 varchar(122)
        /// </summary>
        [XmlElement("onwspveNm")]
        public string OnwspveNm { get; set; }
        /// <summary>
        /// 运输企业名称 varchar(122)
        /// </summary>
        [XmlElement("trsptentNm")]
        public string TrsptentNm { get; set; }
        /// <summary>
        /// 借款企业id varchar(30)
        /// </summary>
        [XmlElement("lonentId")]
        public string LonentId { get; set; }
        /// <summary>
        /// 借款企业名称 varchar(122)
        /// </summary>
        [XmlElement("lonentNm")]
        public string LonentNm { get; set; }
        /// <summary>
        /// 发货日期 char(8)，格式YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime CsnDate { get; set; }
        /// <summary>
        /// 发货日期 char(8)，格式YYYYMMDD, 对应<see cref="CsnDate"/>
        /// </summary>
        [XmlElement("csnDate")]
        public string CsnDateStr
        {
            get
            {
                return this.CsnDate.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.CsnDate = tmp;
                }
            }
        }
        /// <summary>
        /// 预计到港(库)日期 char(8)，格式YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime EtaDate { get; set; }
        /// <summary>
        /// 预计到港(库)日期 char(8)，格式YYYYMMDD, 对应<see cref="EtaDate"/>
        /// </summary>
        [XmlElement("etaDate")]
        public string EtaDateStr
        {
            get
            {
                return this.EtaDate.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.EtaDate = tmp;
                }
            }
        }
        /// <summary>
        /// 预计到港(库) varchar(200)
        /// </summary>
        [XmlElement("epa")]
        public string Epa { get; set; }
        /// <summary>
        /// 纸质监管协议编号 varchar(100)
        /// </summary>
        [XmlElement("offlnsatNo")]
        public string OfflnsatNo { get; set; }
        /// <summary>
        /// 通知书日期 char(8)，格式YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime NtcDate { get; set; }
        /// <summary>
        /// 通知书日期 char(8)，格式YYYYMMDD, 对应<see cref="NtcDate"/>
        /// </summary>
        [XmlElement("ntcDate")]
        public string NtcDateStr
        {
            get
            {
                return this.NtcDate.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.NtcDate = tmp;
                }
            }
        }
        /// <summary>
        /// 货物价值合计 decimal(19,2)
        /// </summary>
        [XmlElement("ttlcmdval")]
        public decimal Ttlcmdval { get; set; }
        /// <summary>
        /// 交货地点 varchar(200)
        /// </summary>
        [XmlElement("excPlace")]
        public string ExcPlace { get; set; }
        /// <summary>
        /// 备注 varchar(200)
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }
        /// <summary>
        /// 属性1 varchar(30) ，按约定返回
        /// </summary>
        [XmlElement("field1")]
        public string Field1 { get; set; }
        /// <summary>
        /// 属性2 varchar(60) ，按约定返回
        /// </summary>
        [XmlElement("field2")]
        public string Field2 { get; set; }
        /// <summary>
        /// 属性3 varchar(100) ，按约定返回
        /// </summary>
        [XmlElement("field3")]
        public string Field3 { get; set; }
        /// <summary>
        /// 总记录数 integer
        /// </summary>
        [XmlElement("totnum")]
        public int Totnum { get; set; }

        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<DeliveryInfo> List { get; set; }
    }
    /// <summary>
    /// 发货信息
    /// </summary>
    public class DeliveryInfo
    {
        /// <summary>
        /// 实际订单纸质编号 varchar(20)
        /// </summary>
        [XmlElement("idtplanNo")]
        public string IdtplanNo { get; set; }
        /// <summary>
        /// 实际订单名称 varchar(100)
        /// </summary>
        [XmlElement("idtplanNm")]
        public string IdtplanNm { get; set; }
        /// <summary>
        /// 商品代码 varchar(60)
        /// </summary>
        [XmlElement("cmdCode")]
        public string CmdCode { get; set; }
        /// <summary>
        /// 商品名称 varchar(200)
        /// </summary>
        [XmlElement("cmdName")]
        public string CmdName { get; set; }
        /// <summary>
        /// 发货数量 decimal(19,2)
        /// </summary>
        [XmlElement("csnNum")]
        public decimal CsnNum { get; set; }
        /// <summary>
        /// 计量单位 varchar(20)
        /// </summary>
        [XmlElement("unit")]
        public string Unit { get; set; }
        /// <summary>
        /// 发货单价 decimal(19,2)
        /// </summary>
        [XmlElement("csnprc")]
        public decimal Csnprc { get; set; }
        /// <summary>
        /// 发货价值 decimal(19,2)
        /// </summary>
        [XmlElement("reqcsnval")]
        public decimal Reqcsnval { get; set; }
        /// <summary>
        /// scf放款批次号 varchar(15)
        /// </summary>
        [XmlElement("scflonNo")]
        public string ScflonNo { get; set; }
        /// <summary>
        /// 质押合同编号 varchar(20)
        /// </summary>
        [XmlElement("mtgcntNo")]
        public string MtgcntNo { get; set; }
        /// <summary>
        /// 备注 varchar(200)
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }
        /// <summary>
        /// 车架号 varchar(40)
        /// </summary>
        [XmlElement("vin")]
        public string Vin { get; set; }
        /// <summary>
        /// 合格证编号 varchar(50)
        /// </summary>
        [XmlElement("hgzNo")]
        public string HgzNo { get; set; }
        /// <summary>
        /// 车价 decimal(19,2)
        /// </summary>
        [XmlElement("carPrice")]
        public decimal CarPrice { get; set; }
        /// <summary>
        /// 融资编号 varchar(30)
        /// </summary>
        [XmlElement("loanCode")]
        public string LoanCode { get; set; }
        /// <summary>
        /// 属性4 varchar(50) ，按约定返回
        /// </summary>
        [XmlElement("field4")]
        public string Field4 { get; set; }
        /// <summary>
        /// 属性5 varchar(50) ，按约定返回
        /// </summary>
        [XmlElement("field5")]
        public string Field5 { get; set; }
        /// <summary>
        /// 属性6 varchar(50) ，按约定返回
        /// </summary>
        [XmlElement("field6")]
        public string Field6 { get; set; }
        /// <summary>
        /// 属性7 varchar(100) ，按约定返回
        /// </summary>
        [XmlElement("field7")]
        public string Field7 { get; set; }
        /// <summary>
        /// 属性8 varchar(100) ，按约定返回
        /// </summary>
        [XmlElement("field8")]
        public string Field8 { get; set; }
        /// <summary>
        /// 属性9 varchar(200) ，按约定返回
        /// </summary>
        [XmlElement("field9")]
        public string Field9 { get; set; }
    }
}
