
//重複讓玩家可以輸入三個數字的字串，並根據以下規格進行遊戲:

//1.若輸入不符合規定，則提醒玩家要重新輸入

//2. 累計猜測次數(+1), 並印出猜測結果

//3. 若猜對了，就恭喜玩家. 然後結束遊戲
namespace XaXb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XaXbEngine xaxb = new XaXbEngine();
            Console.WriteLine(xaxb.GetLuckyNumber());
            int counter = 0;
            while(true)
            {
                Console.WriteLine("請輸入不重複的三個數字(0~9:)");
                string userNum = Console.ReadLine();
                if(xaxb.IsLegal(userNum))
                {
                    counter++;
                    string result = xaxb.GetResult(userNum);
                    Console.WriteLine($"{userNum}:{result},猜測次數:{counter}");
                    if (result == "3A0B")
                    {
                    Console.WriteLine("恭喜你，猜對了!");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("輸入的資料重複或長度不對，請重新輸入");
                        }
            }
        }
    }
    public class XaXbEngine
    {
        string luckynum;
        public XaXbEngine()
        {
            Random random = new Random();
            int[] tem = new int[3];
            tem[0] = random.Next(0, 9);
            tem[1] = random.Next(0, 9);
            tem[2] = random.Next(0, 9);
            while (tem[0] == tem[1] ^ tem[1] == tem[2] ^ tem[0] == tem[2])
            {
                tem[1] = random.Next(0, 9);
                tem[2] = random.Next(0, 9);
            }
            luckynum = $"{tem[0]}{tem[1]}{tem[2]}";
        }
        public bool SetLuckyNumber(String newLuckyNum)
        {
            if (IsLegal(newLuckyNum))
            {
                this.luckynum = newLuckyNum;
                return true;
            }
            else
            {
                return false;
            }
        }
        public string GetLuckyNumber()
        {
            return this.luckynum;
        }
        public Boolean IsLegal(String theNumber)
        {
            char[] tem = theNumber.ToCharArray();
            if (tem.Length == 3)
            {
                if (tem[0] != tem[1] ^ tem[1] != tem[2] ^ tem[0] != tem[2])
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public string GetResult(String userNumber)
        {
            char[] user = userNumber.ToCharArray();
            char[] ans = this.luckynum.ToCharArray();
            int a = 0;
            int b = 0;
            for (int i = 0; i < user.Length; i++)
            {
                for (int j = 0; j < ans.Length; j++)
                {
                    if (user[i] == ans[j])
                    {
                        if (i == j)
                        {
                            a++;
                        }
                        else
                        {
                            b++;
                        }
                    }
                }
            }
            return $"{a}A{b}B";
        }
        public Boolean IsGameover(String userNumber)
        {
            if (GetResult(userNumber) == "3A0B")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}
