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
    /// 承兑电子合同查询响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLBPTQJB : RsBase
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
        public List<AcceptElectronicContract> List { get; set; }
    }
    /// <summary>
    /// 承兑电子合同
    /// </summary>
    public class AcceptElectronicContract
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
        [XmlElement("ACCOUNTNO")]
        public string ACCOUNTNO { get; set; }
        /// <summary>
        /// 合同金额	decimal(15，2)
        /// </summary>
        [XmlElement("BUSSUM")]
        public decimal BUSSUM { get; set; }
        /// <summary>
        /// 主要担保方式 char(8)
        /// </summary>
        [XmlElement("VCHTYPE")]
        public string VCHTYPE { get; set; }
        /// <summary>
        /// 起始日期 char(8) 格式YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime STARTDATE { get; set; }
        /// <summary>
        /// 起始日期 char(8) 格式YYYYMMDD, 对应<see cref="STARTDATE"/>
        /// </summary>
        [XmlElement("STARTDATE")]
        public string STARTDATEStr
        {
            get
            {
                return this.STARTDATE.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.STARTDATE = tmp;
                }
            }
        }
        /// <summary>
        /// 到期日 char(8) 格式YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime DUEDATE { get; set; }
        /// <summary>
        /// 到期日 char(8) 格式YYYYMMDD, 对应<see cref="DUEDATE"/>
        /// </summary>
        [XmlElement("DUEDATE")]
        public string DUEDATEStr
        {
            get
            {
                return this.DUEDATE.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.DUEDATE = tmp;
                }
            }
        }
        /// <summary>
        /// 用途 varchar(200)
        /// </summary>
        [XmlElement("PURPOSE")]
        public string PURPOSE { get; set; }
        /// <summary>
        /// 首次保证金比例 decimal(9，7)
        /// </summary>
        [XmlElement("BAILRAT")]
        public decimal BAILRAT { get; set; }
        /// <summary>
        /// 手续费率 decimal(9，7)
        /// </summary>
        [XmlElement("PDGRATE")]
        public decimal PDGRATE { get; set; }
        /// <summary>
        /// 手续费金额 decimal(15，2)
        /// </summary>
        [XmlElement("PDGAMNT")]
        public decimal PDGAMNT { get; set; }
        /// <summary>
        /// 收费方式 char(1)
        /// </summary>
        [XmlElement("PAYMTHD")]
        public string PAYMTHD { get; set; }
        /// <summary>
        /// 收费周期 char(3)
        /// </summary>
        [XmlElement("PAYPERD")]
        public string PAYPERD { get; set; }
        /// <summary>
        /// 还款来源 varchar(200)
        /// </summary>
        [XmlElement("PAYSRCE")]
        public string PAYSRCE { get; set; }
        /// <summary>
        /// 合同状态 char(2) 00待确认 01已确认 02退回修改 03已生效 04全部
        /// </summary>
        [XmlElement("CONTRST")]
        public string CONTRST { get; set; }
        /// <summary>
        /// 承兑申请人 varchar(122)
        /// </summary>
        [XmlElement("ACAPNAM")]
        public string ACAPNAM { get; set; }
        /// <summary>
        /// 承兑申请人住所 varchar(256)
        /// </summary>
        [XmlElement("ACAPADR")]
        public string ACAPADR { get; set; }
        /// <summary>
        /// 承兑申请人邮政编码 char(6)
        /// </summary>
        [XmlElement("ACAPPST")]
        public string ACAPPST { get; set; }
        /// <summary>
        /// 承兑申请人电话 char(20)
        /// </summary>
        [XmlElement("ACAPTEL")]
        public string ACAPTEL { get; set; }
        /// <summary>
        /// 承兑申请人法定代表人 varchar(122)
        /// </summary>
        [XmlElement("ACAPFPR")]
        public string ACAPFPR { get; set; }
        /// <summary>
        /// 承兑人varchar(122)
        /// </summary>
        [XmlElement("ACCPNAM")]
        public string ACCPNAM { get; set; }
        /// <summary>
        /// 承兑人住所 varchar(256)
        /// </summary>
        [XmlElement("ACCPADR")]
        public string ACCPADR { get; set; }
        /// <summary>
        /// 承兑人邮政编码 char(6)
        /// </summary>
        [XmlElement("ACCPPST")]
        public string ACCPPST { get; set; }
        /// <summary>
        /// 承兑人电话 char(20)
        /// </summary>
        [XmlElement("ACCPTEL")]
        public string ACCPTEL { get; set; }
        /// <summary>
        /// 承兑人传真 char(11)
        /// </summary>
        [XmlElement("ACCPTAX")]
        public string ACCPTAX { get; set; }
        /// <summary>
        /// 承兑法定代表人 char(122) 
        /// </summary>
        [XmlElement("ACCPFPR")]
        public string ACCPFPR { get; set; }
        /// <summary>
        /// 汇票张数 char(3)
        /// </summary>
        [XmlElement("DRFTNUM")]
        public int DRFTNUM { get; set; }
        /// <summary>
        /// 保证金账号 char(19)
        /// </summary>
        [XmlElement("BAILACC")]
        public string BAILACC { get; set; }
        /// <summary>
        /// 保证金金额 decimal(15，2)
        /// </summary>
        [XmlElement("BAILMNT")]
        public decimal BAILMNT { get; set; }
        /// <summary>
        /// 罚息率 decimal(9，7) 
        /// </summary>
        [XmlElement("DFINSTR")]
        public decimal DFINSTR { get; set; }
        /// <summary>
        /// 自由输入文本 varchar(1024)
        /// </summary>
        [XmlElement("FREETXT")]
        public string FREETXT { get; set; }
        /// <summary>
        /// 保证人名称 varchar(122)
        /// </summary>
        [XmlElement("WARENAM")]
        public string WARENAM { get; set; }
        /// <summary>
        /// 保证合同编号 char(32)
        /// </summary>
        [XmlElement("GCONTNM")]
        public string GCONTNM { get; set; }
        /// <summary>
        /// 质押人名称 varchar(122)
        /// </summary>
        [XmlElement("COLTNAM")]
        public string COLTNAM { get; set; }
        /// <summary>
        /// 质押合同编号 varchar(60)
        /// </summary>
        [XmlElement("COLTNUM")]
        public string COLTNUM { get; set; }
        /// <summary>
        /// 抵押人名称 varchar(122)
        /// </summary>
        [XmlElement("MORGNAM")]
        public string MORGNAM { get; set; }
        /// <summary>
        /// 抵押合同编号 char(32) 
        /// </summary>
        [XmlElement("MORGNUM")]
        public string MORGNUM { get; set; }
        /// <summary>
        /// 最高额保证人名称 varchar(122)
        /// </summary>
        [XmlElement("CLAMTGP")]
        public string CLAMTGP { get; set; }
        /// <summary>
        /// 最高额保证合同编号 char(32) 
        /// </summary>
        [XmlElement("CEAMTGN")]
        public string CEAMTGN { get; set; }
        /// <summary>
        /// 最高额抵押人名称 varchar(122)
        /// </summary>
        [XmlElement("CLAMTMP")]
        public string CLAMTMP { get; set; }
        /// <summary>
        /// 最高额抵押合同编号 char(32)
        /// </summary>
        [XmlElement("CLAMTMN")]
        public string CLAMTMN { get; set; }
        /// <summary>
        /// 其他担保事项 varchar(1024)
        /// </summary>
        [XmlElement("ELSGURT")]
        public string ELSGURT { get; set; }
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
        /// 汇票金额合计 decimal(15，2)
        /// </summary>
        [XmlElement("DRFTAMT")]
        public decimal DRFTAMT { get; set; }
        /// <summary>
        /// 币种 char(2)
        /// </summary>
        [XmlElement("CRYTYPE")]
        public string CRYTYPE { get; set; }
    }
}