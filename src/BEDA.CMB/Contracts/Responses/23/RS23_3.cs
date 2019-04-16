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
    /// 23.3.取公司卡详细信息响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS23_3 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTCPRRTV
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTCPRRTV";
        /// <summary>
        /// 23.3.取公司卡详细信息响应内容
        /// </summary>
        public NTCPRRTVZ NTCPRRTVZ { get; set; }
        /// <summary>
        /// 23.3.取公司卡详细信息响应集合
        /// </summary>
        [XmlElement("NTCPRRLMZ")]
        public List<NTCPRRLMZ> List { get; set; }
    }
    /// <summary>
    /// 23.3.取公司卡详细信息响应内容
    /// </summary>
    public class NTCPRRTVZ
    {
        /// <summary>
        /// 公司卡   	C(20)
        /// </summary>
        public string PSBNBR { get; set; }
        /// <summary>
        /// 持有客户   	C(10)
        /// </summary>
        public string OWNCLT { get; set; }
        /// <summary>
        /// 户口序号 	C(8)
        /// </summary>
        public string IACNBR { get; set; }
        /// <summary>
        /// 户口代码 	C(3)
        /// </summary>
        public string EACCOD { get; set; }
        /// <summary>
        /// 持卡人名称	Z(200)
        /// </summary>
        public string CLTNAM { get; set; }
        /// <summary>
        /// 国别地区 	C(3)
        /// </summary>
        public string CLTCNR { get; set; }
        /// <summary>
        /// 证件类别 	C(3)
        /// </summary>
        public string CLTCTF { get; set; }
        /// <summary>
        /// 凭证种类 	C(4)
        /// </summary>
        public string PSBCOD { get; set; }
        /// <summary>
        /// 凭证样式 	C(2)
        /// </summary>
        public string PSBFAC { get; set; }
        /// <summary>
        /// 换卡次数 	C(2)
        /// </summary>
        public string PSBSEQ { get; set; }
        /// <summary>
        /// 支取方式   	C(1)
        /// </summary>
        public string WDWTYP { get; set; }
        /// <summary>
        /// 开户城市   	C(6)
        /// </summary>
        public string CTYCOD { get; set; }
        /// <summary>
        /// 机构       	C(6)
        /// </summary>
        public string BRNNBR { get; set; }
        /// <summary>
        /// 开户日期   	D
        /// </summary>
        [XmlIgnore]
        public DateTime EFTDAT { get; set; }
        /// <summary>
        /// 开户日期   	D, 对应<see cref="EFTDAT"/>
        /// </summary>
        [XmlElement("EFTDAT")]
        public string EFTDATStr
        {
            get
            {
                return this.EFTDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.EFTDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 开户城市   	C(6)
        /// </summary>
        public string TRSCTY { get; set; }
        /// <summary>
        /// 机构       	C(6)
        /// </summary>
        public string TRSBRN { get; set; }
        /// <summary>
        /// 凭证挂失   	C(1)
        /// </summary>
        public string PSBHLD { get; set; }
        /// <summary>
        /// 取款密码挂失	C(1)
        /// </summary>
        public string WPWHLD { get; set; }
        /// <summary>
        /// 户口状态   	C(1)
        /// </summary>
        public string EACSTS { get; set; }
        /// <summary>
        /// 最后使用日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime USEDAT { get; set; }
        /// <summary>
        /// 最后使用日期	D, 对应<see cref="USEDAT"/>
        /// </summary>
        [XmlElement("USEDAT")]
        public string USEDATStr
        {
            get
            {
                return this.USEDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.USEDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 结算户       	C(35)
        /// </summary>
        public string CPREAC { get; set; }
        /// <summary>
        /// 结算户名     	Z(62)
        /// </summary>
        public string CPRNAM { get; set; }
        /// <summary>
        /// 结算户支取方式	C(1)
        /// </summary>
        public string CPRWDW { get; set; }
        /// <summary>
        /// 结算户开户城市	C(6)
        /// </summary>
        public string CPRCTY { get; set; }
        /// <summary>
        /// 结算户开户机构	C(6)
        /// </summary>
        public string CPRBRN { get; set; }
        /// <summary>
        /// 结算户开户日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime CPREFT { get; set; }
        /// <summary>
        /// 结算户开户日期	D, 对应<see cref="CPREFT"/>
        /// </summary>
        [XmlElement("CPREFT")]
        public string CPREFTStr
        {
            get
            {
                return this.CPREFT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.CPREFT = tmp;
                }
            }
        }
        /// <summary>
        /// 户口状态     	C(1)
        /// </summary>
        public string CPRSTS { get; set; }
        /// <summary>
        /// 临时授权     	C(1)
        /// </summary>
        public string AUTSTS { get; set; }
        /// <summary>
        /// 网上支付     	C(1)
        /// </summary>
        public string ITISTS { get; set; }
        /// <summary>
        /// 公司卡开户日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime OPNDAT { get; set; }
        /// <summary>
        /// 公司卡开户日期	D, 对应<see cref="OPNDAT"/>
        /// </summary>
        [XmlElement("OPNDAT")]
        public string OPNDATStr
        {
            get
            {
                return this.OPNDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.OPNDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 公司卡户名 	Z(62)
        /// </summary>
        public string EACNAM { get; set; }
        /// <summary>
        /// 公司卡备注名	Z(62)
        /// </summary>
        public string REMARK { get; set; }
        /// <summary>
        /// 新旧户口标志   	C(1)
        /// </summary>
        public string DGRFLG { get; set; }
        /// <summary>
        /// 黑名单标志 	C(1)
        /// </summary>
        public string BLSFLG { get; set; }
        /// <summary>
        /// M2 手机号码 	C(20)
        /// </summary>
        public string M2NMBL { get; set; }
        /// <summary>
        /// 实名标志   	C(1)
        /// </summary>
        public string NAMFLG { get; set; }
        /// <summary>
        /// 失效日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime EXPDAT { get; set; }
        /// <summary>
        /// 失效日期	D, 对应<see cref="EXPDAT"/>
        /// </summary>
        [XmlElement("EXPDAT")]
        public string EXPDATStr
        {
            get
            {
                return this.EXPDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.EXPDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 资金用途编码	C(4)
        /// </summary>
        public string FNDUSC { get; set; }
        /// <summary>
        /// 相对营收日期	C(2)
        /// </summary>
        public string REVDAT { get; set; }
    }
    /// <summary>
    /// 23.3.取公司卡详细信息响应内容
    /// </summary>
    public class NTCPRRLMZ
    {
        /// <summary>
        /// 额度类别	C(10)
        /// </summary>
        public string PIPCOD { get; set; }
        /// <summary>
        /// 折算货币	C(2)
        /// </summary>
        public string LMTCCY { get; set; }
        /// <summary>
        /// 额度金额	M
        /// </summary>
        public decimal LMTAMT { get; set; }
        /// <summary>
        /// 剩余额度	M
        /// </summary>
        public decimal ONLBAL { get; set; }
        /// <summary>
        /// 生效日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime EFTDAT { get; set; }
        /// <summary>
        /// 生效日期	D, 对应<see cref="EFTDAT"/>
        /// </summary>
        [XmlElement("EFTDAT")]
        public string EFTDATStr
        {
            get
            {
                return this.EFTDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.EFTDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 失效日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime EXPDAT { get; set; }
        /// <summary>
        /// 失效日期	D, 对应<see cref="EXPDAT"/>
        /// </summary>
        [XmlElement("EXPDAT")]
        public string EXPDATStr
        {
            get
            {
                return this.EXPDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.EXPDAT = tmp;
                }
            }
        }
    }
}
