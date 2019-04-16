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
    /// 23.12.查询所有公司卡申请响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS23_12 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTCRDINQ
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTCRDINQ";
        /// <summary>
        /// 23.12.查询所有公司卡申请响应集合
        /// </summary>
        [XmlElement("NTCRDLSTZ")]
        public List<NTCRDLSTZ> List { get; set; }
    }
    /// <summary>
    /// 23.12.查询所有公司卡申请响应内容
    /// </summary>
    public class NTCRDLSTZ
    {
        /// <summary>
        /// 流程号 	C(10)
        /// </summary>
        public string REQNBR { get; set; }
        /// <summary>
        /// 业务类型	C(4)
        /// CRAC 临时授权取消
        /// CRAT 公司卡激活
        /// CRAU  临时授权
        /// CRLM  消费额度设置
        /// CRMM  批量消费额度设置
        /// CRPH  口头挂失
        /// CRWP  取款密码重置
        /// PCSM  批量POS消费额度维护
        /// PCST  POS消费额度维护
        /// SLFM  自定义信息设置
        /// </summary>
        public string CRDTYP { get; set; }
        /// <summary>
        /// 分行号 	C(2)
        /// </summary>
        public string TRSBBK { get; set; }
        /// <summary>
        /// 结算户 	C(35)
        /// </summary>
        public string TRSACC { get; set; }
        /// <summary>
        /// 公司卡 	C(20)
        /// </summary>
        public string PSBNBR { get; set; }
        /// <summary>
        /// 持卡人 	Z(200)
        /// </summary>
        public string CLTNAM { get; set; }
        /// <summary>
        /// 经办日 	D
        /// </summary>
        [XmlIgnore]
        public DateTime OPRDAT { get; set; }
        /// <summary>
        /// 经办日 	D, 对应<see cref="OPRDAT"/>
        /// </summary>
        [XmlElement("OPRDAT")]
        public string OPRDATStr
        {
            get
            {
                return this.OPRDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.OPRDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 期望日        	D
        /// </summary>
        public string EPTDAT { get; set; }
        /// <summary>
        /// 期望时间      	T
        /// </summary>
        public string EPTTIM { get; set; }
        /// <summary>
        /// 期望时间 由<see cref="EPTDAT"/>和<see cref="EPTTIM"/>组成
        /// </summary>
        [XmlIgnore]
        public DateTime? ExpectedTime
        {
            get
            {
                if (DateTime.TryParseExact(string.Format("{0}{1}", this.EPTDAT, this.EPTTIM),
                   new string[] { "yyyyMMdd", "yyyyMMddHHmmss" }, CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    return tmp;
                }
                return null;
            }
        }
        /// <summary>
        /// 附件标志	C(1)
        /// </summary>
        public string ATHFLG { get; set; }
        /// <summary>
        /// 业务参考号     	C(30)
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 币种           	C(2)
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 交易金额       	M
        /// </summary>
        public decimal TRXAM1 { get; set; }
        /// <summary>
        /// 交易金额       	M
        /// </summary>
        public decimal TRXAM2 { get; set; }
        /// <summary>
        /// 日期           	D
        /// </summary>
        [XmlIgnore]
        public DateTime TRXDAT { get; set; }
        /// <summary>
        /// 日期           	D, 对应<see cref="TRXDAT"/>
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
        /// ＰＯＳ开通标志 	C(1)
        /// </summary>
        public string POSFLG { get; set; }
        /// <summary>
        /// 网上支付开通标志	C(1)
        /// </summary>
        public string NPYFLG { get; set; }
        /// <summary>
        /// 摘要内容       	Z(42)
        /// </summary>
        public string TRXTXT { get; set; }
        /// <summary>
        /// 请求状态       	C(3)
        /// </summary>
        public string REQSTS { get; set; }
        /// <summary>
        /// 待处理操作步骤 	C(6)
        /// </summary>
        public string OPRSTP { get; set; }
        /// <summary>
        /// 待处理操作序列	C(3)
        /// </summary>
        public string OPRSQN { get; set; }
        /// <summary>
        /// 操作别名     	Z(32)
        /// </summary>
        public string OPRALS { get; set; }
        /// <summary>
        /// 业务处理结果 	C(1)
        /// </summary>
        public string RTNFLG { get; set; }
        /// <summary>
        /// 结果描述     	Z(92)
        /// </summary>
        public string RTNNAR { get; set; }
        /// <summary>
        /// 卡数         	C(4)
        /// </summary>
        public string PSBNUM { get; set; }
    }
}
