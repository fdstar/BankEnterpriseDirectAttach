using BEDA.CIB.Contracts;
using BEDA.CIB.Contracts.Requests;
using BEDA.CIB.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BEDA.CIB.Samples
{
    /// <summary>
    /// 兴业银行交易辅助类
    /// </summary>
    public class CIBTransactionHelper
    {
        private long _cid;
        private string _userId;
        private string _pwd;
        private ICIBTransactionPurposeBuilder _buider;
        /// <summary>
        /// 转账对应的SUMMNAME
        /// </summary>
        public static string TransactionSummaryName = "汇款";
        /// <summary>
        /// 退票对应的SUMMNAME
        /// </summary>
        public static string RefundSummaryName = "汇出退回";
        /// <summary>
        /// 手续费对应的SUMMNAME
        /// </summary>
        public static string ChargesSummaryName = "收费";
        /// <summary>
        /// 冲账对应的SUMMNAME
        /// </summary>
        public static string RubricSummaryName = "冲账";
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="cid">兴业银行银企直联客户号</param>
        /// <param name="userId">兴业银行银企直联登录用户名</param>
        /// <param name="pwd">兴业银行银企直联登录密码</param>
        /// <param name="host">前置机域名，默认为127.0.0.1</param>
        /// <param name="port">前置机端口，默认为8007</param>
        /// <param name="builder">转账交易用途构建实现，如果不传则使用默认实现<see cref="CIBTransactionPurposeBuilder"/></param>
        public CIBTransactionHelper(long cid, string userId, string pwd,
            string host = "127.0.0.1", int port = 8007, ICIBTransactionPurposeBuilder builder = null)
        {
            if (cid <= 0 || string.IsNullOrWhiteSpace(userId) || string.IsNullOrWhiteSpace(pwd)
                || string.IsNullOrWhiteSpace(host))
            {
                throw new ArgumentException();
            }
            this._cid = cid;
            this._userId = userId;
            this._pwd = pwd;
            this._buider = builder;
            if (builder == null)
            {
                this._buider = new CIBTransactionPurposeBuilder();
            }
            this.Client = new CIBClient(host, port);
        }
        /// <summary>
        /// 兴业银行银企直联客户端
        /// </summary>
        public ICIBClient Client { get; set; }
        /// <summary>
        /// 生成一个用于查询的TRNUID，注意转账之类的业务切记不要采用此方法获取TRNUID
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string GetQueryTRNUID(string key)
        {
            var tmp = (Math.Abs(Guid.NewGuid().GetHashCode()) % 10000).ToString("0000");
            return string.Format("{0:yyMMddHHmmssfff}_{1}_{2}", DateTime.Now, key, tmp);
        }
        /// <summary>
        /// 获取兴业银行3.6查询接口请求主体
        /// </summary>
        /// <param name="acctid"></param>
        /// <param name="dtStart"></param>
        /// <param name="dtEnd"></param>
        /// <param name="page"></param>
        /// <param name="selType"></param>
        /// <returns></returns>
        public FOXRQ<V1_SCUSTSTMTTRNRQ, V1_SCUSTSTMTTRNRS> GetCIBRequest_3_6(string acctid, DateTime dtStart, DateTime dtEnd, int page, int selType)
        {
            return new FOXRQ<V1_SCUSTSTMTTRNRQ, V1_SCUSTSTMTTRNRS>()
            {
                SIGNONMSGSRQV1 = new SIGNONMSGSRQV1
                {
                    SONRQ = new SONRQ
                    {
                        CID = this._cid,
                        USERID = this._userId,
                        USERPASS = this._pwd,
                    }
                },
                SECURITIES_MSGSRQV1 = new V1_SCUSTSTMTTRNRQ
                {
                    SCUSTSTMTTRNRQ = new SCUSTSTMTTRNRQ
                    {
                        TRNUID = GetQueryTRNUID("3.6" + "_" + selType),
                        SCUSTSTMTRQ = new SCUSTSTMTTRN_SCUSTSTMTRQ
                        {
                            VERSION = "2.0",
                            ACCTFROM = new ACCTFROM
                            {
                                ACCTID = acctid
                            },
                            INCTRAN = new INCTRAN
                            {
                                DTEND = dtEnd,
                                DTSTART = dtStart,
                                TRNTYPE = 2,
                                PAGE = page,
                            },
                            SELTYPE = selType
                        }
                    }
                }
            };
        }
        /// <summary>
        /// 获取退票记录
        /// </summary>
        /// <param name="acctid"></param>
        /// <param name="dtStart"></param>
        /// <param name="dtEnd"></param>
        /// <returns></returns>
        public IList<STMTTRN> GetRefundRecords(string acctid, DateTime dtStart, DateTime dtEnd)
        {
            return this.GetRecords(acctid, dtStart, dtEnd, 3);
        }
        private List<STMTTRN> GetRecords(string acctid, DateTime dtStart, DateTime dtEnd, int selType)
        {
            var list = new List<STMTTRN>();
            dtStart = dtStart.Date;
            dtEnd = dtEnd.Date;
            if (dtStart <= dtEnd)
            {
                //历史与当日不能同查，所以此处要加以判断，因为每日流水可能较大，所以此处简单拆分成按每天查询
                var dt = dtStart;
                for (; dt <= dtEnd;)
                {
                    for (var i = 1; ; i++)
                    {
                        var rq = GetCIBRequest_3_6(acctid, dt, dt, i, selType);
                        var rs = this.Client.Execute(rq);
                        if (rs != null && rs.ResponseSuccess && rs.SIGNONMSGSRSV1?.SONRS?.STATUS?.IsCorrect == true
                            && rs.SECURITIES_MSGSRSV1?.SCUSTSTMTTRNRS?.STATUS?.IsCorrect == true
                            && rs.SECURITIES_MSGSRSV1.SCUSTSTMTTRNRS.SCUSTSTMTRS?.TRANLIST?.List != null)
                        {
                            list.AddRange(rs.SECURITIES_MSGSRSV1.SCUSTSTMTTRNRS.SCUSTSTMTRS.TRANLIST.List);
                            if (rs.SECURITIES_MSGSRSV1.SCUSTSTMTTRNRS.SCUSTSTMTRS.TRANLIST.MORE == "Y")
                            {
                                continue;
                            }
                        }
                        break;
                    }
                    dt = dt.AddDays(1);
                }
            }
            return list;
        }
        /// <summary>
        /// 获取交易记录（含手续费、冲账等）
        /// </summary>
        /// <param name="acctid"></param>
        /// <param name="dtStart"></param>
        /// <param name="dtEnd"></param>
        /// <returns></returns>
        public IList<STMTTRN> GetTransactionRecords(string acctid, DateTime dtStart, DateTime dtEnd)
        {
            return this.GetRecords(acctid, dtStart, dtEnd, 1);
        }
        /// <summary>
        /// 根据退票记录获取其对应的交易记录
        /// </summary>
        /// <param name="refundList">退票流水</param>
        /// <param name="acctid">当前退票属于哪个账号</param>
        /// <param name="refundDayDiff">若需自动查询交易流水时，查询几天内的交易流水，默认按兴业银行文档设置为2天</param>
        /// <param name="transList">交易流水，默认为null，代表按退票流水自动查询，如果不为null则与退票流水进行对比</param>
        /// <returns>Key为交易流水id，Tuple.Item1为交易流水，Tuple.Item2为退票流水</returns>
        public IDictionary<string, Tuple<STMTTRN, STMTTRN>> GetRefundMapping(IList<STMTTRN> refundList, string acctid, int refundDayDiff = 2, IList<STMTTRN> transList = null)
        {
            var dic = new Dictionary<string, Tuple<STMTTRN, STMTTRN>>();
            if (refundList != null && refundList.Count > 0)
            {
                refundList = refundList.Where(x => x.SUMMNAME == RefundSummaryName).OrderBy(x => x.DTACCT).ToList();
                if (refundList.Count > 0)
                {
                    if (transList == null || transList.Count == 0)
                    {//如果未传递交易流水，则自动按退票日期获取对应日期的所有交易流水
                        transList = this.GetTransactionRecords(acctid, refundList, refundDayDiff);
                    }
                    var query = from refund in refundList
                                join trans in transList
                                on refund.MEMO equals trans.HXJYLSBH
                                where trans.SUMMNAME == TransactionSummaryName
                                select Tuple.Create(trans, refund);
                    dic = query.ToDictionary(k => this._buider.GetIdFromPurpose(k.Item1.PURPOSE), v => v);
                }
            }
            return dic;
        }
        private IList<STMTTRN> GetTransactionRecords(string acctid, IList<STMTTRN> list, int dayDiff)
        {
            var transList = new List<STMTTRN>();
            var timeList = list.Select(x => x.DTACCT.Date).Distinct().OrderBy(d => d).ToList();
            //虽然底层查询时是拆分成按每日查询，但因为退票或冲账需要倒查N天的交易流水，所以将日期按连续性拆分成日期范围还是有必要的
            var timeRange = this.GetTimeRange(timeList, dayDiff);
            foreach (var t in timeRange)
            {
                var tmp = this.GetTransactionRecords(acctid, t.Item1.AddDays(-1), t.Item2);
                transList.AddRange(tmp);
            }
            return transList;
        }
        private IList<Tuple<DateTime, DateTime>> GetTimeRange(IList<DateTime> timeList, int dayDiff)
        {
            var timeRange = new List<Tuple<DateTime, DateTime>>();
            var dtStart = timeList[0];
            var dtEnd = timeList[0];
            for (var i = 1; i <= timeList.Count; i++)
            {
                DateTime dt = DateTime.MaxValue;
                if (i < timeList.Count)
                {
                    dt = timeList[i];
                }
                if (dt >= dtEnd && dt <= dtEnd.AddDays(dayDiff))
                {
                    //退票需要查询交易流水日期范围为交易当天或交易前一天
                    //所以如果出现跳日，比如03-19和03-21,也应该算是连续日期
                    dtEnd = dt;
                }
                else
                {
                    timeRange.Add(Tuple.Create(dtStart, dtEnd));
                    dtStart = dt;
                    dtEnd = dt;
                }
            }
            return timeRange;
        }
        /// <summary>
        /// 根据交易流水获取对应的交易记录及手续费
        /// </summary>
        /// <param name="list">交易流水</param>
        /// <returns>Key为交易流水id，Tuple.Item1为交易流水，Tuple.Item2为手续费</returns>
        public IDictionary<string, Tuple<STMTTRN, decimal>> GetServiceChargesMapping(IList<STMTTRN> list)
        {
            var dic = new Dictionary<string, Tuple<STMTTRN, decimal>>();
            if (list != null && list.Count > 0)
            {
                //此处判断PURPOSE是否是当前业务组织的PURPOSE
                list = list.Where(x => (x.SUMMNAME == TransactionSummaryName && this._buider.IsCorrectPurpose(x.PURPOSE))
                || x.SUMMNAME == ChargesSummaryName).ToList();
                if (list.Count > 0)
                {
                    var groups = list.GroupBy(x => x.HXJYLSBH);  // new { x.SRVRTID, x.DTACCT }
#if DEBUG
                    var tmp = groups.ToList();
#endif
                    foreach (var g in groups)
                    {
                        var trans = g.FirstOrDefault(x => x.SUMMNAME == TransactionSummaryName);
                        if (trans == null)
                        {
                            continue;
                        }
                        var id = this._buider.GetIdFromPurpose(trans.PURPOSE);
                        if (string.IsNullOrWhiteSpace(id))
                        {
                            continue;
                        }
                        //可能会无需手续费
                        var charge = g.FirstOrDefault(x => x.SUMMNAME == ChargesSummaryName)?.TRNAMT ?? 0;
                        dic.Add(id, Tuple.Create(trans, charge));
                    }
                }
            }
            return dic;
        }
        /// <summary>
        /// 根据交易流水获取其内包含的冲账记录及冲账退回的手续费
        /// </summary>
        /// <param name="list">交易流水</param>
        /// <returns>Tuple.Item1为冲账交易流水，需按其值<see cref="STMTTRN.CHEQUENUM"/>凭证代号与历史交易记录CHEQUENUM的进行比较，Tuple.Item2为冲账时退回的手续费</returns>
        public IList<Tuple<STMTTRN, decimal>> GetRubricRecords(IList<STMTTRN> list)
        {
            var retList = new List<Tuple<STMTTRN, decimal>>();
            if (list != null && list.Count > 0)
            {
                list = list.Where(x => x.SUMMNAME == RubricSummaryName).ToList();
                if (list.Count > 0)
                {
                    var groups = list.GroupBy(x => x.HXJYLSBH);//冲账逻辑与退票本质无差别
                    foreach (var g in groups)
                    {
                        var trans = g.FirstOrDefault(x => !string.IsNullOrWhiteSpace(x.CHEQUENUM));//凭证代号不为空代表冲账交易记录，为空代表冲账手续费
                        if (trans == null)
                        {
                            continue;
                        }
                        var charge = g.FirstOrDefault(x => string.IsNullOrWhiteSpace(x.CHEQUENUM))?.TRNAMT ?? 0;//冲账退回的手续费
                        retList.Add(Tuple.Create(trans, charge));
                    }
                }
            }
            return retList;
        }
        /// <summary>
        /// 根据冲账记录获取其对应的交易记录
        /// </summary>
        /// <param name="rubricList">冲账流水及冲账手续费</param>
        /// <param name="acctid">当前冲账属于哪个账号</param>
        /// <param name="rubricDayDiff">若需自动查询交易流水时，查询几天内的交易流水，默认设置为3天</param>
        /// <param name="transList">交易流水，默认为null，代表按退票流水自动查询，如果不为null则与退票流水进行对比</param>
        /// <returns>Key为交易流水id，Tuple.Item1为交易流水，Tuple.Item2为冲账流水，Tuple.Item3为冲账手续费</returns>
        public IDictionary<string, Tuple<STMTTRN, STMTTRN, decimal>> GetRubricMapping(IList<Tuple<STMTTRN, decimal>> rubricList, string acctid, int rubricDayDiff = 3, IList<STMTTRN> transList = null)
        {
            var dic = new Dictionary<string, Tuple<STMTTRN, STMTTRN, decimal>>();
            if (rubricList != null && rubricList.Count > 0)
            {
                if (transList == null || transList.Count == 0)
                {//如果未传递交易流水，则自动按冲账日期获取对应日期的所有交易流水
                    transList = this.GetTransactionRecords(acctid, rubricList.Select(x => x.Item1).ToList(), rubricDayDiff);
                }
                var query = from rubric in rubricList
                            join trans in transList
                            on rubric.Item1.CHEQUENUM equals trans.CHEQUENUM
                            where trans.SUMMNAME == TransactionSummaryName
                            select Tuple.Create(trans, rubric.Item1, rubric.Item2);
                dic = query.ToDictionary(k => this._buider.GetIdFromPurpose(k.Item1.PURPOSE), v => v);
            }
            return dic;
        }
    }
    /// <summary>
    /// 兴业银行交易流水用途构建约束接口
    /// </summary>
    public interface ICIBTransactionPurposeBuilder
    {
        /// <summary>
        /// 根据内部系统业务Id构建Purpose
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        string GetPurpose(string id);
        /// <summary>
        /// 从交易流水Purpose中获取内部系统业务Id，注意此处Purpose应当为网上汇款交易流水中的PURPOSE
        /// </summary>
        /// <param name="purpose"></param>
        /// <returns></returns>
        string GetIdFromPurpose(string purpose);
        /// <summary>
        /// 当前PURPOSE是否符合标准
        /// </summary>
        /// <param name="purpose"></param>
        /// <returns></returns>
        bool IsCorrectPurpose(string purpose);
    }
    /// <summary>
    /// 兴业银行交易流水用途构建默认实现
    /// </summary>
    public class CIBTransactionPurposeBuilder : ICIBTransactionPurposeBuilder
    {
        /// <summary>
        /// 从交易流水Purpose中获取内部系统业务Id，注意此处Purpose应当为网上汇款交易流水中的PURPOSE
        /// </summary>
        /// <param name="purpose"></param>
        /// <returns></returns>
        public virtual string GetIdFromPurpose(string purpose)
        {
            return purpose;
        }
        /// <summary>
        /// 根据内部系统业务Id构建Purpose
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public virtual string GetPurpose(string id)
        {
            return id;
        }
        /// <summary>
        /// 当前PURPOSE是否符合标准
        /// </summary>
        /// <param name="purpose"></param>
        /// <returns></returns>
        public virtual bool IsCorrectPurpose(string purpose)
        {
            return true;
        }
    }
}
