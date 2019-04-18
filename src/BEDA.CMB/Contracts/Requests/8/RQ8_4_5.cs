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
    /// 8.4.5.业务查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ8_4_5 : CMBBase<RQINFO>, IRequest<RS8_4_5>
    {
        /// <summary>
        /// QueryFixNotify
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "QueryFixNotify";
        /// <summary>
        /// 8.4.5.业务查询请求内容
        /// </summary>
        public NTQRYFNCY NTQRYFNCY { get; set; }
    }
    /// <summary>
    /// 8.4.5.业务查询请求内容
    /// </summary>
    public class NTQRYFNCY
    {
        /// <summary>
        /// 业务类型	C(6)	N08010: 定活互转 N08020: 通知存款 ******: 全部  默认查询全部
        /// </summary>
        public string BUSCOD { get; set; } = "******";
        /// <summary>
        /// 操作类型	C(3)
        /// ***: 全部
        /// FTC: 定转活
        /// CTF: 活转定
        /// CTS: 活期转通知存款
        /// CNF: 取消通知
        /// NTF: 通知
        /// STC: 通知存款转活期
        /// </summary>
        public string OPRTYP { get; set; } = "***";
        /// <summary>
        /// 开始日	D   开始日和结束日的间隔不能超过100天
        /// </summary>
        [XmlIgnore]
        public DateTime BGNDAT { get; set; }
        /// <summary>
        /// 开始日	D, 对应<see cref="BGNDAT"/>
        /// </summary>
        [XmlElement("BGNDAT")]
        public string BGNDATStr
        {
            get
            {
                return this.BGNDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.BGNDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 结束日	D   开始日和结束日的间隔不能超过100天
        /// </summary>
        [XmlIgnore]
        public DateTime ENDDAT { get; set; }
        /// <summary>
        /// 结束日	D, 对应<see cref="ENDDAT"/>
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
        /// 活期账号	C(35)   为空查所有帐号
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 定期账号	C(35)   为空查所有帐号
        /// </summary>
        public string FIXACC { get; set; }
        /// <summary>
        /// 业务参考号	C(30)
        /// </summary>
        public string YURREF { get; set; }
    }
}
