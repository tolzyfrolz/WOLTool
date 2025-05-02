using System.Net.NetworkInformation;
using WOLTool;

namespace WOLTool_Tests
{
    internal class Program
    {
        static async Task<int> Main(string[] args)
        {
            const string macStr1 = "84:1B:77:4C:9F:22";
            const string macStr2 = "3C:98:23:11:A6:7B";
            const string macStr3 = "00:15:5D:8E:44:C1";
            var mac1 = PhysicalAddress.Parse(macStr1);
            var mac2 = PhysicalAddress.Parse(macStr2);
            var mac3 = PhysicalAddress.Parse(macStr3);
            var macStrList = new List<string> { macStr1, macStr2, macStr3 };
            var macList = new List<PhysicalAddress> { mac1, mac2, mac3 };
            if (Test_Broadcast(macStr1) &
                Test_Broadcast(mac1) &
                Test_Broadcast(macStrList) &
                Test_Broadcast(macList) &
                await Test_BroadcastAsync(macStr1) &
                await Test_BroadcastAsync(mac1) &
                await Test_BroadcastAsync(macStrList) &
                await Test_BroadcastAsync(macList))
            {
                Console.WriteLine("All tests passed.");
            }
            else
            {
                Console.WriteLine("Some tests failed.");
            }
            return 0;
        }


        private static bool Test_Broadcast(IEnumerable<string> macAddresses)
        {
            Console.WriteLine("Test_Broadcast(IEnumerable<string> macAddresses)");
            try
            {
                WakeOnLan.Broadcast(macAddresses);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        private static async Task<bool> Test_BroadcastAsync(IEnumerable<string> macAddresses)
        {
            Console.WriteLine("Test_BroadcastAsync(IEnumerable<string> macAddresses)");
            try
            {
                await WakeOnLan.BroadcastAsync(macAddresses);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        private static bool Test_Broadcast(string macAddress)
        {
            Console.WriteLine("Test_Broadcast(string macAddress)");
            try
            {
                WakeOnLan.Broadcast(macAddress);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        private static async Task<bool> Test_BroadcastAsync(string macAddress)
        {
            Console.WriteLine("Test_BroadcastAsync(string macAddress)");
            try
            {
                await WakeOnLan.BroadcastAsync(macAddress);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        private static bool Test_Broadcast(PhysicalAddress macAddress)
        {
            Console.WriteLine("Test_Broadcast(PhysicalAddress macAddress)");
            try
            {
                WakeOnLan.Broadcast(macAddress);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        private static bool Test_Broadcast(IEnumerable<PhysicalAddress> macAddresses)
        {
            Console.WriteLine("Test_Broadcast(IEnumerable<PhysicalAddress> macAddresses)");
            try
            {
                WakeOnLan.Broadcast(macAddresses);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        private static async Task<bool> Test_BroadcastAsync(PhysicalAddress macAddress)
        {
            Console.WriteLine("Test_BroadcastAsync(PhysicalAddress macAddress)");
            try
            {
                await WakeOnLan.BroadcastAsync(macAddress);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        private static async Task<bool> Test_BroadcastAsync(IEnumerable<PhysicalAddress> macAddresses)
        {
            Console.WriteLine("Test_BroadcastAsync(IEnumerable<PhysicalAddress> macAddresses)");
            try
            {
                await WakeOnLan.BroadcastAsync(macAddresses);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }
    }
}

