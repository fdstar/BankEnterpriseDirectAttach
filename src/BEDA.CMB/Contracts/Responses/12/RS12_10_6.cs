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
    /// 12.10.6.离岸外汇汇款明细查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS12_10_6 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTRTOINF
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTRTOINF";
        /// <summary>
        /// 12.10.6.离岸外汇汇款明细查询响应内容
        /// </summary>
        public NTRTOINFZ NTRTOINFZ { get; set; }
    }
    /// <summary>
    /// 12.10.6.离岸外汇汇款明细查询响应内容
    /// </summary>
    public class NTRTOINFZ
    {
        /// <summary>
        /// 流程实例号   	C(10)
        /// </summary>
        public string REQNBR { get; set; }
        /// <summary>
        /// 业务参考号	C(30)
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 汇出汇款编号	C(25)
        /// </summary>
        public string RMTREF { get; set; }
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
        /// 付款人名称	Z(100)
        /// </summary>
        public string RMTNAM { get; set; }
        /// <summary>
        /// 付款人分行号	C(2)	附录A.1
        /// </summary>
        public string RMTBBK { get; set; }
        /// <summary>
        /// 付款人账号	C(35)
        /// </summary>
        public string RMTACC { get; set; }
        /// <summary>
        /// 汇款币种	C(2)	附录A.3
        /// </summary>
        public string RMTCCY { get; set; }
        /// <summary>
        /// 购汇标志	C(1)
        /// </summary>
        public string EXGFLG { get; set; }
        /// <summary>
        /// 汇款金额	M
        /// </summary>
        public decimal RMTAMT { get; set; }
        /// <summary>
        /// 大额预报标志	C(1)
        /// </summary>
        public string PREAPP { get; set; }
        /// <summary>
        /// 收款人信息	C(1)
        /// </summary>
        public string CLTTYP { get; set; }
        /// <summary>
        /// 收款人账号	C(35)
        /// </summary>
        public string RCVACC { get; set; }
        /// <summary>
        /// 收款人姓名	Z(102)
        /// </summary>
        public string RCVNAM { get; set; }
        /// <summary>
        /// 收款人地址	Z(102)
        /// </summary>
        public string RCVADR { get; set; }
        /// <summary>
        /// 汇入国家	C(3) 	附录A.8
        /// </summary>
        public string CNRCOD { get; set; }
        /// <summary>
        /// RTGS 标志	C(1) 
        /// </summary>
        public string RTGFLG { get; set; }
        /// <summary>
        /// 汇入行RTGS	C(11)
        /// </summary>
        public string RCBRTG { get; set; }
        /// <summary>
        /// SWIFT 标志	C(1) 
        /// </summary>
        public string SWFFLG { get; set; }
        /// <summary>
        /// 汇入行 SWIFT	S(11) 
        /// </summary>
        public string RCBSWF { get; set; }
        /// <summary>
        /// 汇入行名址	Z(142)
        /// </summary>
        public string RCBADR { get; set; }
        /// <summary>
        /// 汇入行中文名称	Z(140)
        /// </summary>
        public string CHNADR { get; set; }
        /// <summary>
        /// 代理行 SWIFT	S(11) 
        /// </summary>
        public string AGBSWF { get; set; }
        /// <summary>
        /// 代理行名址	Z(140)
        /// </summary>
        public string AGBADR { get; set; }
        /// <summary>
        /// 代理行账号	C(35) 
        /// </summary>
        public string AGBACC { get; set; }
        /// <summary>
        /// 汇款附言	Z(210)
        /// </summary>
        public string INFTXT { get; set; }
        /// <summary>
        /// 汇款费用承担	C(1)  	O:汇款人 B:收款人 S:共同
        /// </summary>
        public string CFGFOR { get; set; }
        /// <summary>
        /// 备注给我行	Z(140)
        /// </summary>
        public string REMARK { get; set; }
        /// <summary>
        /// 业务处理结果	C(1)  	附录A.6
        /// </summary>
        public string RTNFLG { get; set; }
        /// <summary>
        /// 结果摘要	Z(92)
        /// </summary>
        public string RTNNAR { get; set; }
        /// <summary>
        /// 取消/退回备注	Z(62)
        /// </summary>
        public string CNLTXT { get; set; }
        /// <summary>
        /// IBAN 标志	C(1) 
        /// </summary>
        public string IBNFLG { get; set; }
        /// <summary>
        /// 汇入行城市码	C(6) 
        /// </summary>
        public string RCBCTY { get; set; }
        /// <summary>
        /// 收款行国家代码	C(3) 	附录A.8
        /// </summary>
        public string BNKCNR { get; set; }
        /// <summary>
        /// 汇款方式	C(1) 	O：原币种汇款 M：多币种汇款
        /// </summary>
        public string ORTTYP { get; set; }
        /// <summary>
        /// 到账币种	C(2) 
        /// </summary>
        public string EXGCCY { get; set; }
        /// <summary>
        /// 到账金额	M
        /// </summary>
        public decimal EXGAMT { get; set; }
        /// <summary>
        /// 清分编号	C(18)
        /// </summary>
        public string CLRNBR { get; set; }
        /// <summary>
        /// 特殊码50	C(50)
        /// </summary>
        public string RSV50Z { get; set; }
    }
}
