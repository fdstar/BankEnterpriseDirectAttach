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
    /// 20.4.联动支付综合查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS20_4 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTQRYLKP
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTQRYLKP";
        /// <summary>
        /// 20.4.联动支付综合查询响应集合
        /// </summary>
        [XmlElement("NTQRYLKPZ1")]
        public List<NTQRYLKPZ1> List { get; set; }
    }
    /// <summary>
    /// 20.4.联动支付综合查询响应内容
    /// </summary>
    public class NTQRYLKPZ1
    {
        /// <summary>
        /// 流程实例号	C(10)
        /// </summary>
        public string REQNBR { get; set; }
        /// <summary>
        /// 业务类型	C(6)
        /// </summary>
        public string BUSCOD { get; set; }
        /// <summary>
        /// 业务模式	C(5)
        /// </summary>
        public string BUSMOD { get; set; }
        /// <summary>
        /// 付方分行号	C(2)
        /// </summary>
        public string DBTBBK { get; set; }
        /// <summary>
        /// 付方账号	C(35)
        /// </summary>
        public string DBTACC { get; set; }
        /// <summary>
        /// 授权账号	C(35)
        /// </summary>
        public string AUTEAC { get; set; }
        /// <summary>
        /// 收方分行号	C(2)
        /// </summary>
        public string CRTBBK { get; set; }
        /// <summary>
        /// 收方帐号	C(35)
        /// </summary>
        public string CRTACC { get; set; }
        /// <summary>
        /// 收方名称	Z(62)
        /// </summary>
        public string CRTNAM { get; set; }
        /// <summary>
        /// 币种	C(2)
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 交易金额	M
        /// </summary>
        public decimal TRSAMT { get; set; }
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
        /// 经办日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime OPRDAT { get; set; }
        /// <summary>
        /// 经办日期	D, 对应<see cref="OPRDAT"/>
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
        /// 业务参考号	C(30)
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 是否有附件信息	C(1)	Y=有附件，N=无附件
        /// </summary>
        public string ATHFLG { get; set; }
        /// <summary>
        /// 附件套号	C(40)
        /// </summary>
        public string ATHSET { get; set; }
        /// <summary>
        /// 发起状态	C(1)
        /// A:待审批
        /// T:终审完毕
        /// K：银行处理中
        /// E:失败
        /// S:成功
        /// F:已撤销
        /// B:已退票
        /// R:否决
        /// C:撤销
        /// D:过期撤销
        /// </summary>
        public string BUSCD1 { get; set; }
        /// <summary>
        /// 汇款业务状态	C(1)
        /// A:待审批
        /// T:终审完毕
        /// K：银行处理中
        /// E:失败
        /// S:成功
        /// F:已撤销
        /// B:已退票
        /// R:否决
        /// C:撤销
        /// D:过期撤销
        /// </summary>
        public string BUSCD2 { get; set; }
    }
}
