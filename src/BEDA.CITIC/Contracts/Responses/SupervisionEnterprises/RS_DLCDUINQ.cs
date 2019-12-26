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
    /// 解除质押通知响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLCDUINQ : RsBase
    {
        /// <summary>
        /// 解除质押通知书编号 varchar(20)
        /// </summary>
        [XmlElement("rlsmgntcNo")]
        public string RlsmgntcNo { get; set; }
        /// <summary>
        /// 经办行 varchar(122)
        /// </summary>
        [XmlElement("operOrg")]
        public string OperOrg { get; set; }
        /// <summary>
        /// 出质人名称 varchar(122)
        /// </summary>
        [XmlElement("mtgpsnNm")]
        public string MtgpsnNm { get; set; }
        /// <summary>
        /// 借款企业id varchar(30)
        /// </summary>
        [XmlElement("loaentId")]
        public string LoaentId { get; set; }
        /// <summary>
        /// 借款企业名称 varchar(122)
        /// </summary>
        [XmlElement("lonentNm")]
        public string LonentNm { get; set; }
        /// <summary>
        /// 监管企业名称 varchar(122)
        /// </summary>
        [XmlElement("spventNm")]
        public string SpventNm { get; set; }
        /// <summary>
        /// 核心企业名称 varchar(122)
        /// </summary>
        [XmlElement("corentNm")]
        public string CorentNm { get; set; }
        /// <summary>
        /// 解除质押日期 char(8)，格式YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime RlsmgDate { get; set; }
        /// <summary>
        /// 解除质押日期 char(8)，格式YYYYMMDD, 对应<see cref="RlsmgDate"/>
        /// </summary>
        [XmlElement("rlsmgDate")]
        public string RlsmgDateStr
        {
            get
            {
                return this.RlsmgDate.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.RlsmgDate = tmp;
                }
            }
        }
        /// <summary>
        /// 出库原因 varchar(200)
        /// </summary>
        [XmlElement("ostkrsn")]
        public string Ostkrsn { get; set; }
        /// <summary>
        /// 通知日期 char(8)，格式YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime NtcDate { get; set; }
        /// <summary>
        /// 通知日期 char(8)，格式YYYYMMDD, 对应<see cref="NtcDate"/>
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
        /// 中信银行集合列表
        /// </summary>
        [XmlElement("list")]
        public List<CITICCollection<PledgeReleasedInfo>> List { get; set; }
    }
    /// <summary>
    /// 解除质押信息
    /// </summary>
    public class PledgeReleasedInfo
    {
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
        /// 计量单位 varchar(20)
        /// </summary>
        [XmlElement("unit")]
        public string Unit { get; set; }
        /// <summary>
        /// 库存数量 decimal(19,2)
        /// </summary>
        [XmlElement("stkNum")]
        public decimal StkNum { get; set; }
        /// <summary>
        /// 解除质押数量 decimal(19,2)
        /// </summary>
        [XmlElement("rlsmgNum")]
        public decimal RlsmgNum { get; set; }
        /// <summary>
        /// 所在仓库编号 varchar(20)
        /// </summary>
        [XmlElement("whCode")]
        public string WhCode { get; set; }
        /// <summary>
        /// scf放款批次号 varchar(15)
        /// </summary>
        [XmlElement("scflonNo")]
        public string ScflonNo { get; set; }
        /// <summary>
        /// 动产质押担保合同编号 varchar(100)
        /// </summary>
        [XmlElement("grtcntNo")]
        public string GrtcntNo { get; set; }
        /// <summary>
        /// 移库数量 decimal(19,2)
        /// </summary>
        [XmlElement("mvstkNum")]
        public decimal MvstkNum { get; set; }
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
        /// 属性9 varchar(100) ，按约定返回
        /// </summary>
        [XmlElement("field9")]
        public string Field9 { get; set; }


        /// <summary>
        /// 赎货经办人姓名 varchar(122)
        /// </summary>
        [XmlElement("rdmoprName")]
        public string RdmoprName { get; set; }
        /// <summary>
        /// 赎货经办人身份证号码 varchar(18)
        /// </summary>
        [XmlElement("rdmopridNo")]
        public string RdmopridNo { get; set; }
    }
}
