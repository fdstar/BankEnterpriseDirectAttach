using BEDA.CMB.Contracts.Requests;
using BEDA.CMB.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BEDA.CMB.Samples
{
    partial class Program
    {
        static void Part_04()
        {
            //RQ4_1Sample(); //test
            //RQ4_2Sample(); //test
            //RQ4_3Sample(); //test
            //RQ4_4Sample(); //test
            //RQ4_5Sample(); //test
            //RQ4_6Sample(); //test
            //RQ4_7Sample(); //test
            //RQ4_8Sample(); //test
            //RQ4_9Sample(); //test
            //RQ4_10Sample(); //test
        }

        #region 4.代发代扣
        /// <summary>
        /// 4.1.查询交易代码
        /// </summary>
        public static void RQ4_1Sample()
        {
            var rq = new RQ4_1()
            {
                NTAGTLS2X = new NTAGTLS2X
                {
                    BUSCOD = "N03020",
                    ACCNBR = "591902896710201",
                }
            };
            var rs = client.Execute<RQ4_1, RS4_1>(rq, "银企直连专用集团1");
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 4.2.直接代发代扣
        /// </summary>
        public static void RQ4_2Sample()
        {
            var rq = new RQ4_2()
            {
                SDKATSRQX = new SDKATSRQX
                {
                    BUSCOD = "N03020",
                    BUSMOD = "00001",
                    TRSTYP = "BYTF",
                    DBTACC = "591902896710201",
                    BBKNBR = "59",
                    SUM = 102.5m,
                    TOTAL = 1,
                    YURREF = GetYURREF("4.2"),
                    MEMO = "直接代发代扣MEMO代发",
                },
                List = new List<SDKATDRQX>
                {
                    new SDKATDRQX
                    {
                        ACCNBR="6225880280003345",
                        CLTNAM="王二",
                        TRSAMT=102.5m,
                        BNKFLG="Y",
                    }
                }
            };
            var rs = client.Execute<RQ4_2, RS4_2>(rq, "银企直连专用集团1");
            Console.WriteLine(rs.INFO.ResponseContent);//REQNBR>0030103687</REQNBR
        }
        /// <summary>
        /// 4.3.查询交易概要信息
        /// </summary>
        public static void RQ4_3Sample()
        {
            var rq = new RQ4_3()
            {
                NTAGCINNY1 = new NTAGCINNY1
                {
                    BUSCOD = "N03020",
                    BUSMOD = "00001",
                    BGNDAT = new DateTime(2018, 3, 15),
                    ENDDAT = new DateTime(2018, 3, 20),
                }
            };
            var rs = client.Execute<RQ4_3, RS4_3>(rq, "银企直连专用集团1");
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 4.4.查询交易明细信息
        /// </summary>
        public static void RQ4_4Sample()
        {
            var rq = new RQ4_4()
            {
                SDKATDQYX = new SDKATDQYX
                {
                    REQNBR = "0030103687"
                }
            };
            var rs = client.Execute<RQ4_4, RS4_4>(rq, "银企直连专用集团1");
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 4.5.代发工资额度查询
        /// </summary>
        public static void RQ4_5Sample()
        {
            var rq = new RQ4_5()
            {
                NTAGCLMTX1 = new NTAGCLMTX1
                {
                    ACCNBR = "591902896710201",
                    BBKNBR = "59"
                }
            };
            var rs = client.Execute<RQ4_5, RS4_5>(rq, "银企直连专用集团1");
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 4.6.大批量代发工资经办
        /// </summary>
        public static void RQ4_6Sample()
        {
            var rq = new RQ4_6()
            {
                NTBUSMODY = new NTBUSMODY
                {
                    BUSMOD = "00001"
                },
                NTAGCAGCX1 = new NTAGCAGCX1
                {
                    BEGTAG = "Y",
                    ENDTAG = "Y",
                    TTLAMT = 52.5m,
                    TTLCNT = 1,
                    TTLNUM = 1,
                    CURAMT = 52.5m,
                    TRSTYP = "BYSA",
                    CURCNT = 1,
                    CCYNBR = "10",
                    ACCNBR = "591902896710201",
                    BBKNBR = "59",
                    CCYMKT = "0",
                    NUSAGE = "大批量代发工资经办NUSAGE",
                    YURREF = GetYURREF("4.6"),
                    //ExpectedTime = DateTime.Now.AddYears(-1),
                },
                List = new List<NTAGCDTLY1>
                {
                    new NTAGCDTLY1
                    {
                        TRXSEQ=1,
                        ACCNBR="6225880280003345",
                        ACCNAM="王二",
                        TRSAMT=52.5m,
                        BNKFLG="Y",
                        TRSDSP="王二代发工资"
                    }
                }
            };
            var rs = client.Execute<RQ4_6, RS4_6>(rq, "银企直连专用集团1");
            Console.WriteLine(rs.INFO.ResponseContent);//<REQNBR>0030103753</REQNBR>
        }
        /// <summary>
        /// 4.7.大批量代发经办
        /// </summary>
        public static void RQ4_7Sample()
        {
            var rq = new RQ4_7()
            {
                NTBUSMODY = new NTBUSMODY
                {
                    BUSMOD = "00001"
                },
                NTAGCAGCX1 = new NTAGCAGCX1
                {
                    BEGTAG = "Y",
                    ENDTAG = "Y",
                    TTLAMT = 152.5m,
                    TTLCNT = 1,
                    TTLNUM = 1,
                    CURAMT = 152.5m,
                    TRSTYP = "BYTF",
                    CURCNT = 1,
                    CCYNBR = "10",
                    ACCNBR = "591902896710201",
                    BBKNBR = "59",
                    CCYMKT = "0",
                    NUSAGE = "代发劳务收入NUSAGE",
                    YURREF = GetYURREF("4.7"),
                    //ExpectedTime = DateTime.Now.AddYears(-1),
                },
                List = new List<NTAGCDTLY1>
                {
                    new NTAGCDTLY1
                    {
                        TRXSEQ=1,
                        ACCNBR="6225880280003345",
                        ACCNAM="王二",
                        TRSAMT=152.5m,
                        BNKFLG="Y",
                        TRSDSP="王二代发劳务收入"
                    }
                }
            };
            var rs = client.Execute<RQ4_7, RS4_7>(rq, "银企直连专用集团1");
            Console.WriteLine(rs.INFO.ResponseContent);//<REQNBR>0030103771</REQNBR>
        }
        /// <summary>
        /// 4.8.大批量代扣经办
        /// </summary>
        public static void RQ4_8Sample()
        {
            var rq = new RQ4_8()
            {
                NTBUSMODY = new NTBUSMODY
                {
                    BUSMOD = "00001"
                },
                NTAGCAGCX1 = new NTAGCAGCX1
                {
                    BEGTAG = "Y",
                    ENDTAG = "Y",
                    TTLAMT = 32.5m,
                    TTLCNT = 1,
                    TTLNUM = 1,
                    CURAMT = 32.5m,
                    TRSTYP = "AYTL",
                    CURCNT = 1,
                    CCYNBR = "10",
                    ACCNBR = "755915704910503",
                    BBKNBR = "75",
                    CCYMKT = "0",
                    NUSAGE = "代扣电话费NUSAGE",
                    YURREF = GetYURREF("4.8"),
                    //ExpectedTime = DateTime.Now.AddYears(-1),
                },
                List = new List<NTAGCDTLY1>
                {
                    new NTAGCDTLY1
                    {
                        TRXSEQ=1,
                        ACCNBR="6225880230001175",
                        ACCNAM="刘    五",
                        TRSAMT=32.5m,
                        BNKFLG="Y",
                        TRSDSP="刘    五代扣电话费"
                    }
                }
            };
            var rs = client.Execute<RQ4_8, RS4_8>(rq, "银企直连测试用户143");
            Console.WriteLine(rs.INFO.ResponseContent);//<REQNBR>0030103780</REQNBR>
        }
        /// <summary>
        /// 4.9.查询大批量代发代扣明细信息
        /// </summary>
        public static void RQ4_9Sample()
        {
            var rq = new RQ4_9()
            {
                NTAGDINFY1 = new NTAGDINFY1
                {
                    REQNBR = "0030103780"
                }
            };
            var rs = client.Execute<RQ4_9, RS4_9>(rq, "银企直连测试用户143");
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 4.10.代发结果列表查询-按业务参考号
        /// </summary>
        public static void RQ4_10Sample()
        {
            var rq = new RQ4_10()
            {
                NTAGCINYX1 = new NTAGCINYX1
                {
                    BUSCOD = "N03010",
                    YURREF = "20190314142125_4.6",
                    BGNDAT = new DateTime(2018, 3, 15),
                    ENDDAT = new DateTime(2018, 3, 20),
                }
            };
            var rs = client.Execute<RQ4_10, RS4_10>(rq, "银企直连专用集团1");
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        #endregion
    }
}
