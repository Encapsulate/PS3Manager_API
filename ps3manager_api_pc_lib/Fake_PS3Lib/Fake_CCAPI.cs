// ************************************************* //
//    --- Copyright (c) 2014 iMCS Productions ---    //
// ************************************************* //
//              PS3Lib v4 By FM|T iMCSx              //
//                                                   //
// Features v4.3 :                                   //
// - Support CCAPI v2.5 C# by iMCSx                  //
// - Popup better form with icon                     //
// - CCAPI Consoles List Popup French/English        //
// - CCAPI Get Console Info                          //
// - CCAPI Get Console List                          //
// - CCAPI Get Number Of Consoles                    //
// - Get Console Name TMAPI/CCAPI                    //
//                                                   //
// Credits : FM|T Enstone , Buc-ShoTz                //
//                                                   //
// Follow me :                                       //
//                                                   //
// FrenchModdingTeam.com                             //
// Youtube.com/iMCSx                                 //
// Twitter.com/iMCSx                                 //
// Facebook.com/iMCSx                                //
//                                                   //
// ************************************************* //

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;
using System.Security.Cryptography;

namespace PS3Lib
{
    public class CCAPI
    {
        private static PS3ManagerAPI.PS3MAPI PS3M_API = new PS3ManagerAPI.PS3MAPI();

        public CCAPI()
        {
            PS3ManagerAPI.PS3MAPI PS3M_API = new PS3ManagerAPI.PS3MAPI();
        }
        
        public enum IdType
        {
            IDPS,
            PSID
        }

        public enum NotifyIcon
        {
            INFO,
            CAUTION,
            FRIEND,
            SLIDER,
            WRONGWAY,
            DIALOG,
            DIALOGSHADOW,
            TEXT,
            POINTER,
            GRAB,
            HAND,
            PEN,
            FINGER,
            ARROW,
            ARROWRIGHT,
            PROGRESS,
            TROPHY1,
            TROPHY2,
            TROPHY3,
            TROPHY4
        }

        public enum ConsoleType
        {
            CEX = 1,
            DEX = 2,
            TOOL = 3
        }

        public enum ProcessType
        {
            VSH,
            SYS_AGENT,
            CURRENTGAME
        }

        public enum RebootFlags
        {
            ShutDown = 1,
            SoftReboot = 2,
            HardReboot = 3
        }

        public enum BuzzerMode
        {
            Continuous,
            Single,
            Double
        }

        public enum LedColor
        {
            Green = 1,
            Red = 2
        }

        public enum LedMode
        {
            Off,
            On,
            Blink
        }

        private TargetInfo pInfo = new TargetInfo();

        private class System
        {
            public static int
                connectionID = -1;
            public static uint
                processID = 0;
            public static uint[]
                processIDs;
        }

        /// <summary>Get informations from your target.</summary>
        public class TargetInfo
        {
            public int
                Firmware = 0,
                CCAPI = 0,
                ConsoleType = 0,
                TempCell = 0,
                TempRSX = 0;
            public ulong
                SysTable = 0;
        }

        /// <summary>Get Info for targets.</summary>
        public class ConsoleInfo
        {
            public string
                Name,
                Ip;
        }

        public Extension Extension
        {
            get { return new Extension(SelectAPI.ControlConsole); }
        }

        private void CompleteInfo(ref TargetInfo Info, int fw, int ccapi, ulong sysTable, int consoleType, int tempCELL, int tempRSX)
        {
            Info.Firmware = fw;
            Info.CCAPI = ccapi;
            Info.SysTable = sysTable;
            Info.ConsoleType = consoleType;
            Info.TempCell = tempCELL;
            Info.TempRSX = tempRSX;
        }

        /// <summary>Return true if a ccapi function return a good integer.</summary>
        public bool SUCCESS(int Void)
        {
            if (Void == 0)
                return true;
            else return false;
        }

        /// <summary>Connect your console by console list.</summary>
        public bool ConnectTarget()
        {
            return PS3M_API.ConnectTarget();
        }

        /// <summary>Connect your console by ip address.</summary>
        public int ConnectTarget(string targetIP)
        {
            if (PS3M_API.ConnectTarget(targetIP)) return 0;
            else return -1;
        }

