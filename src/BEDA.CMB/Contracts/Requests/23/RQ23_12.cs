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
    /// 23.12.查询所有公司卡申请请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ23_12 : CMBBase<RQINFO>, IRequest<RS23_12>
    {
        /// <summary>
        /// NTCRDINQ
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTCRDINQ";
        /// <summary>
        /// 23.12.查询所有公司卡申请请求内容
        /// </summary>
        public NTCRDINQY NTCRDINQY { get; set; }
    }
    /// <summary>
    /// 23.12.查询所有公司卡申请请求内容
    /// </summary>
    public class NTCRDINQY
    {
        /// <summary>
        /// 起始日期 	D
        /// </summary>
        [XmlIgnore]
        public DateTime BGNDAT { get; set; }
        /// <summary>
        /// 起始日期	D, 对应<see cref="BGNDAT"/>
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
        /// 结束日期 	D
        /// </summary>
        [XmlIgnore]
        public DateTime ENDDAT { get; set; }
        /// <summary>
        /// 结束日期	D, 对应<see cref="ENDDAT"/>
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
        /// 日期标志 	C(1)    ‘A’：按经办日查询‘B’：按期望日查询
        /// </summary>
        public string DATFLG { get; set; }
        /// <summary>
        /// 经办用户名	Z(30)
        /// </summary>
        public string OPRLGN { get; set; }
        /// <summary>
        /// 业务参考号	C(30)	
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 公司卡号 	C(20)
        /// </summary>
        public string PSBNBR { get; set; }
        /// <summary>
        /// 业务类型 	C(4)
        /// </summary>
        public string CRDTYP { get; set; }
        /// <summary>
        /// 续传     	C(80)
        /// </summary>
        public string CTNKEY { get; set; }
    }
}
