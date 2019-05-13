using BEDA.CMB.Contracts.Requests;
using BEDA.CMB.Contracts.Responses;
using BEDA.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BEDA.CMB.Samples
{
    partial class Program
    {
        static void Main(string[] args)
        {
            //1.系统管理
            Part_01();
            //2.账户管理
            Part_02();
            //3.支付结算
            Part_03();
            //4.代发代扣
            Part_04();



            //21.网银互联
            Part_21();

            Console.ReadLine();
        }

        #region 基础部分
        const string ip = "127.0.0.1";
        const int port = 8082;
        public static ICMBClient client = new CMBClient(ip, port);
        static string GetYURREF(string no)
        {
            var tmp = string.Format("{0:yyyyMMddHHmmss}_{1}", DateTime.Now, no);
            return tmp;
        }
        #endregion
    }
}
