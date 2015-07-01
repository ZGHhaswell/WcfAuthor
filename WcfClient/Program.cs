using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfClient.LocalCalculator;

namespace WcfClient
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorClient client = new CalculatorClient();

            // 使用 "client" 变量在服务上调用操作。
            var result = client.Add(1, 2);
            // 始终关闭客户端。
            client.Close();

        }
    }
}
