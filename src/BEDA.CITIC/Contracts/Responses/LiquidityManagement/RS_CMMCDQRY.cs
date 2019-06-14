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
    /// 收拨明细查询响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_CMMCDQRY : RsBase
    {
        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<Liquidity> List { get; set; }
    }
    /// <summary>
    /// 收拨明细
    /// </summary>
    public class Liquidity
    {
        /// <summary>
        /// 对方开户行名称 char(122)
        /// </summary>
        public string MSOPBM { get; set; }
        /// <summary>
        /// 对方账号 char(19)
        /// </summary>
        public string MXOTAC { get; set; }
        /// <summary>
        /// 对方户名 char(122)
        /// </summary>
        public string MSOPNM { get; set; }
        /// <summary>
        /// 账户余额 decimal(15,2)
        /// </summary>
        public decimal MXACBL { get; set; }
        /// <summary>
        /// 账号 char(19)
        /// </summary>
        public string MXACNO { get; set; }
        /// <summary>
        /// 授权书编号 char(6)
        /// </summary>
        public string MXAUN2 { get; set; }
        /// <summary>
        /// 借贷标识char(1) D借，C贷
        /// </summary>
        public string MXCDFG { get; set; }
        /// <summary>
        /// 渠道 char(1)- N表示网银；C柜台；B日终批处理
        /// </summary>
        public string MXCHNN { get; set; }
        /// <summary>
        /// 协议编号 char(6)
        /// </summary>
        public string MXCON1 { get; set; }
        /// <summary>
        /// 现转标识 char(1) '0'：现金 '1'：转帐
        /// </summary>
        public int MXCTFG { get; set; }
        /// <summary>
        /// 主池ID char(8)
        /// </summary>
        public string MXGJID { get; set; }
        /// <summary>
        /// 总交易流水号 char(13)
        /// </summary>
        public string MXGTNO { get; set; }
        /// <summary>
        /// 集团内部账单余额 decimal(15,2)
        /// </summary>
        public decimal MXNBBL { get; set; }
        /// <summary>
        /// 金融标识 char(1) 0金融交易 1非金融交易
        /// </summary>
        public int MXNFFG { get; set; }
        /// <summary>
        /// 交易池ID char(8)
        /// </summary>
        public string MXPLID { get; set; }
        /// <summary>
        /// 凭证打印次数 char(2)
        /// </summary>
        public int MXPRNM { get; set; }
        /// <summary>
        /// 摘要 char(102)
        /// </summary>
        public string MXREMK { get; set; }
        /// <summary>
        /// 冲补标识 char(1) 0正常1 冲 2 补
        /// </summary>
        public int MXRVSB { get; set; }
        /// <summary>
        /// 记录状态 char(1) ‘A’：正常 ‘D’：冲帐
        /// </summary>
        public string MXSTCD { get; set; }
        /// <summary>
        /// 交易金额 decimal(15,2)
        /// </summary>
        public decimal MXTRAM { get; set; }
        /// <summary>
        /// 交易码 varchar(7)
        /// </summary>
        public string MXTRCD { get; set; }
        /// <summary>
        /// 交易描述 char(40)
        /// </summary>
        public string MXTRDE { get; set; }
        /// <summary>
        /// 交易日期 char(8)
        /// </summary>
        [XmlIgnore]
        public DateTime MXTRDT { get; set; }
        /// <summary>
        /// 交易日期 char(8), 对应<see cref="MXTRDT"/>
        /// </summary>
        [XmlElement("MXTRDT")]
        public string MXTRDTStr
        {
            get
            {
                return this.MXTRDT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.MXTRDT = tmp;
                }
            }
        }
        /// <summary>
        /// 柜员交易号 char(14)
        /// </summary>
        public string MXTRNO { get; set; }
        /// <summary>
        /// 交易柜员 char(10)
        /// </summary>
        public string MXTRTL { get; set; }
        /// <summary>
        /// 交易类别代码 char(2) 11：手工归集；12：自动归集；21：手工下拨；22：自动下拨；31：对外支付；41：外部来账
        /// </summary>
        public string MXTRTP { get; set; }
        /// <summary>
        /// 起息日期 char(8)
        /// </summary>
        [XmlIgnore]
        public DateTime MXVLDT { get; set; }
        /// <summary>
        /// 起息日期 char(8), 对应<see cref="MXVLDT"/>
        /// </summary>
        [XmlElement("MXVLDT")]
        public string MXVLDTStr
        {
            get
            {
                return this.MXVLDT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.MXVLDT = tmp;
                }
            }
        }
        /// <summary>
        /// 凭证号码 varchar(20)
        /// </summary>
        public string VCNM { get; set; }
        /// <summary>
        /// 凭证种类 char(60)
        /// </summary>
        public string VCTP { get; set; }
    }
}
