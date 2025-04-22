using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsoleApp
{
    internal class Guy
    {
        public string Name;
        public int Cash;
        /// <summary>
        /// Viết Tên và Số Tiền của đối tượng đang có
        /// </summary>
        public void WriteMyInfo()
        {
            Console.WriteLine($"{Name} has {Cash} bucks.");
        }
        /// <summary>
        /// Chuyển tiền từ ví đối tượng sang người nhận ( hoặc hiện
        /// thông báo nếu không đủ tiền)
        /// </summary>
        /// <param name="amount">Số Tiền Cho Vay=</param>
        /// <returns>
        /// Số tiền cho vay thành công hoặc 0 nếu không đủ tiền
        /// </returns>
        public int GiveCash(int amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine($"{Name} says: {amount} isn't a valid amount dzungf ");
                    return -1;
            }
            if (amount > Cash)
            {
                Console.WriteLine($"{Name} says: I don't have enough cash to give you {amount}");
                    return 0;
            }
            Console.WriteLine("Transaction Completed Successfully");
            Console.WriteLine($"{Name} says: I have given you {amount} bucks");
            Cash -= amount;
            return amount;
        }
        /// <summary>
        /// Nhận tiền vào ví của đối tượng (hoặc hiện thông báo nếu số tiền không hợp lệ)
        /// </summary>
        /// <param name="amount">Số Tiền Được Giải Ngân</param>
        public void ReceiveCash(int amount)
        {
            if (amount < 0)
            {
                Console.WriteLine($"{Name} says: are you kidding me dzungf ");
                return;
            }
            if (amount == 0)
            {
                Console.WriteLine($"{Name} says: you are so poor");
                return;
            }
            else
            {
                Console.WriteLine($"{Name} says: I have received {amount} bucks");
                Cash += amount;
            }
        }
    }
}
