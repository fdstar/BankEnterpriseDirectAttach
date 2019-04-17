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
    /// 23.25.取关联结算户某日交易（续传）响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS23_25 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTCPATRX
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTCPATRX";
        /// <summary>
        /// 23.25.取关联结算户某日交易（续传）响应集合
        /// </summary>
        [XmlElement("NTCPATRXZ1")]
        public List<NTCPATRXZ1> List { get; set; }
        /// <summary>
        /// 23.25.取关联结算户某日交易（续传）响应内容 续传标志
        /// </summary>
        public NTCPACTNZ1 NTCPACTNZ1 { get; set; }
    }
    /// <summary>
    /// 23.25.取关联结算户某日交易（续传）响应内容
    /// </summary>
    public class NTCPATRXZ1
    {
        /// <summary>
        /// 交易日期 	D
        /// </summary>
        public string ETYDAT { get; set; }
        /// <summary>
        /// 交易时间	T
        /// </summary>
        public string ETYTIM { get; set; }
        /// <summary>
        /// 交易时间 由<see cref="ETYDAT"/>和<see cref="ETYTIM"/>组成
        /// </summary>
        [XmlIgnore]
        public DateTime? TransactionTime
        {
            get
            {
                if (DateTime.TryParseExact(string.Format("{0}{1}", this.ETYDAT, this.ETYTIM),
                   new string[] { "yyyyMMdd", "yyyyMMddHHmmss" }, CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    return tmp;
                }
                return null;
            }
        }
        /// <summary>
        /// 起息日	D
        /// </summary>
        [XmlIgnore]
        public DateTime VLTDAT { get; set; }
        /// <summary>
        /// 起息日	D, 对应<see cref="VLTDAT"/>
        /// </summary>
        [XmlElement("VLTDAT")]
        public string VLTDATStr
        {
            get
            {
                return this.VLTDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.VLTDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 交易类型	C(8)
        /// </summary>
        public string TRSCOD { get; set; }
        /// <summary>
        /// 摘要	Z(62)
        /// </summary>
        public string NARYUR { get; set; }
        /// <summary>
        /// 记账方向 	C(1)
        /// </summary>
        public string BOKDIR { get; set; }
        /// <summary>
        /// 交易金额 	M
        /// </summary>
        public decimal TRSAMT { get; set; }
        /// <summary>
        /// 余额     	M
        /// </summary>
        public decimal ONLBAL { get; set; }
        /// <summary>
        /// 货币     	C(2)
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 交易流水号	C(15)
        /// </summary>
        public string TRXNBR { get; set; }
        /// <summary>
        /// 流程实例号	C(10)
        /// </summary>
        public string REQNBR { get; set; }
        /// <summary>
        /// 业务名称	Z(32)
        /// </summary>
        public string BUSNAM { get; set; }
        /// <summary>
        /// 用途	Z(62)
        /// </summary>
        public string NUSAGE { get; set; }
        /// <summary>
        /// 业务参考号	C(30)
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 公司卡卡号	C(20)
        /// </summary>
        public string PSBNBR { get; set; }
        /// <summary>
        /// 持卡人	Z(62)
        /// </summary>
        public string CLTNAM { get; set; }
        /// <summary>
        /// 卡备注	Z(62)
        /// </summary>
        public string REMARK { get; set; }
        /// <summary>
        /// 商户号         	C(15)
        /// </summary>
        public string MCHNBR { get; set; }
        /// <summary>
        /// 商户名称       	Z(62)
        /// </summary>
        public string MCHDES { get; set; }
        /// <summary>
        /// 收付方帐号分行号	C(2)
        /// </summary>
        public string RPYBBK { get; set; }
        /// <summary>
        /// 收付方帐号     	C(35)
        /// </summary>
        public string RPYACC { get; set; }
        /// <summary>
        /// 收付方名称     	Z(62)
        /// </summary>
        public string RPYNAM { get; set; }
        /// <summary>
        /// 收付方开户行行号	C(20)
        /// </summary>
        public string RPYBBN { get; set; }
        /// <summary>
        /// 收付方开户行行名 	Z(62)
        /// </summary>
        public string RPYBNK { get; set; }
        /// <summary>
        /// 收付方开户行地址 	Z(62)
        /// </summary>
        public string RPYADR { get; set; }
        /// <summary>
        /// 母子帐号分行号   	C(2)
        /// </summary>
        public string GSBBBK { get; set; }
        /// <summary>
        /// 母子公司帐号     	C(35)
        /// </summary>
        public string GSBACC { get; set; }
        /// <summary>
        /// 母子公司名称     	Z(62)
        /// </summary>
        public string GSBNAM { get; set; }
        /// <summary>
        /// 母子公司开户行行号	C(20)
        /// </summary>
        public string GSBBBN { get; set; }
        /// <summary>
        /// 母子公司开户行行名	Z(62)
        /// </summary>
        public string GSBBNK { get; set; }
        /// <summary>
        /// 母子公司开户行地址	Z(62)
        /// </summary>
        public string GSBADR { get; set; }
        /// <summary>
        /// 信息标志	C(1)
        /// </summary>
        public string INFFLG { get; set; }
        /// <summary>
        /// 是否有附件标志	C(1)
        /// </summary>
        public string ATHFLG { get; set; }
        /// <summary>
        /// 票据号	C(20)
        /// </summary>
        public string CHKNBR { get; set; }
        /// <summary>
        /// 冲帐标志	C(1)
        /// </summary>
        public string RSVFLG { get; set; }
        /// <summary>
        /// 扩展摘要	C(34)
        /// </summary>
        public string NAREXT { get; set; }
        /// <summary>
        /// 交易分析码	C(6)
        /// </summary>
        public string TRSANL { get; set; }
        /// <summary>
        /// 商务支付订单号	C(50)
        /// </summary>
        public string REFSUB { get; set; }
        /// <summary>
        /// 企业识别码	C(10)
        /// </summary>
        public string FRMCOD { get; set; }
    }
}
