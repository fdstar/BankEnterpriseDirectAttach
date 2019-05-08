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
    /// 28.2.4.虚拟户付款经办请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ28_2_4 : CMBBase<RQINFO>, IRequest<RS28_2_4>
    {
        /// <summary>
        /// NTOPRDMP
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTOPRDMP";
        /// <summary>
        /// 28.2.4.虚拟户付款经办请求内容
        /// </summary>
        public NTBUSMODY NTBUSMODY { get; set; }
        /// <summary>
        /// 28.2.4.虚拟户付款经办请求内容
        /// </summary>
        public NTOPRDMPX1 NTOPRDMPX1 { get; set; }
    }
    /// <summary>
    /// 28.2.4.虚拟户付款经办请求内容
    /// </summary>
    public class NTOPRDMPX1
    {
        /// <summary>
        /// 转出分行号	C(2)    结算账户开户行
        /// </summary>
        public string DBTBBK { get; set; }
        /// <summary>
        /// 转出帐号	C(35)   	结算账户
        /// </summary>
        public string DBTACC { get; set; }
        /// <summary>
        /// 虚拟户编号	C(20)
        /// </summary>
        public string DUMNBR { get; set; }
        /// <summary>
        /// 币种	C(2)	附录A.3   只支持人民币
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 金额	M
        /// </summary>
        public decimal TRSAMT { get; set; }
        /// <summary>
        /// 系统内标志	C(1)	Y：行内 N：行外
        /// </summary>
        public string BNKFLG { get; set; }
        /// <summary>
        /// 收方分行号	C(3)	附录A.1   BNKFLG为Y时非空
        /// </summary>
        public string OPPBBK { get; set; }
        /// <summary>
        /// 收方开户行行号	C(20)   	联行号
        /// </summary>
        public string OPPBBN { get; set; }
        /// <summary>
        /// 收方帐号	C(35)
        /// </summary>
        public string CRTACC { get; set; }
        /// <summary>
        /// 收方户名	Z(200)
        /// </summary>
        public string CRTNAM { get; set; }
        /// <summary>
        /// 收方行名称	Z(62)
        /// </summary>
        public string CRTBNK { get; set; }
        /// <summary>
        /// 收方行地址	Z(100)
        /// </summary>
        public string CRTADR { get; set; }
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
        /// 结算通道	C(1)	F：快速 N：普通
        /// </summary>
        public string STLCHN { get; set; }
        /// <summary>
        /// 用途	Z(62)
        /// </summary>
        public string NUSAGE { get; set; }
        /// <summary>
        /// 对方参考号	C(30)
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 业务摘要	Z(200)
        /// </summary>
        public string BUSNAR { get; set; }
        /// <summary>
        /// 业务种类	C(6)	100001=普通汇兑 101001=慈善捐款 101002 =其他 默认100001
        /// </summary>
        public string TRSTYP { get; set; }
    }
}
