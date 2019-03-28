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
    /// 8.1.1.查询客户基金协议响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS8_1_1 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTFNDCTR
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTFNDCTR";
        /// <summary>
        /// 8.1.1.查询客户基金协议响应集合
        /// </summary>
        [XmlElement("NTFNDCTRZ")]
        public List<NTFNDCTRZ> List { get; set; }
    }
    /// <summary>
    /// 8.1.1.查询客户基金协议响应内容
    /// </summary>
    public class NTFNDCTRZ
    {
        /// <summary>
        /// 协议状态	C(1)	A-正常，C-关闭
        /// </summary>
        public string STSCOD { get; set; }
        /// <summary>
        /// 开协议日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime? OPNDAT { get; set; }
        /// <summary>
        /// 开协议日期	D, 对应<see cref="OPNDAT"/>
        /// </summary>
        [XmlElement("OPNDAT")]
        public string OPNDATStr
        {
            get
            {
                return this.OPNDAT?.ToString("yyyyMMdd");
            }
            set
            {
                this.OPNDAT = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.OPNDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 关协议日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime? CLSDAT { get; set; }
        /// <summary>
        /// 关协议日期	D, 对应<see cref="CLSDAT"/>
        /// </summary>
        [XmlElement("CLSDAT")]
        public string CLSDATStr
        {
            get
            {
                return this.CLSDAT?.ToString("yyyyMMdd");
            }
            set
            {
                this.CLSDAT = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.CLSDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 客户号	C(10)
        /// </summary>
        public string CLTNBR { get; set; }
        /// <summary>
        /// 客户类型	C(5)
        /// </summary>
        public string CLTTYP { get; set; }
        /// <summary>
        /// 银行卡号	C(35)
        /// </summary>
        public string EACNBR { get; set; }
        /// <summary>
        /// 银行卡类型	C(5)	
        /// </summary>
        public string EACTYP { get; set; }
        /// <summary>
        /// 银行卡序号	C(8)
        /// </summary>
        public string EACITN { get; set; }
        /// <summary>
        /// SA代码	C(3)
        /// </summary>
        public string SAACOD { get; set; }
        /// <summary>
        /// 协议编号	C(10)
        /// </summary>
        public string TACNBR { get; set; }
        /// <summary>
        /// 协议类型	C(5)
        /// </summary>
        public string TACTYP { get; set; }
        /// <summary>
        /// 协议分行	C(3)
        /// </summary>
        public string CTRBBK { get; set; }
        /// <summary>
        /// 协议部门	C(6)
        /// </summary>
        public string CTRBRN { get; set; }
    }
}
