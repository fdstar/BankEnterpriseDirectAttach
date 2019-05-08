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
    /// 28.2.1.虚拟户当天交易查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS28_2_1 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTDMTQRD
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTDMTQRD";
        /// <summary>
        /// 28.2.1.虚拟户当天交易查询响应集合
        /// </summary>
        [XmlElement("NTDMTQRYZ1")]
        public List<NTDMTQRYZ1> List { get; set; }
    }
    /// <summary>
    /// 28.2.1.虚拟户当天交易查询响应内容
    /// </summary>
    public class NTDMTQRYZ1
    {
        /// <summary>
        /// 活期结算账户	C(35)
        /// </summary>
        public string INBACC { get; set; }
        /// <summary>
        /// 虚拟户编号	C(20)
        /// </summary>
        public string DYANBR { get; set; }
        /// <summary>
        /// 交易币种	C(2)	附录A.3
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 交易金额	M
        /// </summary>
        public decimal TRXAMT { get; set; }
        /// <summary>
        /// 交易方向	C(1)
        /// </summary>
        public string TRXDIR { get; set; }
        /// <summary>
        /// 交易日期	D
        /// </summary>
        public string TRXDAT { get; set; }
        /// <summary>
        /// 交易时间	T
        /// </summary>
        public string TRXTIM { get; set; }
        /// <summary>
        /// 交易时间 由<see cref="TRXDAT"/>和<see cref="TRXTIM"/>组成
        /// </summary>
        [XmlIgnore]
        public DateTime TransactionTime
        {
            get
            {
                if (DateTime.TryParseExact(string.Format("{0}{1}", this.TRXDAT, this.TRXTIM),
                   new string[] { "yyyyMMdd", "yyyyMMddHHmmss" }, CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    return tmp;
                }
                return DateTime.MinValue;
            }
        }
        /// <summary>
        /// 交易序号	C(9)
        /// </summary>
        public string TRXSEQ { get; set; }
        /// <summary>
        /// 收付方账号	C(35)
        /// </summary>
        public string RPYACC { get; set; }
        /// <summary>
        /// 收付方名称	Z(200)
        /// </summary>
        public string RPYNAM { get; set; }
        /// <summary>
        /// 收付方分行号	C(3)	附录A.48
        /// </summary>
        public string RPYBBK { get; set; }
        /// <summary>
        /// 收付方开户行行号	C(20)
        /// </summary>
        public string RPYBBN { get; set; }
        /// <summary>
        /// 收付方开户行行名	Z(62)
        /// </summary>
        public string RPYBKN { get; set; }
        /// <summary>
        /// 收付方开户行地址	Z(100)
        /// </summary>
        public string RPYADR { get; set; }
        /// <summary>
        /// 交易类型	C(1)	F：金融
        /// </summary>
        public string TRXTYP { get; set; }
        /// <summary>
        /// 交易摘要	Z(42)
        /// </summary>
        public string TRXTXT { get; set; }
        /// <summary>
        /// 记账流水号	C(15)
        /// </summary>
        public string TRXNBR { get; set; }
        /// <summary>
        /// 交易套号	C(15)
        /// </summary>
        public string TRXSET { get; set; }
        /// <summary>
        /// 关联交易流水号	C(15)   退款交易：关联原交易
        /// </summary>
        public string RLTTRX { get; set; }
        /// <summary>
        /// 关联交易套号	C(15)   退款交易：关联原交易
        /// </summary>
        public string RLTSET { get; set; }
        /// <summary>
        /// 冲正标志	C(1)	R：冲账  
        /// </summary>
        public string RVSTAG { get; set; }
        /// <summary>
        /// 记账方式	C(1)	1：自动
        /// </summary>
        public string AUTFLG { get; set; }
        /// <summary>
        /// 记账标识	C(20)   	交易识别编码
        /// </summary>
        public string NARINN { get; set; }
        /// <summary>
        /// 记账类型	C(3)	INT：利息； OTH：其他交易；
        /// </summary>
        public string TRSMOD { get; set; }
        /// <summary>
        /// 业务状态	C(3)	OPR：退款中， RED：已退款，
        /// </summary>
        public string BUSSTS { get; set; }
        /// <summary>
        /// 交易状态	C(1)	A：生效
        /// </summary>
        public string TRSSTS { get; set; }
    }
}
