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
    /// 4.3.查询交易概要信息响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS4_3 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTAGCINN
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTAGCINN";
        /// <summary>
        /// 4.3.查询交易概要信息响应集合
        /// </summary>
        [XmlElement("NTAGCINQZ")]
        public List<NTAGCINQZ> List { get; set; }
    }
    /// <summary>
    /// 4.3.查询交易概要信息响应内容
    /// </summary>
    public class NTAGCINQZ
    {
        /// <summary>
        /// 流程实例号    	C(10)
        /// </summary>
        public string REQNBR { get; set; }
        /// <summary>
        /// 业务类型      	C(6)	附录A.4
        /// </summary>
        public string BUSCOD { get; set; }
        /// <summary>
        /// 业务模式      	C(5)
        /// </summary>
        public string BUSMOD { get; set; }
        /// <summary>
        /// 经办日	D
        /// </summary>
        [XmlIgnore]
        public DateTime? OPRDAT { get; set; }
        /// <summary>
        /// 经办日	D, 对应<see cref="OPRDAT"/>
        /// </summary>
        [XmlElement("OPRDAT")]
        public string OPRDATStr
        {
            get
            {
                return this.OPRDAT?.ToString("yyyyMMdd");
            }
            set
            {
                this.OPRDAT = null;
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
        /// 业务请求状态  	C(3)	附录A.5
        /// </summary>
        public string REQSTA { get; set; }
        /// <summary>
        /// 业务请求结果  	C(1)	附录 A.6
        /// </summary>
        public string RTNFLG { get; set; }
        /// <summary>
        /// 待处理操作步骤	C(6)
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
        /// 用户登录名   	Z(30)
        /// </summary>
        public string LGNNAM { get; set; }
        /// <summary>
        /// 用户姓名     	Z(20)
        /// </summary>
        public string USRNAM { get; set; }
        /// <summary>
        /// 业务受理城市号	C(6)
        /// </summary>
        public string CTYNBR { get; set; }
        /// <summary>
        /// 业务受理部门号	C(4)
        /// </summary>
        public string BRNNBR { get; set; }
        /// <summary>
        /// 业务受理分行号	C(2)
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 帐号         	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 户名         	Z(62)
        /// </summary>
        public string ACCNAM { get; set; }
        /// <summary>
        /// 交易笔数     	A(6)
        /// </summary>
        public string TRSNUM { get; set; }
        /// <summary>
        /// 总金额       	M
        /// </summary>
        public decimal TOTAMT { get; set; }
        /// <summary>
        /// 币种     	C(2)	附录A.3
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 货币市场 	C(1)
        /// </summary>
        public string CCYMKT { get; set; }
        /// <summary>
        /// 交易类型 	C(4)
        /// </summary>
        public string TRSTYP { get; set; }
        /// <summary>
        /// 成功笔数 	N(6)
        /// </summary>
        public int SUCNUM { get; set; }
        /// <summary>
        /// 成功金额 	M
        /// </summary>
        public decimal SUCAMT { get; set; }
        /// <summary>
        /// 用途     	Z(42)
        /// </summary>
        public string NUSAGE { get; set; }
        /// <summary>
        /// 对方参考号	C(30)
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 记录状态 	C(1)
        /// </summary>
        public string STSCOD { get; set; }
        /// <summary>
        /// 错误码   	C(7)
        /// </summary>
        public string ERRCOD { get; set; }
        /// <summary>
        /// 错误描述 	Z(92)
        /// </summary>
        public string ERRDSP { get; set; }
        /// <summary>
        /// 处理批号      	C(10)
        /// </summary>
        public string SEQCOD { get; set; }
        /// <summary>
        /// 附件标志Y/N	C(1)
        /// </summary>
        public string ATHFLG { get; set; }
        /// <summary>
        /// 保留字 42     	C(42)
        /// </summary>
        public string RSV62Z { get; set; }
        /// <summary>
        /// 虚拟户编号    	C(20)
        /// </summary>
        public string DMANBR { get; set; }
    }
}