        /// <summary>Get the status of the console.</summary>
        public int GetConnectionStatus()
        {
            if (PS3M_API.IsConnected) return 0;
            else return -1;
        }

        /// <summary>Disconnect your console.</summary>
        public int DisconnectTarget()
        {
            PS3M_API.DisconnectTarget();
            return 0;
        }

        /// <summary>Attach the default process (Current Game).</summary>
        public int AttachProcess()
        {
            if (PS3M_API.AttachProcess())
            {
                System.processIDs = PS3M_API.Process.Processes_Pid;
                System.processID = PS3M_API.Process.Process_Pid;
                return 0; 
            }
            else return -1;
          
        }

        /// <summary>Attach your desired process.</summary>
        public int AttachProcess(ProcessType procType)
        {
            if (PS3M_API.AttachProcess())
            {
                System.processIDs = PS3M_API.Process.Processes_Pid;
                System.processID = PS3M_API.Process.Process_Pid;
                return 0;
            }
            else return -1;
        }

         /// <summary>Attach your desired process.</summary>
        public int AttachProcess(uint process)
        {
            if (PS3M_API.AttachProcess(process))
            {
                System.processID = PS3M_API.Process.Process_Pid;
                return 0;
            }
            else return -1;
        }

        /// <summary>Get a list of all processes available.</summary>
        public int GetProcessList(out uint[] processIds)
        {
            processIds = new uint[16];
            try
            {
                processIds = PS3M_API.Process.GetPidProcesses();
                return 0;
            }
            catch
            {
                return -1;
            }
        }

        /// <summary>Get the process name of your choice.</summary>
        public int GetProcessName(uint processId, out string name)
        {
            name = "";
            try
            {
                name = PS3M_API.Process.GetName(processId);
                return 0;
            }
            catch
            {
                return -1;
            }
        }

        /// <summary>Return the current process attached. Use this function only if you called AttachProcess before.</summary>
        public uint GetAttachedProcess()
        {
            return System.processID;
        }

        /// <summary>Set memory to offset (uint).</summary>
        public int SetMemory(uint offset, byte[] buffer)
        {
            try
            {
                PS3M_API.Process.Memory.Set(GetAttachedProcess(), offset, buffer);
                return 0;
            }
            catch
            {
                return -1;
            }
        }

        /// <summary>Set memory to offset (ulong).</summary>
        public int SetMemory(ulong offset, byte[] buffer)
        {
            try
            {
                PS3M_API.Process.Memory.Set(GetAttachedProcess(), (uint)offset, buffer);
                return 0;
            }
            catch
            {
                return -1;
            }
        }

        /// <summary>Set memory to offset (string hex).</summary>
        public int SetMemory(ulong offset, string hexadecimal, EndianType Type = EndianType.BigEndian)
        {
            byte[] Entry = StringToByteArray(hexadecimal);
            if (Type == EndianType.LittleEndian)
                Array.Reverse(Entry);
            try
            {
                PS3M_API.Process.Memory.Set(GetAttachedProcess(), (uint)offset, Entry);
                return 0;
            }
            catch
            {
                return -1;
            }
        }

        /// <summary>Get memory from offset (uint).</summary>
        public int GetMemory(uint offset, byte[] buffer)
        {
            try
            {
                PS3M_API.Process.Memory.Get(GetAttachedProcess(), offset, buffer);
                return 0;
            }
            catch
            {
                return -1;
            }
        }

        /// <summary>Get memory from offset (ulong).</summary>
        public int GetMemory(ulong offset, byte[] buffer)
        {
            try
            {
                PS3M_API.Process.Memory.Get(GetAttachedProcess(), (uint)offset, buffer);
                return 0;
            }
            catch
            {
                return -1;
            }
        }

        /// <summary>Like Get memory but this function return directly the buffer from the offset (uint).</summary>
        public byte[] GetBytes(uint offset, uint length)
        {
            byte[] buffer = new byte[length];
            PS3M_API.Process.Memory.Get(GetAttachedProcess(), offset, buffer);
            return buffer;
        }

        /// <summary>Like Get memory but this function return directly the buffer from the offset (ulong).</summary>
        public byte[] GetBytes(ulong offset, uint length)
        {
            byte[] buffer = new byte[length];
            PS3M_API.Process.Memory.Get(GetAttachedProcess(), (uint)offset, buffer);
            return buffer;
        }

