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
    /// 19.2.3.汇票批量签发经办（银行承兑、商业承兑同一程序）请求主体
    /// 整批成功或整批失败，不存在经办部分成功和部分失败的情况
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ19_2_3 : CMBBase<RQINFO>, IRequest<RS19_2_3>
    {
        /// <summary>
        /// SDKECPSET
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "SDKECPSET";
        /// <summary>
        /// 19.2.3.汇票批量签发经办（银行承兑、商业承兑同一程序）请求内容
        /// </summary>
        public NTBUSMODY NTBUSMODY { get; set; }
        /// <summary>
        /// 19.2.3.汇票批量签发经办（银行承兑、商业承兑同一程序）请求内容
        /// </summary>
        public NTECPSETX1 NTECPSETX1 { get; set; }
        /// <summary>
        /// 19.2.3.汇票批量签发经办（银行承兑、商业承兑同一程序）请求集合
        /// </summary>
        [XmlElement("NTECPSETX2")]
        public List<NTECPSETX2> List { get; set; }
    }
    /// <summary>
    /// 19.2.3.汇票批量签发经办（银行承兑、商业承兑同一程序）请求内容
    /// </summary>
    public class NTECPSETX1
    {
        /// <summary>
        /// 票据类型	C(3)    商业承对汇票：CCP 银行承对汇票：BCP
        /// </summary>
        public string TKTTYP { get; set; }
        /// <summary>
        /// 网上票据标志	C(1)	E:电子票据签发;A:实物汇票申请   商业承对汇票只能经办电子票据
        /// </summary>
        public string NETFLG { get; set; }
        /// <summary>
        /// 额度编号	C(10)   额度查询查得 （银行承兑汇票必输）
        /// </summary>
        public string GRTSEQ { get; set; }
        /// <summary>
        /// 付款人联行号	C(6)
        /// </summary>
        public string OPNBNK { get; set; }
        /// <summary>
        /// 出票人名称	Z(62)
        /// </summary>
        public string PAYNAM { get; set; }
        /// <summary>
        /// 出票人账号	C(35)
        /// </summary>
        public string PAYACC { get; set; }
        /// <summary>
        /// 出票人账号分行号	C(2)
        /// </summary>
        public string PAYBBK { get; set; }
        /// <summary>
        /// 业务参考号	C(30)
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 保证金比例	F(5,2)  百分比，不用输入%号。
        /// </summary>
        public decimal? BALPER { get; set; }
        /// <summary>
        /// 手续费比例	F(5,2)  百分比，不用输入%号。
        /// </summary>
        public decimal? CHGPER { get; set; }
        /// <summary>
        /// 保留字段	A(20)
        /// </summary>
        public string RSV30Z { get; set; }
    }
    /// <summary>
    /// 19.2.3.汇票批量签发经办（银行承兑、商业承兑同一程序）请求内容
    /// </summary>
    public class NTECPSETX2
    {
        /// <summary>
        /// 汇票金额	M
        /// </summary>
        public decimal TKTAMT { get; set; }
        /// <summary>
        /// 出票日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime OPNDAT { get; set; }
        /// <summary>
        /// 出票日期	D, 对应<see cref="OPNDAT"/>
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
        /// 合同号	C(10)
        /// </summary>
        public string TSTSEQ { get; set; }
        /// <summary>
        /// 收款人名称	Z(62)
        /// </summary>
        public string RCVNAM { get; set; }
        /// <summary>
        /// 收款人账号	C(35)
        /// </summary>
        public string RCVACC { get; set; }
        /// <summary>
        /// 收款行地址	Z(62)
        /// </summary>
        public string RCVADR { get; set; }
        /// <summary>
        /// 收款行名称	Z(62)
        /// </summary>
        public string RBKNAM { get; set; }
        /// <summary>
        /// 不可转让标志	C(1)    Y/N 缺省为N：可转让
        /// </summary>
        public string TRMFLG { get; set; }
    }
}
