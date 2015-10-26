using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            //参照
            //http://dobon.net/vb/dotnet/programing/commandline.html

            //コマンドライン引数を表示する
            //Console.WriteLine(System.Environment.CommandLine);

            //コマンドライン引数を配列で取得する
            string[] cmds = System.Environment.GetCommandLineArgs();
            //コマンドライン引数を列挙する
            foreach (string cmd in cmds)
            {
                Console.WriteLine(cmd);
            }

            Console.ReadKey();

        }
    }
}
