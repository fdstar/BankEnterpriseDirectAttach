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
    /// 贴现申请经办请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLTIEXSQ : RqBase<RS_DLTIEXSQ>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLTIEXSQ"; set { } }
        /// <summary>
        /// 客户流水号 varchar (20)
        /// </summary>
        [XmlElement("clientID")]
        public string ClientID { get; set; }
        /// <summary>
        /// 签约账号 char(19)
        /// </summary>
        [XmlElement("accountNo")]
        public string AccountNo { get; set; }
        /// <summary>
        /// 电子票据序列号 char(30)
        /// </summary>
        [XmlElement("billNo")]
        public string BillNo { get; set; }
        /// <summary>
        /// 贴入人是否为中信银行标志 char(1)，0:是1:否
        /// </summary>
        [XmlElement("dsbkIsCitic")]
        public int DsbkIsCitic { get; set; }
        /// <summary>
        /// 贴入人名称 varchar(122)
        /// </summary>
        [XmlElement("dsbkName")]
        public string DsbkName { get; set; }
        /// <summary>
        /// 贴入人账号 varchar(32)，贴入人为我行，贴入人账户为"0"
        /// </summary>
        [XmlElement("dsbkAccNo")]
        public string DsbkAccNo { get; set; }
        /// <summary>
        /// 贴入人行号 varchar(20)
        /// </summary>
        [XmlElement("dsbkBnm")]
        public string DsbkBnm { get; set; }
        /// <summary>
        /// 贴现种类 char(4)，RM00买断式，RM01回购式
        /// </summary>
        [XmlElement("dscntType")]
        public string DscntType { get; set; }
        /// <summary>
        /// 赎回起始日 char(8) 格式YYYYMMDD，可空， 贴现类型为"回购式"时必填
        /// </summary>
        [XmlIgnore]
        public DateTime? RpdStartDate { get; set; }
        /// <summary>
        /// 赎回起始日 char(8) 格式YYYYMMDD, 对应<see cref="RpdStartDate"/>
        /// </summary>
        [XmlElement("rpdStartDate")]
        public string RpdStartDateStr
        {
            get
            {
                return this.RpdStartDate?.ToString("yyyyMMdd");
            }
            set
            {
                this.RpdStartDate = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.RpdStartDate = tmp;
                }
            }
        }
        /// <summary>
        /// 赎回到期日 char(8) 格式YYYYMMDD，可空， 贴现类型为"回购式"时必填
        /// </summary>
        [XmlIgnore]
        public DateTime? RpdDueDate { get; set; }
        /// <summary>
        /// 赎回到期日 char(8) 格式YYYYMMDD, 对应<see cref="RpdDueDate"/>
        /// </summary>
        [XmlElement("rpdDueDate")]
        public string RpdDueDateStr
        {
            get
            {
                return this.RpdDueDate?.ToString("yyyyMMdd");
            }
            set
            {
                this.RpdDueDate = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.RpdDueDate = tmp;
                }
            }
        }
        /// <summary>
        /// 赎回利率 decimal(9.7)，可空， 贴现类型为"回购式"时，选填
        /// </summary>
        [XmlElement("rpdRate")]
        public decimal? RpdRate { get; set; }
        /// <summary>
        /// 赎回实付金额 decimal(15.2)，可空， 贴现类型为"回购式"时，选填
        /// </summary>
        [XmlElement("rpdAmt")]
        public decimal? RpdAmt { get; set; }
        /// <summary>
        /// 贴现利率 decimal(9.7)，年利率
        /// </summary>
        [XmlElement("dscntRate")]
        public decimal DscntRate { get; set; }
        /// <summary>
        /// 入账账号 varchar(32)，可空
        /// </summary>
        [XmlElement("aoaiAccNo")]
        public string AoaiAccNo { get; set; }
        /// <summary>
        /// 入账行号 varchar(20)，可空
        /// </summary>
        [XmlElement("aoaiBnm")]
        public string AoaiBnm { get; set; }
        /// <summary>
        /// 转让标识 char(4)，EM00可再转让，EM01不可再转让，如为"回购式"不得填"EM01"
        /// </summary>
        [XmlElement("endorseMk")]
        public string EndorseMk { get; set; }
        /// <summary>
        /// 实付金额 decimal(15.2)，可空，贴入人非中信银行即TT03贴现(他行)时，必输；转贴现、再贴现时必输
        /// </summary>
        [XmlElement("realAmt")]
        public decimal? RealAmt { get; set; }
        /// <summary>
        /// 付息方式 char(2)，可空，直贴贴入行为我行时有效，01买方付息，02卖方付息，03协议付息，04第三方付息
        /// </summary>
        [XmlElement("inteMthd")]
        public string InteMthd { get; set; }
        /// <summary>
        /// 资金划扣方式 char(1)，可空，0 银行划扣 1客户划扣
        /// </summary>
        [XmlElement("payMthd")]
        public string PayMthd { get; set; }
        /// <summary>
        /// 合同编号 char(32)，可空
        /// </summary>
        [XmlElement("contractNo")]
        public string ContractNo { get; set; }
        /// <summary>
        /// 发票编号 char(30)，可空
        /// </summary>
        [XmlElement("invoiceNo")]
        public string InvoiceNo { get; set; }
        /// <summary>
        /// ECDS批次号 varchar(10) 可空 ；不为空时必须为数字
        /// </summary>
        [XmlElement("ecdsBatNo")]
        public string EcdsBatNo { get; set; }
        /// <summary>
        /// 经办备注 varchar(256)，可空
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }
        /// <summary>
        /// 预约支付标志 0：非预约1：预约 char(1)
        /// </summary>
        [XmlElement("preFlg")]
        public int PreFlg { get; set; }
        /// <summary>
        /// 预约支付时间
        /// </summary>
        [XmlIgnore]
        public DateTime? AppointmentTime { get; set; }
        /// <summary>
        /// 预约支付日期 预约时非空 char(8) 格式YYYYMMDD
        /// </summary>
        [XmlElement("preDate")]
        public string PreDateStr
        {
            get
            {
                return this.AppointmentTime?.ToString("yyyyMMdd");
            }
            set { }
        }
    }
    /// <summary>
    /// 转贴现申请经办请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLZHTXSQ : RQ_DLTIEXSQ
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLZHTXSQ"; set { } }
    }
    /// <summary>
    /// 再贴现申请经办请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLZATXSQ : RQ_DLTIEXSQ
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLZATXSQ"; set { } }
    }
}