        /// <summary>Display the notify message on your PS3.</summary>
        public int Notify(NotifyIcon icon, string message)
        {
            try
            {
                PS3M_API.PS3.Notify(message);
                return 0;
            }
            catch
            {
                return -1;
            }
        }

        /// <summary>Display the notify message on your PS3.</summary>
        public int Notify(int icon, string message)
        {
            try
            {
                PS3M_API.PS3.Notify(message);
                return 0;
            }
            catch
            {
                return -1;
            }
        }

        /// <summary>You can shutdown the console or just reboot her according the flag selected.</summary>
        public int ShutDown(RebootFlags flag)
        {
            if (flag == RebootFlags.ShutDown)
            {
                try
                {
                    PS3M_API.PS3.Shutdown();
                    return 0;
                }
                catch
                {
                    return -1;
                }
            }
            else if (flag == RebootFlags.SoftReboot)
            {
                try
                {
                    PS3M_API.PS3.Reboot(1);
                    return 0;
                }
                catch
                {
                    return -1;
                }
            }
            else if (flag == RebootFlags.HardReboot)
            {
                try
                {
                    PS3M_API.PS3.Reboot(2);
                    return 0;
                }
                catch
                {
                    return -1;
                }
            }
            return -1;
        }

        /// <summary>Your console will emit a song.</summary>
        public int RingBuzzer(BuzzerMode flag)
        {
            if (flag == BuzzerMode.Single)
            {
                try
                {
                    PS3M_API.PS3.RingBuzzer(0);
                    return 0;
                }
                catch
                {
                    return -1;
                }
            }
            else if (flag == BuzzerMode.Double)
            {
                try
                {
                    PS3M_API.PS3.RingBuzzer(1);
                    return 0;
                }
                catch
                {
                    return -1;
                }
            }
            else if (flag == BuzzerMode.Continuous)
            {
                try
                {
                    PS3M_API.PS3.RingBuzzer(2);
                    return 0;
                }
                catch
                {
                    return -1;
                }
            }
            return -1;
        }

        /// <summary>Change leds for your console.</summary>
        public int SetConsoleLed(LedColor color, LedMode mode)
        {
            try
            {
                PS3M_API.PS3.Led((int)color, (int)mode);
                return 0;
            }
            catch
            {
                return -1;
            }
        }

        private int GetTargetInfo()
        {
            try
            {
                uint[] sysTemp = new uint[2];
                int fw = 0, ccapi = 0, consoleType = 0; ulong sysTable = 0;
                fw = Convert.ToInt32(PS3M_API.PS3.GetFirmwareVersion());
                ccapi = Convert.ToInt32(PS3M_API.Core.GetVersion());
                string fwtype = PS3M_API.PS3.GetFirmwareType();
                if (fwtype.Contains("CEX")) consoleType=1;
                else if (fwtype.Contains("DEX")) consoleType=2;
                else if (fwtype.Contains("TOOL")) consoleType=3;
                PS3M_API.PS3.GetTemperature(out sysTemp[0], out sysTemp[1]);
                CompleteInfo(ref pInfo, fw, ccapi, sysTable, consoleType, Convert.ToInt32(sysTemp[0]), Convert.ToInt32(sysTemp[1]));
                return 0;
            }
            catch
            {
                return -1;
            }
        }

        /// <summary>Get informations of your console and store them into TargetInfo class.</summary>
        public int GetTargetInfo(out TargetInfo Info)
        {
            Info = new TargetInfo();
            try
            {
                uint[] sysTemp = new uint[2];
                int fw = 0, ccapi = 0, consoleType = 0; ulong sysTable = 0;
                fw = Convert.ToInt32(PS3M_API.PS3.GetFirmwareVersion());
                ccapi = Convert.ToInt32(PS3M_API.Core.GetVersion());
                string fwtype = PS3M_API.PS3.GetFirmwareType();
                if (fwtype.Contains("CEX")) consoleType = 1;
                else if (fwtype.Contains("DEX")) consoleType = 2;
                else if (fwtype.Contains("TOOL")) consoleType = 3;
                PS3M_API.PS3.GetTemperature(out sysTemp[0], out sysTemp[1]);
                CompleteInfo(ref Info, fw, ccapi, sysTable, consoleType, Convert.ToInt32(sysTemp[0]), Convert.ToInt32(sysTemp[1]));
                CompleteInfo(ref pInfo, fw, ccapi, sysTable, consoleType, Convert.ToInt32(sysTemp[0]), Convert.ToInt32(sysTemp[1]));
                return 0;
            }
            catch
            {
                return -1;
            }
        }

