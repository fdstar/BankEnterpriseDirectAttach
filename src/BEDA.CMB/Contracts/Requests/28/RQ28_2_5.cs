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
    /// 28.2.5.虚拟户退款经办请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ28_2_5 : CMBBase<RQINFO>, IRequest<RS28_2_5>
    {
        /// <summary>
        /// NTOPRDMR
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTOPRDMR";
        /// <summary>
        /// 28.2.5.虚拟户退款经办请求内容
        /// </summary>
        public NTBUSMODY NTBUSMODY { get; set; }
        /// <summary>
        /// 28.2.5.虚拟户退款经办请求内容
        /// </summary>
        public NTOPRDMRX1 NTOPRDMRX1 { get; set; }
    }
    /// <summary>
    /// 28.2.5.虚拟户退款经办请求内容
    /// </summary>
    public class NTOPRDMRX1
    {
        /// <summary>
        /// 原交易套号	C(15)
        /// </summary>
        public string SETNBR { get; set; }
        /// <summary>
        /// 原交易流水号	C(15)
        /// </summary>
        public string TRXNBR { get; set; }
        /// <summary>
        /// 原交易金额 	M   正数(若计息时，原交易金额+利息合成一笔交易的总金额，即最后产生的交易金额=原交易金额+利息)
        /// </summary>
        public decimal TRSAMT { get; set; }
        /// <summary>
        /// 分行号	C(2)
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 主账号	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 虚拟户编号	C(20)
        /// </summary>
        public string DUMNBR { get; set; }
        /// <summary>
        /// 退款日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime EPTDAT { get; set; }
        /// <summary>
        /// 退款日期	D, 对应<see cref="EPTDAT"/>
        /// </summary>
        [XmlElement("EPTDAT")]
        public string EPTDATStr
        {
            get
            {
                return this.EPTDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.EPTDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 原付方账号	C(35)
        /// </summary>
        public string RPYACC { get; set; }
        /// <summary>
        /// 原付方名称	Z(200)
        /// </summary>
        public string RPYNAM { get; set; }
        /// <summary>
        /// 是否退息	C(1) 	Y:退息 N:不退息
        /// </summary>
        public string INTFLG { get; set; }
        /// <summary>
        /// 利息	M   INTFLG为Y时，必须为正数 INTFLG为N时，必须为0
        /// </summary>
        public decimal INTAMT { get; set; }
        /// <summary>
        /// 用途	Z(62)   	如果为空则默认为“资金原路返回交易”
        /// </summary>
        public string NUSAGE { get; set; }
        /// <summary>
        /// 客户摘要	Z(200)
        /// </summary>
        public string BUSNAR { get; set; }
        /// <summary>
        /// 对方参考号	C(30)
        /// </summary>
        public string YURREF { get; set; }
    }
}
