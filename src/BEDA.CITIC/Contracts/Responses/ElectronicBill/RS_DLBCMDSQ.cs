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
    /// 贴现电子合同查询响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLBCMDSQ : RsBase
    {
        /// <summary>
        /// 合同总笔数 char(3)
        /// </summary>
        [XmlElement("totalNum")]
        public int TotalNum { get; set; }

        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<DiscountElectronicContract> List { get; set; }
    }
    /// <summary>
    /// 贴现电子合同
    /// </summary>
    public class DiscountElectronicContract
    {
        /// <summary>
        /// 合同流水号 varchar(26)
        /// </summary>
        [XmlElement("contractFlwNo")]
        public string ContractFlwNo { get; set; }
        /// <summary>
        /// 合同编号 char(32)
        /// </summary>
        [XmlElement("contractNo")]
        public string ContractNo { get; set; }
        /// <summary>
        /// 业务类型 char(2) 01承兑 06 贴现
        /// </summary>
        [XmlElement("BUSTYPE")]
        public string BUSTYPE { get; set; }
        /// <summary>
        /// 入账机构 varchar(80)
        /// </summary>
        [XmlElement("PUTORGZ")]
        public string PUTORGZ { get; set; }
        /// <summary>
        /// 结算账号 char(19)
        /// </summary>
        [XmlElement("ACCTNUM")]
        public string ACCTNUM { get; set; }
        /// <summary>
        /// 合同金额	decimal(15，2)
        /// </summary>
        [XmlElement("BUSSUM")]
        public decimal BUSSUM { get; set; }
        /// <summary>
        /// 合同状态 char(2) 00待确认 01已确认 02退回修改 03已生效 04全部
        /// </summary>
        [XmlElement("CONTRST")]
        public string CONTRST { get; set; }
        /// <summary>
        /// 贴现协议号 char(32)
        /// </summary>
        [XmlElement("DSCNTRC")]
        public string DSCNTRC { get; set; }
        /// <summary>
        /// 贴现申请人名称 varchar(122)
        /// </summary>
        [XmlElement("DSAPNM")]
        public string DSAPNM { get; set; }
        /// <summary>
        /// 申请人住所 varchar(256)
        /// </summary>
        [XmlElement("DSAPADR")]
        public string DSAPADR { get; set; }
        /// <summary>
        /// 申请人邮政编码 char(6)
        /// </summary>
        [XmlElement("DSAPPST")]
        public string DSAPPST { get; set; }
        /// <summary>
        /// 申请人电话 char(20)
        /// </summary>
        [XmlElement("DSAPTEL")]
        public string DSAPTEL { get; set; }
        /// <summary>
        /// 申请人传真 char(11)
        /// </summary>
        [XmlElement("DSAPTAX")]
        public string DSAPTAX { get; set; }
        /// <summary>
        /// 申请人法定代表人 varchar(122)
        /// </summary>
        [XmlElement("DSAPFPR")]
        public string DSAPFPR { get; set; }
        /// <summary>
        /// 贴入行 varchar(122)
        /// </summary>
        [XmlElement("DSPNAM")]
        public string DSPNAM { get; set; }
        /// <summary>
        /// 贴入行住所 varchar(256)
        /// </summary>
        [XmlElement("DSCPADR")]
        public string DSCPADR { get; set; }
        /// <summary>
        /// 贴入行邮政编码 char(6)
        /// </summary>
        [XmlElement("DSCPPST")]
        public string DSCPPST { get; set; }
        /// <summary>
        /// 贴入行电话 char(20)
        /// </summary>
        [XmlElement("DSCPTEL")]
        public string DSCPTEL { get; set; }
        /// <summary>
        /// 贴入行传真 char(11)
        /// </summary>
        [XmlElement("DSCPTAX")]
        public string DSCPTAX { get; set; }
        /// <summary>
        /// 贴入法定代表人 varchar(122)
        /// </summary>
        [XmlElement("DSCPFPR")]
        public string DSCPFPR { get; set; }
        /// <summary>
        /// 协议签订地点 varchar(60)
        /// </summary>
        [XmlElement("DSSIGAD")]
        public string DSSIGAD { get; set; }
        /// <summary>
        /// 协议签订日期 char(8)格式YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime DSSIGDT { get; set; }
        /// <summary>
        /// 协议签订日期 char(8)格式YYYYMMDD, 对应<see cref="DSSIGDT"/>
        /// </summary>
        [XmlElement("DSSIGDT")]
        public string DSSIGDTStr
        {
            get
            {
                return this.DSSIGDT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.DSSIGDT = tmp;
                }
            }
        }
        /// <summary>
        /// 贴现协议项下汇票张数 char(3)
        /// </summary>
        [XmlElement("DRFTNUM")]
        public int DRFTNUM { get; set; }
        /// <summary>
        /// 贴现协议项下汇票金额合计 decimal(15，2)
        /// </summary>
        [XmlElement("DRFTAMT")]
        public decimal DRFTAMT { get; set; }
        /// <summary>
        /// 贴现资金用途 varchar(200)
        /// </summary>
        [XmlElement("DSCPOSE")]
        public string DSCPOSE { get; set; }
        /// <summary>
        /// 贴现协议年利率 decimal(9，7)
        /// </summary>
        [XmlElement("DSYRATE")]
        public decimal DSYRATE { get; set; }
        /// <summary>
        /// 买方付息买方名称 varchar(122)
        /// </summary>
        [XmlElement("DSBPAYR")]
        public string DSBPAYR { get; set; }
        /// <summary>
        /// 买方付息比例 decimal(9，7)
        /// </summary>
        [XmlElement("DSBPSCL")]
        public decimal DSBPSCL { get; set; }
        /// <summary>
        /// 买方付息金额 decimal(15，2)
        /// </summary>
        [XmlElement("DSBPAMT")]
        public decimal DSBPAMT { get; set; }
        /// <summary>
        /// 卖方付息比例 decimal(9，7)
        /// </summary>
        [XmlElement("DSSPAYR")]
        public decimal DSSPAYR { get; set; }
        /// <summary>
        /// 卖方付息金额 decimal(15，2)
        /// </summary>
        [XmlElement("DSSPAMT")]
        public decimal DSSPAMT { get; set; }
        /// <summary>
        /// 实付金额 decimal(15，2)
        /// </summary>
        [XmlElement("DSRPAMT")]
        public decimal DSRPAMT { get; set; }
        /// <summary>
        /// 其他约定事项 varchar(1024)
        /// </summary>
        [XmlElement("ELSPROS")]
        public string ELSPROS { get; set; }
        /// <summary>
        /// 争议解决方式选择 char(1) 1仲裁2诉讼
        /// </summary>
        [XmlElement("DISPUTE")]
        public int DISPUTE { get; set; }
        /// <summary>
        /// 仲裁委员会名称 varchar(60) 
        /// </summary>
        [XmlElement("ARBITRT")]
        public string ARBITRT { get; set; }
        /// <summary>
        /// 自由输入文本 varchar(1024)
        /// </summary>
        [XmlElement("FREETXT")]
        public string FREETXT { get; set; }
        /// <summary>
        /// 币种 char(2)
        /// </summary>
        [XmlElement("CRYTYPE")]
        public string CRYTYPE { get; set; }
    }
}