        /// <summary>Return the current firmware of your console in string format.</summary>
        public string GetFirmwareVersion()
        {
            return PS3M_API.PS3.GetFirmwareVersion_Str();
        }

        /// <summary>Return the current temperature of your system in string.</summary>
        public string GetTemperatureCELL()
        {
            if (pInfo.TempCell == 0)
                GetTargetInfo(out pInfo);

            return pInfo.TempCell.ToString() + " C";
        }

        /// <summary>Return the current temperature of your system in string.</summary>
        public string GetTemperatureRSX()
        {
            if (pInfo.TempRSX == 0)
                GetTargetInfo(out pInfo);
            return pInfo.TempRSX.ToString() + " C";
        }

        /// <summary>Return the type of your firmware in string format.</summary>
        public string GetFirmwareType()
        {
            return PS3M_API.PS3.GetFirmwareType();
        }

        /// <summary>Clear informations into the DLL (PS3Lib).</summary>
        public void ClearTargetInfo()
        {
            pInfo = new TargetInfo();
        }

        /// <summary>Set a new ConsoleID in real time. (string)</summary>
        public int SetConsoleID(string consoleID)
        {
            MessageBox.Show("SetConsoleID: Unsuported By PS3M_API", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return 0;
        }

        /// <summary>Set a new ConsoleID in real time. (bytes)</summary>
        public int SetConsoleID(byte[] consoleID)
        {
            MessageBox.Show("SetConsoleID: Unsuported By PS3M_API", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return 0;
        }

        /// <summary>Set a new PSID in real time. (string)</summary>
        public int SetPSID(string PSID)
        {
            MessageBox.Show("SetPSID: Unsuported By PS3M_API", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return 0;
        }

        /// <summary>Set a new PSID in real time. (bytes)</summary>
        public int SetPSID(byte[] consoleID)
        {
            MessageBox.Show("SetPSID: Unsuported By PS3M_API", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return 0;
        }

        /// <summary>Set a console ID when the console is running. (string)</summary>
        public int SetBootConsoleID(string consoleID, IdType Type = IdType.IDPS)
        {
            MessageBox.Show("SetBootConsoleID: Unsuported By PS3M_API", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return 0;
        }

        /// <summary>Set a console ID when the console is running. (bytes)</summary>
        public int SetBootConsoleID(byte[] consoleID, IdType Type = IdType.IDPS)
        {
            MessageBox.Show("SetBootConsoleID: Unsuported By PS3M_API", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return 0;
        }

        /// <summary>Reset a console ID when the console is running.</summary>
        public int ResetBootConsoleID(IdType Type = IdType.IDPS)
        {
            MessageBox.Show("ResetBootConsoleID: Unsuported By PS3M_API", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return 0;
        }

        /// <summary>Return CCAPI Version.</summary>
        public int GetDllVersion()
        {
            return 777;
        }

        /// <summary>Return a list of informations for each console available.</summary>
        public List<ConsoleInfo> GetConsoleList()
        {
            return new List<ConsoleInfo>();
        }

        internal static byte[] StringToByteArray(string hex)
        {
            string replace = hex.Replace("0x", "");
            string Stringz = replace.Insert(replace.Length - 1, "0");

            int Odd = replace.Length;
            bool Nombre;
            if (Odd % 2 == 0)
                Nombre = true;
            else
                Nombre = false;
            try
            {
                if (Nombre == true)
                {
                    return Enumerable.Range(0, replace.Length)
                 .Where(x => x % 2 == 0)
                 .Select(x => Convert.ToByte(replace.Substring(x, 2), 16))
                 .ToArray();
                }
                else
                {
                    return Enumerable.Range(0, replace.Length)
                 .Where(x => x % 2 == 0)
                 .Select(x => Convert.ToByte(Stringz.Substring(x, 2), 16))
                 .ToArray();
                }
            }
            catch { throw new ArgumentException("Value not possible.", "Byte Array"); }
        }
     }
}
