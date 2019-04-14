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
    /// 19.2.10.撤销托管申请请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ19_2_10 : CMBBase<RQINFO>, IRequest<RS19_2_10>
    {
        /// <summary>
        /// SDKPMGOPR
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "SDKPMGOPR";
        /// <summary>
        /// 19.2.10.撤销托管申请请求内容
        /// </summary>
        public NTPMGOPRX NTPMGOPRX { get; set; }
        /// <summary>
        /// 19.2.10.撤销托管申请请求集合
        /// </summary>
        [XmlElement("NTTKTINFX")]
        public List<NTTKTINFX> List { get; set; }
    }
    /// <summary>
    /// 19.2.10.撤销托管申请请求内容
    /// </summary>
    public class NTPMGOPRX
    {
        /// <summary>
        /// 业务类型	C(6)    银行承兑汇票：N06010;商业承兑汇票： N06011
        /// </summary>
        public string BUSCOD { get; set; }
        /// <summary>
        /// 业务模式编号	C(5)
        /// </summary>
        public string BUSMOD { get; set; }
        /// <summary>
        /// 业务模式名称	Z(200)  业务模式编号、业务模式名称不能同时为空。
        /// </summary>
        public string MODALS { get; set; }
        /// <summary>
        /// 业务参考号	C(30)   必须唯一
        /// </summary>
        public string YURREF { get; set; }
    }
}
