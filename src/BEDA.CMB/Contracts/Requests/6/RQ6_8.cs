﻿using BEDA.CMB.Contracts.Responses;
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
    /// 6.8.批量支付数据列表查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ6_8 : CMBBase<RQINFO>, IRequest<RS6_8>
    {
        /// <summary>
        /// NTQRYBTH
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTQRYBTH";
        /// <summary>
        /// 6.8.批量支付数据列表查询请求内容
        /// </summary>
        public NTQRYBTHY NTQRYBTHY { get; set; }
    }
    /// <summary>
    /// 6.8.批量支付数据列表查询请求内容
    /// </summary>
    public class NTQRYBTHY
    {
        /// <summary>
        /// 起始日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime BEGDAT { get; set; }
        /// <summary>
        /// 起始日期	D, 对应<see cref="BEGDAT"/>
        /// </summary>
        [XmlElement("BEGDAT")]
        public string BEGDATStr
        {
            get
            {
                return this.BEGDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.BEGDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 结束日期	D
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
        /// 商户编号	C(10)
        /// </summary>
        public string MCHNBR { get; set; }
        /// <summary>
        /// 请求状态	C(3) 	OPR：接收成功 FIN：提交成功   	为空则默认为OPR
        /// </summary>
        public string REQSTA { get; set; }
    }
}
