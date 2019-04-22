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
    /// 8.11.2.银期转账直连综合查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS8_11_2 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTBTFDQY
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTBTFDQY";
        /// <summary>
        /// 8.11.2.银期转账直连综合查询响应集合
        /// </summary>
        [XmlElement("NTBTFDQYZ")]
        public List<NTBTFDQYZ> List { get; set; }
    }
    /// <summary>
    /// 8.8.2.银证转账直联综合查询响应内容
    /// </summary>
    public class NTBTFDQYZ
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
        /// 交易类型	C(4)
        /// </summary>
        public string TRSCOD { get; set; }
        /// <summary>
        /// 交易日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime OPRDTA { get; set; }
        /// <summary>
        /// 交易日期	D, 对应<see cref="OPRDTA"/>
        /// </summary>
        [XmlElement("OPRDTA")]
        public string OPRDTAStr
        {
            get
            {
                return this.OPRDTA.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.OPRDTA = tmp;
                }
            }
        }
        /// <summary>
        /// 业务参考号	C(30)
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 资金分行号	C(2)
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 银行帐号	C(35)
        /// </summary>
        public string EACNBR { get; set; }
        /// <summary>
        /// 货币代码	C(2)	A.3 货币代码表
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 转帐金额	M
        /// </summary>
        public decimal TRSAMT { get; set; }
        /// <summary>
        /// 炒汇标志	C(1)
        /// </summary>
        public string CCYFLG { get; set; }
        /// <summary>
        /// 请求状态	C(3)
        /// </summary>
        public string REQSTA { get; set; }
        /// <summary>
        /// 处理结果	C(1)
        /// </summary>
        public string RTNFLG { get; set; }
        /// <summary>
        /// 期货公司编号	C(6)
        /// </summary>
        public string FUTNBR { get; set; }
        /// <summary>
        /// 保证金账号	C(30)
        /// </summary>
        public string MARACT { get; set; }
    }
}
