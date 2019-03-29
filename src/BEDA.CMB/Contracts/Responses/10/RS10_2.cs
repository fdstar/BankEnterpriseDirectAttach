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
    /// 10.2.现金池账户额度积数查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS10_2 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// SDKNTCACINF
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "SDKNTCACINF";
        /// <summary>
        /// 10.2.现金池账户额度积数查询响应集合
        /// </summary>
        [XmlElement("NTAUBRTVZ")]
        public List<NTAUBRTVZ> List { get; set; }
    }
    /// <summary>
    /// 10.2.现金池账户额度积数查询响应内容
    /// </summary>
    public class NTAUBRTVZ
    {
        /// <summary>
        /// 协议编号	C(10)
        /// </summary>
        public string CRSCOD { get; set; }
        /// <summary>
        /// 协议序号	N(5)
        /// </summary>
        public string CRPSEQ { get; set; }
        /// <summary>
        /// 开户机构	C(6)	A.1 招行分行
        /// </summary>
        public string DBTBRN { get; set; }
        /// <summary>
        /// 户口号	C(35)
        /// </summary>
        public string DBTEAC { get; set; }
        /// <summary>
        /// 子公司户口名称	Z(62)
        /// </summary>
        public string DBTNAM { get; set; }
        /// <summary>
        /// 货币	C(2)	A.3 货币代码表
        /// </summary>
        public string DBTCCY { get; set; }
        /// <summary>
        /// 资金地区	C(3)
        /// </summary>
        public string DBTRGN { get; set; }
        /// <summary>
        /// 钞汇标志	C(1)
        /// </summary>
        public string DBTTYP { get; set; }
        /// <summary>
        /// 账户代码	C(5)
        /// </summary>
        public string DBTCOD { get; set; }
        /// <summary>
        /// 开户机构	C(6)	A.1 招行分行
        /// </summary>
        public string CRTBRN { get; set; }
        /// <summary>
        /// 户口号	C(35)
        /// </summary>
        public string CRTEAC { get; set; }
        /// <summary>
        /// 子公司户口名称	Z(62)
        /// </summary>
        public string CRTNAM { get; set; }
        /// <summary>
        /// 货币	C(2) 	A.3 货币代码表
        /// </summary>
        public string CRTCCY { get; set; }
        /// <summary>
        /// 资金地区	C(3) 
        /// </summary>
        public string CRTRGN { get; set; }
        /// <summary>
        /// 钞汇标志	C(1) 
        /// </summary>
        public string CRTTYP { get; set; }
        /// <summary>
        /// 账户代码	C(5) 
        /// </summary>
        public string CRTCOD { get; set; }
        /// <summary>
        /// 生效日期	D(8)
        /// </summary>
        [XmlIgnore]
        public DateTime EFTDAT { get; set; }
        /// <summary>
        /// 生效日期	D(8), 对应<see cref="EFTDAT"/>
        /// </summary>
        [XmlElement("EFTDAT")]
        public string EFTDATStr
        {
            get
            {
                return this.EFTDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.EFTDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 终止日期	D(8)
        /// </summary>
        [XmlIgnore]
        public DateTime ENDDAT { get; set; }
        /// <summary>
        /// 终止日期	D(8), 对应<see cref="ENDDAT"/>
        /// </summary>
        [XmlElement("ENDDAT")]
        public string ENDDATStr
        {
            get
            {
                return this.ENDDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.ENDDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 支付积数	F(17,2) 输入日期段的支付累计数
        /// </summary>
        public decimal DBTAUB { get; set; }
        /// <summary>
        /// 收入积数	F(17,2) 输入日期段的支付累计数
        /// </summary>
        public decimal CRDAUB { get; set; }
        /// <summary>
        /// 额度积数	F(17,2) 输入日期段的支付累计数
        /// </summary>
        public decimal NOMAUB { get; set; }
        /// <summary>
        /// 额度余额	M   实时额度余额，与输入日期段无关
        /// </summary>
        public decimal LMTAMT { get; set; }
        /// <summary>
        /// 保留字段	C(100)
        /// </summary>
        public string SPL100 { get; set; }
    }
}
