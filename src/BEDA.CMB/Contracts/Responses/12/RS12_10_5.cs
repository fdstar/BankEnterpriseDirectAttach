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
    /// 12.10.5.离岸外汇汇款查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS12_10_5 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTQRYRTO
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTQRYRTO";
        /// <summary>
        /// 12.10.5.离岸外汇汇款查询响应集合
        /// </summary>
        [XmlElement("NTQRYRTOZ")]
        public List<NTQRYRTOZ> List { get; set; }
    }
    /// <summary>
    /// 12.10.5.离岸外汇汇款查询响应内容
    /// </summary>
    public class NTQRYRTOZ
    {
        /// <summary>
        /// 流程实例号  	C(10)
        /// </summary>
        public string REQNBR { get; set; }
        /// <summary>
        /// 业务参考号  	C(30)
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 业务编码    	C(6) 
        /// </summary>
        public string BUSCOD { get; set; }
        /// <summary>
        /// 业务模式    	C(5) 
        /// </summary>
        public string BUSMOD { get; set; }
        /// <summary>
        /// 汇款人分行号	C(2) 	附录A.1
        /// </summary>
        public string RMTBBK { get; set; }
        /// <summary>
        /// 汇款人账号  	C(35)
        /// </summary>
        public string RMTACC { get; set; }
        /// <summary>
        /// 交易类型    	C(1) 
        /// 1：汇往招商银行离岸户口；
        /// 2：汇往招商银行非离岸户口；
        /// 3：汇往其他银行境内汇款；
        /// 4：汇往其他银行境外汇款；
        /// </summary>
        public string TRSCOD { get; set; }
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
        /// 经办日期  	D
        /// </summary>
        [XmlIgnore]
        public DateTime OPRDAT { get; set; }
        /// <summary>
        /// 经办日期  	D, 对应<see cref="OPRDAT"/>
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
        /// 汇款币种   	C(2)   	附录A.3
        /// </summary>
        public string RMTCCY { get; set; }
        /// <summary>
        /// 汇款金额   	M
        /// </summary>
        public decimal RMTAMT { get; set; }
        /// <summary>
        /// 汇款状态   	C(3)   	附录A.5
        /// </summary>
        public string REQSTA { get; set; }
        /// <summary>
        /// 汇款结果   	C(1)   	附录A.6
        /// </summary>
        public string RTNFLG { get; set; }
        /// <summary>
        /// 版本标志   	C(1)   	固定返回Y
        /// </summary>
        public string VERFLG { get; set; }
        /// <summary>
        /// 是否有附件 	C(1)   	Y/N
        /// </summary>
        public string ATHFLG { get; set; }
        /// <summary>
        /// 汇出编号   	C(25)
        /// </summary>
        public string ORTREF { get; set; }
        /// <summary>
        /// 收款人名称 	Z(102) 
        /// </summary>
        public string RCVNAM { get; set; }
        /// <summary>
        /// 错误码     	C(7)
        /// </summary>
        public string ERRNBR { get; set; }
        /// <summary>
        /// 错误信息  	Z(192)
        /// </summary>
        public string ERRMSG { get; set; }
        /// <summary>
        /// 汇款方式  	C(1)  	O：原币种汇款 M：多币种汇款
        /// </summary>
        public string ORTTYP { get; set; }
        /// <summary>
        /// 到账币种  	C(2)  	附录A.3
        /// </summary>
        public string EXGCCY { get; set; }
        /// <summary>
        /// 到账金额  	M
        /// </summary>
        public decimal EXGAMT { get; set; }
        /// <summary>
        /// 特殊码 30 	Z(30)
        /// </summary>
        public string RSV30Z { get; set; }
    }
}
