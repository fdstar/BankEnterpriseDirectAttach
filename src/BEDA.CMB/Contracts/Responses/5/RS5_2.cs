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
    /// 5.2.申请人查询开证申请响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS5_2 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTQRYLCA
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTQRYLCA";
        /// <summary>
        /// 5.2.申请人查询开证申请响应集合
        /// </summary>
        [XmlElement("NTLCALSTZ1")]
        public List<NTLCALSTZ1> List { get; set; }
    }
    /// <summary>
    /// 5.2.申请人查询开证申请响应内容
    /// </summary>
    public class NTLCALSTZ1
    {
        /// <summary>
        /// 流程实例号	C(10)
        /// </summary>
        public string REQNBR { get; set; }
        /// <summary>
        /// 申请人分行号	C(2)
        /// </summary>
        public string ACCBBK { get; set; }
        /// <summary>
        /// 申请人账号	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 申请人名称	Z(100)
        /// </summary>
        public string APPNAM { get; set; }
        /// <summary>
        /// 受益人分行号	C(2)
        /// </summary>
        public string BNFBBK { get; set; }
        /// <summary>
        /// 受益人账号	C(35)
        /// </summary>
        public string BNFACC { get; set; }
        /// <summary>
        /// 受益人名称	Z(100)
        /// </summary>
        public string BNFNAM { get; set; }
        /// <summary>
        /// 开证币种	C(2)
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 开证金额	M
        /// </summary>
        public decimal TRSAMT { get; set; }
        /// <summary>
        /// 信用证号	C(15)
        /// </summary>
        public string LCCNBR { get; set; }
        /// <summary>
        /// 业务参考号	C(30)
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 请求状态	C(3)	附录A.5
        /// </summary>
        public string REQSTS { get; set; }
        /// <summary>
        /// 业务处理结果	C(1)	附录A.6   REQSTS =”FIN”才有值
        /// </summary>
        public string RTNFLG { get; set; }
        /// <summary>
        /// 是否有附件	C (1)	‘Y’：有；‘N’：无
        /// </summary>
        public string ATHFLG { get; set; }
        /// <summary>
        /// 经办日	C(8)
        /// </summary>
        [XmlIgnore]
        public DateTime OPRDAT { get; set; }
        /// <summary>
        /// 经办日	C(8), 对应<see cref="OPRDAT"/>
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
        /// 有效期	C (8)
        /// </summary>
        [XmlIgnore]
        public DateTime EPRDAT { get; set; }
        /// <summary>
        /// 有效期	C (8), 对应<see cref="EPRDAT"/>
        /// </summary>
        [XmlElement("EPRDAT")]
        public string EPRDATStr
        {
            get
            {
                return this.EPRDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.EPRDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 业务状态	C (1)	
        /// A:银行审批中
        /// C:客户撤消
        /// D:银行撤消
        /// F:开证成功
        /// H:待银行编押
        /// I:待银行收取保证金
        /// M:银行退回经办
        /// O:待银行开证经办
        /// W:客户处理中
        /// </summary>
        public string BUSSTS { get; set; }
        /// <summary>
        /// 申请类型	C (3)
        /// </summary>
        public string APPTYP { get; set; }
        /// <summary>
        /// 特殊码	C(30)   开证成功之后才有值。第一位Y表示有电文
        /// </summary>
        public string RSV30Z { get; set; }
        /// <summary>
        /// 中介人代码 	C(20)  仅国际信用
        /// </summary>
        public string MIDIDT { get; set; }
        /// <summary>
        /// 离岸标志	C(1)  仅国际信用
        /// </summary>
        public string OSAFLG { get; set; }
    }
}
