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
    /// 21.1.3.业务交易明细查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS21_1_3 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTEBPINF
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTEBPINF";
        /// <summary>
        /// 21.1.3.业务交易明细查询响应内容
        /// </summary>
        public NTEBPINFZ NTEBPINFZ { get; set; }
    }
    /// <summary>
    /// 21.1.3.业务交易明细查询响应内容
    /// </summary>
    public class NTEBPINFZ
    {
        /// <summary>
        /// 流程实例号	C(10)
        /// </summary>
        public string REQNBR { get; set; }
        /// <summary>
        /// NP交易流水号	C(11)
        /// </summary>
        public string TRXNBR { get; set; }
        /// <summary>
        /// 交易方向	C(1)	I：提回 O：提出
        /// </summary>
        public string TRXDIR { get; set; }
        /// <summary>
        /// 报文类型	C(3)	101：网银贷记 103：网银借记 105：第三方贷记
        /// </summary>
        public string MSGNBR { get; set; }
        /// <summary>
        /// 交易日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime TRXDAT { get; set; }
        /// <summary>
        /// 交易日期	D, 对应<see cref="TRXDAT"/>
        /// </summary>
        [XmlElement("TRXDAT")]
        public string TRXDATStr
        {
            get
            {
                return this.TRXDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.TRXDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 交易状态	C(2)	附录 A.48
        /// </summary>
        public string TRXSTS { get; set; }
        /// <summary>
        /// 报文键值	C(50)
        /// </summary>
        public string IBPKEY { get; set; }
        /// <summary>
        /// 委托日期	D
        /// </summary>
        public string TRSDAT { get; set; }
        /// <summary>
        /// 委托时间	T
        /// </summary>
        public string TRSTIM { get; set; }
        /// <summary>
        /// 委托时间 由<see cref="TRSDAT"/>和<see cref="TRSTIM"/>组成
        /// </summary>
        [XmlIgnore]
        public DateTime ExpectedTime
        {
            get
            {
                if (DateTime.TryParseExact(string.Format("{0}{1}", this.TRSDAT, this.TRSTIM),
                   new string[] { "yyyyMMdd", "yyyyMMddHHmmss" }, CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    return tmp;
                }
                return DateTime.MinValue;
            }
        }
        /// <summary>
        /// 内部协议号	C(10)	
        /// </summary>
        public string CNVNBR { get; set; }
        /// <summary>
        /// 交易货币	C(2)	附录 A.3
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 交易金额	M
        /// </summary>
        public decimal TRXAMT { get; set; }
        /// <summary>
        /// 我行客户户口	C(35)	
        /// </summary>
        public string CLTEAC { get; set; }
        /// <summary>
        /// 我行客户号	C(10)
        /// </summary>
        public string CLTNBR { get; set; }
        /// <summary>
        /// 付款人开户行行号	C(12)
        /// </summary>
        public string ACRBRD { get; set; }
        /// <summary>
        /// 付款人开户行名称	Z(100)
        /// </summary>
        public string ACRNAM { get; set; }
        /// <summary>
        /// 付款人账号	C(35)
        /// </summary>
        public string PYREAC { get; set; }
        /// <summary>
        /// 付款人名称	Z(100)
        /// </summary>
        public string PYRNAM { get; set; }
        /// <summary>
        /// 付款清算行行号	C(12)
        /// </summary>
        public string DBTCLR { get; set; }
        /// <summary>
        /// 付款人开户行所属网银系统行号	C(12)
        /// </summary>
        public string DBTPAR { get; set; }
        /// <summary>
        /// 发起参与者	C(12)
        /// </summary>
        public string OTHBRD { get; set; }
        /// <summary>
        /// 收款人开户行行号	C(12)	
        /// </summary>
        public string ACEBRD { get; set; }
        /// <summary>
        /// 收款人开户行名称	Z(100)
        /// </summary>
        public string ACENAM { get; set; }
        /// <summary>
        /// 收款人账号	C(35)
        /// </summary>
        public string PYEEAC { get; set; }
        /// <summary>
        /// 收款人名称	Z(100)
        /// </summary>
        public string PYENAM { get; set; }
        /// <summary>
        /// 收款清算行行号	C(12)
        /// </summary>
        public string CDTCLR { get; set; }
        /// <summary>
        /// 收款人开户行所属网银系统行号	C(12)
        /// </summary>
        public string CDTPAR { get; set; }
        /// <summary>
        /// 手续费金额	M   第三方贷记手续费金额，其他业务为0
        /// </summary>
        public decimal FEEAMT { get; set; }
        /// <summary>
        /// 手续费收款行行号	C(12)
        /// </summary>
        public string FEEBRD { get; set; }
        /// <summary>
        /// 手续费收款人账号	C(35)
        /// </summary>
        public string FEEACC { get; set; }
        /// <summary>
        /// 手续费收款人名称	Z(100)
        /// </summary>
        public string FEENAM { get; set; }
        /// <summary>
        /// 网上交易日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime? NETDAT { get; set; }
        /// <summary>
        /// 网上交易日期	D, 对应<see cref="NETDAT"/>
        /// </summary>
        [XmlElement("NETDAT")]
        public string NETDATStr
        {
            get
            {
                return this.NETDAT?.ToString("yyyyMMdd");
            }
            set
            {
                this.NETDAT = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.NETDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 网上交易单号	C(35)
        /// </summary>
        public string NETSEQ { get; set; }
        /// <summary>
        /// 网上交易说明	Z(200)
        /// </summary>
        public string NETTXT { get; set; }
        /// <summary>
        /// 认证方式	C(4)
        /// </summary>
        public string AUTTYP { get; set; }
        /// <summary>
        /// 认证信息附加标记	C(1)	1= 自动 2= 手工 3= 内部转账
        /// </summary>
        public string AUTFLG { get; set; }
        /// <summary>
        /// 认证信息	C(140)  客户单放在明细最末尾
        /// </summary>
        public string AUTFMT { get; set; }
        /// <summary>
        /// 交易附言	Z(235)
        /// </summary>
        public string REMARK { get; set; }
        /// <summary>
        /// 业务类型编码	C(4)	附录A.49
        /// </summary>
        public string BUSCOD { get; set; }
        /// <summary>
        /// 业务种类编码	C(5)
        /// </summary>
        public string BUSTYP { get; set; }
        /// <summary>
        /// 发起渠道	C(3)
        /// </summary>
        public string ISUCNL { get; set; }
        /// <summary>
        /// 发起方键值	C(10)
        /// </summary>
        public string CLTSEQ { get; set; }
        /// <summary>
        /// 业务参考号	C(30)
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 交易套号	C(15)
        /// </summary>
        public string TRXSET { get; set; }
        /// <summary>
        /// 记账套号	C(15)
        /// </summary>
        public string ACTSET { get; set; }
        /// <summary>
        /// 记账日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime ACTDAT { get; set; }
        /// <summary>
        /// 记账日期	D, 对应<see cref="ACTDAT"/>
        /// </summary>
        [XmlElement("ACTDAT")]
        public string ACTDATStr
        {
            get
            {
                return this.ACTDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.ACTDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 拒绝码	C(4)
        /// </summary>
        public string RJCCOD { get; set; }
        /// <summary>
        /// 拒绝原因	Z(175)
        /// </summary>
        public string RJCRSN { get; set; }
        /// <summary>
        /// 结果摘要	Z(120)
        /// </summary>
        public string RTNNAR { get; set; }
        /// <summary>
        /// 保留字 50
        /// </summary>
        public string RSV50Z { get; set; }
    }
}
