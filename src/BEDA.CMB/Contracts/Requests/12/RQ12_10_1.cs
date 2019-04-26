using BEDA.CMB.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CMB.Contracts.Requests
{
    /// <summary>
    /// 12.10.1.离岸外汇汇款经办请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ12_10_1 : CMBBase<RQINFO>, IRequest<RS12_10_1>
    {
        /// <summary>
        /// NTRTOOP1
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTRTOOP1";
        /// <summary>
        /// 12.10.1.离岸外汇汇款经办请求内容
        /// </summary>
        public NTRTOOPTX NTRTOOPTX { get; set; }
        /// <summary>
        /// 12.10.1.离岸外汇汇款经办请求内容
        /// </summary>
        public NTRTOOPRX NTRTOOPRX { get; set; }
    }
    /// <summary>
    /// 12.10.1.离岸外汇汇款经办请求内容
    /// </summary>
    public class NTRTOOPTX
    {
        /// <summary>
        /// 业务模式 	C(5)
        /// </summary>
        public string BUSMOD { get; set; }
    }
    /// <summary>
    /// 12.10.1.离岸外汇汇款经办请求内容
    /// </summary>
    public class NTRTOOPRX
    {
        /// <summary>
        /// 业务参考号	C(30) 
        /// </summary>
        public string YURREF { get; set; }
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
        /// 汇款分行号	C(2)	附录A.1
        /// </summary>
        public string RMTBBK { get; set; }
        /// <summary>
        /// 汇款账号	C(35)
        /// </summary>
        public string RMTACC { get; set; }
        /// <summary>
        /// 汇款币种	C(2)	附录A.3
        /// </summary>
        public string RMTCCY { get; set; }
        /// <summary>
        /// 购汇标志	C(1)	付款人账号的币种与汇款币种不符，赋值Y， 否则留空
        /// </summary>
        public string EXGFLG { get; set; }
        /// <summary>
        /// 汇款金额	M
        /// </summary>
        public decimal RMTAMT { get; set; }
        /// <summary>
        /// 预报标志	C(1)	汇款金额超过企银金额预设值时，需要打上预报标志Y，否则为空
        /// 各币种金额预设值见附录A.9
        /// </summary>
        public string PREAPP { get; set; }
        /// <summary>
        /// 收款人信息	C(1)	A:公司客户; P:个人客户
        /// </summary>
        public string CLTTYP { get; set; }
        /// <summary>
        /// 收款人账号	C(35)
        /// </summary>
        public string RCVACC { get; set; }
        /// <summary>
        /// 收款人名称	Z(100)  收款人名称＋收款人地址总长不能超过140个字符
        /// </summary>
        public string RCVNAM { get; set; }
        /// <summary>
        /// 收款人地址	Z(100)  收款人名称＋收款人地址总长不能超过140个字符
        /// </summary>
        public string RCVADR { get; set; }
        /// <summary>
        /// 收款人国家代码	C(3)
        /// </summary>
        public string RCVCNR { get; set; }
        /// <summary>
        /// 汇入国家	C(3)
        /// CHN:中国
        /// HKG:香港
        /// SGP:新加坡
        /// USA:美国
        /// </summary>
        public string CNRCOD { get; set; }
        /// <summary>
        /// 汇入行 SWIFT	S(11)
        /// </summary>
        public string RCBSWF { get; set; }
        /// <summary>
        /// 汇入行名址	Z(140)  当汇入国家不为CHN时，此字段必输
        /// </summary>
        public string RCBADR { get; set; }
        /// <summary>
        /// 汇入行中文名称	Z(140)
        /// </summary>
        public string CHNADR { get; set; }
        /// <summary>
        /// 汇入行城市码	C(6)
        /// </summary>
        public string RCBCTY { get; set; }
        /// <summary>
        /// 汇款附言   	Z(140)
        /// 1）选择标准附言，汇款信息提交后，附言栏只需要提交英文信息，标准附言内容如下：
        /// A运费/FREIGHT
        /// B工资薪金/SALARY
        /// C货款/GOODS PAYMENT
        /// D同名划转/TRANSFER OF THE SAME ACCOUNT
        /// E佣金/COMMISSION
        /// F保险费/INSURANCE FEE
        /// G预付货款/ADVANCE PAYMENT
        /// 2）客户自行输入附言功能，可输入任意英文字符，长度不超过140字符
        /// </summary>
        public string INFTXT { get; set; }
        /// <summary>
        /// 汇款费用承担	C(1) 	S:共同  O:汇款人  
        /// </summary>
        public string CHGFOR { get; set; }
        /// <summary>
        /// 保证条款标志	C(1)    必须为Y
        /// </summary>
        public string GRTFLG { get; set; } = "Y";
        /// <summary>
        /// 备注给我行 	Z(100)
        /// </summary>
        public string REMARK { get; set; }
        /// <summary>
        /// 汇款方式	C(1)	O：原币种汇款
        /// </summary>
        public string ORTTYP { get; set; }
        /// <summary>
        /// 特殊码 50	C(50)
        /// </summary>
        public string RSV50Z { get; set; }
    }
}
