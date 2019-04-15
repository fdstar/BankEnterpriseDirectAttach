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
    /// 22.1.6.纸质商业汇票托管申请请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ22_1_6 : CMBBase<RQINFO>, IRequest<RS22_1_6>
    {
        /// <summary>
        /// NTBILHSD
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTBILHSD";
        /// <summary>
        /// 22.1.6.纸质商业汇票托管申请请求内容
        /// </summary>
        public NTBILHSDX1 NTBILHSDX1 { get; set; }
        /// <summary>
        /// 22.1.6.纸质商业汇票托管申请请求集合
        /// </summary>
        [XmlElement("NTBILHSDX2")]
        public List<NTBILHSDX2> List { get; set; }
    }
    /// <summary>
    /// 22.1.6.纸质商业汇票托管申请请求内容
    /// </summary>
    public class NTBILHSDX1
    {
        /// <summary>
        /// 分行号	C(2)
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 持票人账号	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 业务参考号	C(30)
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 期望日	D
        /// </summary>
        [XmlIgnore]
        public DateTime? ExpectedTime { get; set; }
        /// <summary>
        /// 期望日	D
        /// </summary>
        [XmlElement("EPTDAT")]
        public string EPTDATStr
        {
            get
            {
                return this.ExpectedTime?.ToString("yyyyMMdd");
            }
            set { }
        }
        /// <summary>
        /// 期望时间	T
        /// </summary>
        [XmlElement("EPTTIM")]
        public string EPTTIMStr
        {
            get
            {
                return this.ExpectedTime?.ToString("HHmmss");
            }
            set { }
        }
        /// <summary>
        /// 票据总张数	C(5)    检验录入票的总张数使用
        /// </summary>
        public int TOLCNT { get; set; }
        /// <summary>
        /// 票据总金额	M
        /// </summary>
        public decimal TOLAMT { get; set; }
    }
    /// <summary>
    /// 22.1.6.纸质商业汇票托管申请请求内容
    /// </summary>
    public class NTBILHSDX2
    {
        /// <summary>
        /// 序号	C(3)
        /// </summary>
        public string SQRNBR { get; set; }
        /// <summary>
        /// 票据号	C(20)
        /// </summary>
        public string BILNBR { get; set; }
        /// <summary>
        /// 票据种类	C(1)	‘0’ 银行承兑汇票 ‘1’   商业承兑汇票
        /// </summary>
        public string BILTYP { get; set; }
        /// <summary>
        /// 票面金额	M
        /// </summary>
        public decimal BILAMT { get; set; }
        /// <summary>
        /// 出票日	D
        /// </summary>
        [XmlIgnore]
        public DateTime OPNDAT { get; set; }
        /// <summary>
        /// 出票日	D, 对应<see cref="OPNDAT"/>
        /// </summary>
        [XmlElement("OPNDAT")]
        public string OPNDATStr
        {
            get
            {
                return this.OPNDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.OPNDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 到期日	D
        /// </summary>
        [XmlIgnore]
        public DateTime ENDDAT { get; set; }
        /// <summary>
        /// 到期日	D, 对应<see cref="ENDDAT"/>
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
        /// 出票人	Z (62)
        /// </summary>
        public string PAYNAM { get; set; }
        /// <summary>
        /// 付款行行别	C(3)
        /// </summary>
        public string BNKTYP { get; set; }
        /// <summary>
        /// 付款行行号	C(12)
        /// </summary>
        public string BRDNBR { get; set; }
        /// <summary>
        /// 付款行行名	Z(62)
        /// </summary>
        public string PAYBNK { get; set; }
        /// <summary>
        /// 收款人	Z(62)
        /// </summary>
        public string RCVNAM { get; set; }
        /// <summary>
        /// 收款行行名	Z(62)
        /// </summary>
        public string RCVBNK { get; set; }
        /// <summary>
        /// 持票人名称	Z(62)
        /// </summary>
        public string OWNNAM { get; set; }
        /// <summary>
        /// 自动托收标志	C(1)	‘Y’ 自动托收 ‘N’ 持票人自行发托收申请
        /// </summary>
        public string ATORCV { get; set; }
    }
}
