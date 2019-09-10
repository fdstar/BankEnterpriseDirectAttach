using BEDA.CITIC.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CITIC.Contracts.Requests
{
    /// <summary>
    /// 订货计划接收请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLCRODGM : RqBase<RS_DLCRODGM>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLCRODGM"; set { } }

        /// <summary>
        /// 核心厂商订货计划编号 varchar(20)
        /// </summary>
        [XmlElement("ntcNo")]
        public string NtcNo { get; set; }
        /// <summary>
        /// 企业端经销商客户代码 varchar(20)
        /// </summary>
        [XmlElement("cpCustCd")]
        public string CpCustCd { get; set; }
        /// <summary>
        /// 银行端借款企业id varchar(20),可空
        /// </summary>
        [XmlElement("bkCustCd")]
        public string BkCustCd { get; set; }
        /// <summary>
        /// 借款企业名称 varchar(122)
        /// </summary>
        [XmlElement("lonCpNm")]
        public string LonCpNm { get; set; }
        /// <summary>
        /// 经办分行编号 varchar(20) ,可空
        /// </summary>
        [XmlElement("opBrhCd")]
        public string OpBrhCd { get; set; }
        /// <summary>
        /// 经办分行名称 varchar(122) ,可空
        /// </summary>
        [XmlElement("opBrhNm")]
        public string OpBrhNm { get; set; }
        /// <summary>
        /// 额度编号 varchar(20) ,可空
        /// </summary>
        [XmlElement("creditNo")]
        public string CreditNo { get; set; }
        /// <summary>
        /// 品牌编码 varchar(20) ,可空
        /// </summary>
        [XmlElement("brandCd")]
        public string BrandCd { get; set; }
        /// <summary>
        /// 品牌名称 varchar(100) ,可空
        /// </summary>
        [XmlElement("brandNm")]
        public string BrandNm { get; set; }
        /// <summary>
        /// 融资类型 varchar(2),10:纸票,20:流贷,30:电子票
        /// </summary>
        [XmlElement("loanTypp")]
        public string LoanTypp { get; set; }
        /// <summary>
        /// 融资申请金额 decimal(19,2) ,可空
        /// </summary>
        [XmlElement("loanAmt")]
        public decimal? LoanAmt { get; set; }
        /// <summary>
        /// 订货数量 decimal(19,2)
        /// </summary>
        [XmlElement("idtQty")]
        public decimal IdtQty { get; set; }
        /// <summary>
        /// 订货总价值 decimal(19,2)
        /// </summary>
        [XmlElement("idtTotAmt")]
        public decimal IdtTotAmt { get; set; }
        /// <summary>
        /// 属性1 varchar(30),交易流水号
        /// </summary>
        [XmlElement("field1")]
        public string Field1 { get; set; }
        /// <summary>
        /// 属性2 int (3),可空,融资期限，单位：天
        /// </summary>
        [XmlElement("field2")]
        public string Field2 { get; set; }
        /// <summary>
        /// 属性3 varchar(100),可空,按约定上送
        /// </summary>
        [XmlElement("field3")]
        public string Field3 { get; set; }


        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlElement("list")]
        public CITICCollection<PledgeGoods> Collection { get; set; }
    }
    /// <summary>
    /// 抵押品信息
    /// </summary>
    public class PledgeGoods
    {
        /// <summary>
        /// 押品代码 varchar(30)
        /// </summary>
        [XmlElement("pldCode")]
        public string PldCode { get; set; }
        /// <summary>
        /// 押品名称 varchar(100)
        /// </summary>
        [XmlElement("pldName")]
        public string PldName { get; set; }
        /// <summary>
        /// 押品单价 decimal(19,2)
        /// </summary>
        [XmlElement("pldPrice")]
        public decimal PldPrice { get; set; }
        /// <summary>
        /// 押品数量 decimal(19,2)
        /// </summary>
        [XmlElement("pldQty")]
        public decimal PldQty { get; set; }
        /// <summary>
        /// 押品货值 decimal(19,2)
        /// </summary>
        [XmlElement("pldValue")]
        public decimal PldValue { get; set; }
        /// <summary>
        /// 押品品牌代码 varchar(60),可空
        /// </summary>
        [XmlElement("pldBdCd")]
        public string PldBdCd { get; set; }
        /// <summary>
        /// 押品品牌名称 varchar(100),可空
        /// </summary>
        [XmlElement("pldBdNm")]
        public string PldBdNm { get; set; }
        /// <summary>
        /// 属性4 varchar(30),可空,按约定上送
        /// </summary>
        [XmlElement("field4")]
        public string Field4 { get; set; }
        /// <summary>
        /// 属性5 varchar(30),可空,按约定上送
        /// </summary>
        [XmlElement("field5")]
        public string Field5 { get; set; }
        /// <summary>
        /// 属性6 varchar(30),可空,按约定上送
        /// </summary>
        [XmlElement("field6")]
        public string Field6 { get; set; }
        /// <summary>
        /// 属性7 varchar(60),可空,按约定上送
        /// </summary>
        [XmlElement("field7")]
        public string Field7 { get; set; }
        /// <summary>
        /// 属性8 varchar(60),可空,按约定上送
        /// </summary>
        [XmlElement("field8")]
        public string Field8 { get; set; }
        /// <summary>
        /// 属性9 varchar(60),可空,按约定上送
        /// </summary>
        [XmlElement("field9")]
        public string Field9 { get; set; }
        /// <summary>
        /// 属性10 varchar(100),可空,按约定上送
        /// </summary>
        [XmlElement("field10")]
        public string Field10 { get; set; }
        /// <summary>
        /// 属性11 varchar(100),可空,按约定上送
        /// </summary>
        [XmlElement("field11")]
        public string Field11 { get; set; }
        /// <summary>
        /// 属性12 varchar(200),可空,按约定上送
        /// </summary>
        [XmlElement("field12")]
        public string Field12 { get; set; }
    }
}