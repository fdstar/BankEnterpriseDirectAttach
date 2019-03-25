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
    /// 21.3.1.协议查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ21_3_3 : CMBBase<RQINFO>, IRequest<RS21_3_3>
    {
        /// <summary>
        /// NTQRYCBQ
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTQRYCBQ";
        /// <summary>
        /// 21.3.1.协议查询请求内容
        /// </summary>
        public NTQRYCBQX NTQRYCBQX { get; set; }
    }
    /// <summary>
    /// 21.3.1.协议查询请求内容
    /// </summary>
    public class NTQRYCBQX
    {
        /// <summary>
        /// 协议类型	C(2)    不传则查询全部
        /// 03=查询协议
        /// 02=授权支付协议
        /// 01=贷记协议
        /// </summary>
        public string PTCTYP { get; set; }
        /// <summary>
        /// 银行号	C(2)
        /// </summary>
        public string QRYBBK { get; set; }
        /// <summary>
        /// 查询账号	C(35)
        /// </summary>
        public string QRYACC { get; set; }
        /// <summary>
        /// 内部协议编号	C(10)   输入为单笔查询
        /// </summary>
        public string CNVNBR { get; set; }
        /// <summary>
        /// 人行协议号	C(60)
        /// </summary>
        public string PTCNBR { get; set; }
        /// <summary>
        /// 协议状态	C(2)
        /// </summary>
        public string PTCSTS { get; set; }
        /// <summary>
        /// 协议生效起始日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime? BGNDAT { get; set; }
        /// <summary>
        /// 协议生效起始日期	D, 对应<see cref="BGNDAT"/>
        /// </summary>
        [XmlElement("BGNDAT")]
        public string BGNDATStr
        {
            get
            {
                return this.BGNDAT?.ToString("yyyyMMdd");
            }
            set
            {
                this.BGNDAT = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.BGNDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 协议生效结束日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime? ENDDAT { get; set; }
        /// <summary>
        /// 协议生效结束日期	D, 对应<see cref="ENDDAT"/>
        /// </summary>
        [XmlElement("ENDDAT")]
        public string ENDDATStr
        {
            get
            {
                return this.ENDDAT?.ToString("yyyyMMdd");
            }
            set
            {
                this.ENDDAT = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.ENDDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 协议失效起始日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime? EFTDAT { get; set; }
        /// <summary>
        /// 协议失效起始日期	D, 对应<see cref="EFTDAT"/>
        /// </summary>
        [XmlElement("EFTDAT")]
        public string EFTDATStr
        {
            get
            {
                return this.EFTDAT?.ToString("yyyyMMdd");
            }
            set
            {
                this.EFTDAT = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.EFTDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 协议失效结束日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime? EFEDAT { get; set; }
        /// <summary>
        /// 协议失效结束日期	D, 对应<see cref="EFEDAT"/>
        /// </summary>
        [XmlElement("EFEDAT")]
        public string EFEDATStr
        {
            get
            {
                return this.EFEDAT?.ToString("yyyyMMdd");
            }
            set
            {
                this.EFEDAT = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.EFEDAT = tmp;
                }
            }
        }
    }
}
